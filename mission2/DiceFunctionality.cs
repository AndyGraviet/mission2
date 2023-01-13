using System;
namespace mission2
{
	public static class DiceFunctionality
	{
		public static void Roll(int maxRolls)
		{
            Random rnd = new Random();
            int[] totals = new int[11];

            //LOOP FOR GENERATING ALL THE ROLE VALUES
            for (int i = 0; i < maxRolls; i++)
            {
                //role 2 dice generating random numbers less than or equal to 6
                int currRoll = rnd.Next(1, 7);
                currRoll += rnd.Next(1, 7);
                totals[currRoll - 2] += 1;
                currRoll = 0;
                //add them, add 1 to index where index = sum of dice
            }

            for (int i = 0; i < totals.Length; i++)
            {
                //get percentage 
                float numStars = (totals[i] / (float)maxRolls) * 100;
                string numStarsString = "";
                //convert percentage to string of stars
                for (int j = 0; j < numStars; j++)
                {
                    numStarsString += "*";
                }

                //print the stars
                Console.WriteLine((i + 2) + ": " + numStarsString + " " + numStars);
            }
        }
	}
}

//here's conflict one
//here's conflict two