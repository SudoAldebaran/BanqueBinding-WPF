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
    /// Logique d'interaction pour statistiques.xaml
    /// </summary>
    public partial class statistiques : Window
    {
        private Banque laBanque;
        public statistiques(Banque b)
        {
            InitializeComponent();

            this.laBanque = b;

            double nbComptes = 0;
            double soldeTotal = 0;
            double soldeMax = double.MinValue;
            double soldeMin = double.MaxValue;
            double soldeNeg = 0;

            foreach(Compte c in this.laBanque.mesComptes)
            {
                if (c.solde > soldeMax)
                {
                    soldeMax = c.solde;
                }
                if (c.solde < soldeMin)
                {
                    soldeMin = c.solde;
                }
                if (c.solde < 0)
                {
                    soldeNeg++;
                }
                soldeTotal = soldeTotal + c.solde;
                nbComptes++;
            }

            this.nombreComptes.Text = nbComptes.ToString();
            this.soldeMoyen.Text = (soldeTotal / nbComptes).ToString("0.00");
            this.soldeMax.Text = soldeMax.ToString();
            this.soldeMin.Text = soldeMin.ToString();
            this.nbSoldesNegatifs.Text = soldeNeg.ToString();

        }
    }
}
