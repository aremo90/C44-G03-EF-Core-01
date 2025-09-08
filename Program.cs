using ConsoleApp1.Context;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Database connection

            using ITIDbContext context = new ITIDbContext();

            #endregion

        }
    }
}
