namespace Module_10_HW_
{
    class EnterUser
    {
        public double GetEnter()
        {
            Calculate calculater = new Calculate();
            Console.WriteLine("Введите первое число");
            double one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double two = Convert.ToDouble(Console.ReadLine());
            double summ = calculater.Summ(one, two);
            return summ;
        }
    }
}
