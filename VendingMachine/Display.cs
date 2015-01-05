namespace VendingMachine
{
    public class Display : IDisplay
    {
        public Display()
        {
            Row1 = "";
            Row2 = "";
        }

        public string Row1 { get; set; }
        public string Row2 { get; set; }
    }
}