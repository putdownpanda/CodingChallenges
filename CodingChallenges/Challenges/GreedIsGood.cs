namespace CodingChallenges.Challenges;

public class GreedIsGood
{
    /*Description:

Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.

 Three 1's => 1000 points
 Three 6's =>  600 points
 Three 5's =>  500 points
 Three 4's =>  400 points
 Three 3's =>  300 points
 Three 2's =>  200 points
 One   1   =>  100 points
 One   5   =>   50 point

A single die can only be counted once in each roll. For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

Example scoring

 Throw       Score
 ---------   ------------------
 5 1 3 4 1   250:  50 (for the 5) + 2 * 100 (for the 1s)
 1 1 1 3 1   1100: 1000 (for three 1s) + 100 (for the other 1)
 2 4 4 5 4   450:  400 (for three 4s) + 50 (for the 5)
*/
    private static Dictionary<int,int> _diceScoreValues = new Dictionary<int,int>
    {
        {1, 100},
        {5, 50}
    };
    //solution is to get all the dice values into a multidimensional array and then loop through the array to get the score by check the length of each array
    public static int ScoreDiceRolls(int[] dice)
    {
        try
        {
            if (dice.Length != 5)
                return -1;

            int score = 0;
            List<int>[] scoreArray = new List<int>[6];

            for (int i = 0; i < scoreArray.Length; i++)
            {
                scoreArray[i] = new List<int>();
            }

            foreach (var roll in dice)
            {
                if (roll == 1)
                    scoreArray[0].Add(roll);

                else if (roll == 2)
                    scoreArray[1].Add(roll);

                else if (roll == 3)
                    scoreArray[2].Add(roll);

                else if (roll == 4)
                    scoreArray[3].Add(roll);

                else if (roll == 5)
                    scoreArray[4].Add(roll);

                else if (roll == 6)
                    scoreArray[5].Add(roll);
            }

            for (int i = 0; i < scoreArray.Length; i++)
            {
                if (scoreArray[i].Count >= 3)
                {
                    if (i == 0)
                        score += 1000;
                    if (i == 1)
                        score += 200;
                    if (i == 2)
                        score += 300;
                    if (i == 3)
                        score += 400;
                    if (i == 4)
                        score += 500;
                    if (i == 5)
                        score += 600;

                    //deal with if there are more then 3 of the same number
                    if (scoreArray[i].Count > 3)
                        score += _diceScoreValues[i + 1] * (scoreArray[i].Count - 3);

                }
                else if (scoreArray[i].Count > 0 && _diceScoreValues.ContainsKey(i + 1))
                {
                    score += _diceScoreValues[i + 1] * scoreArray[i].Count;
                }
            }

            return score;
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}