using ClassLib1;
namespace uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Class1 c1 ;
            //c1.Property = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.Property = 1;
            //class1.a = 2;
            class1.Deneme();
            MessageBox.Show(class1.b.ToString());
        }
    }
}