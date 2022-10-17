namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // for division, operator exercise
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine("Please enter the radius of your circle:");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            Console.WriteLine(AreaOfCircle(radius));
        }

        //determine the area of the user entered circle
        public static double AreaOfCircle(double radius)
        {
            //scope of the method
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}