using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel1 = Microsoft.Office.Interop.Excel;
using Loja_de_Eletronicos;

public class Excel
{
    public static Excel1.Application excelApp = new Excel1.Application();
    public static Excel1.Workbook excelWorkbook;
    public static Excel1.Worksheet excelWorksheet;



    public void ExcelAdd(string id, string nome, double valor, string df, int quantidade)
    {
        try
        {
            
            excelWorkbook = excelApp.Workbooks.Open(@"C:\Users\proco\source\repos\Loja_Eletronicos\Loja_Eletronicos\Banco Dados\Estoque.xlsx");
            excelWorksheet = excelWorkbook.Sheets[1];
            int lastRow = excelWorksheet.Cells[excelWorksheet.Rows.Count, "A"].End[Excel1.XlDirection.xlUp].Row;//SERVE PRA PEGAR A ULTIMA LINHA USADA
            lastRow++;//VAI PRA PROXIMA DPS DA USADA

            excelWorksheet.Cells[lastRow, 1] = id;
            excelWorksheet.Cells[lastRow, 2] = nome;
            excelWorksheet.Cells[lastRow, 3] = valor;
            excelWorksheet.Cells[lastRow, 4] = df;
            excelWorksheet.Cells[lastRow, 5] = quantidade;
            //COLUNAS
            excelWorksheet.Cells[1, 1]= "Id";
            excelWorksheet.Cells[1, 2]= "Produto";
            excelWorksheet.Cells[1, 3]= "Valor";
            excelWorksheet.Cells[1, 4] = "DataFabricação";
            excelWorksheet.Cells[1, 5]= "Quantidade";

            // Salve as alterações no arquivo
            excelWorkbook.Save();

            excelWorkbook.Close();
            
             MessageBox.Show("Salvoo com sucesso!");
         }
         catch (Exception ex)
         {
             MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
         }
     }



    public void LerExcel()
    {
        try
        {
            Excel1.Workbook excelWorkbook = excelApp.Workbooks.Open(@"C:\Users\proco\source\repos\Loja_Eletronicos\Loja_Eletronicos\Banco Dados\Estoque.xlsx");
            Excel1.Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // Supondo que você queira ler a primeira planilha.

            // Encontre a última linha e coluna usada no Excel.
            int lastRow = excelWorksheet.Cells.SpecialCells(Excel1.XlCellType.xlCellTypeLastCell).Row;
            int lastColumn = excelWorksheet.Cells.SpecialCells(Excel1.XlCellType.xlCellTypeLastCell).Column;


            for (int row = 2; row <= lastRow; row++)
            {
                int col = 1;
                string cellValue = excelWorksheet.Cells[row, col].Text;
                if (cellValue != "")
                {
                    string Id = excelWorksheet.Cells[row, col].Text;
                    //MessageBox.Show("Id " + Id);
                    col++;

                    string Nome = excelWorksheet.Cells[row, col].Text;
                    // MessageBox.Show(("Nome " + Nome));
                    col++;

                    string Valor = excelWorksheet.Cells[row, col].Text;
                    //MessageBox.Show(("Valor " + Valor.ToString()));
                    col++;

                    string DataFabr = excelWorksheet.Cells[row, col].Text;
                    //MessageBox.Show(("Data Fabricação " + DataFabr.ToString()));
                    col++;

                    string Quantidade = excelWorksheet.Cells[row, col].Text;
                    //MessageBox.Show(("Quantidade " + Quantidade.ToString()));

                    Produtos conexao = new Produtos(Id, Nome, Convert.ToDouble(Valor), DataFabr, Convert.ToInt32(Quantidade));
                    Program.listaProdutos.Add(conexao);
                }
            }
            // Feche o arquivo Excel e libere os recursos.
            excelWorkbook.Close();
            excelApp.Quit();
        }
        catch (Exception error)
        {
            MessageBox.Show("Ocorreu um erro inesperado: " + error.Message);
        }
    }


    public static void ExcluirExcel(int index)//SERVE PARA EXCLUIR ALGUMA LINHA DO EXCEL
    {
        excelWorkbook = excelApp.Workbooks.Open(@"C:\Users\proco\source\repos\Loja_Eletronicos\Loja_Eletronicos\Banco Dados\Estoque.xlsx");
        excelWorksheet = excelWorkbook.Sheets[1];
        int linha = index + 2;//SERVE PRA PEGAR A LINHA CERTINHA DO EXCEL
        excelWorksheet.Cells[linha, 1] = null;
        excelWorksheet.Cells[linha, 2] = null;
        excelWorksheet.Cells[linha, 3] = null;
        excelWorksheet.Cells[linha, 4] = null;
        excelWorksheet.Cells[linha, 5] = null;

        excelWorkbook.Save();
        excelWorkbook.Close();
        MessageBox.Show("Apagado com exito!");
    }
}
       



            
