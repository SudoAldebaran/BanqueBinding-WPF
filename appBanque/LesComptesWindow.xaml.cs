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
    /// Logique d'interaction pour LesComptesWindow.xaml
    /// </summary>
    public partial class LesComptesWindow : Window
    {
        private Banque laBanque;
        public LesComptesWindow(Banque b)
        {
            InitializeComponent();
            this.laBanque = b;
            this.dtGrid.ItemsSource = this.laBanque.mesComptes;
            
        }
    }
}
