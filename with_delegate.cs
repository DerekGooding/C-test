using System;
using System.Collections;
using System.Collections.Generic;

class Test
{
    delegate void MyDelegate(string text);
    delegate void MyDelegate2(string text);

    public void AfficherText()
    {
        MyDelegate.Invoke("Salut");
        MyDelegate2.Invoke("Salut");
    }
}

class TestService : IDisposable
{
    class TestService(Test test)
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