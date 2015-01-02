namespace VendingMachine
{
    public class Coin : ICoin
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public static Coin New5p() {  return new Coin("Five pence", 5);}

        private Coin(string name, int value)
        {
            Value = value;
            Name = name;
        }
    }
}