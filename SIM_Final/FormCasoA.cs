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
    public partial class FormCasoA : Form
    {
        private double textBB;
        private double textBR;
        private double textBM;
        private double textRB;
        private double textRR;
        private double textRM;
        private double textMB;
        private double textMR;
        private double textMM;
        private double textSemanas;
        private double numeroAleatorio;
        private double numeroAleatorio2;
        private string estadoMotorInicio;
        private string estadoMotorFin;

        public FormCasoA()
        {
            InitializeComponent();
            this.configurarDataGrid();
            
        }

        private void FormCasoA_Load(object sender, EventArgs e)
        {

        }

        public string compararValores(double aletatorio, double probBueno, double probRegular, double probMalo)
        {
            string estado;
            double aleatorioComparar = aletatorio;
            double probabilidadBueno = probBueno;
            double probabilidadRegular = probRegular;
            double probabilidadMalo = probMalo;
            if (aleatorioComparar < probabilidadBueno)
            {
                estado = "Bueno";
            }
            else if (aleatorioComparar < (probabilidadRegular + probabilidadBueno))
            {
                estado = "Regular";
            }
            else
            {
                estado = "Malo";
            }
            return estado;

        }

        private void configurarDataGrid()
        {
            dgv_GridCasoA.ColumnCount = 4;
            dgv_GridCasoA.Columns[0].HeaderText = "Iteración en Semanas";
            dgv_GridCasoA.Columns[1].HeaderText = "Estado Motor Inicio Semana";
            dgv_GridCasoA.Columns[2].HeaderText = "RND Estado Motor Fin Semana";
            dgv_GridCasoA.Columns[3].HeaderText = "Estado Motor Fin Semana";


            dgv_GridCasoA.Columns[0].Width = 90;
            dgv_GridCasoA.Columns[1].Width = 90;
            dgv_GridCasoA.Columns[2].Width = 90;
            dgv_GridCasoA.Columns[3].Width = 90;
        }


        private void cargarFormulario(int numeroFila, string estadoMotorI, double rndEstado, string estadoMotorF)
        {
            dgv_GridCasoA.Rows.Add(numeroFila,estadoMotorI,rndEstado,estadoMotorF);
        }

        private void btn_ComenzarSimulación_Click(object sender, EventArgs e)
        {
            textBB = Convert.ToDouble(txt_BB.Text);
            textBR = Convert.ToDouble(txt_BR.Text);
            textBM = Convert.ToDouble(txt_BM.Text);
            textRB = Convert.ToDouble(txt_RB.Text);
            textRR = Convert.ToDouble(txt_RR.Text);
            textRM = Convert.ToDouble(txt_RM.Text);
            textMB = Convert.ToDouble(txt_MB.Text);
            textMR = Convert.ToDouble(txt_MR.Text);
            textMM = Convert.ToDouble(txt_MM.Text);
            textSemanas = Convert.ToDouble(txt_Semana.Text);
            numeroAleatorio = GeneradorAleatorio.ObtenerSiguienteAleatorio();
            numeroAleatorio2 = GeneradorAleatorio.ObtenerSiguienteAleatorio();
            estadoMotorInicio = compararValores(numeroAleatorio, textBB, textBR, textBM);
            this.cargarFormulario(0, "----", numeroAleatorio, estadoMotorInicio);
            for (int i = 1; i < textSemanas; i++)
            {
                if (estadoMotorInicio == "Bueno")
                {
                    estadoMotorFin = compararValores(numeroAleatorio2, textBB, textBR, textBM);
                }
                if (estadoMotorInicio == "Regular")
                {
                    estadoMotorFin = compararValores(numeroAleatorio2, textRB, textRR, textRM);
                }
                if (estadoMotorInicio == "Malo")
                {
                    estadoMotorFin = compararValores(numeroAleatorio2, textMB, textMR, textMM);
                }
                this.cargarFormulario(i, estadoMotorInicio, numeroAleatorio2, estadoMotorFin);
                estadoMotorInicio = estadoMotorFin;
                numeroAleatorio2 = GeneradorAleatorio.ObtenerSiguienteAleatorio();

            }
            btn_ComenzarSimulación.Enabled = false;
            btn_borrarSimulacion.Enabled = true;
        }

        private void resetarDatos()
        {
            dgv_GridCasoA.Rows.Clear();
            textBB = 0;
            textBR = 0;
            textBM = 0;
            textRB = 0;
            textRR = 0;
            textRM = 0;
            textMB = 0;
            textMR = 0;
            textMM = 0;
            textSemanas = 0;
            numeroAleatorio = 0;
            numeroAleatorio2 = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resetarDatos();
            btn_ComenzarSimulación.Enabled = true;
            btn_borrarSimulacion.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.resetarDatos();
            this.Dispose();
            
        }
    }
}
