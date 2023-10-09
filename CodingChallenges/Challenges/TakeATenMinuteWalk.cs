namespace CodingChallenges.Challenges;

public class TakeATenMinuteWalk
{
    /*
     * You live in the city of Cartesia where all roads are laid out in a perfect grid.
     * You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk.
     * The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']).
     * You always walk only a single block for each letter (direction) and you know it takes you one minute to traverse one city block, so create a function that will return true if the walk the app gives you will take
     * you exactly ten minutes (you don't want to be early or late!) and will, of course, return you to your starting point.
     * Return false otherwise.
     */
    public static bool AutoTest()
    {
        return IsValidWalk(new []{"n","s","n","s","n","s","n","s","n","s"});
    }

    public static bool IsValidWalk(string[] walk)
    {
        //must be a 10min walk
        if(walk.Length != 10)
            return false;
        //convert the directions to numerical values, then add them together and see if they equal 0
        //north and east +1, south and west -1
        int eastWest = 0;
        int northSouth = 0;
        foreach (string direction in walk)
        {
            switch (direction)
            {
                case "n":
                    northSouth += 1;
                break;
                case "s":
                    northSouth += -1;
                break;
                case "e":
                    eastWest += 1;
                break;
                case "w":
                    eastWest += -1;
                break;
                default:
                    return false;
            }
        }

        if (eastWest == 0 && northSouth == 0)
        {
            return true;
        }
        else
            return false;
    }
}