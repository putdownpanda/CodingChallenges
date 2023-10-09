namespace CodingChallenges.Challenges;

public class HighestAndLowest
{
    /*In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
     
    All numbers are valid Int32, no need to validate them.
    There will always be at least one number in the input string.
    Output string must be two numbers separated by a single space, and highest number is first.
    */
    public static bool AutoTest()
    {
        return HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4") == "42 -9";
    }
    
    public static string HighAndLow(string numbers)
    {
        int highest = 0;
        int lowest = 0;
        string[]newNumbers = numbers.Split(' ');
        bool firstRun = true;
        for (int i = 0; i < newNumbers.Length; i++)
        {
            
            string number = newNumbers[i];

            if (firstRun == true)
            {
                highest = int.Parse(number);
                lowest = int.Parse(number);
                firstRun = false;
                continue;
            }
            int newNumber = int.Parse(number);
            if(newNumber > highest)
                highest = newNumber;
            if(newNumber < lowest)
                lowest = newNumber;
        }
        
        return $"{highest} {lowest}";
    }
}