namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("1");
        }

        /// <summary>
        /// PUBLIC => Visibilidade do meu método
        /// VOID => Retorno (No caso ele não retorna nada)
        /// Nome do método
        /// (zero ou mais parâmetros)
        /// </summary>
        /// <param name="textoAcrescentar"></param>
        public void GerarStringTxtResultado(string textoAcrescentar)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = textoAcrescentar;
            }
            else
            {
                txtResultado.Text += textoAcrescentar;
            }
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            GerarStringTxtResultado("0");
        }
    }
}