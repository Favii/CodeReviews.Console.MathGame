namespace MathGame
{
    public class Match
    {
        //public bool winOrLose { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int result { get; set; }
        public string answer { get; set; }
        public char mode { get; set; }
        

        public void DisplayGame()
        {
            string game = $"{num1} {mode} {num2} = {answer} (correct answer: {result})";

            Console.WriteLine(game);
        }
    
    }
}
