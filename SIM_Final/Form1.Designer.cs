namespace SIM_Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl_EstadoBueno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_BB = new System.Windows.Forms.TextBox();
            this.txt_BR = new System.Windows.Forms.TextBox();
            this.txt_BM = new System.Windows.Forms.TextBox();
            this.lbl_BB = new System.Windows.Forms.Label();
            this.lbl_BR = new System.Windows.Forms.Label();
            this.lbl_BM = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_RM = new System.Windows.Forms.Label();
            this.lbl_RR = new System.Windows.Forms.Label();
            this.lbl_RB = new System.Windows.Forms.Label();
            this.txt_RM = new System.Windows.Forms.TextBox();
            this.txt_RR = new System.Windows.Forms.TextBox();
            this.txt_RB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_MM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MM = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Recalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "Caso A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 124);
            this.button2.TabIndex = 1;
            this.button2.Text = "Caso B";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(381, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 124);
            this.button3.TabIndex = 2;
            this.button3.Text = "Caso C";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(568, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 124);
            this.button4.TabIndex = 3;
            this.button4.Text = "Caso D";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbl_EstadoBueno
            // 
            this.lbl_EstadoBueno.AutoSize = true;
            this.lbl_EstadoBueno.Location = new System.Drawing.Point(35, 203);
            this.lbl_EstadoBueno.Name = "lbl_EstadoBueno";
            this.lbl_EstadoBueno.Size = new System.Drawing.Size(119, 13);
            this.lbl_EstadoBueno.TabIndex = 4;
            this.lbl_EstadoBueno.Text = "Motor en Estado Bueno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Probabilidad \r\nBueno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Probabilidad\r\nRegular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Probabilidad\r\nMalo:";
            // 
            // txt_BB
            // 
            this.txt_BB.Location = new System.Drawing.Point(94, 236);
            this.txt_BB.Name = "txt_BB";
            this.txt_BB.Size = new System.Drawing.Size(42, 20);
            this.txt_BB.TabIndex = 8;
            this.txt_BB.Text = "0.7";
            // 
            // txt_BR
            // 
            this.txt_BR.Location = new System.Drawing.Point(94, 276);
            this.txt_BR.Name = "txt_BR";
            this.txt_BR.Size = new System.Drawing.Size(42, 20);
            this.txt_BR.TabIndex = 9;
            this.txt_BR.Text = "0.2";
            // 
            // txt_BM
            // 
            this.txt_BM.Location = new System.Drawing.Point(94, 323);
            this.txt_BM.Name = "txt_BM";
            this.txt_BM.Size = new System.Drawing.Size(42, 20);
            this.txt_BM.TabIndex = 10;
            this.txt_BM.Text = "0.1";
            // 
            // lbl_BB
            // 
            this.lbl_BB.AutoSize = true;
            this.lbl_BB.Location = new System.Drawing.Point(147, 239);
            this.lbl_BB.Name = "lbl_BB";
            this.lbl_BB.Size = new System.Drawing.Size(22, 13);
            this.lbl_BB.TabIndex = 11;
            this.lbl_BB.Text = "0.7";
            // 
            // lbl_BR
            // 
            this.lbl_BR.AutoSize = true;
            this.lbl_BR.Location = new System.Drawing.Point(147, 279);
            this.lbl_BR.Name = "lbl_BR";
            this.lbl_BR.Size = new System.Drawing.Size(22, 13);
            this.lbl_BR.TabIndex = 12;
            this.lbl_BR.Text = "0.9";
            // 
            // lbl_BM
            // 
            this.lbl_BM.AutoSize = true;
            this.lbl_BM.Location = new System.Drawing.Point(147, 326);
            this.lbl_BM.Name = "lbl_BM";
            this.lbl_BM.Size = new System.Drawing.Size(13, 13);
            this.lbl_BM.TabIndex = 13;
            this.lbl_BM.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Motor en Estado Regular";
            // 
            // lbl_RM
            // 
            this.lbl_RM.AutoSize = true;
            this.lbl_RM.Location = new System.Drawing.Point(370, 326);
            this.lbl_RM.Name = "lbl_RM";
            this.lbl_RM.Size = new System.Drawing.Size(13, 13);
            this.lbl_RM.TabIndex = 23;
            this.lbl_RM.Text = "1";
            // 
            // lbl_RR
            // 
            this.lbl_RR.AutoSize = true;
            this.lbl_RR.Location = new System.Drawing.Point(370, 279);
            this.lbl_RR.Name = "lbl_RR";
            this.lbl_RR.Size = new System.Drawing.Size(22, 13);
            this.lbl_RR.TabIndex = 22;
            this.lbl_RR.Text = "0.6";
            // 
            // lbl_RB
            // 
            this.lbl_RB.AutoSize = true;
            this.lbl_RB.Location = new System.Drawing.Point(370, 239);
            this.lbl_RB.Name = "lbl_RB";
            this.lbl_RB.Size = new System.Drawing.Size(13, 13);
            this.lbl_RB.TabIndex = 21;
            this.lbl_RB.Text = "0";
            this.lbl_RB.Visible = false;
            // 
            // txt_RM
            // 
            this.txt_RM.Location = new System.Drawing.Point(317, 323);
            this.txt_RM.Name = "txt_RM";
            this.txt_RM.Size = new System.Drawing.Size(42, 20);
            this.txt_RM.TabIndex = 20;
            this.txt_RM.Text = "0.4";
            // 
            // txt_RR
            // 
            this.txt_RR.Location = new System.Drawing.Point(317, 276);
            this.txt_RR.Name = "txt_RR";
            this.txt_RR.Size = new System.Drawing.Size(42, 20);
            this.txt_RR.TabIndex = 19;
            this.txt_RR.Text = "0.6";
            // 
            // txt_RB
            // 
            this.txt_RB.Enabled = false;
            this.txt_RB.Location = new System.Drawing.Point(317, 236);
            this.txt_RB.Name = "txt_RB";
            this.txt_RB.Size = new System.Drawing.Size(42, 20);
            this.txt_RB.TabIndex = 18;
            this.txt_RB.Text = "0";
            this.txt_RB.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Probabilidad\r\nMalo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Probabilidad\r\nRegular:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 26);
            this.label10.TabIndex = 15;
            this.label10.Text = "Probabilidad \r\nBueno: ";
            this.label10.Visible = false;
            // 
            // lbl_MM
            // 
            this.lbl_MM.AutoSize = true;
            this.lbl_MM.Location = new System.Drawing.Point(593, 326);
            this.lbl_MM.Name = "lbl_MM";
            this.lbl_MM.Size = new System.Drawing.Size(13, 13);
            this.lbl_MM.TabIndex = 33;
            this.lbl_MM.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // txt_MM
            // 
            this.txt_MM.Location = new System.Drawing.Point(540, 323);
            this.txt_MM.Name = "txt_MM";
            this.txt_MM.Size = new System.Drawing.Size(42, 20);
            this.txt_MM.TabIndex = 30;
            this.txt_MM.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(540, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 20);
            this.textBox2.TabIndex = 29;
            this.textBox2.Text = "0";
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(540, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(42, 20);
            this.textBox3.TabIndex = 28;
            this.textBox3.Text = "0";
            this.textBox3.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(458, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 27;
            this.label11.Text = "Probabilidad\r\nMalo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(458, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 26);
            this.label12.TabIndex = 26;
            this.label12.Text = "Probabilidad\r\nRegular:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(458, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 26);
            this.label13.TabIndex = 25;
            this.label13.Text = "Probabilidad \r\nBueno: ";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(481, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Motor en Estado Malo";
            // 
            // btn_Recalcular
            // 
            this.btn_Recalcular.Location = new System.Drawing.Point(661, 254);
            this.btn_Recalcular.Name = "btn_Recalcular";
            this.btn_Recalcular.Size = new System.Drawing.Size(74, 63);
            this.btn_Recalcular.TabIndex = 34;
            this.btn_Recalcular.Text = "Recalcular Probabilidad";
            this.btn_Recalcular.UseVisualStyleBackColor = true;
            this.btn_Recalcular.Click += new System.EventHandler(this.btn_Recalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 358);
            this.Controls.Add(this.btn_Recalcular);
            this.Controls.Add(this.lbl_MM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_MM);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_RM);
            this.Controls.Add(this.lbl_RR);
            this.Controls.Add(this.lbl_RB);
            this.Controls.Add(this.txt_RM);
            this.Controls.Add(this.txt_RR);
            this.Controls.Add(this.txt_RB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_BM);
            this.Controls.Add(this.lbl_BR);
            this.Controls.Add(this.lbl_BB);
            this.Controls.Add(this.txt_BM);
            this.Controls.Add(this.txt_BR);
            this.Controls.Add(this.txt_BB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_EstadoBueno);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_EstadoBueno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_BB;
        private System.Windows.Forms.TextBox txt_BR;
        private System.Windows.Forms.TextBox txt_BM;
        private System.Windows.Forms.Label lbl_BB;
        private System.Windows.Forms.Label lbl_BR;
        private System.Windows.Forms.Label lbl_BM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_RM;
        private System.Windows.Forms.Label lbl_RR;
        private System.Windows.Forms.Label lbl_RB;
        private System.Windows.Forms.TextBox txt_RM;
        private System.Windows.Forms.TextBox txt_RR;
        private System.Windows.Forms.TextBox txt_RB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_MM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_MM;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Recalcular;
    }
}

