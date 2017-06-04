using System;
using System.IO;
using System.IO.Compression;


namespace GeoRAT.Client.Compressor
{
    class Compression
    {
        //Simple GZIP compression class i found on google, saved me 5 minutes of my life
        //Works good 

        public static byte[] Compress(byte[] data)
        {
            using (var ms = new MemoryStream())
            {
                using (var gzip = new GZipStream(ms, CompressionLevel.Optimal))
                {
                    gzip.Write(data, 0, data.Length);
                }
                data = ms.ToArray();
            }
            return data;
        }

        public static byte[] Decompress(byte[] data)
        {
          
            var lengthBuffer = new byte[4];
            Array.Copy(data, data.Length - 4, lengthBuffer, 0, 4);
            int uncompressedSize = BitConverter.ToInt32(lengthBuffer, 0);
            var buffer = new byte[uncompressedSize];
            using (var ms = new MemoryStream(data))
            {
                using (var gzip = new GZipStream(ms, CompressionMode.Decompress))
                {
                    gzip.Read(buffer, 0, uncompressedSize);
                }
            }
            return buffer;
        }
    }


}





   


