using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;





namespace Loja_de_Eletronicos
{
    public partial class Form3_VisualizarEstoque : Form
    {
        public Form3_VisualizarEstoque()
        {
            InitializeComponent();

            foreach (Produtos str in Program.listaProdutos)
            {
                dataGridView1.Rows.Add(str.Id, str.Nome, str.Valor, str.DataFabr, str.Quantidade);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cadastrar_Produto produto = new Cadastrar_Produto();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_VisualizarEstoque_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Cadastrar_Produto RV = new Cadastrar_Produto();
            this.Visible = false;
            RV.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form1 voltarMenu = new Form1();
            this.Visible = false;
            voltarMenu.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(index);
                Program.listaProdutos.RemoveAt(index);
            }
        }
    }
}
