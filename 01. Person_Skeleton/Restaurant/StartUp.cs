namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Cake cake = new Cake("torta");
            Coffee napitka = new Coffee("kafe", 3.5);
            Fish riba = new Fish("kafe", 3.5m);
        }
    }
}