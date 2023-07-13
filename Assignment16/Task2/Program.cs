// See https://aka.ms/new-console-template for more information
using Task2;
using static Task2.FindDelegateUtils;

Contact contact = new Contact();
contact.AddPerson(new Person("Lionel", "Messi", 36));
contact.AddPerson(new Person("Andres", "Iniesta", 39));
contact.AddPerson(new Person("Ronald", "Araujo", 23));
contact.AddPerson(new Person("Andres", "Christensen", 27));
contact.AddPerson(new Person("Ansu", "Fati", 20));


try {
    Console.WriteLine("Select search criteria:\n\t1 - By name\n\t2 - By surname\n\t3 - By name or surname\n\t4 - By age (enter range sperated by '-')");
    String serchCriteria = Console.ReadLine();
    while (string.IsNullOrEmpty(serchCriteria))
    {
        Console.Write("Invalid search criteria, please select again: ");
        serchCriteria = Console.ReadLine();
    }

    FindDelegate fd = FindDelegateUtils.GetDelegate(serchCriteria);

    if (fd == null)
    {
        Console.Write("Selected wrong search criteria, please try again!");
        return;
    }

    Console.Write("Type search key: ");
    String searchKey = Console.ReadLine();
    while (string.IsNullOrEmpty(searchKey))
    {
        Console.Write("Invalid search key, please type again: ");
        searchKey = Console.ReadLine();
    }

    List<Person> dit = contact.FindPerson(fd, searchKey);
    foreach (Person p in dit)
    {
        Console.WriteLine(p.Name + " " + p.SurName + " " + p.Age);
    }
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
