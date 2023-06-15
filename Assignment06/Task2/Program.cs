// See https://aka.ms/new-console-template for more information
using System;
using Task2;

//CustomList<Person> list = new CustomList<Person>();
PersonList list = new PersonList();
Person p1 = new Person() { Id = 1, Name = "Person1", Age = 31};
Person p2 = new Person() { Id = 2, Name = "Person2", Age = 32 };
Person p3 = new Person() { Id = 3, Name = "Person3", Age = 33 };
Person p4 = new Person() { Id = 4, Name = "Person4", Age = 34 };
Person p5 = new Person() { Id = 5, Name = "Person5", Age = 35 };
Person p6 = new Person() { Id = 6, Name = "Person6", Age = 36 };
Person p7 = new Person() { Id = 7, Name = "Person7", Age = 37 };
Person p8 = new Person() { Id = 8, Name = "Person8", Age = 38 };
Person p9 = new Person() { Id = 9, Name = "Person9", Age = 39 };
Person p10 = new Person() { Id = 10, Name = "Person10", Age = 40 };

list.AddElement(p1);
list.AddElement(p2);
list.AddList(new Person[] { p3, p4 });
list.InsertElement(p5, 2);
list.InsertElement(p8, 4);
list.InsertList(new Person[] { p6, p7 }, 3);
list.InsertList(new Person[] { p9, p10  }, 6);

Console.WriteLine("Count of list: " + list.Cuunt);
for (int i = 0; i < list.items.Length; i++)
{
    Console.WriteLine(list.items[i].Name);
}

Person gp1;
if (list.GetElement(6, out gp1)) {
    Console.WriteLine("======GetElement======");
    Console.WriteLine("GP1: " + gp1.Name);
}

Person[] gl1;
if (list.GetList(6, 3, out gl1))
{
    Console.WriteLine("======GetList======");
    foreach (Person p in gl1)
    {
        Console.WriteLine(p.Name);
    }
}

Console.WriteLine("======RemoveElement======");
list.RemoveElement(p5);
Console.WriteLine("Count of list: " + list.Cuunt);
for (int i = 0; i < list.items.Length; i++)
{
    Console.WriteLine(list.items[i].Name);
}

Console.WriteLine("======RemoveList======");
list.RemoveList(new Person[] {p2, p4, p6, p8});
Console.WriteLine("Count of list: " + list.Cuunt);
for (int i = 0; i < list.items.Length; i++)
{
    Console.WriteLine(list.items[i].Name);
}


//list[45] = p7;
//Console.WriteLine("Count of list: " + list[4].Name);

Console.WriteLine("======Clear======");
list.Clear();
Console.WriteLine("Count of list: " + list.Cuunt);

/*Console.WriteLine("Find ======");
Person find = list.Find("Person2");

list.Clear();
Console.WriteLine("After clear: " + list.Cuunt);*/


//Console.WriteLine(find.Name);





