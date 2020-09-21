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
    public partial class FormCasoD : Form
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
        private int contadorBueno;
        private int contadorRegular;
        private int contadorMalo;
        private double costoOperacionSemana;
        private double costoOperacionSemanaAcumulado;
        private double costoSemanaBueno;
        private double costoSemanaRegular;
        private double costoSemanaMalo;
        private double costoReparacion;

        public FormCasoD()
        {
            InitializeComponent();
            this.configurarDataGrid();
        }

        private void FormCasoD_Load(object sender, EventArgs e)
        {
            gb_probabilidades.Enabled = false;
            btn_Recalcular.Enabled = false;
            recalcularCostoOperacion();
        }

        public void recalcularCostoOperacion()
        {
            costoSemanaBueno = Convert.ToDouble(txt_costoBueno.Text);
            costoSemanaRegular = Convert.ToDouble(txt_costoRegular.Text);
            costoSemanaMalo = Convert.ToDouble(txt_costoMalo.Text);

            lbl_costoSemanaBueno.Text = GeneradorAleatorio.Truncar4Decimales((costoSemanaBueno / 52)).ToString();
            lbl_costoSemanaRegular.Text = GeneradorAleatorio.Truncar4Decimales((costoSemanaRegular / 52)).ToString();
            lbl_costoSemanaMalo.Text = GeneradorAleatorio.Truncar4Decimales((costoSemanaMalo / 52)).ToString();
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
            dgv_GridCasoA.ColumnCount = 7;
            dgv_GridCasoA.Columns[0].HeaderText = "Iteración en Semanas";
            dgv_GridCasoA.Columns[1].HeaderText = "Estado Motor Inicio Semana";
            dgv_GridCasoA.Columns[2].HeaderText = "RND Estado Motor Fin Semana";
            dgv_GridCasoA.Columns[3].HeaderText = "Estado Motor Fin Semana";
            dgv_GridCasoA.Columns[4].HeaderText = "Costo de operación por Semana";
            dgv_GridCasoA.Columns[5].HeaderText = "Costo de operación por Semana Acumulado";
            dgv_GridCasoA.Columns[6].HeaderText = "Costo de Reparacion";


            dgv_GridCasoA.Columns[0].Width = 90;
            dgv_GridCasoA.Columns[1].Width = 90;
            dgv_GridCasoA.Columns[2].Width = 90;
            dgv_GridCasoA.Columns[3].Width = 90;
            dgv_GridCasoA.Columns[4].Width = 90;
            dgv_GridCasoA.Columns[5].Width = 90;
            dgv_GridCasoA.Columns[6].Width = 90;
        }

        private void cargarFormulario(int numeroFila, string estadoMotorI, double rndEstado, string estadoMotorF, double costoSemanal, double costoSemanalAcumulado, double costoPorReparar)
        {
            dgv_GridCasoA.Rows.Add(numeroFila, estadoMotorI, rndEstado, estadoMotorF, costoSemanal, costoSemanalAcumulado, costoPorReparar);
        }

        private void btn_ComenzarSimulación_Click(object sender, EventArgs e)
        {
            costoReparacion = 0;
            costoOperacionSemana = 0;
            contadorBueno = contadorRegular = contadorMalo = 0;
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
            this.cargarFormulario(0, "----", numeroAleatorio, estadoMotorInicio, 0, 0, 0);
            for (int i = 1; i <= textSemanas; i++)
            {
                if (estadoMotorInicio == "Bueno")
                {
                    estadoMotorFin = compararValores(numeroAleatorio2, textBB, textBR, textBM);
                    contadorBueno += 1;
                    costoOperacionSemana = Convert.ToDouble(lbl_costoSemanaBueno.Text);
                    costoReparacion = 0;
                }
                if (estadoMotorInicio == "Regular")
                {
                    estadoMotorFin = compararValores(numeroAleatorio2, textRB, textRR, textRM);
                    contadorRegular += 1;
                    costoOperacionSemana = Convert.ToDouble(lbl_costoSemanaRegular.Text);
                    costoReparacion = Convert.ToDouble(txt_reparacionRegular.Text);
                    estadoMotorFin = "Bueno";
                    costoOperacionSemanaAcumulado += costoReparacion;
                }
                if (estadoMotorInicio == "Malo")
                {
                    estadoMotorFin = compararValores(numeroAleatorio2, textMB, textMR, textMM);
                    contadorMalo += 1;
                    costoOperacionSemana = Convert.ToDouble(lbl_costoSemanaMalo.Text);
                    costoReparacion = 0;
                }
                costoOperacionSemanaAcumulado += costoOperacionSemana;
                this.cargarFormulario(i, estadoMotorInicio, numeroAleatorio2, estadoMotorFin, costoOperacionSemana, costoOperacionSemanaAcumulado, costoReparacion);
                estadoMotorInicio = estadoMotorFin;
                numeroAleatorio2 = GeneradorAleatorio.ObtenerSiguienteAleatorio();

            }
            lbl_CostoAcumuladoTotal.Text = "Costo Acumulado Total: $ " + this.PonerPuntos(costoOperacionSemanaAcumulado);
            btn_ComenzarSimulación.Enabled = false;
            btn_borrarSimulacion.Enabled = true;
            lbl_Bueno.Text = contadorBueno.ToString();
            lbl_Regular.Text = contadorRegular.ToString();
            lbl_Malo.Text = contadorMalo.ToString();
            gb_costoOperacion.Enabled = false;
            gb_costoReparacion.Enabled = false;
            gb_modificarProbabilidades.Enabled = false;
        }


        private string PonerPuntos(double doble)
        {
            int numero = Convert.ToInt32(doble);
            string resultado = "";
            string inicio = numero.ToString();
            int i = inicio.Length - 1;
            int j = 0;


            while (true)
            {
                resultado = inicio[i] + resultado;
                i--;
                j++;
                if (i == -1)
                {
                    break;
                }
                if (j % 3 == 0)
                {
                    resultado = "," + resultado;
                    j = 0;
                }
            }
            return resultado;
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
            lbl_CostoAcumuladoTotal.Text = "Costo Acumulado Total: $ 0";
            lbl_Bueno.Text = "0";
            lbl_Regular.Text = "0";
            lbl_Malo.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resetarDatos();
            btn_ComenzarSimulación.Enabled = true;
            btn_borrarSimulacion.Enabled = false;
            gb_costoOperacion.Enabled = true;
            gb_costoReparacion.Enabled = true;
            gb_modificarProbabilidades.Enabled = true;
        }

        private void rbt_modificar_CheckedChanged(object sender, EventArgs e)
        {
            gb_probabilidades.Enabled = true;
            btn_Recalcular.Enabled = true;
            btn_ComenzarSimulación.Enabled = false;

        }

        private void rbt_valoresListos_CheckedChanged(object sender, EventArgs e)
        {
            gb_probabilidades.Enabled = false;
            btn_Recalcular.Enabled = false;
            btn_ComenzarSimulación.Enabled = true;

        }

        private void btn_Recalcular_Click(object sender, EventArgs e)
        {
            double pBB = Convert.ToDouble(txt_BB.Text) * 10;
            double pBR = Convert.ToDouble(txt_BR.Text) * 10;
            double pBM = Convert.ToDouble(txt_BM.Text) * 10;

            double pRR = Convert.ToDouble(txt_RR.Text) * 10;
            double pRM = Convert.ToDouble(txt_RM.Text) * 10;

            double pMM = Convert.ToDouble(txt_MM.Text) * 10;

            if ((pBB + pBR + pBM) == 10)
            {
                lbl_BB.Text = (pBB / 10).ToString();
                lbl_BR.Text = ((pBB + pBR) / 10).ToString();
                lbl_BM.Text = "1";
            }
            else
            {
                MessageBox.Show("La suma de todas las probabilidades de un motor en buen estado deben sumar 1", "Error en las probabilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_BB.Text = "0.7";
                txt_BR.Text = "0.2";
                txt_BM.Text = "0.1";
            }

            if ((pRR + pRM) == 10)
            {
                lbl_RR.Text = (pRR / 10).ToString();
                lbl_RM.Text = "1";
            }
            else
            {
                MessageBox.Show("La suma de todas las probabilidades de un motor en estado regular deben sumar 1", "Error en las probabilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_RR.Text = "0.6";
                txt_RM.Text = "0.4";
            }

            if (pMM == 10)
            {
                lbl_MM.Text = (pMM / 10).ToString();
            }
            else
            {
                MessageBox.Show("La suma de todas las probabilidades de un motor en estado malo deben sumar 1", "Error en las probabilidades", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txt_MM.Text = "1";
            }
        }

        private void btn_recalcularCostos_Click(object sender, EventArgs e)
        {
            recalcularCostoOperacion();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.resetarDatos();
            this.Dispose();
        }
    }
}
