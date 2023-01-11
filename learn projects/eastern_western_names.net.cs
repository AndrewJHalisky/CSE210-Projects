public class Person
{
    public string _givenName = "Andrew";
    public string _familyName = "Halisky";
    
    public Person()
    {
    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName} {_givenName}");
    }

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }

}
