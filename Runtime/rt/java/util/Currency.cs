//***************************************************
//* This file was generated by JSharp
//***************************************************
namespace java.util
{
    public partial class Currency : global::java.lang.Object, global::java.io.Serializable
    {
        public Currency(){}
        public virtual global::java.lang.String getDisplayName(Locale prm1){return default(global::java.lang.String);}
        public static Currency getInstance(Locale prm1){return default(Currency);}
        public static Currency getInstance(global::java.lang.String prm1){return default(Currency);}
        public virtual global::java.lang.String getSymbol(Locale prm1){return default(global::java.lang.String);}
        public override global::java.lang.String toString(){return default(global::java.lang.String);}
        public Set<Currency>  AvailableCurrencies { get; private set;}
        public global::java.lang.String  CurrencyCode { get; private set;}
        public int  DefaultFractionDigits { get; private set;}
        public global::java.lang.String  DisplayName { get; private set;}
        public int  NumericCode { get; private set;}
        public global::java.lang.String  Symbol { get; private set;}
    }
}
