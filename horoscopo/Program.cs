using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("este es el horóscopo de hoy ingrese un mes con numeros de 1 al 12");
        int mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine(" ganaras todos tus cursos de la u.");
                break;
            case 2:
                Console.WriteLine("Este mes ganaras mucho dinero.");
                break;
            case 3:
                Console.WriteLine("La primavera está por llegar y con ella nuevas oportunidades de crecimiento personal y profesional.");
                break;
            case 4:
                Console.WriteLine("Este mes ganaras la loteria.");
                break;
            case 5:
                Console.WriteLine("Este mes conoseras a tu amor .");
                break;
            case 6:
                Console.WriteLine("vas a ter un hijo.");
                break;
            case 7:
                Console.WriteLine(" este mes saldras en la tv.");
                break;
            case 8:
                Console.WriteLine("Este mes te traerá muchas oportunidades para crecer en tu carrera y alcanzar nuevos logros profesionales.");
                break;
            case 9:
                Console.WriteLine("Este mes será un buen momento para enfocarte en tu salud y bienestar físico.");
                break;
            case 10:
                Console.WriteLine("este mes seras el mass inteligente.");
                break;
            case 11:
                Console.WriteLine("este mes  Guatemala irá al mundial al mundial.");
                break;
            case 12:
                Console.WriteLine(" este mes sera de nuevos retos para ti");
                break;
            default:
                Console.WriteLine("El número de mes ingresado no es válido.");
                break;
        }
    }
}
