using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM_Final
{
    public partial class Form1 : Form
    {
        private double textBB;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCasoA formCasoA = new FormCasoA();
            formCasoA.ShowDialog();
        }

        private void btn_Recalcular_Click(object sender, EventArgs e)
        {
            //Varia el estado bueno
            //textBB = Convert.ToDouble(txt_BB.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCasoB formCasoB = new FormCasoB();
            formCasoB.ShowDialog();
        }
    }
}
