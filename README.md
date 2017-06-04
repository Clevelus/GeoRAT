
This is improved version of Ratty remote administration tool. 
Features of new version :


1. Asynchronous connection

2. Data exchange is now estabilished using simple protocol. Before messages are sent over socket, their length is calculated and sent first. Server/Client receives message length and starts waiting for  specified amount of data. This feature guarantees that data will be delivered in its original form without being fragmented. Since TCP is a stream and doesn't operate on raw packets unlike UDP, this is a necessary feature for secure data exchange. 

3. Server and client now support data compression. Every byte[] array is compressed using GZIP before being sent and decompressed on receiving side. Makes data less heavy. 

4. Accurate GeoIP 

5. Code is now structured and organized, few Interfaces added. Every class has its own folder.

This tool is a good example of networking using C# sockets. Its easier to exchange large amounts of information now, such as screenshots for desktop sharing feature or w/e. Unlike first version, this one will be reliable not only in LAN but over internet with big latency too. 

Screenshot : 

![bytes](https://cloud.githubusercontent.com/assets/26791677/26762406/938ab888-48f6-11e7-8c69-077d40684938.png)
