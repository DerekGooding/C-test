class Program
{
    static void Main()
    {
        Test p = new Test();
        TestService service = new TestService();
        p.AfficherText(service);
    }
}
