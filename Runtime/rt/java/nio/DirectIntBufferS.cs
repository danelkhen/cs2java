//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.nio
{
    internal partial class DirectIntBufferS : IntBuffer, global::sun.nio.ch.DirectBuffer
    {
        public static bool unaligned;
        public static global::sun.misc.Unsafe @unsafe;
        public DirectIntBufferS(){}
        public virtual long address(){return default(long);}
        public override IntBuffer asReadOnlyBuffer(){return default(IntBuffer);}
        public virtual global::System.Object attachment(){return default(global::System.Object);}
        public virtual global::sun.misc.Cleaner cleaner(){return default(global::sun.misc.Cleaner);}
        public override IntBuffer compact(){return default(IntBuffer);}
        public override IntBuffer duplicate(){return default(IntBuffer);}
        public override IntBuffer get(int[] prm1, int prm2, int prm3){return default(IntBuffer);}
        public override int get(int prm1){return default(int);}
        public override int get(){return default(int);}
        public override ByteOrder order(){return default(ByteOrder);}
        public override IntBuffer put(int[] prm1, int prm2, int prm3){return default(IntBuffer);}
        public override IntBuffer put(IntBuffer prm1){return default(IntBuffer);}
        public override IntBuffer put(int prm1){return default(IntBuffer);}
        public override IntBuffer put(int prm1, int prm2){return default(IntBuffer);}
        public override IntBuffer slice(){return default(IntBuffer);}
        public bool  IsDirect { get; private set;}
        public bool  IsReadOnly { get; private set;}
    }
}
