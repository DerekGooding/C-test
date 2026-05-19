namespace WithDelegate;

class Test
{
    public Action<string> MyDelegate;
    public Action<string> MyDelegate2;

    public void AfficherText()
    {
        MyDelegate.Invoke("Salut");
        MyDelegate2.Invoke("Salut");
    }
}