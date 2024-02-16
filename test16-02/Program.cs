// See https://aka.ms/new-console-template for more information
Console.WriteLine("Въведете годините ви:");
 int age = int.Parse(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine("непълнолетен");
}
else
{
    Console.WriteLine("пълнолетен");
}