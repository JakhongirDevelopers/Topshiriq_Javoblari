Console.Write("\nEnter you name:");
string name=Console.ReadLine();
Console.WriteLine($"Ismingiz:{name}");
System.Console.Write($"{name} tug'ulgan yilingizni kiriting:");
int age=Convert.ToInt32(Console.ReadLine());
int Age=2023-age;
System.Console.Write($"Yoshingiz:{Age}");

//sizeof
Console.WriteLine("\nshort , int , long ma'lumot turlari quyidagi qiymatlarni qabul qiladi!");
Console.WriteLine(sizeof(short));
Console.WriteLine(sizeof(int));
Console.WriteLine(sizeof(long));

//range 
Console.WriteLine("\nshort , int , long ma'lumot turlari quyida keltirilgan oraliqdagi qiymatlarni qabul qiladi!");
Console.WriteLine($"{short.MinValue} dan {short.MaxValue}");
Console.WriteLine($"{int.MinValue} dan {int.MaxValue}");
Console.WriteLine($"{long.MinValue} dan {long.MaxValue}");

Console.WriteLine("\nushort , uint , ulong ma'lumot turlari quyida keltirilgan oraliqdagi qiymatlarni qabul qiladi!");
Console.WriteLine($"{ushort.MinValue} dan {ushort.MaxValue}");
Console.WriteLine($"{uint.MinValue} dan {uint.MaxValue}");
Console.WriteLine($"{ulong.MinValue} dan {ulong.MaxValue}\n");

Console.Write("\nBiror son kiriting : ");
double bir=Convert.ToDouble(Console.ReadLine());
Console.Write("Kiritilgan sonni 3 bulamizmi ha=1,yoq=0 : ");
double sn1=Convert.ToDouble(Console.ReadLine());
if (sn1==1)
{
    double son=bir/3;
    Console.WriteLine(son);
}
Console.Write("\nIxtiyoriy son kiriting : ");
decimal ikki=Convert.ToDecimal(Console.ReadLine());
Console.Write("Kiritilgan sonni 3 bulamizmi ha=1,yoq=0 : ");
decimal sn=Convert.ToDecimal(Console.ReadLine());
if (sn==1)
{
    decimal sun=ikki/3;
    Console.WriteLine(sun);
}

decimal birr=1.3m;
decimal ikkii=1.1m;
decimal sum=2.4m;
Console.WriteLine(birr+ikkii==sum);

Console.Write("\nType first namber : ");
int firstNamber=Convert.ToInt32(Console.ReadLine());
Console.Write("\nEnter operation ( +, -, /, *, % ) : ");
string operation =Console.ReadLine();
Console.Write("\nType second namber : ");
int secondNamber=Convert.ToInt32(Console.ReadLine());

string message =
    !(firstNamber>=0)
        ? "\nResult : 1 st namber is negative\n"
        : "\nResult : 1 st namber is positive\n";
Console.WriteLine(message);

if (firstNamber>secondNamber)
{
    Console.WriteLine($"Result : {firstNamber} > {secondNamber}\n");
}
else if (firstNamber==secondNamber)
{
    Console.WriteLine($"Result : {firstNamber} = {secondNamber}\n");
}
else 
{
    Console.WriteLine($"Result : {firstNamber} < {secondNamber}\n");
}

string result = operation switch 
{
    "+" =>$"Result : {firstNamber} + {secondNamber} = {firstNamber+secondNamber}\n",
    "-" =>$"Result : {firstNamber} - {secondNamber} = {firstNamber-secondNamber}\n",
    "/" =>$"Result : {firstNamber} / {secondNamber} = {firstNamber/secondNamber}\n",
    "*" =>$"Result : {firstNamber} * {secondNamber} = {firstNamber*secondNamber}\n",
    "%" =>$"Result : {firstNamber} % {secondNamber} = {firstNamber%secondNamber}\n",
    _ =>"Operation Not Found!\n"
};
Console.WriteLine(result);

switch (operation)
{
    case "+":
        Console.WriteLine($"Result : {firstNamber} + {secondNamber} = {firstNamber+secondNamber}\n");
        break;
    case "-":
        Console.WriteLine($"Result : {firstNamber} - {secondNamber} = {firstNamber-secondNamber}\n");
        break;
    case "/":
        Console.WriteLine($"Result : {firstNamber} / {secondNamber} = {firstNamber/secondNamber}\n");
        break;
    case "*":
        Console.WriteLine($"Result : {firstNamber} * {secondNamber} = {firstNamber*secondNamber}\n");
        break;
    case "%":
        Console.WriteLine($"Result : {firstNamber} % {secondNamber} = {firstNamber%secondNamber}\n");
        break;
    default:
        Console.WriteLine("Operation Not Found!\n");
        break;
}

int x=5,y=10,z=15;
bool a=(x<y)||!(y>z)&&!(x==z);
bool b=(x>y)||(y>z)&&!(x==z);
bool c=!(x==y)||!(x!=z)&&!(z>y);
System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);

string s ="camputer";
for (int i=0; i<s.Length; i++)
{
    System.Console.Write(s[i]);
}