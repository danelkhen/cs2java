//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public partial class DatagramSocket : global::java.lang.Object, global::java.io.Closeable
    {
        public virtual void bind(SocketAddress prm1){}
        public virtual void close(){}
        public virtual void connect(SocketAddress prm1){}
        public virtual void connect(InetAddress prm1, int prm2){}
        public virtual void disconnect(){}
        public DatagramSocket(int prm1){}
        public DatagramSocket(int prm1, InetAddress prm2){}
        public DatagramSocket(DatagramSocketImpl prm1){}
        public DatagramSocket(){}
        public DatagramSocket(SocketAddress prm1){}
        public virtual void receive(DatagramPacket prm1){}
        public virtual void send(DatagramPacket prm1){}
        public virtual void setBroadcast(bool prm1){}
        public static void setDatagramSocketImplFactory(DatagramSocketImplFactory prm1){}
        public virtual void setReceiveBufferSize(int prm1){}
        public virtual void setReuseAddress(bool prm1){}
        public virtual void setSendBufferSize(int prm1){}
        public virtual void setSoTimeout(int prm1){}
        public virtual void setTrafficClass(int prm1){}
        public bool  Broadcast { get; set;}
        public global::java.nio.channels.DatagramChannel  Channel { get; private set;}
        public InetAddress  InetAddress { get; private set;}
        public bool  IsBound { get; private set;}
        public bool  IsClosed { get; private set;}
        public bool  IsConnected { get; private set;}
        public InetAddress  LocalAddress { get; private set;}
        public int  LocalPort { get; private set;}
        public SocketAddress  LocalSocketAddress { get; private set;}
        public int  Port { get; private set;}
        public int  ReceiveBufferSize { get; set;}
        public SocketAddress  RemoteSocketAddress { get; private set;}
        public bool  ReuseAddress { get; set;}
        public int  SendBufferSize { get; set;}
        public int  SoTimeout { get; set;}
        public int  TrafficClass { get; set;}
    }
}