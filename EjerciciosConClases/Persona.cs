using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosConClases
{
    class Persona
    {
        protected String nombre;
        protected int edad;

        //Constructor por defecto
        public Persona()
        {
            this.nombre = "Lorenzo";
            this.edad = 35;
        }

        public Persona(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }


        //METODOS GETTER & SETTER
        //Metodos SET
        public void setNombre(String nombre) { this.nombre = nombre; }
        public void setEdad(int edad) { this.edad = edad; }

        //Metodos GET
        public String getNombre() { return this.nombre; }
        public int getEdad(){ return this.edad;}

        /// <summary>
        /// Método que nos imprime los datos de la persona
        /// </summary>
        public override string ToString(){
            String strg = " DATOS " +
                "\n Nombre: " + this.nombre +
                "\n Edad: " + this.edad;
            return strg;
        }
    }
}
