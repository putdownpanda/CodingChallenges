namespace CodingChallenges.Challenges;

public class MoveZeroes
{
    /*Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
     */
    public static int[] MoveTheZeroes(int[] arr)
    {
        List<int> finalArray = new List<int>();
        List<int> zeroArray = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                zeroArray.Add(arr[i]);
                continue;
            }
            finalArray.Add(arr[i]);
        }
        finalArray.AddRange(zeroArray);
        return finalArray.ToArray();
    }
}