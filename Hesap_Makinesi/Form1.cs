using System;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        double value;
        string operation;
        bool operation_prassed;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Sonuc.Text == "0") || (operation_prassed))
                Sonuc.Clear();
            operation_prassed = false;
            Button a = (Button)sender;
            Sonuc.Text += a.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Sonuc.Clear();
        }

        private void oprerator_click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            operation = a.Text;
            value = double.Parse(Sonuc.Text);
            operation_prassed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Sonuc.Text = (value + double.Parse(Sonuc.Text)).ToString();
                    break;
                case "-":
                    Sonuc.Text = (value - double.Parse(Sonuc.Text)).ToString();
                    break;
                case "/":
                    Sonuc.Text = (value / double.Parse(Sonuc.Text)).ToString();
                    break;
                case "x":
                    Sonuc.Text = (value * double.Parse(Sonuc.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Sonuc.Clear();
        }
    }
}
