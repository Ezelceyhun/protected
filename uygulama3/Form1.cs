using ClassLib1;
using static System.Net.Mime.MediaTypeNames;
namespace uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Class1 c1;
            //c1.Property = 1;
        }
        //�nternal Class sadece bulundu�u exe ve dll de �al��t�r�labilir. Bulundu�u proje katman�nda
        internal class c2()
        {
            public int k;
        }
        //<method overloading>
        string OverloadingMethod()
        {
            string text = "Parametresiz De�er D�nd�ren Method �al��t�. Textbox'lar Bo�";
            return text;
        }
        string OverloadingMethod(string text2)
        {
            string text = "Parametreli Method �al��t�. 1 Tane Textbox Dolu.";
            return text;
        }
        string OverloadingMethod(bool control)//bool control = true/false
        {
            string text = "Parametreli ve Control Yap�s� Olan Method �al��t�.";
            return text;
        }
        //</method overloading>
        string OverloadingMethod(string text4, string text5)
        {
            string text = "Parametreli Method �al��t�. Textbox'lar�n hepsi Dolu";
            return text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.Property = 1;
            class1.ver();
            int topla = class1.b + class1.Property;
            label1.Text = "class ile toplama yap�ld� " + topla.ToString();

            Class2 class2 = new Class2();
            class2.gonder();
            class2.Property = 2;
            topla = class2.b + class2.Property;
            label2.Text = "ver Metot'u �al��t�." + topla;

            Class3 class3 = new Class3();
            class3.Property = 3;
            class3.al();
            topla = class3.b + class3.Property;
            label3.Text = "al metotu �al��t� " + topla;

            //�nternal �rne�i
            c2 c2 = new c2();
            c2.k = 21;
            label4.Text = "�nternal �rne�i " + c2.k;

            //�nterface �rne�i
            Class4 class4 = new Class4();
            class4.carp(2, 4);
            label5.Text = "�arpma ��lemi: " + class4.top + "  |  Z De�i�keni: " + class4.z;
            class4.topla(2, 4);
            label5.Text += " Toplama ��lemi: " + class4.top + "  |  Z De�i�keni: " + class4.z;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //method overloading �rne�i
            if (checkBox1.Checked)
            {
                string text1 = OverloadingMethod(true);
                label6.Text = text1;
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                string text2 = OverloadingMethod();
                label6.Text = text2;
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                string text3 = OverloadingMethod("web", "site");
                label6.Text = text3;
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                string text4 = OverloadingMethod("codingarchive");
                label6.Text = text4;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Override �rne�i
            notebook notebook = new notebook();
            notebook.Model = textBox3.Text;
            notebook.CPU = textBox4.Text;
            notebook.Ram = textBox5.Text;
            if (checkBox2.Checked)
            {
                notebook.Bluetooth = "VAR";
            }
            else
            {
                notebook.Bluetooth = "YOK";
            }
            notebook.ozellik();
            label7.Text = notebook.Info;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Abstract (Soyut S�n�flar)
            //Class5 class5 = new Class5();   ---->   Yaz�m� yanl��t�r abstract s�n�flar new ile �a��r�lamaz.

            Class5 car = new Car();
            car.num1 = 30;
            car.num2 = 10;
            car.fuel();
            textBox6.Text = "Araban�n Yak�t�: " + car.num3 + Environment.NewLine; // --->  sat�r koymak i�in kullan�l�r.
            Class5 bus = new Bus();
            bus.num1 = 50;
            bus.num2 = 10;
            bus.fuel();
            textBox6.Text += "Otob�s�n Yak�t�: " + bus.num3;
        }
    }
}
