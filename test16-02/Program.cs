// See https://aka.ms/new-console-template for more information
Console.WriteLine("Въведете годините ви:");
 int age = int.Parse(Console.ReadLine());
if (age < 21)
{
    Console.WriteLine("непълнолетен");
}
else
{
    Console.WriteLine("пълнолетен");
}
