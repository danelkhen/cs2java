//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util.zip
{
    public partial class DeflaterOutputStream : global::java.io.FilterOutputStream
    {
        public byte[] buf;
        public Deflater def;
        public override void close(){}
        protected virtual void deflate(){}
        public virtual void finish(){}
        public override void flush(){}
        public DeflaterOutputStream(global::java.io.OutputStream prm1) : base(default(global::java.io.OutputStream)){}
        public DeflaterOutputStream(global::java.io.OutputStream prm1, bool prm2) : base(default(global::java.io.OutputStream)){}
        public DeflaterOutputStream(global::java.io.OutputStream prm1, Deflater prm2) : base(default(global::java.io.OutputStream)){}
        public DeflaterOutputStream(global::java.io.OutputStream prm1, Deflater prm2, int prm3, bool prm4) : base(default(global::java.io.OutputStream)){}
        public DeflaterOutputStream(global::java.io.OutputStream prm1, Deflater prm2, int prm3) : base(default(global::java.io.OutputStream)){}
        public DeflaterOutputStream(global::java.io.OutputStream prm1, Deflater prm2, bool prm3) : base(default(global::java.io.OutputStream)){}
        public override void write(byte[] prm1, int prm2, int prm3){}
        public override void write(int prm1){}
    }
}
