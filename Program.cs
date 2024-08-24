
// upper lower 
System.Console.Write("enter the word ");
string str = Console.ReadLine();
System.Console.Write("enter the number ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > str.Length)
{
    Console.WriteLine(str.ToUpper());
}else {
    Console.WriteLine(str.ToLower());
}



// if else operation
System.Console.Write("enter the firstnumber ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("enter the secondnumber ");
int y = Convert.ToInt32(Console.ReadLine());

string result = "";

if (x > y)
{
    result = "x is greater than y";
}else if(x < y){
    result = "x is less than y";
}else if(x == y){
    result = "x is equal to y";
}else{
    result = "x and y are not comparable";
}

Console.WriteLine(result);



// days of week
Console.Write("hafta kunini kiriting ");
string hafta = Console.ReadLine();

string week = hafta switch 
{
    "dushanba" => "this is Monday",
    "seshanba" => "this is Tuesday",
    "chorshanba" => "this is Wednesday",
    "payshanba"  => "this is Thursday",
    "juma"       => "this is Friday",
    "shanba"     => "this is Saturday",
    "yakshanba"  => "this is Sunday",
    _            => "this is its not a weekday"
};

Console.WriteLine(week);