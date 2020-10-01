using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosConClases
{
    class Cliente
    {
        //Atributos
        private String dni;
        private String name;
        private int cantidad;

        //Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Cliente() {
            this.dni = "44558899L";
            this.name = "Laura";
            this.cantidad = 2000;
        }

        //Metodos SETTER & GETTER
        //SETTER
        public void setDni(String dni) { this.dni = dni; }
        public void setName(String name) { this.name = name; }
        public void setCantidad(int cantidad) { this.cantidad = cantidad; }

        //GETTER
        public String getDni() { return this.dni; }
        public String getName() {  return this.name; }
        public int getCantidad() { return this.cantidad; }


        /// <summary>
        /// Constructor que recibe paramentros
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="name"></param>
        /// <param name="cantidad"></param>
        public Cliente(String dni, String name, int cantidad)
        {
            this.dni = dni;
            this.name = name;
            this.cantidad = cantidad;
        }

        //METODOS
        /// <summary>
        /// Método que permite aumentar la cantidad de dinero
        /// </summary>
        /// <param name="ingreso"></param>
        public void ingresarDinero(int ingreso)
        {
            this.cantidad += ingreso;
        }

        public void extraerDinero(int extraccion)
        {
            if(extraccion < 10){
                Console.WriteLine("ERROR. Extracción mínima de 10€");

            }else if(extraccion > 500){
                Console.WriteLine("ERROR. Extracción máxima permitida 500€");

            }else if(extraccion > this.cantidad){
                Console.WriteLine("ERROR. Saldo no disponible");
            }else{
                this.cantidad -= extraccion;
            }
        }

        /// <summary>
        /// Método que nos imprime el saldo del cliente
        /// </summary>
        public void consultarSaldo()
        {
            Console.WriteLine("El Saldo actual de " + this.name + " es de: "
                + this.cantidad);
        }
    }
}
