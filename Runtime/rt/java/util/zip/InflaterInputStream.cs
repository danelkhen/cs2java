//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util.zip
{
    public partial class InflaterInputStream : global::java.io.FilterInputStream
    {
        public byte[] buf;
        public Inflater inf;
        public int len;
        public override int available(){return default(int);}
        public override void close(){}
        protected virtual void fill(){}
        public InflaterInputStream(global::java.io.InputStream prm1, Inflater prm2) : base(default(global::java.io.InputStream)){}
        public InflaterInputStream(global::java.io.InputStream prm1, Inflater prm2, int prm3) : base(default(global::java.io.InputStream)){}
        public InflaterInputStream(global::java.io.InputStream prm1) : base(default(global::java.io.InputStream)){}
        public override void mark(int prm1){}
        public override bool markSupported(){return default(bool);}
        public override int read(){return default(int);}
        public override int read(byte[] prm1, int prm2, int prm3){return default(int);}
        public override void reset(){}
        public override long skip(long prm1){return default(long);}
    }
}