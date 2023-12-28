// See https://aka.ms/new-console-template for more information
using coreAdvancedConcepts;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

Console.WriteLine("Hello, World!");
Calculation calculation = new Calculation();
calculation.Calculate();

var anonType = new
{
    email = "test@gmail.com",
    password = "password",
    address = new { streetName = "street name" },
    sosmeds = new[]
    {
        new { sosmedName = "Test",sosmedLink = "Test" },
        new { sosmedName = "Test",sosmedLink = "Test" },
    }
};

Console.WriteLine(anonType.email);
Console.WriteLine(anonType.password);
Console.WriteLine(anonType.address.streetName);
Console.WriteLine(anonType.sosmeds[0].sosmedName);

CalculateDelegate calculateDelegate = new CalculateDelegate(DelegateExample.Addition);
calculateDelegate(100);
Console.WriteLine(DelegateExample.GetNumber());
calculateDelegate += new CalculateDelegate(DelegateExample.Addition);
calculateDelegate(300);
Console.WriteLine(DelegateExample.GetNumber());

int[] numbers = [2, 3, 4, 5, 7, 5];
int count = numbers.Count(x => x == 5);
Console.WriteLine(count);
int isFiveExist = numbers.Count(x => { return x == 5; });