//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    internal partial interface InetAddressImpl
    {
        InetAddress anyLocalAddress();
        global::java.lang.String getHostByAddr(byte[] prm1);
        bool isReachable(InetAddress prm1, int prm2, NetworkInterface prm3, int prm4);
        InetAddress[] lookupAllHostAddr(global::java.lang.String prm1);
        InetAddress loopbackAddress();
        global::java.lang.String  LocalHostName { get;}
    }
}
