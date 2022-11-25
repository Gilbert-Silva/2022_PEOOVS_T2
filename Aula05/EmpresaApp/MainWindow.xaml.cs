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

namespace EmpresaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Empresa emp;

        private void btnEmpresa_Click(object sender, RoutedEventArgs e)
        {
            emp = new Empresa(txtEmpresa.Text);
            MessageBox.Show(emp.ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cliente x = new Cliente(txtCliente.Text,
                double.Parse(txtLimite.Text));
            emp.Inserir(x);
            // Insere um a um os objetos no ListBox
            // listCliente.Items.Add(x);
            // Insere um vetor num ListBox
            listCliente.ItemsSource = null;
            listCliente.ItemsSource = emp.Listar2();
        }
    }
}
