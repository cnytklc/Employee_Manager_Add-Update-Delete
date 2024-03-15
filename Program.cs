class Interfaces
{
    static void Main(string[] args)
    {
        IPersonManager manager = new Manager();
        IPersonManager employee = new Employee();

        PersonalInformation manager1 = new PersonalInformation()
        {
          PersonalId = 1,
          Age = 26,
          FirstName = "Cüneyt", 
          LastName = "Kılıç"
        };
        PersonalInformation employee1 = new PersonalInformation()
        {
            PersonalId = 1,
            Age = 25,
            FirstName = "A",
            LastName = "Kılıç"
        };
        manager.Add(manager1);
        employee.Add(employee1);


    }

}


public class PersonalInformation 
{
    public int PersonalId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }


}
interface IPersonManager
{
    void Add(PersonalInformation personalInformation);
    void Update(PersonalInformation personalInformation);
    void Delete(PersonalInformation personalInformation);


}
class Employee : IPersonManager
{
    public void Add(PersonalInformation personalInformation)
    {
        Console.WriteLine("Personal Added : "+ personalInformation.FirstName +" "+ personalInformation.LastName);
    }

    public void Delete(PersonalInformation personalInformation)
    {
        Console.WriteLine("Personal Deleted : " + personalInformation.FirstName +" "+ personalInformation.LastName);


    }

    public void Update(PersonalInformation personalInformation)
    {
        Console.WriteLine("Personal Information Updated : " + personalInformation.FirstName +" "+ personalInformation.LastName);


    }
}

class Manager : IPersonManager
{
   

    public void Add(PersonalInformation personalInformation)
    {
        Console.WriteLine("Manager Added : " + personalInformation.FirstName + " " + personalInformation.LastName);

    }


    public void Delete(PersonalInformation personInformation)
    {
        Console.WriteLine("Manager Deleted : " + personInformation.FirstName + " " + personInformation.LastName);

    }

    public void Update(PersonalInformation personalInformation)
    {
        Console.WriteLine("Manager Information Updated : " + personalInformation.FirstName + " " + personalInformation.LastName);

    }
}