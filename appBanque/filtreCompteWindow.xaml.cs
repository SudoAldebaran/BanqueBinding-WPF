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
    /// Logique d'interaction pour filtreCompteWindow.xaml
    /// </summary>
    public partial class filtreCompteWindow : Window
    {
        private Banque laBanque;
        public filtreCompteWindow(Banque b)
        {
            InitializeComponent();
            // code pour charger la listBox
            for (int i = -10000; i <= 10000; i = i + 1000)
            {
                this.lstSolde.Items.Add(i);
            }

            this.laBanque = b;
            //this.gridSolde.ItemsSource = this.laBanque.mesComptes;

            
        }

        private void lstSolde_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int iSolde = Convert.ToInt32(this.lstSolde.SelectedItem);
            // code à compléter

            this.afficheSolde.Text = $"{iSolde}";

            List<Compte> compteList = new List<Compte>();


            foreach (Compte compte in this.laBanque.mesComptes)
            {
                if (compte.solde <= iSolde)
                {
                    compteList.Add(compte);
                }


            }

            this.gridSolde.ItemsSource = compteList;
        }
    }
}
