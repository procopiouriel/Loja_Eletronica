namespace Loja_de_Eletronicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialg = new DialogResult();
            dialg = MessageBox.Show("Deseja mesmo sair?", "Alerta!", MessageBoxButtons.YesNo);

            if (dialg == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Cadastrar_Produto cp = new Cadastrar_Produto();
                cp.ShowDialog();
            }
            this.Visible = false;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar_Produto RV = new Cadastrar_Produto();
            this.Visible = false;
            RV.ShowDialog();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2_RealizarVenda tela = new Form2_RealizarVenda();
            this.Visible = false;
            tela.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3_VisualizarEstoque RV = new Form3_VisualizarEstoque();
            this.Visible = false;
            RV.ShowDialog();
        }
    }
}