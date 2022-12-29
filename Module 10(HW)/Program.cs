namespace Module_10_HW_
{
    class Programm
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    EnterUser enter = new EnterUser();
                    double result = enter.GetEnter();

                    Console.WriteLine("Сумма равна {0}", result);
                    Console.WriteLine("");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Logger logger = new Logger();
                    logger.Error(ex.Message);
                }

                catch (FormatException ex)
                {
                    Logger logger = new Logger();
                    logger.Error(ex.Message);
                }
            }
        }
    }
}