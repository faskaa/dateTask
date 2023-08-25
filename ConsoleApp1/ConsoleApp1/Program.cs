namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            try
            {
                string time = Console.ReadLine();
                DateTime.ParseExact(time, "dd | MM | yyyy", null);
                time.ToString();
                Console.WriteLine(time);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }




        }
    }
}