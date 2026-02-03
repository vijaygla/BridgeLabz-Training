namespace LexiTransform
{
    public class LexiTransformer
    {
        public string SolveProblem(string word)
        {
            if(word == null || word.Length < 6)
            {
                return "";
            }

            // Rule 2: Must contain only alphabets
            foreach(char c in word)
            {
                if(!char.IsLetter(c))
                {
                    return "";
                }
            }

            // convert the word to the lower case
            word = word.ToLower();

            // remove all vowels
            string filtered = "";
            foreach (char c in word)
            {
                if (!"aeiou".Contains(c))
                {
                    filtered += c;
                }
            }

            // Reverse the filtered string
            char[] arr = filtered.ToCharArray();
            Array.Reverse(arr);

            // Convert even index characters to uppercase
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }

            return new string(arr);
        }
    }
}
