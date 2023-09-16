using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_Eletronicos
{
    public partial class Cadastrar_Produto : Form
    {
        public static int ID;
        public Cadastrar_Produto()
        {

            InitializeComponent();

            foreach (Produtos str in Program.listaProdutos)
            {
                ID = Convert.ToInt32(str.Id);
                ID++;
                txt_id.Text = ID.ToString();
            }

        }

        private void box_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_df_TextChanged(object sender, EventArgs e)
        {

        }
        private void tx_qtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Produto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            box_valor.Text = "";
            txt_id.Text = "";
            tx_qtd.Text = "";
            box_df.Text = "";
            txt_id.Text = "";
        }

        private void box_df_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void but_salvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string nome = txt_nome.Text;
                double valor = Convert.ToDouble(box_valor.Text);
                string datafabricacao = box_df.Text;
                int qtd = Convert.ToInt32(tx_qtd.Text);
                Produtos p = new Produtos("1", nome, valor, datafabricacao, qtd);
                Program.listaProdutos.Add(p);

                Excel xls = new Excel();
                xls.ExcelAdd("1", nome, valor, datafabricacao, qtd);



                Form3_VisualizarEstoque tela = new Form3_VisualizarEstoque();
                this.Visible = false;
                tela.ShowDialog();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, verefique se os parametros foram inseridos corretamente!");

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.ShowDialog();
        }
    }
}
