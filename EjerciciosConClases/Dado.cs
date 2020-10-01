using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosConClases
{
    /// <summary>
    /// Clase Dado: atributo valor 
    /// métodos Tirar, que generará un aleatorio entre 1 y 6
    /// método Imprimir que mostrará el valor del dado.
    /// </summary>
    public class Dado
    {
        //Atributo
        private int valor;

        //Cosntructor
        public Dado()
        {
            this.valor = 0;
        }

        //METODOS

        /// <summary>
        /// Metodo SetValor, cambia el valor del dado, al que le pasemos por parametro 
        /// </summary>
        /// <param name="args"> int valor </param>
        public void setValor(int valor)
        {
            this.valor = valor;
        }

        /// <summary>
        /// metodo getValor, con el obtendremos el valor 
        /// </summary>
        public int getValor()
        {
            return this.valor;
        }

        /// <summary>
        /// Metodo tirarDado: Nos generara un numero entre el 1-6 de manara aleatoria
        /// </summary>
        public int tirarDado()
        {
            Random rnd = new Random();
            this.valor = rnd.Next(1, 6);
            return this.valor;
        }

        /// <summary>
        /// Metodo imprimirResultado: Nos imprime el resultado de la tirada
        /// </summary>
        public void imprimirResultado()
        {
            Console.WriteLine("Resultado: " + this.valor);
        }
    }
}