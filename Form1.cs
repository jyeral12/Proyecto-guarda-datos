namespace Proyecto_guarda_datos
{
    public partial class Form1 : Form
    {
        List<servidor> Contactos = new List<servidor>();
        private int indise = -1;

        public Form1()
        {
            InitializeComponent();
        }

        bool valor;
        private object servidores;
        private object SelectedRows;

        private void BTNAGREGAR_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                if ((textBox1.Text == listBox1.Items[i].ToString())&&
                    (textBox2.Text == listBox2.Items[i].ToString())&&
                    (textBox3.Text == listBox3.Items[i].ToString())&&
                    (textBox5.Text == listBox4.Items[i].ToString()))
                {
                    valor = true;
                    
                }



            }


            if (valor == true)
            {

                MessageBox.Show(" this Username that Existe {0} ");
                valor = false;
                Console.ForegroundColor= ConsoleColor.Black;
            }

            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox2.Text);
                listBox3.Items.Add(textBox3.Text);
                listBox4.Items.Add(textBox5.Text);
                linpiCampos();
            }






        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < listBox1.Items.Count; a++)
            {
                if (textBox4.Text == listBox1.Items[a].ToString())
                {
                    Console.ForegroundColor= ConsoleColor.DarkBlue;
                    MessageBox.Show(listBox1.Items[a].ToString() + "____________" +
                    listBox2.Items[a].ToString() + "____________" +
                    listBox3.Items[a].ToString() + "____________" +
                    listBox4.Items[a].ToString());
                    textBox4.Clear();
                    Console.ForegroundColor= ConsoleColor.White;
                   
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                StreamReader lector = new StreamReader("agenda.txt");
                string linea;
                while ((linea = lector.ReadLine()) != null)
                {
                    int posicion;
                    servidor persona = new servidor();
                    posicion = linea.IndexOf("|");
                    persona.caja1= linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf("|");


                    persona.caja2 = linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf("|");


                    persona.caja3 = linea.Substring(0, posicion);
                    linea = linea.Substring(posicion + 1);
                    posicion = linea.IndexOf("|");
                    persona.caja4 = linea.Substring(0, posicion);

                    Contactos.Add(persona);

                }
                lector.Close();
                actualizaVista();
            }
            catch (Exception ec)
            {
                Console.WriteLine("Exception:" + ec.Message);
            }
            finally
            {
                Console.WriteLine("EJECUCIOn FInALIZADA");
            }
            */




        }

        private void actualizaVista()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = Contactos;
            listBox3.DataSource = Contactos;
            listBox4.DataSource = Contactos;


        }



        private void button2_Click(object sender, EventArgs e)
        {
            TextWriter write = new StreamWriter("agenda.txt");
            foreach (servidor persona in Contactos)
            {
                write.WriteLine(textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox5.Text + "|"); 

            }
            write.Close();
            MessageBox.Show("Datos  guardados satifactoriamente");
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  //NULL

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  //NULL
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  //NULL
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  //NULL
        }

        private void linpiCampos()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);   
            listBox3.Items.Remove(listBox3.SelectedItem);
            listBox4.Items.Remove(listBox4.SelectedItem);   
       
        {

         MessageBox.Show(" Regsitro borrado");

        }

            }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            linpiCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            linpiCampos();
        }
    }
    }































//{
  //  valor = true;
//}