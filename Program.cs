using OOPhomework2;
using OOPhomework2.Part_2;
using OOPhomework2.Part_3;

var dog = new Dog("Bobik");
Console.WriteLine(dog.name);
dog.Breathe();
dog.Walk();
Console.WriteLine($"The dog has {dog.GetPaws()} paws");
if (dog.HasTail())
{
    Console.WriteLine("The dog has tail");
}

if(dog is Mammal)
{
    Console.WriteLine("Dog is mammal");
}

var dove = new Dove();
dove.Breathe();
dove.Walk();
dove.Fly();
Console.WriteLine($"The dove has {dove.GetPaws()} paws");
if (dove.HasTail())
{
    Console.WriteLine("The dove has tail");
}

if (dove is Bird)
{
    Console.WriteLine("Dove is bird");
}

Dog.BarkToConsole(3);

var worker = new Worker("John", 1000, 25);
Console.WriteLine(worker.GetAge());
Console.WriteLine(worker.GetSalary());

var worker1 = new Worker2();
worker1.SetName("Ivan");
worker1.SetAge(25);
worker1.SetSalary(1000);

var worker2 = new Worker2();
worker2.SetName("Vasya");
worker2.SetAge(26);
worker2.SetSalary(2000);

var sumSalaries = worker1.GetSalary() + worker2.GetSalary();
Console.WriteLine(sumSalaries);

var student = new Student(1000, 2);
student.ShowStudentInfo();
