using System;
using System.Collections;
using System.Collections.Generic;

class Test
{
    public void AfficherText(TestService service)
    {
        service.Maj("Salut");
        service.Min("Salut");
    }
}

class TestService
{
    void Maj(string text)
    {
        Console.WriteLine(text.ToUpper());
    }
    void Min(string text)
    {
        Console.WriteLine(text.ToLower());
    }
}
