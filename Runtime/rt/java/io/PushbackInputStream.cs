//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.io
{
    public partial class PushbackInputStream : FilterInputStream
    {
        public byte[] buf;
        public int pos;
        public override int available(){return default(int);}
        public override void close(){}
        public PushbackInputStream(InputStream prm1) : base(default(InputStream)){}
        public PushbackInputStream(InputStream prm1, int prm2) : base(default(InputStream)){}
        public override void mark(int prm1){}
        public override bool markSupported(){return default(bool);}
        public override int read(byte[] prm1, int prm2, int prm3){return default(int);}
        public override int read(){return default(int);}
        public override void reset(){}
        public override long skip(long prm1){return default(long);}
        public virtual void unread(int prm1){}
        public virtual void unread(byte[] prm1){}
        public virtual void unread(byte[] prm1, int prm2, int prm3){}
    }
}
