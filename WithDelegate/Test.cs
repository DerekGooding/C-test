class Test
{
    public delegate void MyDelegate(string text);
    public delegate void MyDelegate2(string text);

    public void AfficherText()
    {
        MyDelegate.Invoke("Salut");
        MyDelegate2.Invoke("Salut");
    }
}
