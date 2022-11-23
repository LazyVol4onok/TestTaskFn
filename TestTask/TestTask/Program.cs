using System.Text;

public class main
{
       public static void Main()
     {
         string word = "(( @";
         StringBuilder str = new StringBuilder(word.ToLower());
         StringBuilder str2 = new StringBuilder();
         for (int i = 0; i < str.Length; i++)
         {
             for (int j = 0; j < str.Length; j++)
             {
                if (str[i].ToString() == str[j].ToString() && i != j)
                 {
                     str2.Append(')');
                    break;
                 }

                if (str[i].ToString() != str[j].ToString() && j == word.Length - 1)
                {
                    str2.Append('(');
                }
                if (i == j && j == word.Length - 1)
                {

                    str2.Append('(');
                    
                }
                
            }

         }
         Console.WriteLine(str2.ToString());
     }

}