using Start_Stop3.Properties;
using System.IO;

namespace Start_Stop3
{
    public partial class Form1 : Form
    {  
       
       

        string txt;
        string okunan;
        int sayac = 0;
        public Form1()
        {   
            InitializeComponent();
            StreamReader sr = new StreamReader("C:\\Users\\meka\\Desktop\\Sevde Nur Yýldýz\\veri.txt");
            okunan = sr.ReadLine();
            sayac = Convert.ToInt32(okunan);
            if (sayac != -1)
            {
                YenidenBaslama();
            }
            sr.Close(); 
        }

        private void YenidenBaslama()
        {
            StreamReader sr = new StreamReader("C:\\Users\\meka\\Desktop\\Sevde Nur Yýldýz\\veri.txt");
            okunan = sr.ReadLine();
            sr.Close();
            sayac = Convert.ToInt32(okunan);

            if (sayac == 0 || sayac == 1)
            {
                pictureBox1.Image = Resources.ON1;
               

            }
            else if (sayac == 2)
            {
                pictureBox1.Image = Resources.ON2;

            }
            else if (sayac == 3)
            {
                pictureBox1.Image = Resources.ON3;

            }
            else
            {
                pictureBox1.Image = Resources.ON4;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 1;
            switch (sayac)
            {
                case 1: pictureBox1.Image = Resources.ON1; break;
                case 2: pictureBox1.Image = Resources.ON2; break;
                case 3: pictureBox1.Image = Resources.ON3; break;
                case 4: pictureBox1.Image = Resources.ON4; break;
                default: sayac = 0; break;
            }
          
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (sayac == 0 || sayac == 1)
            {
                pictureBox1.Image = Resources.ON3;
                
            }
            else if (sayac == 2)
            {
                pictureBox1.Image = Resources.ON3;
               
            }
            else if (sayac == 3)
            {
                pictureBox1.Image = Resources.ON3;
                
            }
            else
            {
                pictureBox1.Image = Resources.ON3;
               
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\meka\\Desktop\\Sevde Nur Yýldýz\\veri.txt");
           
            if (sayac == 0 || sayac == 1)
            {
                pictureBox1.Image = Resources.ON1;
                txt = sayac.ToString();
                sw.WriteLine(txt);
                sw.Close();
            }
            else if (sayac == 2)
            {
                pictureBox1.Image = Resources.ON2;
                txt = sayac.ToString();
                sw.WriteLine(txt);
                sw.Close();
            }
            else if (sayac == 3)
            {
                pictureBox1.Image = Resources.ON3;
                txt = sayac.ToString();
                sw.WriteLine(txt);
                sw.Close();
            }
            else
            {
                pictureBox1.Image = Resources.ON4;
                txt = sayac.ToString();
                sw.WriteLine(txt);
                sw.Close();
            }
            Application.Exit();
        }
    }
}
