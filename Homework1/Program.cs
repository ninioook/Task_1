// 1. დაბეჭდავს კლავიატურიდან შემოტანილ ტექსტს.(სახელს და გვარს)

Console.WriteLine("Enter Firstname and Lastname");

string info = Console.ReadLine();

Console.WriteLine(info);

// 2. კლავიატურიდან შემოიტანს ორ რიცხვს და დაბეჭდავს მათ : ჯამს , სხვაობას, ნამრავლს, პირველი რიცხვის მეორეზე გაყოფის ნაშთს.

Console.WriteLine("Enter first number");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");

int y = int.Parse(Console.ReadLine());

Console.WriteLine($"x+y: {x + y}");
Console.WriteLine($"x - y: {x - y}");
Console.WriteLine($"x*y: {x * y}");
Console.WriteLine($"x % y: {x % y}");

// 3. კლავიატურიდან შემოიტანს ორ რიცხვს და გაუცვლის მათ მნიშვნელობას. (მაგ. თუ x-ში შეინახავთ რიცხვს 5-ს y-ში 3-ს უნდა დაწეროთ პროგრამა რომლის შედეგადაც x და y ის მნიშვნელობა გაუცვლის ადგილს ერთმანეთს.(swap)

Console.WriteLine("Enter a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter b");
int b = int.Parse(Console.ReadLine());

int temp = a;
a = b;
b = temp;

Console.WriteLine($"a:{a}, b: {b}");

// 4. კონსოლიდან(კლავიატურიდან) შემოიტანს 4 რიცხვს და გამოითვლის ამ რიცხვების საშუალოს.

Console.WriteLine("Enter first number");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number");
int second = int.Parse(Console.ReadLine());

Console.WriteLine("Enter third number");
int third = int.Parse(Console.ReadLine());

Console.WriteLine("Enter fourth number");
int fourth = int.Parse(Console.ReadLine());

Console.WriteLine($"Average: {(first + second + third + fourth) / 4}");


// 5. რომელიც კელვინს გადაიყვანს ცელსიუსში(კონცერტაციის ფორმულა ნახეთ ინტერნეტში 🙂 )

Console.WriteLine("Enter celsius");
int celsius = int.Parse(Console.ReadLine());

double kelvin = celsius + 273.15;
Console.WriteLine(kelvin);

// 6. კლავიატურიდან შემოიტანს რიცხვს და თუ ეს რიცხვი დადებითია დაბეჭდავს ტექსტ “number is positive”

Console.WriteLine("Enter number");

int z = int.Parse(Console.ReadLine());

if (z > 0)
    Console.WriteLine("number is positive");

// 7. კლავიატურიდან შემოიტანს 3 რიცხვს და დაბეჭდავს ამ 3 რიცხვიდან უმცირესს /უდიდესს
Console.Write("Enter c ");
int c = int.Parse(Console.ReadLine());
Console.Write("Enter d ");
int d = int.Parse(Console.ReadLine());
Console.Write("Enter e ");
int e = int.Parse(Console.ReadLine());

if (c < d && c < e)
    Console.WriteLine($"Min number is{c}");
if (d < e && d < c)
    Console.WriteLine($"Min number is{d}");
if (e < d && e < c)
    Console.WriteLine($"Min number is{e}");

if (c > d && c > e)
    Console.WriteLine($"Max number is{c}");
if (d > e && d > c)
    Console.WriteLine($"Max number is{d}");
if (e > d && e > c)
    Console.WriteLine($"Max number is{e}");

// 8. კლავიატურიდან შემოიტანს ორ რიცხვს და თუ ეს ორი რიცხვი ტოლია გაზრდის მათ მნიშვნელობებს 3 ჯერ
Console.Write("Enter number");
int f = int.Parse(Console.ReadLine());

Console.Write("Enter number");
int j = int.Parse(Console.ReadLine());

if (f == j)
{
    f *= 3;
    j *= 3;

    Console.WriteLine($"f={f};j={j}");
}

// 9. კლავიატურიდან შემოტანილ რიცხვს შეამოწმებს არის თუ არა 7 -ის ჯერადი.
Console.Write("Enter number");
int k = int.Parse(Console.ReadLine());

bool canDivide;
if (k % 7 == 0)
{
    canDivide = true;
    Console.WriteLine(canDivide);
}
else
{
    canDivide = false;
    Console.WriteLine(canDivide);
}
// 10. კლავიატურიდან შემოიტანს რიცხვს და დაბეჭდავს შეიცავს თუ არა ეს რიცხვი ციფრ 5-ს.
Console.Write("Enter number");
string number = Console.ReadLine();

bool contains = number.Contains('5');
Console.WriteLine(contains);

// 11. კლავიატურიდან შემოიტანს ამ რიცხვს და დაბეჭდავს ამ რიცხვის ციფრებს.(მაგ 324 უნდა დაბეჭდოს 3 2 4
