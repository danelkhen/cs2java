//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public partial class URL : global::java.lang.Object, global::java.io.Serializable
    {
        public override bool equals(global::System.Object prm1){return default(bool);}
        public global::System.Object getContent(global::java.lang.Class<global::java.lang.Q>[] prm1){return default(global::System.Object);}
        public override int hashCode(){return default(int);}
        public URL(URL prm1, global::java.lang.String prm2, URLStreamHandler prm3){}
        public URL(URL prm1, global::java.lang.String prm2){}
        public URL(global::java.lang.String prm1){}
        public URL(global::java.lang.String prm1, global::java.lang.String prm2, int prm3, global::java.lang.String prm4){}
        public URL(global::java.lang.String prm1, global::java.lang.String prm2, global::java.lang.String prm3){}
        public URL(global::java.lang.String prm1, global::java.lang.String prm2, int prm3, global::java.lang.String prm4, URLStreamHandler prm5){}
        public virtual URLConnection openConnection(){return default(URLConnection);}
        public virtual URLConnection openConnection(global::java.net.Proxy prm1){return default(URLConnection);}
        public global::java.io.InputStream openStream(){return default(global::java.io.InputStream);}
        public virtual bool sameFile(URL prm1){return default(bool);}
        protected virtual void set(global::java.lang.String prm1, global::java.lang.String prm2, int prm3, global::java.lang.String prm4, global::java.lang.String prm5){}
        protected virtual void set(global::java.lang.String prm1, global::java.lang.String prm2, int prm3, global::java.lang.String prm4, global::java.lang.String prm5, global::java.lang.String prm6, global::java.lang.String prm7, global::java.lang.String prm8){}
        public static void setURLStreamHandlerFactory(URLStreamHandlerFactory prm1){}
        public virtual global::java.lang.String toExternalForm(){return default(global::java.lang.String);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public virtual URI toURI(){return default(URI);}
        public global::java.lang.String  Authority { get; private set;}
        public global::System.Object  Content { get; private set;}
        public int  DefaultPort { get; private set;}
        public global::java.lang.String  File { get; private set;}
        public global::java.lang.String  Host { get; private set;}
        public global::java.lang.String  Path { get; private set;}
        public int  Port { get; private set;}
        public global::java.lang.String  Protocol { get; private set;}
        public global::java.lang.String  Query { get; private set;}
        public global::java.lang.String  Ref { get; private set;}
        public global::java.lang.String  UserInfo { get; private set;}
    }
}
