namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnZero = new Button();
            btnPonto = new Button();
            btnIgual = new Button();
            btnSoma = new Button();
            btnTres = new Button();
            btnDois = new Button();
            btnUm = new Button();
            btnSubtracao = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnMultiplicacao = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnLimpar = new Button();
            btnDivisao = new Button();
            btnAlteraSinal = new Button();
            txtResultado = new TextBox();
            lblHistorico = new Label();
            SuspendLayout();
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.White;
            btnZero.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnZero.Location = new Point(40, 477);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(146, 70);
            btnZero.TabIndex = 0;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnPonto
            // 
            btnPonto.BackColor = Color.White;
            btnPonto.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnPonto.Location = new Point(192, 477);
            btnPonto.Name = "btnPonto";
            btnPonto.Size = new Size(70, 70);
            btnPonto.TabIndex = 2;
            btnPonto.Text = ".";
            btnPonto.UseVisualStyleBackColor = false;
            btnPonto.Click += btnPonto_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.White;
            btnIgual.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnIgual.Location = new Point(268, 477);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(70, 70);
            btnIgual.TabIndex = 3;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.White;
            btnSoma.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSoma.Location = new Point(268, 387);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(70, 70);
            btnSoma.TabIndex = 7;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.White;
            btnTres.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.Location = new Point(192, 387);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(70, 70);
            btnTres.TabIndex = 6;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnDois
            // 
            btnDois.BackColor = Color.White;
            btnDois.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDois.Location = new Point(116, 387);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(70, 70);
            btnDois.TabIndex = 5;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = false;
            btnDois.Click += btnDois_Click;
            // 
            // btnUm
            // 
            btnUm.BackColor = Color.White;
            btnUm.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnUm.Location = new Point(40, 387);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(70, 70);
            btnUm.TabIndex = 4;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = false;
            btnUm.Click += btnUm_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.White;
            btnSubtracao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubtracao.Location = new Point(268, 295);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(70, 70);
            btnSubtracao.TabIndex = 11;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = Color.White;
            btnSeis.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeis.Location = new Point(192, 295);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(70, 70);
            btnSeis.TabIndex = 10;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = Color.White;
            btnCinco.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCinco.Location = new Point(116, 295);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(70, 70);
            btnCinco.TabIndex = 9;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.BackColor = Color.White;
            btnQuatro.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuatro.Location = new Point(40, 295);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(70, 70);
            btnQuatro.TabIndex = 8;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = false;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.White;
            btnMultiplicacao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMultiplicacao.Location = new Point(268, 206);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(70, 70);
            btnMultiplicacao.TabIndex = 15;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnNove
            // 
            btnNove.BackColor = Color.White;
            btnNove.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnNove.Location = new Point(192, 206);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(70, 70);
            btnNove.TabIndex = 14;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = false;
            btnNove.Click += btnNove_Click;
            // 
            // btnOito
            // 
            btnOito.BackColor = Color.White;
            btnOito.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnOito.Location = new Point(116, 206);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(70, 70);
            btnOito.TabIndex = 13;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = false;
            btnOito.Click += btnOito_Click;
            // 
            // btnSete
            // 
            btnSete.BackColor = Color.White;
            btnSete.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnSete.Location = new Point(40, 206);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(70, 70);
            btnSete.TabIndex = 12;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = false;
            btnSete.Click += btnSete_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(40, 113);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(70, 70);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.White;
            btnDivisao.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivisao.Location = new Point(268, 113);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(70, 70);
            btnDivisao.TabIndex = 17;
            btnDivisao.Text = "÷";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnAlteraSinal
            // 
            btnAlteraSinal.BackColor = Color.White;
            btnAlteraSinal.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlteraSinal.Location = new Point(116, 113);
            btnAlteraSinal.Name = "btnAlteraSinal";
            btnAlteraSinal.Size = new Size(70, 70);
            btnAlteraSinal.TabIndex = 18;
            btnAlteraSinal.Text = "+ / -";
            btnAlteraSinal.UseVisualStyleBackColor = false;
            btnAlteraSinal.Click += btnAlteraSinal_Click;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txtResultado.Location = new Point(40, 73);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(298, 34);
            txtResultado.TabIndex = 19;
            txtResultado.Text = "0";
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // lblHistorico
            // 
            lblHistorico.AutoSize = true;
            lblHistorico.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorico.ForeColor = Color.Navy;
            lblHistorico.Location = new Point(40, 31);
            lblHistorico.Name = "lblHistorico";
            lblHistorico.Size = new Size(0, 28);
            lblHistorico.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(lblHistorico);
            Controls.Add(txtResultado);
            Controls.Add(btnAlteraSinal);
            Controls.Add(btnDivisao);
            Controls.Add(btnLimpar);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSubtracao);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnSoma);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnIgual);
            Controls.Add(btnPonto);
            Controls.Add(btnZero);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnZero;
        private Button btnPonto;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnTres;
        private Button btnDois;
        private Button btnUm;
        private Button btnSubtracao;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnMultiplicacao;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnLimpar;
        private Button btnDivisao;
        private Button btnAlteraSinal;
        private TextBox txtResultado;
        private Label lblHistorico;
    }
}