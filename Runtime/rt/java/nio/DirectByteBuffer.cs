//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.nio
{
    internal partial class DirectByteBuffer : MappedByteBuffer, global::sun.nio.ch.DirectBuffer
    {
        public static bool unaligned;
        public static global::sun.misc.Unsafe @unsafe;
        public virtual long address(){return default(long);}
        public override CharBuffer asCharBuffer(){return default(CharBuffer);}
        public override DoubleBuffer asDoubleBuffer(){return default(DoubleBuffer);}
        public override FloatBuffer asFloatBuffer(){return default(FloatBuffer);}
        public override IntBuffer asIntBuffer(){return default(IntBuffer);}
        public override LongBuffer asLongBuffer(){return default(LongBuffer);}
        public override ByteBuffer asReadOnlyBuffer(){return default(ByteBuffer);}
        public override ShortBuffer asShortBuffer(){return default(ShortBuffer);}
        public virtual global::System.Object attachment(){return default(global::System.Object);}
        public virtual global::sun.misc.Cleaner cleaner(){return default(global::sun.misc.Cleaner);}
        public override ByteBuffer compact(){return default(ByteBuffer);}
        public override ByteBuffer duplicate(){return default(ByteBuffer);}
        public override byte get(){return default(byte);}
        public override byte get(int prm1){return default(byte);}
        public override ByteBuffer get(byte[] prm1, int prm2, int prm3){return default(ByteBuffer);}
        public override char getChar(int prm1){return default(char);}
        public override double getDouble(int prm1){return default(double);}
        public override float getFloat(int prm1){return default(float);}
        public override int getInt(int prm1){return default(int);}
        public override long getLong(int prm1){return default(long);}
        public override short getShort(int prm1){return default(short);}
        public DirectByteBuffer(int prm1, long prm2, global::java.io.FileDescriptor prm3, global::java.lang.Runnable prm4){}
        public override ByteBuffer put(int prm1, byte prm2){return default(ByteBuffer);}
        public override ByteBuffer put(ByteBuffer prm1){return default(ByteBuffer);}
        public override ByteBuffer put(byte[] prm1, int prm2, int prm3){return default(ByteBuffer);}
        public override ByteBuffer put(byte prm1){return default(ByteBuffer);}
        public override ByteBuffer putChar(char prm1){return default(ByteBuffer);}
        public override ByteBuffer putChar(int prm1, char prm2){return default(ByteBuffer);}
        public override ByteBuffer putDouble(double prm1){return default(ByteBuffer);}
        public override ByteBuffer putDouble(int prm1, double prm2){return default(ByteBuffer);}
        public override ByteBuffer putFloat(float prm1){return default(ByteBuffer);}
        public override ByteBuffer putFloat(int prm1, float prm2){return default(ByteBuffer);}
        public override ByteBuffer putInt(int prm1){return default(ByteBuffer);}
        public override ByteBuffer putInt(int prm1, int prm2){return default(ByteBuffer);}
        public override ByteBuffer putLong(int prm1, long prm2){return default(ByteBuffer);}
        public override ByteBuffer putLong(long prm1){return default(ByteBuffer);}
        public override ByteBuffer putShort(int prm1, short prm2){return default(ByteBuffer);}
        public override ByteBuffer putShort(short prm1){return default(ByteBuffer);}
        public override ByteBuffer slice(){return default(ByteBuffer);}
        public char  Char { get; private set;}
        public double  Double { get; private set;}
        public float  Float { get; private set;}
        public int  Int { get; private set;}
        public bool  IsDirect { get; private set;}
        public bool  IsReadOnly { get; private set;}
        public long  Long { get; private set;}
        public short  Short { get; private set;}
    }
}