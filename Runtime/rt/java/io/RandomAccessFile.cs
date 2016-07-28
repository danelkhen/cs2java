//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.io
{
    public partial class RandomAccessFile : global::java.lang.Object, DataOutput, DataInput, Closeable
    {
        public virtual void close(){}
        public RandomAccessFile(global::java.lang.String prm1, global::java.lang.String prm2){}
        public RandomAccessFile(File prm1, global::java.lang.String prm2){}
        public virtual long length(){return default(long);}
        public virtual int read(byte[] prm1){return default(int);}
        public virtual int read(byte[] prm1, int prm2, int prm3){return default(int);}
        public virtual int read(){return default(int);}
        public bool readBoolean(){return default(bool);}
        public byte readByte(){return default(byte);}
        public char readChar(){return default(char);}
        public double readDouble(){return default(double);}
        public float readFloat(){return default(float);}
        public void readFully(byte[] prm1){}
        public void readFully(byte[] prm1, int prm2, int prm3){}
        public int readInt(){return default(int);}
        public global::java.lang.String readLine(){return default(global::java.lang.String);}
        public long readLong(){return default(long);}
        public short readShort(){return default(short);}
        public int readUnsignedByte(){return default(int);}
        public int readUnsignedShort(){return default(int);}
        public global::java.lang.String readUTF(){return default(global::java.lang.String);}
        public virtual void seek(long prm1){}
        public virtual void setLength(long prm1){}
        public virtual int skipBytes(int prm1){return default(int);}
        public virtual void write(byte[] prm1){}
        public virtual void write(byte[] prm1, int prm2, int prm3){}
        public virtual void write(int prm1){}
        public void writeBoolean(bool prm1){}
        public void writeByte(int prm1){}
        public void writeBytes(global::java.lang.String prm1){}
        public void writeChar(int prm1){}
        public void writeChars(global::java.lang.String prm1){}
        public void writeDouble(double prm1){}
        public void writeFloat(float prm1){}
        public void writeInt(int prm1){}
        public void writeLong(long prm1){}
        public void writeShort(int prm1){}
        public void writeUTF(global::java.lang.String prm1){}
        public global::java.nio.channels.FileChannel  Channel { get; private set;}
        public FileDescriptor  FD { get; private set;}
        public long  FilePointer { get; private set;}
    }
}
