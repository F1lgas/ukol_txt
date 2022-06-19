using System.Text;

namespace ukol_txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string jmenosouboru = string.Empty;
            int celkem = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int vysledek = 0;
                int y = 1;
                jmenosouboru = openFileDialog1.FileName;
                StreamReader cteni = new StreamReader(jmenosouboru, Encoding.UTF8);
                
                while (!cteni.EndOfStream)
                {
                    string veta = cteni.ReadLine();

                    listBox1.Items.Add(veta);

                    char[] mezera = { ' ', '\t' };
                    string[] cisla = veta.Split(mezera);

                    for (int i = 0; i < cisla.Count(); i++)
                    {
                        int cislo = Convert.ToInt32(cisla[i]);

                        vysledek += cislo;
                        celkem += cislo;
                    }
                    MessageBox.Show("Souèet èísel v " + y + ". øádku je " + vysledek);
                    vysledek = 0;
                    y++;
                }

                cteni.Close();

                MessageBox.Show("Celkový souèet všech èísel je " + celkem);

                StreamWriter zapis = new StreamWriter(openFileDialog1.FileName, true);

                zapis.WriteLine(Environment.NewLine + "Celkový souèet všech èísel je " + celkem);
                zapis.Close();
            }
        }
    }
}