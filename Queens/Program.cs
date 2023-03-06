using System;

namespace Queens
{
    class Program
    {
        
      
        static void Main(string[] args)
        {

            NQueens q = new NQueens(8);
            q.AllOptions();
            Console.ReadKey();
        }
    }
}
