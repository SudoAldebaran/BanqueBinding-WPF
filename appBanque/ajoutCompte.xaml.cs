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
    /// Logique d'interaction pour ajoutCompte.xaml
    /// </summary>
    public partial class ajoutCompte : Window
    {
        private Banque laBanque;
        
        public ajoutCompte(Banque b)
        {
            InitializeComponent();
            laBanque = b;
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            while (string.IsNullOrEmpty(num.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(sold.Text) || string.IsNullOrEmpty(dec.Text))
            {
                MessageBox.Show("Champs vides !!");
                return;
            }

            

            string newNum = this.num.Text;
            string newName = this.name.Text;
            double newSolde;
            double newDecouvert;

            while (!double.TryParse(sold.Text, out newSolde) || !double.TryParse(dec.Text, out newDecouvert))
            {
                MessageBox.Show("Vous devez insérer des nombres dans Solde ou Découvert !");
                return;
            }


                Compte nouveauCompte = new Compte
            {
                numero = newNum,
                nom = newName,
                solde = newSolde,
                decouvertAutorise = newDecouvert,
            };

            // Ajouter le compte à la liste

            if (laBanque.RendCompte(newNum) != null) 
            {
                MessageBox.Show("Ce numéro de compte existe déjà");
            }
            else
            {
                laBanque.ajouterCompte(nouveauCompte);
            }
            

            

            numAffiche.Text = newNum;
            nameAffiche.Text = newName;
            soldAffiche.Text = newSolde.ToString();
            decAffiche.Text = newDecouvert.ToString();


        }
    }
}
