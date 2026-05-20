using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFAppThemeTest.Models;

namespace WPFAppThemeTest
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dgProdutos.ItemsSource = new List<Produto>()
            {
                new Produto()
                {
                    Codigo = "001",
                    Descricao = "Motor",
                    Quantidade = 2
                },

                new Produto()
                {
                    Codigo = "002",
                    Descricao = "Parafuso",
                    Quantidade = 15
                },

                new Produto()
                {
                    Codigo = "003",
                    Descricao = "Engrenagem",
                    Quantidade = 8
                }
            };
        }

        private void EditarProduto_Click(object sender, RoutedEventArgs e)
        {
            Button botao = (Button)sender;

            Produto produto = (Produto)botao.Tag;

            MessageBox.Show(
                $"Produto: {produto.Descricao}");
        }
    }


}
