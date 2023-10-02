namespace switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayName = WeekDay(0);
            Console.WriteLine(dayName);
           
        }

        static string WeekDay(int number)
        {
            string TheDay;
            switch (number)
            {
                case 0:
                    TheDay = "Sunday";
                    break;
                case 1:
                    TheDay = "Monday";
                    break;
                case 2:
                    TheDay = "Tuesday";
                    break;
                case 3:
                    TheDay = "Wednesday";
                    break;
                case 4:
                    TheDay = "Thursday";
                    break;
                case 5:
                    TheDay = "Friday";
                    break;
                case 6:
                    TheDay = "Saturday";
                    break;

                default:
                    TheDay = "Invalid day number";
                    break;

            }


            return TheDay;


        }
    }
}