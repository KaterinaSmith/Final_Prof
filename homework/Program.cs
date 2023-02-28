string[] ARR;
Console.WriteLine("Введите значения через пробел:");
string array = Console.ReadLine();
ARR = array.Split(' ');
var result = new string[ARR.Length];
var count = 0;
foreach (var l in ARR)
{
    if(l.Length<4)
    {
        result[count] = l;
        count++;
    }
}
Console.Write(string.Join(Environment.NewLine, result));