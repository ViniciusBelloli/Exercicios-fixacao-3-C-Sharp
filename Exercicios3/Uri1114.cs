using System;

namespace Exercicios3
{
   class Uri1114
   {
      static void Main(string[] args)
      {
         String senha = Console.ReadLine();

         while (senha != "2002")
         {
            Console.WriteLine("Senha Invalida");
            senha = Console.ReadLine();
         }

         Console.WriteLine("Acesso Permitido");
      }
   }
}