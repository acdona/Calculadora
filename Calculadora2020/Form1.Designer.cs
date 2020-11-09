namespace Calculadora2020
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.btnResto = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.lstFita = new System.Windows.Forms.ListBox();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnLimpaFita = new System.Windows.Forms.Button();
            this.tkbDigitos = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSeletorDigitos = new System.Windows.Forms.Panel();
            this.lblDigitoF = new System.Windows.Forms.Label();
            this.lblDigito0 = new System.Windows.Forms.Label();
            this.lblDigito2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tkbDigitos)).BeginInit();
            this.pnlSeletorDigitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(180, 135);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(63, 25);
            this.btnSomar.TabIndex = 0;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnOperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(180, 48);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(63, 25);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnOperador);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(180, 106);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(63, 25);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnOperador);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(180, 79);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(63, 25);
            this.btnSubtrair.TabIndex = 3;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnOperador);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(124, 48);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(50, 25);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.Location = new System.Drawing.Point(68, 164);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(50, 25);
            this.btnPonto.TabIndex = 5;
            this.btnPonto.Text = ",";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 164);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(50, 25);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 77);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 25);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(68, 79);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 25);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(124, 79);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 25);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 106);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 25);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(68, 106);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 25);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(124, 106);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 25);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 135);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 25);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(68, 135);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 25);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumero);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(124, 135);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 25);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumero);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(124, 164);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(50, 25);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // txtVisor
            // 
            this.txtVisor.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisor.Location = new System.Drawing.Point(12, 12);
            this.txtVisor.MaxLength = 27;
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.ReadOnly = true;
            this.txtVisor.Size = new System.Drawing.Size(308, 30);
            this.txtVisor.TabIndex = 17;
            this.txtVisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnResto
            // 
            this.btnResto.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResto.Location = new System.Drawing.Point(180, 164);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(63, 25);
            this.btnResto.TabIndex = 18;
            this.btnResto.Text = "%";
            this.btnResto.UseVisualStyleBackColor = true;
            this.btnResto.Click += new System.EventHandler(this.btnOperador);
            // 
            // btnBS
            // 
            this.btnBS.Location = new System.Drawing.Point(60, 51);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(57, 21);
            this.btnBS.TabIndex = 19;
            this.btnBS.Text = "<--";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // lstFita
            // 
            this.lstFita.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFita.FormatString = "N2";
            this.lstFita.FormattingEnabled = true;
            this.lstFita.ItemHeight = 16;
            this.lstFita.Location = new System.Drawing.Point(373, 11);
            this.lstFita.Name = "lstFita";
            this.lstFita.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstFita.Size = new System.Drawing.Size(141, 244);
            this.lstFita.TabIndex = 20;
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(249, 48);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(63, 25);
            this.btnCE.TabIndex = 21;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnLimpaFita
            // 
            this.btnLimpaFita.Location = new System.Drawing.Point(20, 219);
            this.btnLimpaFita.Name = "btnLimpaFita";
            this.btnLimpaFita.Size = new System.Drawing.Size(97, 28);
            this.btnLimpaFita.TabIndex = 22;
            this.btnLimpaFita.Text = "Limpa Fita";
            this.btnLimpaFita.UseVisualStyleBackColor = true;
            this.btnLimpaFita.Click += new System.EventHandler(this.btnLimpaFita_Click);
            // 
            // tkbDigitos
            // 
            this.tkbDigitos.LargeChange = 1;
            this.tkbDigitos.Location = new System.Drawing.Point(3, 3);
            this.tkbDigitos.Maximum = 2;
            this.tkbDigitos.Name = "tkbDigitos";
            this.tkbDigitos.Size = new System.Drawing.Size(100, 45);
            this.tkbDigitos.SmallChange = 0;
            this.tkbDigitos.TabIndex = 23;
            this.tkbDigitos.Value = 1;
            this.tkbDigitos.Scroll += new System.EventHandler(this.tkbDigitos_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "label1";
            // 
            // pnlSeletorDigitos
            // 
            this.pnlSeletorDigitos.Controls.Add(this.lblDigitoF);
            this.pnlSeletorDigitos.Controls.Add(this.lblDigito0);
            this.pnlSeletorDigitos.Controls.Add(this.lblDigito2);
            this.pnlSeletorDigitos.Controls.Add(this.tkbDigitos);
            this.pnlSeletorDigitos.Location = new System.Drawing.Point(137, 197);
            this.pnlSeletorDigitos.Name = "pnlSeletorDigitos";
            this.pnlSeletorDigitos.Size = new System.Drawing.Size(106, 42);
            this.pnlSeletorDigitos.TabIndex = 25;
            // 
            // lblDigitoF
            // 
            this.lblDigitoF.AutoSize = true;
            this.lblDigitoF.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitoF.Location = new System.Drawing.Point(85, 30);
            this.lblDigitoF.Name = "lblDigitoF";
            this.lblDigitoF.Size = new System.Drawing.Size(12, 13);
            this.lblDigitoF.TabIndex = 27;
            this.lblDigitoF.Text = "F";
            // 
            // lblDigito0
            // 
            this.lblDigito0.AutoSize = true;
            this.lblDigito0.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigito0.Location = new System.Drawing.Point(10, 30);
            this.lblDigito0.Name = "lblDigito0";
            this.lblDigito0.Size = new System.Drawing.Size(13, 13);
            this.lblDigito0.TabIndex = 26;
            this.lblDigito0.Text = "0";
            // 
            // lblDigito2
            // 
            this.lblDigito2.AutoSize = true;
            this.lblDigito2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigito2.Location = new System.Drawing.Point(47, 30);
            this.lblDigito2.Name = "lblDigito2";
            this.lblDigito2.Size = new System.Drawing.Size(13, 13);
            this.lblDigito2.TabIndex = 28;
            this.lblDigito2.Text = "2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 281);
            this.Controls.Add(this.pnlSeletorDigitos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpaFita);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.lstFita);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnResto);
            this.Controls.Add(this.txtVisor);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.tkbDigitos)).EndInit();
            this.pnlSeletorDigitos.ResumeLayout(false);
            this.pnlSeletorDigitos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Button btnResto;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.ListBox lstFita;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnLimpaFita;
        private System.Windows.Forms.TrackBar tkbDigitos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSeletorDigitos;
        private System.Windows.Forms.Label lblDigito0;
        private System.Windows.Forms.Label lblDigitoF;
        private System.Windows.Forms.Label lblDigito2;
    }
}

