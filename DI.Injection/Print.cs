namespace DI.Injection
{
    public class Print : IPrint
    {
        public void Impress()
        {
            Console.WriteLine("Print >> Impress");
        }
    }
}