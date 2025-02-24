namespace MathGame
{
    public class Match
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Result { get; set; }
        public string Answer { get; set; }
        public char Mode { get; set; }
        

        public void DisplayGame()
        {
            string game = $"{Num1} {Mode} {Num2} = {Answer} (correct answer: {Result})";

            Console.WriteLine(game);
        }
    
    }
}
