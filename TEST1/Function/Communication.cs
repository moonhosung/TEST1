using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.IO;
using MySql.Data.MySqlClient;

namespace TEST1.Function
{
    class Communication
    {
        private object lockObject = new object();

        Socket mainSock;
        Socket client;
        //IPAddress thisAddress;
        int TextLength;
        bool Continue = false;
        string oldText;
        int oldTextLength = 0;
        int ByteLength = 16;
        string[] msgComane = new string[2];
        string TotalText;
        private List<Socket> connectedClients = new List<Socket>();
        SerialPort sp1 = new SerialPort();
        SerialPort sp2 = new SerialPort();
        SerialPort sp3 = new SerialPort();
        SerialPort sp4 = new SerialPort();
        SerialPort sp5 = new SerialPort();
        SerialPort sp6 = new SerialPort();
        SerialPort sp7 = new SerialPort();
        SerialPort sp8 = new SerialPort();
        SerialPort sp9 = new SerialPort();
        SerialPort sp10 = new SerialPort();
        WATUTF8 watUTF8 = new WATUTF8();
        string msg;
        private static Communication theInstance = null;
        private MySqlConnection connection;
        private TcpClient clientSocket1 = new TcpClient();
        private NetworkStream stream1 = default(NetworkStream);
        private TcpClient clientSocket2 = new TcpClient();
        private NetworkStream stream2 = default(NetworkStream);
        private TcpClient clientSocket3 = new TcpClient();
        private NetworkStream stream3 = default(NetworkStream);
        private TcpClient clientSocket4 = new TcpClient();
        private NetworkStream stream4 = default(NetworkStream);
        private TcpClient clientSocket5 = new TcpClient();
        private NetworkStream stream5 = default(NetworkStream);
        private TcpClient clientSocket6 = new TcpClient();
        private NetworkStream stream6 = default(NetworkStream);
        private TcpClient clientSocket7 = new TcpClient();
        private NetworkStream stream7 = default(NetworkStream);
        private TcpClient clientSocket8 = new TcpClient();
        private NetworkStream stream8 = default(NetworkStream);
        private TcpClient clientSocket9 = new TcpClient();
        private NetworkStream stream9 = default(NetworkStream);
        private TcpClient clientSocket10 = new TcpClient();
        private NetworkStream stream10 = default(NetworkStream);

        string Path = System.Environment.CurrentDirectory.ToString() + "\\Setup\\Test.xlsx";

        //string Path2 = System.Environment.CurrentDirectory.ToString() + "\\Setup\\Test2.xl
            
        public static Communication CreateInstance()
        {
            if (theInstance == null)
            {
                theInstance = new Communication();
            }
            return theInstance;
        }

        public string Init_ClientTCP1(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText1(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage1()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose1()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP2(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText2(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage2()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose2()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP3(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText3(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage3()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose3()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP4(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText4(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage4()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose4()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP5(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText5(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage5()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose5()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP6(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText6(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage6()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose6()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP7(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText7(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage7()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose7()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP8(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText8(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage8()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose8()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP9(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText9(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage9()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose9()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public string Init_ClientTCP10(IPAddress thisAddress, int port)
        {
            string msg;
            try
            {
                clientSocket1.Connect(thisAddress, port);
                stream1 = clientSocket1.GetStream();
            }
            catch (Exception ex)
            {

            }

            msg = "Server Connected...";
            return msg;
        }

        public string ClientSendText10(string message)
        {
            string msg;
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            stream1.Write(buffer, 0, buffer.Length);
            stream1.Flush();
            msg = "Send : " + message;
            return msg;
        }

        public string ClientGetMessage10()
        {
            stream1 = clientSocket1.GetStream();
            int BUFFERSIZE = clientSocket1.ReceiveBufferSize;
            byte[] buffer = new byte[BUFFERSIZE];
            int bytes = stream1.Read(buffer, 0, buffer.Length);
            string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
            return msg;
        }
        public string ClientClose10()
        {
            stream1.Close();
            clientSocket1.Close();
            string msg = "ClientClose1...";
            return msg;
        }
        public void Init_ServerTCP(IPAddress thisAddress, int port)
        {
            IPHostEntry he = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress addr in he.AddressList)
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    thisAddress = addr;
                    break;
                }
            }
            if (thisAddress == null)

                thisAddress = IPAddress.Loopback;
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            IPEndPoint serverEP = new IPEndPoint(thisAddress, port);
            mainSock.Bind(serverEP);
            mainSock.Listen(10);

            mainSock.BeginAccept(ServerAcceptCallback, null);

            //return msg;
        }
        public void ServerAcceptCallback(IAsyncResult ar)
        {
            Socket client = mainSock.EndAccept(ar);
            mainSock.BeginAccept(ServerAcceptCallback, null);
            AsyncObject obj = new AsyncObject(ByteLength);
            obj.WorkingSocket = client;
            connectedClients.Add(client);
            //AppendText(txtHistory, string.Format("클라이언트 (@ {0})가 연결되었습니다.", client.RemoteEndPoint));
            client.BeginReceive(obj.Buffer, 0, ByteLength, 0, ServerDataReceived, obj);
        }
        public void ServerDataReceived(IAsyncResult ar)
        {


            AsyncObject obj = (AsyncObject)ar.AsyncState;
            int received = obj.WorkingSocket.EndReceive(ar);
            if (received <= 0)
            {
                obj.WorkingSocket.Close();
                msgComane[0] = "WorkingSocket Close";
                msgComane[1] = TotalText;
                //CommandQ.Enqueue(msgComane);
                //Message(TotalText, "WorkingSocket Close");
                return;
            }

            string text = Encoding.UTF8.GetString(obj.Buffer);

            if (text.Substring(0, 1) == "0")
            {
                TextLength = Convert.ToInt32(text);
                Continue = true;
            }

            else
            {
                if (Continue)
                {
                    TotalText = oldText + text;
                    oldText = TotalText;
                }

                if (TotalText.Length > TextLength)
                {
                    //CommandQ.Enqueue(msgComane);
                    msgComane[0] = "Message Tran";
                    msgComane[1] = TotalText;
                    Continue = false;
                    oldText = "";
                    oldTextLength = 0;
                }
            }

            obj.ClearBuffer();
            bool ClientState = obj.WorkingSocket.Connected;
            if (ClientState)
            {
                obj.WorkingSocket.BeginReceive(obj.Buffer, 0, ByteLength, 0, ServerDataReceived, obj);
            }
        }
        public string ServerSendText(string SendCommand)
        {
            byte[] bDts = Encoding.UTF8.GetBytes(SendCommand);
            Socket socket = connectedClients[connectedClients.Count - 1];
            bool ClientState = socket.Connected;
            if (ClientState)
            {
                try
                {
                    socket.Send(bDts);
                    msg = "[보냄] : " + SendCommand;
                }
                catch
                {
                    try { socket.Dispose(); }
                    catch { }
                    msg = "Socket Dispose";
                }
            }
            return msg;
            //AppendText(txtHistory, string.Format("[보냄]{0}: {1}", txtAddress.ToString(), SendCommand));
        }
        public string InitSerial1(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp1.IsOpen)
                {
                    sp1.PortName = PortName;
                    sp1.BaudRate = BaudRate;
                    sp1.DataBits = DataBits;
                    sp1.RtsEnable = true;
                    sp1.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial2(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp2.IsOpen)
                {
                    sp2.PortName = PortName;
                    sp2.BaudRate = BaudRate;
                    sp2.DataBits = DataBits;
                    sp2.RtsEnable = true;
                    sp2.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial3(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp3.IsOpen)
                {
                    sp3.PortName = PortName;
                    sp3.BaudRate = BaudRate;
                    sp3.DataBits = DataBits;
                    sp3.RtsEnable = true;
                    sp3.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial4(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp4.IsOpen)
                {
                    sp4.PortName = PortName;
                    sp4.BaudRate = BaudRate;
                    sp4.DataBits = DataBits;
                    sp4.RtsEnable = true;
                    sp4.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial5(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp5.IsOpen)
                {
                    sp5.PortName = PortName;
                    sp5.BaudRate = BaudRate;
                    sp5.DataBits = DataBits;
                    sp5.RtsEnable = true;
                    sp5.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial6(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp6.IsOpen)
                {
                    sp6.PortName = PortName;
                    sp6.BaudRate = BaudRate;
                    sp6.DataBits = DataBits;
                    sp6.RtsEnable = true;
                    sp6.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial7(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp7.IsOpen)
                {
                    sp7.PortName = PortName;
                    sp7.BaudRate = BaudRate;
                    sp7.DataBits = DataBits;
                    sp7.RtsEnable = true;
                    sp7.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial8(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp8.IsOpen)
                {
                    sp8.PortName = PortName;
                    sp8.BaudRate = BaudRate;
                    sp8.DataBits = DataBits;
                    sp8.RtsEnable = true;
                    sp8.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial9(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp9.IsOpen)
                {
                    sp9.PortName = PortName;
                    sp9.BaudRate = BaudRate;
                    sp9.DataBits = DataBits;
                    sp9.RtsEnable = true;
                    sp9.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }
        public string InitSerial10(string PortName, int BaudRate, int DataBits)
        {
            try
            {
                // sp1 값이 null 일때만 새로운 SerialPort 를 생성합니다.
                if (!sp10.IsOpen)
                {
                    sp10.PortName = PortName;
                    sp10.BaudRate = BaudRate;
                    sp10.DataBits = DataBits;
                    sp10.RtsEnable = true;
                    sp10.Open();
                    msg = PortName + "포트가 열였습니다.";
                    // RefreshViewControl(true);

                }

            }
            catch (System.Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }

        public string SerialSendMessage1(string Sendmsg)
        {
            string remsg = null;
            if (sp1 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp1.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp1.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }

        public string SerialSendMessage2(string Sendmsg)
        {
            string remsg = null;
            if (sp2 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp2.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp2.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage3(string Sendmsg)
        {
            string remsg = null;
            if (sp3 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp3.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp3.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage4(string Sendmsg)
        {
            string remsg = null;
            if (sp4 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp4.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp4.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage5(string Sendmsg)
        {
            string remsg = null;
            if (sp5 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp5.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp5.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage6(string Sendmsg)
        {
            string remsg = null;
            if (sp6 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp6.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp6.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage7(string Sendmsg)
        {
            string remsg = null;
            if (sp7 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp7.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp7.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage8(string Sendmsg)
        {
            string remsg = null;
            if (sp8 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp8.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp8.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage9(string Sendmsg)
        {
            string remsg = null;
            if (sp9 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp9.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp9.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialSendMessage10(string Sendmsg)
        {
            string remsg = null;
            if (sp10 == null)
            {
                remsg = "SerialOpen NULL";
            }
            if (!sp10.IsOpen)
            {
                remsg = "SerialOpen Not Open";
            }
            try
            {
                sp10.Write(Sendmsg + "\r\n");
                msg = "LightSend : " + Sendmsg;
            }
            catch (SystemException ex)
            {
                remsg = ex.Message;
            }
            return remsg;
        }
        public string SerialDataReceived1()
        {
            try
            {
                string strTemp;
                int iRecSize = sp1.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp1.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived2()
        {
            try
            {
                string strTemp;
                int iRecSize = sp2.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp2.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived3()
        {
            try
            {
                string strTemp;
                int iRecSize = sp3.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp3.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived4()
        {
            try
            {
                string strTemp;
                int iRecSize = sp4.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp4.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived5()
        {
            try
            {
                string strTemp;
                int iRecSize = sp5.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp5.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived6()
        {
            try
            {
                string strTemp;
                int iRecSize = sp6.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp6.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived7()
        {
            try
            {
                string strTemp;
                int iRecSize = sp7.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp7.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived8()
        {
            try
            {
                string strTemp;
                int iRecSize = sp8.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp8.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived9()
        {
            try
            {
                string strTemp;
                int iRecSize = sp9.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp9.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }
        public string SerialDataReceived10()
        {
            try
            {
                string strTemp;
                int iRecSize = sp10.BytesToRead; // 수신된 데이터 갯수

                if (iRecSize >= 0) // 수신된 데이터의 수가 0이 아닐때만 처리하자
                {
                    //Console.Write("rx:" + iRecSize.ToString());

                    byte[] buff = new byte[iRecSize];
                    try
                    {
                        sp10.Read(buff, 0, iRecSize);

                        strTemp = this.watUTF8.AddBytes(buff.ToList()).Replace("\r", "").Replace("\n", Environment.NewLine);

                        msg = "LightDataReceived :" + strTemp + "\r\n";

                        // txtVacuum.AppendText(Convert.ToInt32(strTemp.Substring(3, 4)).ToString() + "." + strTemp.Substring(7, 1).ToString());
                        //if (this.ReturnMsg.InvokeRequired)
                        //{
                        //    this.ReturnMsg.Invoke(new MethodInvoker(delegate { ReturnMsg.Text = strTemp; }));
                        //}
                    }
                    catch (Exception ex)
                    {
                        msg = ex.Message;
                    }
                }
            }
            catch (System.Exception ex)
            {
                msg += ex.Message;
            }

            return msg;
        }

        public string SerialClose1(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp1)
            {
                if (sp1.IsOpen)
                {
                    sp1.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }

        public string SerialClose2(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp2)
            {
                if (sp2.IsOpen)
                {
                    sp2.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }
        public string SerialClose3(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp3)
            {
                if (sp3.IsOpen)
                {
                    sp3.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }
        public string SerialClose4(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp4)
            {
                if (sp4.IsOpen)
                {
                    sp4.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }
        public string SerialClose5(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp5)
            {
                if (sp5.IsOpen)
                {
                    sp5.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;
        }

        public string SerialClose6(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp6)
            {
                if (sp6.IsOpen)
                {
                    sp6.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }
        public string SerialClose7(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp7)
            {
                if (sp7.IsOpen)
                {
                    sp7.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }
        public string SerialClose8(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp8)
            {
                if (sp8.IsOpen)
                {
                    sp8.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }
        public string SerialClose9(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp9)
            {
                if (sp9.IsOpen)
                {
                    sp9.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }
        public string SerialClose10(string PortName)
        {
            string msg = "";
            // sp1 이 null 아닐때만 close 처리를 해준다.
            if (null != sp10)
            {
                if (sp10.IsOpen)
                {
                    sp10.Close();
                    msg = PortName + "가 닫혔습니다.";
                }
            }
            return msg;

        }

        public void DBInitialize(string server, string database, string uid, string password)
        {
            //server = "127.0.0.1";
            //database = "test1";
            //uid = "famecs";
            //password = "famecs";
            string connectionString;
            connectionString = "SERVER=" + server + ";"+ "Port=" + "1111" + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public bool DBCloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }
        public List<string>[] DBSelect(string TableName, string[] Cloums)
        {
            lock (lockObject)
            {

                string query = "SELECT * FROM " + TableName;
                int CloumCount = Cloums.Length;
                //Create a list to store the result
                List<string>[] list = new List<string>[CloumCount];

                for (int i = 0; i < CloumCount; i++)
                {
                    list[i] = new List<string>();
                }

                //list[0] = new List<string>();
                //list[1] = new List<string>();
                //list[2] = new List<string>();

                //Open connection
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    OpenConnection();
                }
                //Create Command

                MySqlCommand cmd = new MySqlCommand(query, connection);

               // OpenConnection();
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //DBCloseConnection();
                //Read the data and store them in the list

                while (dataReader.Read())
                {
                    for (int a = 0; a < CloumCount; a++)
                    {
                        list[a].Add(dataReader[Cloums[a].ToString()] + "");
                        //list[0].Add(dataReader["NO"] + "");
                        //list[1].Add(dataReader["Text"] + "");
                        //list[2].Add(dataReader["age"] + "");
                    }
                }


                //close Data Reader
                dataReader.Close();

                //close Connection
                // this.DBCloseConnection();

                //return list to be displayed
                return list;
            }
        }
        public void DBQuery(string query)
        {
            lock (lockObject)
            {

                // string query = "INSERT INTO famecs1 (NO, Text) VALUES('20', 'Test')";

                //open connection

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    OpenConnection();
                }
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

               // OpenConnection();
                //Execute command
                cmd.ExecuteNonQueryAsync();
                //DBCloseConnection();
                //cmd.Dispose();
                //close connection
                // this.DBCloseConnection();
            }
        }

        #region 시리얼통신 읽음
        public class WATUTF8
        {
            List<byte> RemainBytes = new List<byte>();

            bool IsUTF8(byte _byte)
            {
                if ((_byte & 0xE0) == 0xE0) return true;
                return false;

            }

            public String AddBytes(List<byte> _bytes)
            {
                RemainBytes.AddRange(_bytes);

                if (this.RemainBytes.Count >= 2 && IsUTF8(this.RemainBytes[this.RemainBytes.Count - 2]))
                {
                    String s = System.Text.Encoding.UTF8.GetString(RemainBytes.ToArray(), 0, this.RemainBytes.Count - 2);
                    RemainBytes.RemoveRange(0, this.RemainBytes.Count - 2);
                    return s;
                }
                else if (this.RemainBytes.Count >= 1 && IsUTF8(this.RemainBytes[this.RemainBytes.Count - 1]))
                {
                    String s = System.Text.Encoding.UTF8.GetString(RemainBytes.ToArray(), 0, this.RemainBytes.Count - 1);
                    RemainBytes.RemoveRange(0, this.RemainBytes.Count - 1);
                    return s;
                }
                else
                {
                    String s = System.Text.Encoding.UTF8.GetString(RemainBytes.ToArray(), 0, this.RemainBytes.Count);
                    RemainBytes.Clear();
                    return s;
                }
            }

        }
        #endregion

    }
    class AsyncObject
    {
        public byte[] Buffer;
        public Socket WorkingSocket;
        public readonly int BufferSize;
        public AsyncObject(int bufferSize)
        {
            BufferSize = bufferSize;
            Buffer = new byte[BufferSize];
        }

        public void ClearBuffer()
        {
            Array.Clear(Buffer, 0, BufferSize);
        }
    }
}
