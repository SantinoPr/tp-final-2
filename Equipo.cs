using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final_2
{
    class Equipo
    {
        int faltas;
        int cont = 0;
        Jugador[] jugador = new Jugador[5];
        int [] vector= new int[5];  
        string nombreEquipo;
        
      
        public void CrearJ(string nombre, int num)
        {
            jugador[cont] = new Jugador(num, nombre);
            cont++;
        }


        public void NombreEquipo(string nombre)
        {
            nombreEquipo = nombre;

        }

        public string NombreE
        {
            get { return nombreEquipo; }
        }


        public void Anotar(int tanto, int indice)
        {
            jugador[indice].Marcador(tanto);

        }
        public void burbuja()
        {
            Jugador aux = new Jugador(0, "cero");
            int mayor = 0;
            bool bandera = false;

            for (int i = 0; i < jugador.Length - 1; i++)
            {
                if (bandera)
                {
                    break;
                }
                bandera = true;
                for (int j = 0; j < jugador.Length - 1; j++)
                {
                    if (jugador[j].Puntos > jugador[j + 1].Puntos)
                    {
                        
                        aux = jugador[j];
                        jugador[j] = jugador[j+1];
                        jugador[j+1] = aux;
                        bandera = false;

                    }
                }
            }
        }
        public string Nom(int indice)
        {
            return jugador[indice].Nombre;

        }


        public int PuntosTotales()
        {
            int acum = 0;

            for (int i = 0; i < 5; i++)
            {
                acum += jugador[i].Puntos;

            }
            return acum;
        }


        public void Faltas(int indice)
        {
            jugador[indice].Falta();
            faltas++;

        }

        public int FaltasTotales()
        {
            int acum = 0;

            for (int i = 0; i < 5; i++)
            {
                acum += jugador[i].faltastotales;

            }

            return acum;
        }

        public bool PuedeJugar(int indice)
        {
            return jugador[indice].PuedeJugar();

        }

        public string Mayores()
        {
            string Mayornombre = "";
            int Mayorpuntos = 0;

            for (int i = 0; i < 5; i++)
            {
                if (jugador[i].Puntos > Mayorpuntos)
                {
                    Mayorpuntos = jugador[i].Puntos;
                    Mayornombre = jugador[i].Nombre;
                }

            }

            return String.Format("{0} - {1} en total", Mayornombre, Mayorpuntos);


        }

        public string Menores()
        {
            string Menornombre = "";
            int Menorpuntos=PuntosTotales();

            for (int i = 0; i < 5; i++)
            {
                if (jugador[i].Puntos < Menorpuntos)
                {
                    Menorpuntos = jugador[i].Puntos;
                    Menornombre = jugador[i].Nombre;
                }

            }

            return String.Format("{0} - {1} en total", Menornombre, Menorpuntos);


        }
    }
}
