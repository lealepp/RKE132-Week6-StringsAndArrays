string hello = "we are the champions?";

int stringLenght = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);
Console.WriteLine(hello);

int wordCounter = 1;
int i = 0;
{
    if (char.IsWhiteSpace(hello[i]))
    { wordCounter++; }
    Console.WriteLine($"Word count in {hello}: {wordCounter + 3} words");}