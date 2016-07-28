//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.nio
{
    public abstract partial class DoubleBuffer : Buffer, global::java.lang.Comparable<DoubleBuffer>
    {
        public DoubleBuffer(){}
        public static DoubleBuffer allocate(int prm1){return default(DoubleBuffer);}
        public double[] array(){return default(double[]);}
        public int arrayOffset(){return default(int);}
        public virtual DoubleBuffer asReadOnlyBuffer(){return default(DoubleBuffer);}
        public virtual DoubleBuffer compact(){return default(DoubleBuffer);}
        public virtual int compareTo(DoubleBuffer prm1){return default(int);}
        public virtual DoubleBuffer duplicate(){return default(DoubleBuffer);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public virtual DoubleBuffer get(double[] prm1, int prm2, int prm3){return default(DoubleBuffer);}
        public virtual DoubleBuffer get(double[] prm1){return default(DoubleBuffer);}
        public virtual double get(){return default(double);}
        public virtual double get(int prm1){return default(double);}
        public bool hasArray(){return default(bool);}
        public override int hashCode(){return default(int);}
        public virtual ByteOrder order(){return default(ByteOrder);}
        public DoubleBuffer put(double[] prm1){return default(DoubleBuffer);}
        public virtual DoubleBuffer put(double[] prm1, int prm2, int prm3){return default(DoubleBuffer);}
        public virtual DoubleBuffer put(int prm1, double prm2){return default(DoubleBuffer);}
        public virtual DoubleBuffer put(DoubleBuffer prm1){return default(DoubleBuffer);}
        public virtual DoubleBuffer put(double prm1){return default(DoubleBuffer);}
        public virtual DoubleBuffer slice(){return default(DoubleBuffer);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public static DoubleBuffer wrap(double[] prm1, int prm2, int prm3){return default(DoubleBuffer);}
        public static DoubleBuffer wrap(double[] prm1){return default(DoubleBuffer);}
        public bool  IsDirect { get; private set;}
    }
}
