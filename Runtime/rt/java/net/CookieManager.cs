//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.net
{
    public partial class CookieManager : CookieHandler
    {
        public override global::java.util.Map<global::java.lang.String,global::java.util.List<global::java.lang.String>> get(URI prm1, global::java.util.Map<global::java.lang.String,global::java.util.List<global::java.lang.String>> prm2){return default(global::java.util.Map<global::java.lang.String,global::java.util.List<global::java.lang.String>>);}
        public CookieManager(){}
        public CookieManager(CookieStore prm1, CookiePolicy prm2){}
        public override void put(URI prm1, global::java.util.Map<global::java.lang.String,global::java.util.List<global::java.lang.String>> prm2){}
        public virtual void setCookiePolicy(CookiePolicy prm1){}
        public CookieStore  CookieStore { get; private set;}
    }
}
