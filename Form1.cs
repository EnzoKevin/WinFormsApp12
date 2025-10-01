namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        StreamWriter sw = null;
        double saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw = new StreamWriter("C:\\Users\\Aluno\\source\\repos\\projLivraria\\teste.csv");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CreditoCheck.Checked)
            {
                Credito.Text = BtnPrice.Text;
            }
            else
            {
                DebitoBtn.Text = BtnPrice.Text;
            }
            try
            {

                if (DebitoBtn.Text != null && Credito.Text != null)
                {
                    double cred = Convert.ToDouble(Credito.Text);
                    double deb = Convert.ToDouble(DebitoBtn.Text);
                    double result = deb - cred;

                    Saldo.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sw.Close();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {

            if (BtnData.Text != null || BtnName != null)
            {
                sw.Write("o Saldo Foi - " + Saldo.Text + ";" + "a Justificativa foi - " + BtnName.Text + ";" + "o Dia foi - " + BtnData.Text + ";");
            }
            else
            {
                MessageBox.Show("Digite todos os quadrados");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
