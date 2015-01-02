namespace VendingMachine
{
    public class Coin : ICoin
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public static Coin New5p() {  return new Coin("Five pence", 5);}
        public static Coin New10p() { return new Coin("Ten pence", 10); }
        public static Coin New20p() { return new Coin("Twenty pence", 20); }
        public static Coin New50p() { return new Coin("Fifty pence", 50); }
        public static Coin New1Pound() { return new Coin("One pound", 100); }
        public static Coin New2Pounds() { return new Coin("Two pounds", 200); }

        private Coin(string name, int value)
        {
            Value = value;
            Name = name;
        }

    }
}