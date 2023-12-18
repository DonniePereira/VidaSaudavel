namespace VidaSaudavel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pesoIdealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesoIdeal pesoIdealForm = new PesoIdeal();
            pesoIdealForm.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Quer mesmo sair?", "Vida Saudável", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void iMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IMC imcForm = new IMC();
            imcForm.ShowDialog();
        }
    }
}
