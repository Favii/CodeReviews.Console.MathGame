namespace MathGame

{
    public class Helper
    {
        public void GenerateNumbers(ref int a, ref int b)
        {
            Random random = new Random();
            a = random.Next(1, 10);
            b = random.Next(1, 10);
        }

        public void GenerateNumbersForDivision(ref int a, ref int b)
        {
            Random random = new Random();
            a = random.Next(1, 101);
            b = random.Next(1, 101);

            while (a % b != 0)
            {
                a = random.Next(1, 101);
                b = random.Next(1, 101);
            }
        }

        public bool VerifySolution(int solution, string answer)
        {
            int answerInt = 0;
            int.TryParse(answer, out answerInt);

            if (solution == answerInt)
            {
                return true;
            }
            else
                return false;

        }
    
        public void AddNewMatch(List<Match> gamesHistory, int roll1, int roll2, string answer, int solution, char mode)
        {
            Match newMatch = new();

            newMatch.num1 = roll1;
            newMatch.num2 = roll2;
            newMatch.answer = answer;
            newMatch.result = solution;
            newMatch.mode = mode;

            gamesHistory.Add(newMatch);
        }
    }
}
