// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Regular expression");

string text = "1 One, 2 Two, 3 Three is good. 4      hi.";
string pattern = @"\d\s*(\D*)[,.]";

Console.WriteLine("Text ::" + text + "::");
Console.WriteLine("Pattern ::" + pattern + "::");

Regex regex = new Regex(pattern);

Console.WriteLine(  "Findes");
Console.WriteLine(regex.IsMatch(text));
Console.WriteLine();

Console.WriteLine(" De enkelte elementer");
Match m = regex.Match(text);
Console.WriteLine("match = " + m);
Console.WriteLine("første gruppe = " + m.Groups[0]);
Console.WriteLine("første gruppe = " + m.Groups[1]);

Console.WriteLine("get all groups");
MatchCollection mc =  regex.Matches(text);
foreach (Match elem in mc)
{
    foreach(Group g in elem.Groups)
    {
        Console.WriteLine("Group : " + g);
    }
}

String twoCiffers = @"^\d{2}$";
regex = new Regex(twoCiffers);
Console.WriteLine("med pattern " + twoCiffers);
Console.WriteLine( regex.IsMatch("12"));
Console.WriteLine(regex.IsMatch("1"));
Console.WriteLine(regex.IsMatch("123"));
Console.WriteLine(regex.IsMatch("12 "));



