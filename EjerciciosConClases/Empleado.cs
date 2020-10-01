using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosConClases
{
    class Empleado : Persona
    {
        private double sueldo;

        /// <summary>
        /// Constructor que hereda de la Clase Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edad"></param>
        /// <param name="sueldo"></param>
        public Empleado(String nombre, int edad, double sueldo)
            : base(nombre, edad){
            this.sueldo = sueldo;
        }

        public override string ToString()
        {
            String msj = "---------\n" + base.ToString();
            msj += "\nSueldo: " + this.sueldo;
            return msj;
        }
    }
}
