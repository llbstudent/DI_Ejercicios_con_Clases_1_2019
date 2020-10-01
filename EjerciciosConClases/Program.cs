using System;

namespace EjerciciosConClases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int opcionSwitch = 0;
            do
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("Seleccione que quiere ejecutar (Inserte el número de los corchetes):");
                Console.WriteLine("[1]- Triángulo");
                Console.WriteLine("[2]- Juego Dados");
                Console.WriteLine("[3]- Banco");
                Console.WriteLine("[4]- Persona/Empleado");
                Console.WriteLine("__________________________");

                opcionSwitch = Convert.ToInt32(Console.ReadLine());

                switch (opcionSwitch)
                {
                    case 1:
                        int ladosIguales, ladoBase, tam;

                        Console.WriteLine("CREAMOS NUESTRO TRIANGULO ISOSCELES. INSERTE LOS DATOS: ");
                        Console.Write("Lados Iguales: ");
                        ladosIguales = int.Parse(Console.ReadLine());
                        /*Se pueden hacer de 2 maneras: 
                        int num1 = int.Parse(Console.ReadLine());
                        int num1 = Convert.ToInt32( Console.ReadLine() );*/
                        Console.Write("Base del Triangulo: ");
                        ladoBase = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        tam = int.Parse(Console.ReadLine());

                        //Creamos el objeto/instancia
                        Triangulo t1 = new Triangulo(ladosIguales, ladoBase, tam);

                        //Obtenemos el perimetro
                        int areaT1 = t1.calculaArea();
                        Console.WriteLine("Area de nuestro Triangulo: " + areaT1);

                        //Obtenemos el Area
                        int perimetroT1 = t1.calculaPerimetro();
                        Console.WriteLine("Perimetro de nuestro Triangulo: " + perimetroT1);
                        break;

                    case 2:
                        JuegoDados tirada = new JuegoDados();
                        tirada.jugarDados();
                        break;

                    case 3:
                        //Nos creamos los clientes
                        Cliente cli1 = new Cliente("88554963J", "Luis Gómez", 690);
                        Cliente cli2 = new Cliente("75865463D", "David Moreno", 15900);
                        Cliente cli3 = new Cliente("31689347Q", "Sandra Osuna", 3000);

                        //Nos creamos el Array de clientes
                        Banco banco1 = new Banco(cli1, cli2, cli3);

                        banco1.operar();
                        Console.WriteLine("¿Desea ver cuanto tiene el banco al final del día?");
                        Console.WriteLine("[1] SI");
                        Console.WriteLine("[2] NO");
                        int opcion = Convert.ToInt32(Console.ReadLine());
                        //Sentencia Switch
                        switch (opcion)
                        {
                            case 1:
                                banco1.finalDelDia();
                                break;

                            case 2:
                                Console.WriteLine("Hasta Pronto!");
                                break;
                        }

                        break;

                    case 4:
                        //Definimos el objeto de clase persona
                        Persona p1 = new Persona();
                        //Imprimimos
                        Console.WriteLine(p1.ToString());

                        //Definimos el objeto de la clase Empleado que hereda de Persona
                        Empleado e1 = new Empleado("Laura", 27, 1407.86);
                        //Imprimimos
                        Console.WriteLine(e1.ToString());
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

            } while (opcionSwitch > 0 && opcionSwitch <= 4);
        }
    }
}
