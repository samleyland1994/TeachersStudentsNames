Console.WriteLine("How many students are in your class?");
Console.ReadLine();
string[] studentNames = new string[6];
Console.WriteLine("Please input names");
for (int i = 0; i < studentNames.Length; i++)
{
    studentNames[i] = Console.ReadLine();
}
Console.WriteLine("\nHere they are alphabetically");

Array.Sort(studentNames);

for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}
Console.ReadKey();



