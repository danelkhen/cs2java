//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public partial class Proxy : global::java.lang.Object
    {
        public partial class Type : global::java.lang.Enum<global::java.net.Proxy.Type>
        {
            public static global::java.net.Proxy.Type DIRECT;
            public static global::java.net.Proxy.Type HTTP;
            public static global::java.net.Proxy.Type SOCKS;
            public Type(){}
            public static global::java.net.Proxy.Type valueOf(global::java.lang.String prm1){return default(global::java.net.Proxy.Type);}
            public static global::java.net.Proxy.Type[] values(){return default(global::java.net.Proxy.Type[]);}
        }
        public static global::java.net.Proxy NO_PROXY;
        public virtual SocketAddress address(){return default(SocketAddress);}
        public bool equals(global::System.Object prm1){return default(bool);}
        public int hashCode(){return default(int);}
        public Proxy(Proxy.Type prm1, SocketAddress prm2){}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public virtual Proxy.Type type(){return default(Proxy.Type);}
    }
}
