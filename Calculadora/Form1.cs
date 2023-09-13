namespace Calculadora
{
    public partial class Form1 : Form
    {
        //Sempre que tivermos a variável seguida de ? quer dizer que ela aceita null
        decimal numero1, numero2;
        string operacao = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            operacao = "";
            numero1 = 0;
            numero2 = 0;
            lblHistorico.Text = "";
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
            if (txtResultado.Text == "0" && textoAcrescentar != ",")
            {
                txtResultado.Text = textoAcrescentar;
            }
            else
            {
                txtResultado.Text += textoAcrescentar;
            }

            lblHistorico.Text += textoAcrescentar;
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

        private void btnPonto_Click(object sender, EventArgs e)
        {
            //Contains vai verificar se existe esse(s) caracteres dentro da string
            //Vou verificar se NÃO existe um ponto
            if (!txtResultado.Text.Contains(","))
            {
                GerarStringTxtResultado(",");
            }
        }

        public void CalcularOperacao()
        {
            decimal resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    break;
            }

            txtResultado.Text = resultado.ToString();

            lblHistorico.Text += " = " + resultado;

            operacao = "";
        }

        public void CriaOperacao(string operacaoParametro)
        {
            if (operacao != "")
            {
                numero2 = Convert.ToDecimal(txtResultado.Text);
                CalcularOperacao();
            }

            operacao = operacaoParametro;
            numero1 = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "0";

            lblHistorico.Text += " " + operacao + " ";
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            CriaOperacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            CriaOperacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            CriaOperacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            CriaOperacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDecimal(txtResultado.Text);
            CalcularOperacao();
        }

        private void btnAlteraSinal_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Contains("-"))
            {
                //Remove é o método capaz de remover um ou mais caracteres de uma string
                //Informe o indice que ele inicia a remoção e a quantidade de caracteres
                txtResultado.Text = txtResultado.Text.Remove(0, 1);
                lblHistorico.Text = "(" + lblHistorico.Text + ") * -1";
            }
            else
            {
                if (Convert.ToDecimal(txtResultado.Text) != 0)
                {
                    txtResultado.Text = "-" + txtResultado.Text;
                    lblHistorico.Text = "(" + lblHistorico.Text + ") * -1";
                }
            }
        }
    }
}