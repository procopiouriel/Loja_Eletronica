using System;
using System.Collections.Generic;
using System.IO;
using Excel1 = Microsoft.Office.Interop.Excel;

namespace Loja_de_Eletronicos
{
    internal static class Program
    {
        public static List<Produtos> listaProdutos = new List<Produtos>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Excel conexao = new Excel();
            conexao.LerExcel();//ADICIONAR OS DADOS DO EXCEL NA listaProdutos
            if (listaProdutos.Count > 1)
            {
                listaProdutos.RemoveAt(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
