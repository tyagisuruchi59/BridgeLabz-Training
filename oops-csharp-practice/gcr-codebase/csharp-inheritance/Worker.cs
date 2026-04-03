interface Worker
{
    void PerformDuties();
}

class Person
{
    public string Name;
    public int Id;
}

class Chef : Person, Worker
{
    public void PerformDuties()
    {
        Console.WriteLine("Chef is cooking");
    }
}

class Waiter : Person, Worker
{
    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving food");
    }
}
