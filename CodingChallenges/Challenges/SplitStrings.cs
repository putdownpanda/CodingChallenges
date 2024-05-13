namespace CodingChallenges.Challenges;
using System.Linq;
using System.Collections;
public class SplitStrings
{
    /*Complete the solution so that it splits the string into pairs of two characters.
     If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').
     */

    public static string[] SplitTheStrings(string str)
    {
        char[] SplitStrings = str.ToCharArray();
        if(SplitStrings.Length % 2 != 0)
        {
            Array.Resize(ref SplitStrings, SplitStrings.Length + 1);
            SplitStrings[SplitStrings.Length - 1] = '_';
        }
        //tracker will be used to determine if the current character is the first or second in the pair
        List<string> finalArray = new List<string>();
        for (int i = 0; i < SplitStrings.Length; i +=2)
        {
            finalArray.Add($"{SplitStrings[i]}{SplitStrings[i + 1]}");
        }
        return finalArray.ToArray();
    }
}