namespace ST10449016_Prog_ICE_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Rectangle rect = new Rectangle("Rectangle", 10, 15);
                rect.Display();

                Console.WriteLine();

                Circle circle = new Circle("Circle", 8);
                circle.Display();
            }
        }
    }
}
