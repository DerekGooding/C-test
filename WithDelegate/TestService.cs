class TestService : IDisposable
{
    public TestService(Test test)
    {
        test.MyDelegate += Maj;
        test.MyDelegate2 += Min;
    }


    void Maj(string text)
    {
        Console.WriteLine(text.ToUpper());
    }
    void Min(string text)
    {
        Console.WriteLine(text.ToLower());
    }

    public void Dispose()
    {
        test.MyDelegate -= Maj;
        test.MyDelegate2 -= Min;
    }
}