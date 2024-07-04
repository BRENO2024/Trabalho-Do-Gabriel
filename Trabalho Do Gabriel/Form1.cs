namespace Trabalho_Do_Gabriel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(textBoxR.Text);
                double V = Convert.ToDouble(textBoxV.Text);
                double G = Convert.ToDouble(textBoxG.Text);

                if (checkBox1.Checked)
                {
                    double M = (2 * R * Math.Pow(V, 2)) / G;
                    labelResultado.Text = "A Massa da mat�ria escura �: " + M.ToString("F2") + " kg";
                }
                else
                {
                    double M = (2 * R * Math.Pow(V, 2)) / G;
                    double rho = M / ((4.0 / 3.0) * Math.PI * Math.Pow(R, 3));
                    labelResultado.Text = "A densidade de mat�ria escura �: " + rho.ToString("F2") + " kg/m�";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores num�ricos v�lidos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                labelFeedback.Text = "Calculando Massa da Mat�ria Escura...";
            }
            else
            {
                labelFeedback.Text = "Calculando Densidade da Mat�ria Escura...";
            }
        }

        private void labelFeedback_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}