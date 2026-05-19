namespace WithDelegate;

class Program
{
    static void Main()
    {
        Test p = new Test();
        using var _ = new TestService(p);
        p.AfficherText();
    }
}
