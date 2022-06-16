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
           /* int vysledek = 0;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string radek = listBox1.Items[i].ToString();

                int cislo = Convert.ToInt32(radek.Split(" "));

                vysledek += cislo;
            }*/
        }

        private void otevøítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jmenosouboru = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                jmenosouboru = openFileDialog1.FileName;
                StreamReader cteni = new StreamReader(jmenosouboru, Encoding.UTF8);

                while (!cteni.EndOfStream)
                {
                    string veta = cteni.ReadLine();

                    listBox1.Items.Add(veta);
                }

                cteni.Close();
            }
        }
    }
}