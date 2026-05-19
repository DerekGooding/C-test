namespace NoDelegate;
class Test
{
    public void AfficherText(TestService service)
    {
        service.Maj("Salut");
        service.Min("Salut");
    }
}
