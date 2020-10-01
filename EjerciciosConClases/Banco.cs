using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosConClases
{
    class Banco
    {
        private Cliente[] arrayClientes;
        private const int tam = 3;

        //Constructores
        /// <summary>
        /// Constructor por defecto que siempre será el mismo cliente
        /// </summary>
        public Banco(){
            this.arrayClientes = new Cliente[tam];
            for(int i=0; i < tam; i++){
                this.arrayClientes[i] = new Cliente();
            }
        }

        /// <summary>
        /// Le pasamos por parámetro a 3 clientes diferestes
        /// (Se podría haber hecho de otra manera con un Arraylist)
        /// </summary>
        /// <param name="cli1"></param>
        /// <param name="cli2"></param>
        /// <param name="cli3"></param>
        public Banco(Cliente cli1, Cliente cli2, Cliente cli3)
        {
            this.arrayClientes = new Cliente[tam];
            //Insertamos los valores
            this.arrayClientes[0] = cli1;
            this.arrayClientes[1] = cli2;
            this.arrayClientes[2] = cli3;

        }

        /// <summary>
        /// Método que permitirá llamar a los métodos 'extraer' y 'operar' de los clientes
        /// </summary>
        public void operar()
        {
            int opcion = 0;
            String dniConfirm;
            int auxFlujoDinero;
            bool existeCliente = false;
            do
            {
                Console.WriteLine("Que desea realizar. Escriba el botón que se encuentra entre 'corchetes'");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("[1] Extraer efectivo");
                Console.WriteLine("[2] Ingresar");

                opcion = Convert.ToInt32(Console.ReadLine());
                //Sentencia switch
                switch (opcion)
                {
                    //Opción de extracción
                    case 1:
                        Console.WriteLine("Escriba su DNI:");
                        dniConfirm = Console.ReadLine();
                        //Recorremos el Array de los clientes buscando si coincide el ´dni´
                        for (int i=0; i < tam; i++)
                        {
                            if (this.arrayClientes[i].getDni().Equals(dniConfirm)) {
                                existeCliente = true;
                                i = tam;
                                Console.Write("Escriba cuanto desea extraer:");
                                //Pasamos a la variable auxiliar cuanto dinero deseamos extraer
                                 auxFlujoDinero = Convert.ToInt32(Console.ReadLine());
                                 //Llamamos al método
                                this.arrayClientes[i].extraerDinero(auxFlujoDinero);
                            }
                        }
                        //Comprobación de que no existe el cliente
                        if (!existeCliente){
                             Console.WriteLine("ERROR. Cliente no encontrado");
                        }
                        break;
                    
                    //Opción de Ingresar dinero
                    case 2:
                        Console.WriteLine("Escriba su DNI:");
                        dniConfirm = Console.ReadLine();
                        //Recorremos el Array de los clientes buscando si coincide el ´dni´
                        for (int i = 0; i < tam; i++)
                        {
                            if (this.arrayClientes[i].getDni().Equals(dniConfirm))
                            {
                                Console.Write("Escriba cuanto desea ingresar:");
                                //Pasamos a la variable auxiliar cuanto dinero deseamos ingresar
                                auxFlujoDinero = Convert.ToInt32(Console.ReadLine());
                                //Llamamos al método
                                this.arrayClientes[i].ingresarDinero(auxFlujoDinero);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no disponible");
                        break;
                }
            } while (opcion != 0 ) ;

        }

        public void finalDelDia()
        {
            int cantidadTotal = 0;
            for (int i = 0; i < this.arrayClientes.Length; i++){
                cantidadTotal += this.arrayClientes[i].getCantidad();
            }
            Console.WriteLine("Nuestro registro monetaio del dia es de: " + cantidadTotal);
        }
    }
}
