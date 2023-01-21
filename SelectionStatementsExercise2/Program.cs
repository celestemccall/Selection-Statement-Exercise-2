namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            Console.WriteLine("Input your answer below.?");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Nice, math is a not an easy subject for many!");
                    break;

                case "science":
                    Console.WriteLine("Cool, science is a very experimental subject!");
                    break;

                case "english":
                    Console.WriteLine("Wonderful, english is a very useful subject!");
                    break;

                case "physical education":
                    Console.WriteLine("Yay! physical education is an incredibly fun subject!");
                    break;

                case "social studies":
                    Console.WriteLine("Great, social studies is a very interesting subject!");
                    break;

                default:
                    Console.WriteLine($"Wow, I have never taken that subject before! {subject} sounds fun!");
                    break;

               



       
            }


        }
    }
}