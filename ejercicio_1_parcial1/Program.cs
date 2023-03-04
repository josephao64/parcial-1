//Busca y corrige los errores
using System;  // se agrego using system

namespace ConsoleApp2
{
    class  Program // se cambio de internal a class
    {
        static void Main(string[] args)
    {
            int num1 = 10, num2 = 20;   // se agrego un int

            if (num1 > num2)  // se quito el ;
            
            {            //se abrio una llave

                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            
            {
                Console.WriteLine("{0}es menor o igual que {1}", num1, num2);
}
        }
    }
}