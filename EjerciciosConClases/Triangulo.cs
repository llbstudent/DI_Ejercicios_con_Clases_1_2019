using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosConClases
{
    public class Triangulo
    {
        //Atributos
        private int ladosIguales;   //Atributo de los lados iguales
        private int ladoBase;       //Atributo de la base/lado diferente
        private int tam;            //Atributo que representa la altura del triangulo

        //Constructor por defecto
        Triangulo()
        {
            this.ladosIguales = 5;
            this.ladoBase = 10;
            this.tam = 5;
        }

        //Constructor por parametros
        public Triangulo(int ladosIguales, int ladoBase, int tam)
        {
            this.ladosIguales = ladosIguales;
            this.ladoBase = ladoBase;
            this.tam = tam;
        }

        //Metodos

        /// <summary>
        /// Metodo que te calcula el perimetro de un triangulo
        /// Te devuelve in entero/Integer
        /// </summary>
        public int calculaPerimetro()
        {
            int sumaLados = 0;
            sumaLados = this.ladoBase + (this.ladosIguales * 2);
            return sumaLados;
        }


        /// <summary>
        /// Metodo que calcula el area de un triangulo isosceles
        /// area = (Base * altura)/2
        /// Deveulve un entero/Integer
        /// </summary>
        public int calculaArea()
        {
            int area = 0;
            area = (this.ladoBase * this.tam) / 2;
            return area;
        }
    }
}
