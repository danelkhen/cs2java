//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public partial class Inet6Address : InetAddress
    {
        public Inet6Address(){}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public static Inet6Address getByAddress(global::java.lang.String prm1, byte[] prm2, int prm3){return default(Inet6Address);}
        public static Inet6Address getByAddress(global::java.lang.String prm1, byte[] prm2, NetworkInterface prm3){return default(Inet6Address);}
        public override int hashCode(){return default(int);}
        public byte[]  Address { get; private set;}
        public global::java.lang.String  HostAddress { get; private set;}
        public bool  IsAnyLocalAddress { get; private set;}
        public bool  IsIPv4CompatibleAddress { get; private set;}
        public bool  IsLinkLocalAddress { get; private set;}
        public bool  IsLoopbackAddress { get; private set;}
        public bool  IsMCGlobal { get; private set;}
        public bool  IsMCLinkLocal { get; private set;}
        public bool  IsMCNodeLocal { get; private set;}
        public bool  IsMCOrgLocal { get; private set;}
        public bool  IsMCSiteLocal { get; private set;}
        public bool  IsMulticastAddress { get; private set;}
        public bool  IsSiteLocalAddress { get; private set;}
        public NetworkInterface  ScopedInterface { get; private set;}
        public int  ScopeId { get; private set;}
    }
}
