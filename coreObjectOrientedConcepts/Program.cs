// See https://aka.ms/new-console-template for more information
using coreObjectOrientedConcepts;

Console.WriteLine("Hello, World!");

Student student = new Student();
student.acceptDetails();
student.displayDetails();

Console.WriteLine();

SavingAccount account = new SavingAccount();
account.balance();
account.deposit();
account.withdraw();

Console.WriteLine();

SavingAcc acc = new SavingAcc();
acc.balance();
acc.deposit();
acc.withdraw();
acc.createAccount();
acc.deleteAccount();

Console.WriteLine(CustomCalculator.increament());
Console.WriteLine(CustomCalculator.increament());
Console.WriteLine(CustomCalculator.increament());  
Console.WriteLine(CustomCalculator.decreament());

Console.WriteLine();

int number = 0;
bool result = number.IsGreaterThan(1);

Console.WriteLine();

Employee employee = new Employee();
employee.EmployeeID = number;
employee.EmployeeName = "Ryan";
employee.DisplayDetails();

Console.WriteLine();

User user = new User();
user.Name = "Test";
user.Email = "test@gmail.com";
Console.WriteLine(user.Id);
Console.WriteLine(user.Name);
Console.WriteLine(user.Email);  

Console.WriteLine();
StringIndexerType indexerType = new StringIndexerType();
indexerType[1] = "test 1";
indexerType[2] = "test 2";
indexerType[3] = "test 3";
indexerType[4] = "test 4";

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(indexerType[i]);
}

Console.WriteLine();

EnumDemo enumDemo = new EnumDemo();
enumDemo.display();