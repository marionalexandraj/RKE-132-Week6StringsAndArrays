string[] fruits = new string[3];

fruits[0] = "apples";
fruits[1] = "bananas";
fruits[2] = "oranges";

Console.WriteLine($"{fruits[0]}, {fruits[1]}, {fruits[2]})");

int fruitsArrayLenght = fruits.Length;

Console.WriteLine($"There are {fruitsArrayLenght} in your array");

for (int i = 0;  i < fruitsArrayLenght; i++)
{
    fruits[i] = fruits[i].Replace(fruits[i][0], char.ToUpper(fruits[i][0]));
}

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}