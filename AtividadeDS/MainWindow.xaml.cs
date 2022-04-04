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
using AtividadeDS.WindowsWpf;
using BibliotecaMsg;


namespace AtividadeDS
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        
        string usuario = "admin";
        string senha = "admin";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            WpfCadastro wpf = new WpfCadastro();
            wpf.ShowDialog();
        }

        private void btnEntrarLogin_Click(object sender, RoutedEventArgs e)
        {
            if ((usuario == Convert.ToString(txtUsuario.Text)) && (senha == Convert.ToString(pswSenha.Password)))
            {
                txtUsuario.Clear();
                pswSenha.Clear();
                WpfConversaoMoeda wpf = new WpfConversaoMoeda();
                wpf.ShowDialog();
            }
            else
            {
                if ((VrsGlobais.usuario == Convert.ToString(txtUsuario.Text)) && (VrsGlobais.senha == Convert.ToString(pswSenha.Password)))
                {
                    txtUsuario.Clear();
                    pswSenha.Clear();
                    WpfConversaoMoeda wpf = new WpfConversaoMoeda();
                    wpf.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos!");
                  
                }
            }
        }
    }
}
