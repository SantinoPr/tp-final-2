using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final_2
{
    class Jugador
    {
        int nroJugador;
        string nombre;
        int faltas;
        int tanto;
        

         public Jugador(int numero, string nombre)//creacion del jugador
         {
            nroJugador= numero;
            this.nombre = nombre;
         }
        
        public int NroCamiseta
        {
            get { return nroJugador; }
        }
        public string Nombre
        {
            get { return nombre; } 
        }

        public void Marcador(int puntos) //puntos totales
        {
            tanto += puntos;
        }

        

        public int Puntos
        {
            get { return tanto; } set { tanto = value; } 

        }

        public int faltastotales 
        {
            get { return faltas; }
        }
        
        public bool PuedeJugar()
        {
            bool Faltas = false;

            if(faltas >= 5)
            {
                 Faltas= true;
            }
            return Faltas;

        }

        

        public void Falta()
        {
            faltas++;

        }

        }
    }


