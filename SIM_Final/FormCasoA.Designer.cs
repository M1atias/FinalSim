namespace SIM_Final
{
    partial class FormCasoA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_GridCasoA = new System.Windows.Forms.DataGridView();
            this.lbl_Semana = new System.Windows.Forms.Label();
            this.txt_Semana = new System.Windows.Forms.TextBox();
            this.lbl_MM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MM = new System.Windows.Forms.TextBox();
            this.txt_MR = new System.Windows.Forms.TextBox();
            this.txt_MB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_RM = new System.Windows.Forms.Label();
            this.lbl_RR = new System.Windows.Forms.Label();
            this.lbl_RB = new System.Windows.Forms.Label();
            this.txt_RM = new System.Windows.Forms.TextBox();
            this.txt_RR = new System.Windows.Forms.TextBox();
            this.txt_RB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_BM = new System.Windows.Forms.Label();
            this.lbl_BR = new System.Windows.Forms.Label();
            this.lbl_BB = new System.Windows.Forms.Label();
            this.txt_BM = new System.Windows.Forms.TextBox();
            this.txt_BR = new System.Windows.Forms.TextBox();
            this.txt_BB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_EstadoBueno = new System.Windows.Forms.Label();
            this.btn_ComenzarSimulación = new System.Windows.Forms.Button();
            this.btn_borrarSimulacion = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lbl_Bueno = new System.Windows.Forms.Label();
            this.lbl_Regular = new System.Windows.Forms.Label();
            this.lbl_Malo = new System.Windows.Forms.Label();
            this.gb_modificarProbabilidades = new System.Windows.Forms.GroupBox();
            this.btn_Recalcular = new System.Windows.Forms.Button();
            this.rbt_modificar = new System.Windows.Forms.RadioButton();
            this.rbt_valoresListos = new System.Windows.Forms.RadioButton();
            this.gb_probabilidades = new System.Windows.Forms.GroupBox();
            this.gb_costoOperacion = new System.Windows.Forms.GroupBox();
            this.btn_recalcularCostos = new System.Windows.Forms.Button();
            this.lbl_costoSemanaMalo = new System.Windows.Forms.Label();
            this.lbl_costoSemanaRegular = new System.Windows.Forms.Label();
            this.lbl_costoSemanaBueno = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_costoMalo = new System.Windows.Forms.TextBox();
            this.txt_costoRegular = new System.Windows.Forms.TextBox();
            this.txt_costoBueno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_CostoAcumuladoTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.gb_costoReparacion = new System.Windows.Forms.GroupBox();
            this.txt_reparacionMala = new System.Windows.Forms.TextBox();
            this.txt_reparacionRegular = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_reparacion = new System.Windows.Forms.TextBox();
            this.lbl_reparacionSemanas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GridCasoA)).BeginInit();
            this.gb_modificarProbabilidades.SuspendLayout();
            this.gb_probabilidades.SuspendLayout();
            this.gb_costoOperacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_costoReparacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_GridCasoA
            // 
            this.dgv_GridCasoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GridCasoA.Location = new System.Drawing.Point(15, 235);
            this.dgv_GridCasoA.Name = "dgv_GridCasoA";
            this.dgv_GridCasoA.Size = new System.Drawing.Size(604, 454);
            this.dgv_GridCasoA.TabIndex = 0;
            // 
            // lbl_Semana
            // 
            this.lbl_Semana.AutoSize = true;
            this.lbl_Semana.Location = new System.Drawing.Point(16, 205);
            this.lbl_Semana.Name = "lbl_Semana";
            this.lbl_Semana.Size = new System.Drawing.Size(60, 13);
            this.lbl_Semana.TabIndex = 1;
            this.lbl_Semana.Text = "Semanas : ";
            // 
            // txt_Semana
            // 
            this.txt_Semana.Location = new System.Drawing.Point(82, 202);
            this.txt_Semana.Name = "txt_Semana";
            this.txt_Semana.Size = new System.Drawing.Size(58, 20);
            this.txt_Semana.TabIndex = 2;
            this.txt_Semana.Text = "52";
            // 
            // lbl_MM
            // 
            this.lbl_MM.AutoSize = true;
            this.lbl_MM.Location = new System.Drawing.Point(584, 139);
            this.lbl_MM.Name = "lbl_MM";
            this.lbl_MM.Size = new System.Drawing.Size(13, 13);
            this.lbl_MM.TabIndex = 63;
            this.lbl_MM.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // txt_MM
            // 
            this.txt_MM.Location = new System.Drawing.Point(531, 136);
            this.txt_MM.Name = "txt_MM";
            this.txt_MM.Size = new System.Drawing.Size(42, 20);
            this.txt_MM.TabIndex = 60;
            this.txt_MM.Text = "1";
            // 
            // txt_MR
            // 
            this.txt_MR.Enabled = false;
            this.txt_MR.Location = new System.Drawing.Point(531, 89);
            this.txt_MR.Name = "txt_MR";
            this.txt_MR.Size = new System.Drawing.Size(42, 20);
            this.txt_MR.TabIndex = 59;
            this.txt_MR.Text = "0";
            // 
            // txt_MB
            // 
            this.txt_MB.Enabled = false;
            this.txt_MB.Location = new System.Drawing.Point(531, 49);
            this.txt_MB.Name = "txt_MB";
            this.txt_MB.Size = new System.Drawing.Size(42, 20);
            this.txt_MB.TabIndex = 58;
            this.txt_MB.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(449, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 57;
            this.label11.Text = "Probabilidad\r\nMalo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(449, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 26);
            this.label12.TabIndex = 56;
            this.label12.Text = "Probabilidad\r\nRegular:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(449, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 26);
            this.label13.TabIndex = 55;
            this.label13.Text = "Probabilidad \r\nBueno: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(472, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Motor en Estado Malo";
            // 
            // lbl_RM
            // 
            this.lbl_RM.AutoSize = true;
            this.lbl_RM.Location = new System.Drawing.Point(361, 139);
            this.lbl_RM.Name = "lbl_RM";
            this.lbl_RM.Size = new System.Drawing.Size(13, 13);
            this.lbl_RM.TabIndex = 53;
            this.lbl_RM.Text = "1";
            // 
            // lbl_RR
            // 
            this.lbl_RR.AutoSize = true;
            this.lbl_RR.Location = new System.Drawing.Point(361, 92);
            this.lbl_RR.Name = "lbl_RR";
            this.lbl_RR.Size = new System.Drawing.Size(22, 13);
            this.lbl_RR.TabIndex = 52;
            this.lbl_RR.Text = "0.6";
            // 
            // lbl_RB
            // 
            this.lbl_RB.AutoSize = true;
            this.lbl_RB.Location = new System.Drawing.Point(361, 52);
            this.lbl_RB.Name = "lbl_RB";
            this.lbl_RB.Size = new System.Drawing.Size(13, 13);
            this.lbl_RB.TabIndex = 51;
            this.lbl_RB.Text = "0";
            this.lbl_RB.Visible = false;
            // 
            // txt_RM
            // 
            this.txt_RM.Location = new System.Drawing.Point(308, 136);
            this.txt_RM.Name = "txt_RM";
            this.txt_RM.Size = new System.Drawing.Size(42, 20);
            this.txt_RM.TabIndex = 50;
            this.txt_RM.Text = "0.4";
            // 
            // txt_RR
            // 
            this.txt_RR.Location = new System.Drawing.Point(308, 89);
            this.txt_RR.Name = "txt_RR";
            this.txt_RR.Size = new System.Drawing.Size(42, 20);
            this.txt_RR.TabIndex = 49;
            this.txt_RR.Text = "0.6";
            // 
            // txt_RB
            // 
            this.txt_RB.Enabled = false;
            this.txt_RB.Location = new System.Drawing.Point(308, 49);
            this.txt_RB.Name = "txt_RB";
            this.txt_RB.Size = new System.Drawing.Size(42, 20);
            this.txt_RB.TabIndex = 48;
            this.txt_RB.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(226, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 26);
            this.label8.TabIndex = 47;
            this.label8.Text = "Probabilidad\r\nMalo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(226, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 26);
            this.label9.TabIndex = 46;
            this.label9.Text = "Probabilidad\r\nRegular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 26);
            this.label10.TabIndex = 45;
            this.label10.Text = "Probabilidad \r\nBueno: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Motor en Estado Regular";
            // 
            // lbl_BM
            // 
            this.lbl_BM.AutoSize = true;
            this.lbl_BM.Location = new System.Drawing.Point(138, 139);
            this.lbl_BM.Name = "lbl_BM";
            this.lbl_BM.Size = new System.Drawing.Size(13, 13);
            this.lbl_BM.TabIndex = 43;
            this.lbl_BM.Text = "1";
            // 
            // lbl_BR
            // 
            this.lbl_BR.AutoSize = true;
            this.lbl_BR.Location = new System.Drawing.Point(138, 92);
            this.lbl_BR.Name = "lbl_BR";
            this.lbl_BR.Size = new System.Drawing.Size(22, 13);
            this.lbl_BR.TabIndex = 42;
            this.lbl_BR.Text = "0.9";
            // 
            // lbl_BB
            // 
            this.lbl_BB.AutoSize = true;
            this.lbl_BB.Location = new System.Drawing.Point(138, 52);
            this.lbl_BB.Name = "lbl_BB";
            this.lbl_BB.Size = new System.Drawing.Size(22, 13);
            this.lbl_BB.TabIndex = 41;
            this.lbl_BB.Text = "0.7";
            // 
            // txt_BM
            // 
            this.txt_BM.Location = new System.Drawing.Point(85, 136);
            this.txt_BM.Name = "txt_BM";
            this.txt_BM.Size = new System.Drawing.Size(42, 20);
            this.txt_BM.TabIndex = 40;
            this.txt_BM.Text = "0.1";
            // 
            // txt_BR
            // 
            this.txt_BR.Location = new System.Drawing.Point(85, 89);
            this.txt_BR.Name = "txt_BR";
            this.txt_BR.Size = new System.Drawing.Size(42, 20);
            this.txt_BR.TabIndex = 39;
            this.txt_BR.Text = "0.2";
            // 
            // txt_BB
            // 
            this.txt_BB.Location = new System.Drawing.Point(85, 49);
            this.txt_BB.Name = "txt_BB";
            this.txt_BB.Size = new System.Drawing.Size(42, 20);
            this.txt_BB.TabIndex = 38;
            this.txt_BB.Text = "0.7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = "Probabilidad\r\nMalo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 36;
            this.label2.Text = "Probabilidad\r\nRegular:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "Probabilidad \r\nBueno: ";
            // 
            // lbl_EstadoBueno
            // 
            this.lbl_EstadoBueno.AutoSize = true;
            this.lbl_EstadoBueno.Location = new System.Drawing.Point(23, 16);
            this.lbl_EstadoBueno.Name = "lbl_EstadoBueno";
            this.lbl_EstadoBueno.Size = new System.Drawing.Size(119, 13);
            this.lbl_EstadoBueno.TabIndex = 34;
            this.lbl_EstadoBueno.Text = "Motor en Estado Bueno";
            // 
            // btn_ComenzarSimulación
            // 
            this.btn_ComenzarSimulación.Location = new System.Drawing.Point(353, 195);
            this.btn_ComenzarSimulación.Name = "btn_ComenzarSimulación";
            this.btn_ComenzarSimulación.Size = new System.Drawing.Size(75, 35);
            this.btn_ComenzarSimulación.TabIndex = 64;
            this.btn_ComenzarSimulación.Text = "Comenzar Simulación";
            this.btn_ComenzarSimulación.UseVisualStyleBackColor = true;
            this.btn_ComenzarSimulación.Click += new System.EventHandler(this.btn_ComenzarSimulación_Click);
            // 
            // btn_borrarSimulacion
            // 
            this.btn_borrarSimulacion.Enabled = false;
            this.btn_borrarSimulacion.Location = new System.Drawing.Point(441, 195);
            this.btn_borrarSimulacion.Name = "btn_borrarSimulacion";
            this.btn_borrarSimulacion.Size = new System.Drawing.Size(75, 35);
            this.btn_borrarSimulacion.TabIndex = 65;
            this.btn_borrarSimulacion.Text = "Borrar Simulación";
            this.btn_borrarSimulacion.UseVisualStyleBackColor = true;
            this.btn_borrarSimulacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(736, 194);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 35);
            this.btn_salir.TabIndex = 66;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_Bueno
            // 
            this.lbl_Bueno.AutoSize = true;
            this.lbl_Bueno.Location = new System.Drawing.Point(163, 57);
            this.lbl_Bueno.Name = "lbl_Bueno";
            this.lbl_Bueno.Size = new System.Drawing.Size(13, 13);
            this.lbl_Bueno.TabIndex = 67;
            this.lbl_Bueno.Text = "0";
            // 
            // lbl_Regular
            // 
            this.lbl_Regular.AutoSize = true;
            this.lbl_Regular.Location = new System.Drawing.Point(163, 79);
            this.lbl_Regular.Name = "lbl_Regular";
            this.lbl_Regular.Size = new System.Drawing.Size(13, 13);
            this.lbl_Regular.TabIndex = 68;
            this.lbl_Regular.Text = "0";
            // 
            // lbl_Malo
            // 
            this.lbl_Malo.AutoSize = true;
            this.lbl_Malo.Location = new System.Drawing.Point(162, 102);
            this.lbl_Malo.Name = "lbl_Malo";
            this.lbl_Malo.Size = new System.Drawing.Size(13, 13);
            this.lbl_Malo.TabIndex = 69;
            this.lbl_Malo.Text = "0";
            // 
            // gb_modificarProbabilidades
            // 
            this.gb_modificarProbabilidades.Controls.Add(this.btn_Recalcular);
            this.gb_modificarProbabilidades.Controls.Add(this.rbt_modificar);
            this.gb_modificarProbabilidades.Controls.Add(this.rbt_valoresListos);
            this.gb_modificarProbabilidades.Location = new System.Drawing.Point(644, 9);
            this.gb_modificarProbabilidades.Name = "gb_modificarProbabilidades";
            this.gb_modificarProbabilidades.Size = new System.Drawing.Size(167, 180);
            this.gb_modificarProbabilidades.TabIndex = 70;
            this.gb_modificarProbabilidades.TabStop = false;
            this.gb_modificarProbabilidades.Text = "Modificar Probabilidades";
            // 
            // btn_Recalcular
            // 
            this.btn_Recalcular.Location = new System.Drawing.Point(17, 103);
            this.btn_Recalcular.Name = "btn_Recalcular";
            this.btn_Recalcular.Size = new System.Drawing.Size(137, 46);
            this.btn_Recalcular.TabIndex = 71;
            this.btn_Recalcular.Text = "Recalcular Probabilidad\r\nAcumuladas";
            this.btn_Recalcular.UseVisualStyleBackColor = true;
            this.btn_Recalcular.Click += new System.EventHandler(this.btn_Recalcular_Click);
            // 
            // rbt_modificar
            // 
            this.rbt_modificar.AutoSize = true;
            this.rbt_modificar.Location = new System.Drawing.Point(6, 71);
            this.rbt_modificar.Name = "rbt_modificar";
            this.rbt_modificar.Size = new System.Drawing.Size(101, 17);
            this.rbt_modificar.TabIndex = 1;
            this.rbt_modificar.Text = "Modicar Valores";
            this.rbt_modificar.UseVisualStyleBackColor = true;
            this.rbt_modificar.CheckedChanged += new System.EventHandler(this.rbt_modificar_CheckedChanged);
            // 
            // rbt_valoresListos
            // 
            this.rbt_valoresListos.AutoSize = true;
            this.rbt_valoresListos.Checked = true;
            this.rbt_valoresListos.Location = new System.Drawing.Point(6, 36);
            this.rbt_valoresListos.Name = "rbt_valoresListos";
            this.rbt_valoresListos.Size = new System.Drawing.Size(98, 30);
            this.rbt_valoresListos.TabIndex = 0;
            this.rbt_valoresListos.TabStop = true;
            this.rbt_valoresListos.Text = "Valores listos \r\npara simulación";
            this.rbt_valoresListos.UseVisualStyleBackColor = true;
            this.rbt_valoresListos.CheckedChanged += new System.EventHandler(this.rbt_valoresListos_CheckedChanged);
            // 
            // gb_probabilidades
            // 
            this.gb_probabilidades.Controls.Add(this.lbl_EstadoBueno);
            this.gb_probabilidades.Controls.Add(this.label1);
            this.gb_probabilidades.Controls.Add(this.label2);
            this.gb_probabilidades.Controls.Add(this.label3);
            this.gb_probabilidades.Controls.Add(this.txt_BB);
            this.gb_probabilidades.Controls.Add(this.txt_BR);
            this.gb_probabilidades.Controls.Add(this.txt_BM);
            this.gb_probabilidades.Controls.Add(this.lbl_BB);
            this.gb_probabilidades.Controls.Add(this.lbl_MM);
            this.gb_probabilidades.Controls.Add(this.lbl_BR);
            this.gb_probabilidades.Controls.Add(this.label6);
            this.gb_probabilidades.Controls.Add(this.lbl_BM);
            this.gb_probabilidades.Controls.Add(this.label7);
            this.gb_probabilidades.Controls.Add(this.label4);
            this.gb_probabilidades.Controls.Add(this.txt_MM);
            this.gb_probabilidades.Controls.Add(this.label10);
            this.gb_probabilidades.Controls.Add(this.txt_MR);
            this.gb_probabilidades.Controls.Add(this.label9);
            this.gb_probabilidades.Controls.Add(this.txt_MB);
            this.gb_probabilidades.Controls.Add(this.label8);
            this.gb_probabilidades.Controls.Add(this.label11);
            this.gb_probabilidades.Controls.Add(this.txt_RB);
            this.gb_probabilidades.Controls.Add(this.label12);
            this.gb_probabilidades.Controls.Add(this.txt_RR);
            this.gb_probabilidades.Controls.Add(this.label13);
            this.gb_probabilidades.Controls.Add(this.txt_RM);
            this.gb_probabilidades.Controls.Add(this.label14);
            this.gb_probabilidades.Controls.Add(this.lbl_RB);
            this.gb_probabilidades.Controls.Add(this.lbl_RM);
            this.gb_probabilidades.Controls.Add(this.lbl_RR);
            this.gb_probabilidades.Location = new System.Drawing.Point(15, 5);
            this.gb_probabilidades.Name = "gb_probabilidades";
            this.gb_probabilidades.Size = new System.Drawing.Size(604, 184);
            this.gb_probabilidades.TabIndex = 71;
            this.gb_probabilidades.TabStop = false;
            this.gb_probabilidades.Text = "Probabilidades";
            // 
            // gb_costoOperacion
            // 
            this.gb_costoOperacion.Controls.Add(this.btn_recalcularCostos);
            this.gb_costoOperacion.Controls.Add(this.lbl_costoSemanaMalo);
            this.gb_costoOperacion.Controls.Add(this.lbl_costoSemanaRegular);
            this.gb_costoOperacion.Controls.Add(this.lbl_costoSemanaBueno);
            this.gb_costoOperacion.Controls.Add(this.label18);
            this.gb_costoOperacion.Controls.Add(this.label17);
            this.gb_costoOperacion.Controls.Add(this.txt_costoMalo);
            this.gb_costoOperacion.Controls.Add(this.txt_costoRegular);
            this.gb_costoOperacion.Controls.Add(this.txt_costoBueno);
            this.gb_costoOperacion.Controls.Add(this.label16);
            this.gb_costoOperacion.Controls.Add(this.label15);
            this.gb_costoOperacion.Controls.Add(this.label5);
            this.gb_costoOperacion.Location = new System.Drawing.Point(661, 235);
            this.gb_costoOperacion.Name = "gb_costoOperacion";
            this.gb_costoOperacion.Size = new System.Drawing.Size(362, 175);
            this.gb_costoOperacion.TabIndex = 72;
            this.gb_costoOperacion.TabStop = false;
            this.gb_costoOperacion.Text = "Costo Operación";
            // 
            // btn_recalcularCostos
            // 
            this.btn_recalcularCostos.Location = new System.Drawing.Point(115, 146);
            this.btn_recalcularCostos.Name = "btn_recalcularCostos";
            this.btn_recalcularCostos.Size = new System.Drawing.Size(117, 23);
            this.btn_recalcularCostos.TabIndex = 11;
            this.btn_recalcularCostos.Text = "Recalcular Costos";
            this.btn_recalcularCostos.UseVisualStyleBackColor = true;
            this.btn_recalcularCostos.Click += new System.EventHandler(this.btn_recalcularCostos_Click);
            // 
            // lbl_costoSemanaMalo
            // 
            this.lbl_costoSemanaMalo.AutoSize = true;
            this.lbl_costoSemanaMalo.Location = new System.Drawing.Point(262, 112);
            this.lbl_costoSemanaMalo.Name = "lbl_costoSemanaMalo";
            this.lbl_costoSemanaMalo.Size = new System.Drawing.Size(25, 13);
            this.lbl_costoSemanaMalo.TabIndex = 10;
            this.lbl_costoSemanaMalo.Text = "------";
            // 
            // lbl_costoSemanaRegular
            // 
            this.lbl_costoSemanaRegular.AutoSize = true;
            this.lbl_costoSemanaRegular.Location = new System.Drawing.Point(262, 73);
            this.lbl_costoSemanaRegular.Name = "lbl_costoSemanaRegular";
            this.lbl_costoSemanaRegular.Size = new System.Drawing.Size(25, 13);
            this.lbl_costoSemanaRegular.TabIndex = 9;
            this.lbl_costoSemanaRegular.Text = "------";
            // 
            // lbl_costoSemanaBueno
            // 
            this.lbl_costoSemanaBueno.AutoSize = true;
            this.lbl_costoSemanaBueno.Location = new System.Drawing.Point(262, 37);
            this.lbl_costoSemanaBueno.Name = "lbl_costoSemanaBueno";
            this.lbl_costoSemanaBueno.Size = new System.Drawing.Size(25, 13);
            this.lbl_costoSemanaBueno.TabIndex = 8;
            this.lbl_costoSemanaBueno.Text = "------";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(235, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Costo por Semana";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(95, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Costo Anual";
            // 
            // txt_costoMalo
            // 
            this.txt_costoMalo.Location = new System.Drawing.Point(85, 109);
            this.txt_costoMalo.Name = "txt_costoMalo";
            this.txt_costoMalo.Size = new System.Drawing.Size(100, 20);
            this.txt_costoMalo.TabIndex = 5;
            this.txt_costoMalo.Text = "2000000";
            // 
            // txt_costoRegular
            // 
            this.txt_costoRegular.Location = new System.Drawing.Point(85, 70);
            this.txt_costoRegular.Name = "txt_costoRegular";
            this.txt_costoRegular.Size = new System.Drawing.Size(100, 20);
            this.txt_costoRegular.TabIndex = 4;
            this.txt_costoRegular.Text = "1000000";
            // 
            // txt_costoBueno
            // 
            this.txt_costoBueno.Location = new System.Drawing.Point(85, 37);
            this.txt_costoBueno.Name = "txt_costoBueno";
            this.txt_costoBueno.Size = new System.Drawing.Size(100, 20);
            this.txt_costoBueno.TabIndex = 3;
            this.txt_costoBueno.Text = "500000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Malo :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Regular : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bueno : ";
            // 
            // lbl_CostoAcumuladoTotal
            // 
            this.lbl_CostoAcumuladoTotal.AutoSize = true;
            this.lbl_CostoAcumuladoTotal.Location = new System.Drawing.Point(6, 27);
            this.lbl_CostoAcumuladoTotal.Name = "lbl_CostoAcumuladoTotal";
            this.lbl_CostoAcumuladoTotal.Size = new System.Drawing.Size(138, 13);
            this.lbl_CostoAcumuladoTotal.TabIndex = 73;
            this.lbl_CostoAcumuladoTotal.Text = "Costo Acumulado Total: $ 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lbl_Malo);
            this.groupBox2.Controls.Add(this.lbl_CostoAcumuladoTotal);
            this.groupBox2.Controls.Add(this.lbl_Regular);
            this.groupBox2.Controls.Add(this.lbl_Bueno);
            this.groupBox2.Location = new System.Drawing.Point(661, 556);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 133);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados  de Simulación:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 102);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 13);
            this.label21.TabIndex = 76;
            this.label21.Text = "Cantidad Semanas en Malo :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 79);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 13);
            this.label20.TabIndex = 75;
            this.label20.Text = "Cantidad Semanas en Regular :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 13);
            this.label19.TabIndex = 74;
            this.label19.Text = "Cantidad Semanas en Bueno :";
            // 
            // gb_costoReparacion
            // 
            this.gb_costoReparacion.Controls.Add(this.txt_reparacionMala);
            this.gb_costoReparacion.Controls.Add(this.txt_reparacionRegular);
            this.gb_costoReparacion.Controls.Add(this.label23);
            this.gb_costoReparacion.Controls.Add(this.label24);
            this.gb_costoReparacion.Location = new System.Drawing.Point(661, 416);
            this.gb_costoReparacion.Name = "gb_costoReparacion";
            this.gb_costoReparacion.Size = new System.Drawing.Size(362, 110);
            this.gb_costoReparacion.TabIndex = 96;
            this.gb_costoReparacion.TabStop = false;
            this.gb_costoReparacion.Text = "Costo Reparación";
            // 
            // txt_reparacionMala
            // 
            this.txt_reparacionMala.Location = new System.Drawing.Point(85, 68);
            this.txt_reparacionMala.Name = "txt_reparacionMala";
            this.txt_reparacionMala.Size = new System.Drawing.Size(100, 20);
            this.txt_reparacionMala.TabIndex = 12;
            this.txt_reparacionMala.Text = "5000000";
            // 
            // txt_reparacionRegular
            // 
            this.txt_reparacionRegular.Location = new System.Drawing.Point(85, 29);
            this.txt_reparacionRegular.Name = "txt_reparacionRegular";
            this.txt_reparacionRegular.Size = new System.Drawing.Size(100, 20);
            this.txt_reparacionRegular.TabIndex = 11;
            this.txt_reparacionRegular.Text = "2500000";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Malo :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "Regular : ";
            // 
            // txt_reparacion
            // 
            this.txt_reparacion.Location = new System.Drawing.Point(242, 202);
            this.txt_reparacion.Name = "txt_reparacion";
            this.txt_reparacion.Size = new System.Drawing.Size(58, 20);
            this.txt_reparacion.TabIndex = 98;
            this.txt_reparacion.Text = "52";
            // 
            // lbl_reparacionSemanas
            // 
            this.lbl_reparacionSemanas.AutoSize = true;
            this.lbl_reparacionSemanas.Location = new System.Drawing.Point(165, 197);
            this.lbl_reparacionSemanas.Name = "lbl_reparacionSemanas";
            this.lbl_reparacionSemanas.Size = new System.Drawing.Size(71, 26);
            this.lbl_reparacionSemanas.TabIndex = 97;
            this.lbl_reparacionSemanas.Text = "Periodo de\r\nReparación : ";
            // 
            // FormCasoA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 721);
            this.Controls.Add(this.txt_reparacion);
            this.Controls.Add(this.lbl_reparacionSemanas);
            this.Controls.Add(this.gb_costoReparacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_costoOperacion);
            this.Controls.Add(this.gb_probabilidades);
            this.Controls.Add(this.gb_modificarProbabilidades);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_borrarSimulacion);
            this.Controls.Add(this.btn_ComenzarSimulación);
            this.Controls.Add(this.txt_Semana);
            this.Controls.Add(this.lbl_Semana);
            this.Controls.Add(this.dgv_GridCasoA);
            this.Name = "FormCasoA";
            this.Text = "FormCasoA";
            this.Load += new System.EventHandler(this.FormCasoA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GridCasoA)).EndInit();
            this.gb_modificarProbabilidades.ResumeLayout(false);
            this.gb_modificarProbabilidades.PerformLayout();
            this.gb_probabilidades.ResumeLayout(false);
            this.gb_probabilidades.PerformLayout();
            this.gb_costoOperacion.ResumeLayout(false);
            this.gb_costoOperacion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_costoReparacion.ResumeLayout(false);
            this.gb_costoReparacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_GridCasoA;
        private System.Windows.Forms.Label lbl_Semana;
        private System.Windows.Forms.TextBox txt_Semana;
        private System.Windows.Forms.Label lbl_MM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MM;
        private System.Windows.Forms.TextBox txt_MR;
        private System.Windows.Forms.TextBox txt_MB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_RM;
        private System.Windows.Forms.Label lbl_RR;
        private System.Windows.Forms.Label lbl_RB;
        private System.Windows.Forms.TextBox txt_RM;
        private System.Windows.Forms.TextBox txt_RR;
        private System.Windows.Forms.TextBox txt_RB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_BM;
        private System.Windows.Forms.Label lbl_BR;
        private System.Windows.Forms.Label lbl_BB;
        private System.Windows.Forms.TextBox txt_BM;
        private System.Windows.Forms.TextBox txt_BR;
        private System.Windows.Forms.TextBox txt_BB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_EstadoBueno;
        private System.Windows.Forms.Button btn_ComenzarSimulación;
        private System.Windows.Forms.Button btn_borrarSimulacion;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_Bueno;
        private System.Windows.Forms.Label lbl_Regular;
        private System.Windows.Forms.Label lbl_Malo;
        private System.Windows.Forms.GroupBox gb_modificarProbabilidades;
        private System.Windows.Forms.Button btn_Recalcular;
        private System.Windows.Forms.RadioButton rbt_modificar;
        private System.Windows.Forms.RadioButton rbt_valoresListos;
        private System.Windows.Forms.GroupBox gb_probabilidades;
        private System.Windows.Forms.GroupBox gb_costoOperacion;
        private System.Windows.Forms.Button btn_recalcularCostos;
        private System.Windows.Forms.Label lbl_costoSemanaMalo;
        private System.Windows.Forms.Label lbl_costoSemanaRegular;
        private System.Windows.Forms.Label lbl_costoSemanaBueno;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_costoMalo;
        private System.Windows.Forms.TextBox txt_costoRegular;
        private System.Windows.Forms.TextBox txt_costoBueno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_CostoAcumuladoTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox gb_costoReparacion;
        private System.Windows.Forms.TextBox txt_reparacionMala;
        private System.Windows.Forms.TextBox txt_reparacionRegular;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_reparacion;
        private System.Windows.Forms.Label lbl_reparacionSemanas;
    }
}