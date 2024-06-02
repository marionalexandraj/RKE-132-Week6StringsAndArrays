string hello = " we are the heroes?";

int stringLength = hello.Length;

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');
Console.WriteLine(firstLetter);
Console.WriteLine(hello);