using Eletros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Loja_de_Eletronicos
{
    public partial class Form2_RealizarVenda : Form
    {
        public Form2_RealizarVenda()
        {
            InitializeComponent();

            foreach (Produtos str in Program.listaProdutos)
            {
                txt_id.Items.Add(str.Id);
            }

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lucro_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void txt_qtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            // Encontra o produto selecionado no ComboBox
            string selectedProductName = txt_id.Text;
            Produtos selectedProduct = Program.listaProdutos.Find(prod => prod.Id == selectedProductName);

            int linha = Program.listaProdutos.IndexOf(selectedProduct) + 2;

            if (selectedProduct != null)
            {
                int qtd = Convert.ToInt32(txt_qtd.Text);

                // Diminui a quantidade do produto em 1
                selectedProduct.Quantidade = selectedProduct.Quantidade - qtd;
                //Excel.Atualizar(linha, selectedProduct);
            }
            Venda v = new Venda();
            try
            {
                v.Id = Convert.ToString(txt_id.Text);
                v.Nome = box_nome.Text;
                v.Valor = Convert.ToDouble(txt_valor.Text);
                v.Lucro = Convert.ToInt32(txt_lucro.Text);

  
                txt_id.Enabled = false;
                box_nome.Enabled = false;
                txt_valor.Enabled = false;
                txt_qtd.Enabled = false;
                txt_lucro.Enabled = false;
                txt_venda.Enabled = false;
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message + "\n Tente digitar novamente");
            }

            txt_venda.Text = v.ValorVenda(v.Valor, v.Lucro).ToString("");
        }

        private void box_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = txt_id.SelectedItem.ToString();
            Produtos selectedProduct = Program.listaProdutos.Find(prod => prod.Id == selectedProductName);

            if (selectedProduct != null)
            {
                // Aqui você pode acessar os atributos do produto selecionado
                string id = selectedProduct.Id;
                string nome = selectedProduct.Nome;
                double preco = selectedProduct.Valor;

                // Atualiza os controles na interface com as informações do produto;
                txt_valor.Text = preco.ToString();
                txt_id.Text = id.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txt_id.Text = "";
            box_nome.Text = "";
            txt_valor.Text = "";
            txt_qtd.Text = "";
            txt_lucro.Clear();
            txt_venda.Clear();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            this.Visible = false;
            menu.ShowDialog();
            this.Visible = true;
        }
    }
}