//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.lang
{
    public abstract partial class ClassLoader : Object
    {
        public virtual void clearAssertionStatus(){}
        protected Class<global::System.Object> defineClass(String prm1, byte[] prm2, int prm3, int prm4){return default(Class<global::System.Object>);}
        protected Class<global::System.Object> defineClass(String prm1, byte[] prm2, int prm3, int prm4, global::java.security.ProtectionDomain prm5){return default(Class<global::System.Object>);}
        protected Class<global::System.Object> defineClass(String prm1, global::java.nio.ByteBuffer prm2, global::java.security.ProtectionDomain prm3){return default(Class<global::System.Object>);}
        protected Class<global::System.Object> defineClass(byte[] prm1, int prm2, int prm3){return default(Class<global::System.Object>);}
        protected virtual Package definePackage(String prm1, String prm2, String prm3, String prm4, String prm5, String prm6, String prm7, global::java.net.URL prm8){return default(Package);}
        protected virtual Class<global::System.Object> findClass(String prm1){return default(Class<global::System.Object>);}
        protected virtual String findLibrary(String prm1){return default(String);}
        protected Class<global::System.Object> findLoadedClass(String prm1){return default(Class<global::System.Object>);}
        protected virtual global::java.net.URL findResource(String prm1){return default(global::java.net.URL);}
        protected virtual global::java.util.Enumeration<global::java.net.URL> findResources(String prm1){return default(global::java.util.Enumeration<global::java.net.URL>);}
        protected Class<global::System.Object> findSystemClass(String prm1){return default(Class<global::System.Object>);}
        protected virtual global::System.Object getClassLoadingLock(String prm1){return default(global::System.Object);}
        protected virtual Package getPackage(String prm1){return default(Package);}
        public virtual global::java.net.URL getResource(String prm1){return default(global::java.net.URL);}
        public virtual global::java.io.InputStream getResourceAsStream(String prm1){return default(global::java.io.InputStream);}
        public virtual global::java.util.Enumeration<global::java.net.URL> getResources(String prm1){return default(global::java.util.Enumeration<global::java.net.URL>);}
        public static global::java.net.URL getSystemResource(String prm1){return default(global::java.net.URL);}
        public static global::java.io.InputStream getSystemResourceAsStream(String prm1){return default(global::java.io.InputStream);}
        public static global::java.util.Enumeration<global::java.net.URL> getSystemResources(String prm1){return default(global::java.util.Enumeration<global::java.net.URL>);}
        public ClassLoader(ClassLoader prm1){}
        public ClassLoader(){}
        protected virtual Class<global::System.Object> loadClass(String prm1, bool prm2){return default(Class<global::System.Object>);}
        public virtual Class<global::System.Object> loadClass(String prm1){return default(Class<global::System.Object>);}
        protected static bool registerAsParallelCapable(){return default(bool);}
        protected void resolveClass(Class<global::System.Object> prm1){}
        public virtual void setClassAssertionStatus(String prm1, bool prm2){}
        public virtual void setDefaultAssertionStatus(bool prm1){}
        public virtual void setPackageAssertionStatus(String prm1, bool prm2){}
        protected void setSigners(Class<global::System.Object> prm1, global::System.Object[] prm2){}
        public Package[]  Packages { get; private set;}
        public ClassLoader  Parent { get; private set;}
        public ClassLoader  SystemClassLoader { get; private set;}
    }
}
