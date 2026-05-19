namespace WithDelegate;

class TestService : IDisposable
{
    private readonly Test _test;
    public TestService(Test test)
    {
        _test = test;
        _test.MyDelegate += Maj;
        _test.MyDelegate2 += Min;
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
        _test.MyDelegate -= Maj;
        _test.MyDelegate2 -= Min;
    }
}