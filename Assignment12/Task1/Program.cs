// See https://aka.ms/new-console-template for more information
using System.Collections;
using Task1;
using Task1.McDonald;
using Task1.School;

Console.WriteLine("Hello, World!");

/*int[] ar1 = new int[6] { 3, 4, 5, 0, 0, 18 };
Console.WriteLine(ar1.Length);
Console.WriteLine(ar1.FirstOrDefault());
Console.WriteLine(ar1.LastOrDefault());
Console.WriteLine(ar1.LongLength);
Console.WriteLine(ar1.All((a) => a > -25));
int[] t = ar1.Append(188).ToArray();
Console.WriteLine(t[6]);
Console.WriteLine(ar1.Average());
Console.WriteLine(ar1.Contains(0));*/

/*ArrL<int> arl = new ArrL<int>(18);
arl.Add(15);
Console.WriteLine(arl);

arl.Add(new int[] { 10, 4, 9 });
Console.WriteLine(arl);

arl.Insert(3, 87);
Console.WriteLine(arl);

arl.Insert(2, new int[] { 81, 108 });
Console.WriteLine(arl);

arl.Reverse();
Console.WriteLine(arl);

arl.Remove(87);
Console.WriteLine(arl);

arl.RemoveAt(2);
Console.WriteLine(arl);

arl.RemoveAt(2, 2);
Console.WriteLine(arl);

arl.Reverse(0, 1);

arl.Sort();
Console.WriteLine(arl);

arl.Clear();
Console.WriteLine(arl);
Console.WriteLine(arl.Search(9));*/

/*GenList<Car> carList = new GenList<Car>();
Car bmw = new Car("BMW", 1200, 505);
carList.Add(new Car("Audi", 1200, 345));
carList.Add(new Car("Ferrari", 1200, 605));
carList.Add(bmw);
carList.Add(new Car("Opel", 1200, 145));
carList.Add(new Car("Honda", 1200, 245));
Console.WriteLine(carList);
Console.WriteLine(carList.IndexOf(bmw, 3, 2));
carList.Sort();
Console.WriteLine(carList);
Console.WriteLine(carList.IndexOf(bmw, 3, 2));
carList.Add(new Car("Ferrari", 1200, 605));
carList.Add(bmw);
carList.Add(new Car("Opel", 1200, 145));
carList.Add(new Car("Honda", 1200, 245));
Console.WriteLine(carList);
Console.WriteLine(carList.IndexOf(bmw, 3, 2));
carList.Sort();
Console.WriteLine(carList);
Console.WriteLine(carList.IndexOf(bmw, 3, 2));
 */

/*GenDict<string, Car> carListGen = new GenDict<string, Car>();
Motorcycle suzuki = new Motorcycle("Suzuki", 450, 330);
Car opel = new Car("Opel", 980, 140);

carListGen.Add("dito", new List<Car>() { new Car("Hoda", 1150, 240), suzuki });
carListGen.PrintList("dito");

carListGen.Add("dito", new Car("Lexus", 1300, 425));
carListGen.PrintList("dito");

//carListGen.Remove("dito", 2);
//carListGen.PrintList("dito");
//carListGen.Remove("dito", suzuki);
//carListGen.PrintList("dito");

carListGen.Add("leo", opel);
carListGen.PrintList("leo");
carListGen.Add("leo", new Car("Ford", 1005, 200));
carListGen.Add("leo", new Car("Bugatti", 855, 1100));
carListGen.PrintList("leo");

carListGen.Append(new KeyValuePair<string, List<Car>>("jon", new List<Car>() { new Car("Tesla", 100, 222) } ));

Console.WriteLine(carListGen.HasMotorcycle());
Console.WriteLine(carListGen.HasMotorcycle("dito"));
Console.WriteLine(carListGen.HasMotorcycle("leo"));
Console.WriteLine(carListGen.HasMotorcycle("jon"));
Console.WriteLine(carListGen.FastestCar("dito").Mark);
Console.WriteLine(carListGen.FastestCar("leo").Mark);
Console.WriteLine(carListGen.FastestCar("jon").Mark);
Console.WriteLine(carListGen.FastestCar().Mark);*/


/*SchoolClass sc = new SchoolClass("3 School", "A1");
sc.Add("dito", new Student("Dito Khanishvili"));
sc.Add("adam", new Student("Adam Khanishvili"));
sc.Add("adami", new Student("Adam Adamadze"));
sc.Add("zezva", new Student("Zezva Zezvadze"));
sc.Remove("zezva");
Console.WriteLine(sc.GetTotalStudents());
Console.WriteLine(sc);

sc.Clear();
Console.WriteLine(sc.GetTotalStudents());
Console.WriteLine(sc);*/

McDonald mc = new McDonald("street 1");
mc.StartOrder(new Order("Order 1", 11.23));
mc.StartOrder(new Order("Order 2", 22.37));
mc.StartOrder(new Order("Order 3", 33.33));
mc.FinishOrder();
mc.FinishOrder();
mc.StartOrder(new Order("Order 4", 44.23));
mc.StartOrder(new Order("Order 5", 55.37));
mc.StartOrder(new Order("Order 6", 66.33));
mc.FinishOrder();
mc.FinishOrder();
mc.StartOrder(new Order("Order 7", 77.23));
mc.StartOrder(new Order("Order 8", 88.37));
mc.StartOrder(new Order("Order 9", 99.33));
Console.WriteLine(mc.GetCurrentOrder());
Console.WriteLine(mc.GetAllOrder());
mc.CloseOffice();
Console.WriteLine(mc.GetAllOrder());