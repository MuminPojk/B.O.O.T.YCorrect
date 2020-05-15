using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.O.O.T.Y
{
    class Program
    {
        static void Main(string[] args)
        {


            Dungeon dungeon = new Dungeon();// Här instansieras klassen dungeon som innehåller den mesta bas logiken för spelet, alltså när de olika metoderna från klasser ska kallas

            dungeon.PlayGame(); // Här kallas metoden PlayGame som finns i Dungeon, den metoden kommer spelas och sedan avslutas programmet.

            
        }
       
        
    }
}
