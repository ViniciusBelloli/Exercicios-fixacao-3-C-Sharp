using System;

namespace Uri1134
{
   class Uri1134
   {
      static void Main(string[] args)
      {
         int entrada = 0, gasolina = 0, alcool = 0, diesel = 0;

         while (entrada != 4)
         {
            entrada = int.Parse(Console.ReadLine());

            if (entrada == 1)
            {
               alcool++;
            }
            else if (entrada == 2)
            {
               gasolina++;
            }
            else if (entrada == 3)
            {
               diesel++;
            }
         }

         Console.WriteLine("MUITO OBRIGADO");
         Console.WriteLine("Alcool: " + alcool);
         Console.WriteLine("Gasolina: " + gasolina);
         Console.WriteLine("Diesel: " + diesel);
      }
   }
}