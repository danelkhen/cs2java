//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.nio
{
    public abstract partial class CharBuffer : Buffer, global::java.lang.Comparable<CharBuffer>, global::java.lang.Appendable, global::java.lang.CharSequence, global::java.lang.Readable
    {
        public CharBuffer(){}
        public static CharBuffer allocate(int prm1){return default(CharBuffer);}
        public virtual CharBuffer append(char prm1){return default(CharBuffer);}
        public virtual CharBuffer append(global::java.lang.CharSequence prm1){return default(CharBuffer);}
        public virtual CharBuffer append(global::java.lang.CharSequence prm1, int prm2, int prm3){return default(CharBuffer);}
        global::java.lang.Appendable global::java.lang.Appendable.append(global::java.lang.CharSequence prm1){return default(global::java.lang.Appendable);}
        global::java.lang.Appendable global::java.lang.Appendable.append(global::java.lang.CharSequence prm1, int prm2, int prm3){return default(global::java.lang.Appendable);}
        global::java.lang.Appendable global::java.lang.Appendable.append(char prm1){return default(global::java.lang.Appendable);}
        public char[] array(){return default(char[]);}
        public int arrayOffset(){return default(int);}
        public virtual CharBuffer asReadOnlyBuffer(){return default(CharBuffer);}
        public char charAt(int prm1){return default(char);}
        public virtual CharBuffer compact(){return default(CharBuffer);}
        public virtual int compareTo(CharBuffer prm1){return default(int);}
        public virtual CharBuffer duplicate(){return default(CharBuffer);}
        public override bool equals(global::System.Object prm1){return default(bool);}
        public virtual char get(int prm1){return default(char);}
        public virtual char get(){return default(char);}
        public virtual CharBuffer get(char[] prm1, int prm2, int prm3){return default(CharBuffer);}
        public virtual CharBuffer get(char[] prm1){return default(CharBuffer);}
        public bool hasArray(){return default(bool);}
        public override int hashCode(){return default(int);}
        public int length(){return default(int);}
        public virtual ByteOrder order(){return default(ByteOrder);}
        public CharBuffer put(char[] prm1){return default(CharBuffer);}
        public virtual CharBuffer put(char prm1){return default(CharBuffer);}
        public virtual CharBuffer put(CharBuffer prm1){return default(CharBuffer);}
        public virtual CharBuffer put(int prm1, char prm2){return default(CharBuffer);}
        public virtual CharBuffer put(char[] prm1, int prm2, int prm3){return default(CharBuffer);}
        public CharBuffer put(global::java.lang.String prm1){return default(CharBuffer);}
        public virtual CharBuffer put(global::java.lang.String prm1, int prm2, int prm3){return default(CharBuffer);}
        public virtual int read(CharBuffer prm1){return default(int);}
        public virtual CharBuffer slice(){return default(CharBuffer);}
        public virtual CharBuffer subSequence(int prm1, int prm2){return default(CharBuffer);}
        global::java.lang.CharSequence global::java.lang.CharSequence.subSequence(int prm1, int prm2){return default(global::java.lang.CharSequence);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public static CharBuffer wrap(char[] prm1){return default(CharBuffer);}
        public static CharBuffer wrap(global::java.lang.CharSequence prm1, int prm2, int prm3){return default(CharBuffer);}
        public static CharBuffer wrap(char[] prm1, int prm2, int prm3){return default(CharBuffer);}
        public static CharBuffer wrap(global::java.lang.CharSequence prm1){return default(CharBuffer);}
        public bool  IsDirect { get; private set;}
    }
}
