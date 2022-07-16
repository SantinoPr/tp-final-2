using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_final_2
{
    public partial class Form1 : Form
    {
        Equipo Local = new Equipo();
        Equipo visitante = new Equipo();
        AñadirLocal añadir;
        Iniciar tanto = new Iniciar();

      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        
        private void button2_Click(object sender, EventArgs e) //Boton añadir Local
        {
            añadir = new AñadirLocal();
            añadir.label2.Text = "LOCAL";

            if (añadir.ShowDialog() == DialogResult.OK)
            {

                string nombreEquipo1 = añadir.textBox11.Text;
                Local.NombreEquipo(label1.Text=nombreEquipo1);

                string jugador1 = añadir.textBox1.Text;
                int numjugador1 = Convert.ToInt32(añadir.textBox6.Text);
                Local.CrearJ(jugador1, numjugador1);

                string jugador2 = añadir.textBox2.Text;
                int numjugador2 = Convert.ToInt32(añadir.textBox7.Text);
                Local.CrearJ(jugador2, numjugador2);

                string jugador3 = añadir.textBox3.Text;
                int numjugador3 = Convert.ToInt32(añadir.textBox8.Text);
                Local.CrearJ(jugador3, numjugador3);


                string jugador4 = añadir.textBox4.Text;
                int numjugador4 = Convert.ToInt32(añadir.textBox9.Text);
                Local.CrearJ(jugador4, numjugador4);


                string jugador5 = añadir.textBox5.Text;
                int numjugador5 = Convert.ToInt32(añadir.textBox10.Text);
                Local.CrearJ(jugador5, numjugador5);

                


                listBox1.Items.Clear();
                
                listBox1.Items.Add(string.Format("{0} - {1}",numjugador1,jugador1));
                listBox1.Items.Add(string.Format("{0} - {1}",numjugador2,jugador2));
                listBox1.Items.Add(string.Format("{0} - {1}",numjugador3,jugador3));
                listBox1.Items.Add(string.Format("{0} - {1}",numjugador4,jugador4));
                listBox1.Items.Add(string.Format("{0} - {1}",numjugador5, jugador5));

                    

            }
            añadir.DialogResult= DialogResult;
            añadir.Dispose();

        }

        private void button3_Click(object sender, EventArgs e) //Boton añadir visitante
        {

            añadir = new AñadirLocal();
            añadir.label2.Text = "VISITANTE";

            if (añadir.ShowDialog() == DialogResult.OK)
            {

                string nombreEquipo2 = añadir.textBox11.Text;
                visitante.NombreEquipo(label2.Text = nombreEquipo2);

                string jugador1 = añadir.textBox1.Text;//nombre de jugador
                int numjugador1 = Convert.ToInt32(añadir.textBox6.Text);//num de jugador
                visitante.CrearJ(jugador1, numjugador1);//crea el jugadorp

                string jugador2 = añadir.textBox2.Text;
                int numjugador2 = Convert.ToInt32(añadir.textBox7.Text);
                visitante.CrearJ(jugador2, numjugador2);

                string jugador3 = añadir.textBox3.Text;
                int numjugador3 = Convert.ToInt32(añadir.textBox8.Text);
                visitante.CrearJ(jugador3, numjugador3);


                string jugador4 = añadir.textBox4.Text;
                int numjugador4 = Convert.ToInt32(añadir.textBox9.Text);
                visitante.CrearJ(jugador4, numjugador4);


                string jugador5 = añadir.textBox5.Text;
                int numjugador5 = Convert.ToInt32(añadir.textBox10.Text);
                visitante.CrearJ(jugador5, numjugador5);


                listBox2.Items.Clear();
                listBox2.Items.Add(string.Format("{0} - {1}",numjugador1,jugador1));
                listBox2.Items.Add(string.Format("{0} - {1}",numjugador2,jugador2));
                listBox2.Items.Add(string.Format("{0} - {1}",numjugador3,jugador3));
                listBox2.Items.Add(string.Format("{0} - {1}",numjugador4,jugador4));
                listBox2.Items.Add(string.Format("{0} - {1}",numjugador5,jugador5));
                

            }

            añadir.Dispose();


        }

       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (Local.PuedeJugar(listBox1.SelectedIndex) == false)
            {
                DialogResult result = tanto.ShowDialog();

            if (result == DialogResult.OK)
            {
                Local.Anotar( 3,listBox1.SelectedIndex);

            }
            if(result == DialogResult.No)
            {
                Local.Anotar(2, listBox1.SelectedIndex);

            }
            if(result == DialogResult.Retry)
            {
                Local.Anotar(1, listBox1.SelectedIndex);

            }
            if (result == DialogResult.Yes)
            {
                Local.Faltas(listBox1.SelectedIndex);
               
            }
                
            }
            else
            {
                MessageBox.Show("El jugador seleccionado no puede jugar");
;           }

            label3.Text = Local.PuntosTotales().ToString("00");
            label5.Text = Local.FaltasTotales().ToString("00");
            
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (visitante.PuedeJugar(listBox2.SelectedIndex) == false)
            {
                DialogResult result = tanto.ShowDialog();
                if (result == DialogResult.OK)
                {
                    visitante.Anotar(3, listBox2.SelectedIndex);

                }
                if (result == DialogResult.No)
                {
                    visitante.Anotar(2, listBox2.SelectedIndex);
                }
                if (result == DialogResult.Retry)
                {
                    visitante.Anotar(1, listBox2.SelectedIndex);

                }

                if (result == DialogResult.Yes)
                {
                    visitante.Faltas(listBox2.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("El jugador seleccionado no puede jugar");

            }

                label4.Text = visitante.PuntosTotales().ToString("00");
                label6.Text = visitante.FaltasTotales().ToString("00");
        }
                

        

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Resultado r = new Resultado();

            if (Local.PuntosTotales() > visitante.PuntosTotales())
            {

                r.listBox1.Items.Add(String.Format("El equipo ganador es: {0}", Local.NombreE));
            }
            else if(Local.PuntosTotales() == visitante.PuntosTotales())
            {
                r.listBox1.Items.Add(String.Format("                                                   Empate"));
            }
            else
            {
                r.listBox1.Items.Add(String.Format("El equipo ganador es: {0}", visitante.NombreE));
            

            r.listBox1.Items.Add(String.Format("El jugador que mas puntos anoto para los locales es: {0}", Local.Mayores()));
            r.listBox1.Items.Add(String.Format("------------------------------------------------------------------------------------------------------------------"));
            r.listBox1.Items.Add(String.Format("El jugador que menos puntos anoto para los locales es: {0}", Local.Menores()));
            r.listBox1.Items.Add(String.Format("------------------------------------------------------------------------------------------------------------------"));
            r.listBox1.Items.Add(String.Format("El jugador que mas puntos anoto para los visitantes es: {0}", visitante.Mayores()));
            r.listBox1.Items.Add(String.Format("------------------------------------------------------------------------------------------------------------------"));
            r.listBox1.Items.Add(String.Format("El jugador que menos puntos anoto para los visitantes es: {0}", visitante.Menores()));
            r.listBox1.Items.Add(String.Format("------------------------------------------------------------------------------------------------------------------"));
            for(int i = 0; i < 5; i++)
            {
                r.listBox2.Items.Add(String.Format(Local.Nom(i)));
            }
            r.ShowDialog();
            
            
        }
    }
}
