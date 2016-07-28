//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public partial class URI : global::java.lang.Object, global::java.lang.Comparable<URI>, global::java.io.Serializable
    {
        public virtual int compareTo(URI prm1){return default(int);}
        public static URI create(global::java.lang.String prm1){return default(URI);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public override int hashCode(){return default(int);}
        public URI(global::java.lang.String prm1, global::java.lang.String prm2, global::java.lang.String prm3){}
        public URI(global::java.lang.String prm1, global::java.lang.String prm2, global::java.lang.String prm3, global::java.lang.String prm4){}
        public URI(global::java.lang.String prm1, global::java.lang.String prm2, global::java.lang.String prm3, global::java.lang.String prm4, global::java.lang.String prm5){}
        public URI(global::java.lang.String prm1){}
        public URI(global::java.lang.String prm1, global::java.lang.String prm2, global::java.lang.String prm3, int prm4, global::java.lang.String prm5, global::java.lang.String prm6, global::java.lang.String prm7){}
        public virtual URI normalize(){return default(URI);}
        public virtual URI parseServerAuthority(){return default(URI);}
        public virtual URI relativize(URI prm1){return default(URI);}
        public virtual URI resolve(global::java.lang.String prm1){return default(URI);}
        public virtual URI resolve(URI prm1){return default(URI);}
        public virtual global::java.lang.String toASCIIString(){return default(global::java.lang.String);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public virtual URL toURL(){return default(URL);}
        public global::java.lang.String  Authority { get; private set;}
        public global::java.lang.String  Fragment { get; private set;}
        public global::java.lang.String  Host { get; private set;}
        public bool  IsAbsolute { get; private set;}
        public bool  IsOpaque { get; private set;}
        public global::java.lang.String  Path { get; private set;}
        public int  Port { get; private set;}
        public global::java.lang.String  Query { get; private set;}
        public global::java.lang.String  RawAuthority { get; private set;}
        public global::java.lang.String  RawFragment { get; private set;}
        public global::java.lang.String  RawPath { get; private set;}
        public global::java.lang.String  RawQuery { get; private set;}
        public global::java.lang.String  RawSchemeSpecificPart { get; private set;}
        public global::java.lang.String  RawUserInfo { get; private set;}
        public global::java.lang.String  Scheme { get; private set;}
        public global::java.lang.String  SchemeSpecificPart { get; private set;}
        public global::java.lang.String  UserInfo { get; private set;}
    }
}