using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosConClases
{
    class JuegoDados
    {
        private Dado[] arrayDado;
        private const int tam = 3;

        //Constructor
        /// <summary>
        /// Nos crearemos un constructor por defecto que nos rellenará nuestro Array 'JuegoDados'
        /// de instancias/objetos Dado
        /// </summary>
        public JuegoDados()
        {
            this.arrayDado = new Dado[tam];
            for (int i = 0; i < tam; i++) {
                this.arrayDado[i] = new Dado();
            }
        }

       /// <summary>
       /// Metodo que nos comprobará si los dados son o no iguales
       /// Además que nos imprimirá por pantalla si hemos/o no ganado
       /// </summary>
       public void jugarDados()
        {
            int contador = 0;
            bool ganar = false;
            //Primero hacemos la jugada
            for (int i = 0; i < tam; i++){
                this.arrayDado[i].tirarDado();
            }
            //Comparamos las 3 posiciones del Array mediante comparaciones recorriendo el 'for'
            // Si el array tiene 3 posiciones, haremos 2 comprobaciones
            for (int i = 1; i < tam; i++) {
                if (this.arrayDado[i - 1].getValor() == this.arrayDado[i].getValor()) {
                    contador++;
                }
            }
            //Comprobación del contador
            if (contador == (tam - 1)) { ganar = true; }
            //Comprobación del booleano
            if (ganar) {
                Console.WriteLine("¡ENHORABUENA!¡HAS GANADO!"); 
            }else{
                Console.WriteLine("Suerte la próxima vez");
            }

            //Imprimimos los dados llamando al método 'imprimirresultado' de la clase Triangulo
            for (int i=0; i < tam; i++){
                this.arrayDado[i].imprimirResultado();
            }
        }
    }
}
