class Person
{
    //attributes
    public string? Name;

    public int Age;
    
    //presentation method

    public void Presentation(){
        Console.WriteLine($"My name is {Name}");
    }

    //method to return age status 
    public string VerifyAge(){
        return Age>= 18 ? "Of legal age" : "Under age";
    }
}