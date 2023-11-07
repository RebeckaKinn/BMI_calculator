namespace BMI_calculator
{
    internal class Calculator
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("*****************************\n");
            Console.WriteLine("WELCOME TO THE BMI CALCULATOR\n");
            Console.WriteLine("*****************************\n");
            CheckBMI();
        }
        public void CheckBMI()
        {
            Console.WriteLine("\nPlease write your height:");
            var userHeight = Console.ReadLine();
            Console.WriteLine("\nPlease write your weight:");
            var userWeight = Console.ReadLine();
            Console.WriteLine($"Is this correct?\nHeight: {userHeight}\nWeight: {userWeight}\n");
            Console.WriteLine("y / n");

            var userAnswer = Console.ReadLine();
            switch (userAnswer)
            {
                case "y":
                    GetResult(Convert.ToDouble(userHeight), Convert.ToDouble(userWeight));
                    break;
                case "n":
                    Start();
                    break;
                default:
                    Start();
                    break;
            };
        }

        private void GetResult(double height, double weight)
        {
            double heightInMeters = height / 100;
            double answer = weight / (heightInMeters * heightInMeters);
            string? message = "";

            if (answer < 18) message = "You are underweight according to the internet.";
            else if (answer > 18 && answer < 25) message = "You are normal according to the intenret.";
            else if (answer >= 25 && answer < 40) message = "You are overweight according to the internet.";
            else message = "You are obese accordning to the internet.";

            string extraMessage = "But do NOT LET THIS DEFINE YOU. Remember, this is just math,\nit doesn't know you.";

            Console.WriteLine($"Your BMI is:\n{answer}\n{message}\n{extraMessage}\n\nAgain?");
            Console.ReadKey();
            Start();
        }



    }
}
