static string MakeUpperCase(string str)
{
    return str.ToUpper();

}

Console.WriteLine("Write something: ");
var input = Console.ReadLine();
Console.WriteLine(MakeUpperCase(input));