using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_sluiten_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_toonBMI_Click(object sender, EventArgs e)
        {
            float Gewicht, lengte, som, lengteSom;
            Gewicht = float.Parse( gewicht_textbox.Text);
            lengte = float.Parse(lengte_textbox.Text);
            lengteSom = lengte * lengte;
            som = Gewicht / lengteSom;
            textBox_BMI.Text =  som.ToString();

        }

        private void gewicht_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lengte_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_BMI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
