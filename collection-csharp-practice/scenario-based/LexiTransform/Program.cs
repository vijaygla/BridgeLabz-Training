using LexiTransform;

Console.Write("Enter any word having 6 character atleast : ");
string word = Console.ReadLine();

LexiTransformer transformer = new LexiTransformer();
string result = transformer.SolveProblem(word);

if (string.IsNullOrEmpty(result))
{
    Console.WriteLine("Invalid input");
}
else
{
    Console.WriteLine("Generated String : " + result);
}
