
using Practice;


// See https://aka.ms/new-console-template for more information

Person[] persons = new Person[] { new Person { name = "Enrique" }, new Person { name = "Jose" }, new Person { name = "Enmanuel" } };


foreach (Person i in persons)
{
    Console.WriteLine(i.name);
    if (i.name == "Jose")
    {
        break;
    }
}

PartTimeEmployee FTE = new PartTimeEmployee();

FTE.name = "Enrique";
FTE.lastName = "Terrero";
Console.WriteLine(FTE.PrintFullName());


Employee[] employees = new Employee[4];

employees[0] = new Employee() { name="enrique" ,lastName="Terrero"};
employees[1] =new PartTimeEmployee() { name = "Enrique", lastName = "Terrero" };
employees[2] =new FullTimeEmployee() { name = "Enrique", lastName = "Terrero" };
employees[3]=new TemporaryEmployee() { name = "Enrique", lastName = "Terrero" };

foreach (Employee e in employees)
{
    try
    {
        Console.WriteLine(e.PrintFullName());
    }catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Customer customer = new Customer(101, "mark");
customer.PrintDetails(); 
Customer customer2 = new Customer();
customer2.Name = "maria";
customer2.Id = 101;
customer2.PrintDetails();
((ICustomer)customer2).Print();


