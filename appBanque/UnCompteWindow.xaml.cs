using dllBanque;
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
using System.Windows.Shapes;

namespace appBanque
{
    /// <summary>
    /// Logique d'interaction pour UnCompteWindow.xaml
    /// </summary>
    public partial class UnCompteWindow : Window
    {
        private Banque laBanque;
        public UnCompteWindow(Banque b)
        {
            InitializeComponent();
            this.laBanque = b;
            this.lstComptes.ItemsSource = b.mesComptes;
            this.lstComptes.DisplayMemberPath = "numero";    
            
        }
    }
}
