using System;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
namespace Server
{
    class Program
    {
        static private Socket connection;
        static private Thread readThread;
        static private NetworkStream socketStream;
        static private BinaryWriter writer;
        static private BinaryReader reader;

        static private void iniReader()
        {

        }

        static public void RunServer()
        {
            TcpListener listener;
            int counter = 1;

            try
            {
                IPAddress serverIP = IPAddress.Parse("127.0.0.1");
                listener = new TcpListener(serverIP, 443);

                listener.Start();

                while (true)
                {
                    Console.WriteLine("Waiting for connection...");

                    connection = listener.AcceptSocket();

                    socketStream = new NetworkStream(connection);


                    writer = new BinaryWriter(socketStream);
                    reader = new BinaryReader(socketStream);

                    Console.WriteLine("Connection " + counter + " received.");

                    writer.Write(">Connected to hangman server");

                    string theReply = "guess e";
                    do
                    {
                        try
                        {
                            theReply = reader.ReadString();

                            if (theReply == "guess*")
                            {

                            }

                            if (theReply == "CLIENT>>> newword")
                            {
                                writer.Write("New word");
                            }

                            Console.WriteLine(theReply);
                        }
                        catch (Exception)
                        {
                            break;

                        }
                    } while (connection.Connected);

                    Console.WriteLine("Client terminated connection");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("!!! " + error.ToString() + " !!!");
                throw;
            }
        }

        static void Main()
        {
            readThread = new Thread(new ThreadStart(RunServer));
            readThread.Start();
        }

    }
}
