using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Xml.Serialization;


namespace Client
{
    class GetInfo
    {
        //Get PC information class 


        //Seems to work good 

        public static string GetOS()
        {


            string OS = string.Empty;
            ManagementObjectSearcher MS = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");

            foreach (ManagementObject _m in MS.Get())
            {
                OS = _m["Caption"].ToString();
            }
            return OS;

        }

       
         public static string GetCountry()
        {

            //get public IP address from API
            string externalip = new WebClient().DownloadString("https://api.ipify.org/");
           //debug  Console.WriteLine("{0}", externalip);


           //call ParaseXML Method on this IP, get country information from GeoIP API
            var country = ParseXML(externalip);
            return country.CountryName;


        }

        //Credits to OllyDbg for fast solution 
        //Might replace this with Maxmind's GeoIP C# method later
        private static Response ParseXML(string ip)
        {
            Response ret = new Response();
            try
            {
                //join geoip url and ip address into 1 string
                var apiname = "http://freegeoip.net/xml/";
                var formattedStr = $"{apiname}{ip}";
                //

               //debug Console.WriteLine("{0}", formattedStr);
                var request = WebRequest.Create(formattedStr);
                var response = request.GetResponse();

                if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                {
                    Stream dataStream = response.GetResponseStream();
                    XmlSerializer serializer = new XmlSerializer(typeof(Response));
                    ret = (Response)serializer.Deserialize(dataStream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e.Message);
            }

            return ret;
        }
    


        //Get username 
        public static string Name()
        {
            var name = Environment.UserName;
            return name;
        }

        public static Process[] GetProcess()
        {
            Process[] Processlist = Process.GetProcesses();
            return Processlist;
        }

    }
}