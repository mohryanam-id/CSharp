// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("Let's Learn C# Programming");

string name = "King Alpha";
float discount = 3000.50F;
double contactNumber = 12312312312;
char gender = 'M';
Boolean isValid = true;

Console.WriteLine(name);
Console.WriteLine(discount);
Console.WriteLine(contactNumber);
Console.WriteLine(gender);
Console.WriteLine(isValid);


float baseSalary = 4000000;
float tax = 0.50F;
float netSalary = baseSalary - (baseSalary * tax);
Console.WriteLine("Base Salary:" + baseSalary);
Console.WriteLine("Net Salary:" + netSalary);

int temperature = 50;
if (temperature < 20)
    Console.WriteLine("Its Very Could Outside");
else
    Console.WriteLine("Its Moderate Outside");

bool isLoggedIn = true;
bool isEmailVerified = true;
bool cardInfo = true;

if (isLoggedIn && isEmailVerified && cardInfo)
    Console.WriteLine("Allowed to make a purchase");
else
{
    Console.WriteLine("Not Allowed to make a purchase");
}

bool isAuthenticated  = true;

if (isAuthenticated)
{
    Console.WriteLine("You are logged in.");
}
else
{
    Console.WriteLine("You are not logged in.");    
}

string result = isAuthenticated ? "You are logged in" : "You are not logged in";
Console.WriteLine(result);

if (temperature < 20)
{
    Console.WriteLine("Its very cold outside");
}
else if (temperature >= 20 && temperature <= 50)
{
    Console.WriteLine("Its moderate outside");
}
else
{
    Console.WriteLine("Its too hot outside");
}

string[] names = ["Arjuna", "Gatot", "Semar", "Petruk", "Bagong"];

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

for (int i = names.Length -1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();

int j = 0;
while (j< names.Length)
{
    Console.WriteLine(names[j]);
    j++;
}

Console.WriteLine();

j = 0;
do
{
    Console.WriteLine(names[j]);
    j++;
} while (j < names.Length);

Console.WriteLine();

foreach(string currName in names)
{
    Console.WriteLine(currName);
}

Console.WriteLine();

for(int i=0; i <= 10; i++)
{
    if (i == 5) continue;
    if (i == 7) break;
    Console.WriteLine(i);

}

switch("admin")
{
    case "admin":
        Console.WriteLine("You have write access");
        goto case "non admin";
    case "non admin":
        Console.WriteLine("You have read access");
        break;
}

int[] marks = new int[5] { 11, 22, 33, 44, 55 };
foreach (int i in marks)
{
Console.WriteLine(i);
}

int[,] multiArray = new int[3, 4]
{
    {1,2,3,4},
    {1,2,3,4},
    {1,2,3,4}
};

for (int x = 0; x<3; x++)
{
    for (int y = 0;y<4; y++)
    {
        Console.Write(multiArray[x,y]);
    }
    Console.WriteLine();
}

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[5];

Console.WriteLine();

string str1 = "Hello World";
string str2 = "C# Programming";
Console.WriteLine(str1);
Console.WriteLine(str1.Length);
Console.WriteLine(string.Concat(str1, str2));

StringBuilder stringBuilder = new StringBuilder();
stringBuilder.Append(str1);
stringBuilder.Append(str2);