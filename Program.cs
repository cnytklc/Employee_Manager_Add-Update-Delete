class Interfaces
{
    static void Main(string[] args)
    {
        IPersonManager person1 = new Employee();
        IManagersManager manager1 = new Manager();

        ManagerInformation managerInformation = new ManagerInformation()
        {
          PersonalId = 1,
          Age = 26,
          FirstName = "Cüneyt", 
          LastName = "Kılıç"
        };
        manager1.Add(managerInformation);

    }

}

class ManagerInformation : PersonalInformation
{
}
class PersonalInformation 
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

interface IManagersManager
{
    void Add(ManagerInformation managerInformation);
    void Update(ManagerInformation managerInformation);
    void Delete(ManagerInformation managerInformation);


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

class Manager : IManagersManager
{
   

    public void Add(ManagerInformation managerInformation)
    {
        Console.WriteLine("Manager Added : " + managerInformation.FirstName + " " + managerInformation.LastName);

    }


    public void Delete(ManagerInformation managerInformation)
    {
        Console.WriteLine("Manager Deleted : " + managerInformation.FirstName + " " + managerInformation.LastName);

    }

    public void Update(ManagerInformation managerInformation)
    {
        Console.WriteLine("Manager Information Updated : " + managerInformation.FirstName + " " + managerInformation.LastName);

    }
}