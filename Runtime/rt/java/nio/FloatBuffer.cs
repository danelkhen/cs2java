//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.nio
{
    public abstract partial class FloatBuffer : Buffer, global::java.lang.Comparable<FloatBuffer>
    {
        public FloatBuffer(){}
        public static FloatBuffer allocate(int prm1){return default(FloatBuffer);}
        public float[] array(){return default(float[]);}
        public int arrayOffset(){return default(int);}
        public virtual FloatBuffer asReadOnlyBuffer(){return default(FloatBuffer);}
        public virtual FloatBuffer compact(){return default(FloatBuffer);}
        public virtual int compareTo(FloatBuffer prm1){return default(int);}
        public virtual FloatBuffer duplicate(){return default(FloatBuffer);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public virtual FloatBuffer get(float[] prm1, int prm2, int prm3){return default(FloatBuffer);}
        public virtual FloatBuffer get(float[] prm1){return default(FloatBuffer);}
        public virtual float get(){return default(float);}
        public virtual float get(int prm1){return default(float);}
        public bool hasArray(){return default(bool);}
        public override int hashCode(){return default(int);}
        public virtual ByteOrder order(){return default(ByteOrder);}
        public FloatBuffer put(float[] prm1){return default(FloatBuffer);}
        public virtual FloatBuffer put(float[] prm1, int prm2, int prm3){return default(FloatBuffer);}
        public virtual FloatBuffer put(int prm1, float prm2){return default(FloatBuffer);}
        public virtual FloatBuffer put(FloatBuffer prm1){return default(FloatBuffer);}
        public virtual FloatBuffer put(float prm1){return default(FloatBuffer);}
        public virtual FloatBuffer slice(){return default(FloatBuffer);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public static FloatBuffer wrap(float[] prm1, int prm2, int prm3){return default(FloatBuffer);}
        public static FloatBuffer wrap(float[] prm1){return default(FloatBuffer);}
        public bool  IsDirect { get; private set;}
    }
}