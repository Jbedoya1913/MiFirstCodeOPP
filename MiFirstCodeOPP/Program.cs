using System;

namespace MiFirstCodeOPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {                            
                
                var dateObject = new Date(0,0,0);
                Console.WriteLine("Introduzca la fecha en formato (yyy/mm/dd");                                            
                Console.WriteLine(dateObject);
            }

            catch (Exception ex)
            {
                    Console.WriteLine(ex.Message);
            }

            
          
        }

        
    }
}
