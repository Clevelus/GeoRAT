
Simple remote administration tool concept. 

Features of current version : 

1. Asynchronous connection using Sockets (No TCPClient or other higher level wrappers) 
2. Simple protocol based on message-length prefixes. This feature ensures that every packet will get delivered from client to server and vice-versa. Since TCP is a stream and does't operate on RAW packets unlike UDP, it's necessary to check if data arrived in its original form. The issue is not showing in LAN enviroment, but when packets are sent over internet with higher latency, its possible that bytes in stream could get messed up. 
3. Simple traffic encryption using GZIP. Before being sent, every byte[] array is compressed, then decompressed on receiving side. Makes data exchange less heavy. 
4. Simple packet structure and serialization. Every packet gets constructed using special class, object of this class is serialized into byte[] array, deserialized on receiving side. 
5. GeoIP using online API (Will change to local use of GeoIP.dat) 
6. Updated user interface 

Current commands include - Open website, disconnect, send message, reboot. 
UI shows detailed information about client (Country, Username, CPU, IP and small country flag icon) 

In progress : 

1. Remote desktop 
2. Traffic encryption
3. Finish GUI (Add builder and other stuff) 
4. Everything else that comes to my mind 

This project is not meant to be professional tool, i am working on it only for practice and because of my personal interest in network programming using C#. It could be very useful for beginners who want to learn asynchronous socketing, basics of serialization and secure data exchange. 

Project is in active development, will update GitHub whenever i add new functions. 

Screenshot of new GUI : 

![rat](https://user-images.githubusercontent.com/26791677/26846687-5fcce056-4aaf-11e7-91c0-adf82c8388e5.png)
