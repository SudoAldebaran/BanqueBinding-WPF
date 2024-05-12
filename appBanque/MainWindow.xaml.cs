using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using dllBanque;
using Microsoft.Win32;

namespace appBanque
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Banque laBanque = null;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Fichiers data |*.data";
            dialog.ShowDialog();
            try
            {
                String nomFichier = dialog.FileName;
                this.laBanque = SerializeBanque.deserialize(nomFichier);
            }
            catch 
            {
                MessageBox.Show("format non valide");
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            try
            {
                dialog.Filter = "Fichiers data |*.data";
                dialog.ShowDialog();
                String nomFichier = dialog.FileName;
                SerializeBanque.serialize(this.laBanque, nomFichier);
            }
            catch 
            {
                MessageBox.Show("format non valide");
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            if (this.laBanque == null)
                MessageBox.Show("il faut charger le fichier data!!");
            else { 
                LesComptesWindow c = new LesComptesWindow(this.laBanque);
                c.Show();
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Avez-vous bien sauvegardé vos modifications ?","fermer l'application",MessageBoxButton.OKCancel);
            if( MessageBoxResult.OK == result)
                  Application.Current.MainWindow.Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            if (this.laBanque == null)
            {
                MessageBox.Show("Veuillez charger le fichier Data");
            }
            else
            {
                filtreCompteWindow c = new filtreCompteWindow(this.laBanque);
                c.Show();
            }
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            if (this.laBanque == null)
                MessageBox.Show("il faut charger le fichier data!!");
            else
            {
                UnCompteWindow c = new UnCompteWindow(this.laBanque);
                c.Show();
            }
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            if(this.laBanque == null)
            {
                MessageBox.Show("Veuillez charger le fichier Data");
            }
            else
            {
                ajoutCompte c = new ajoutCompte(this.laBanque);
                c.Show();
            }
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            if(this.laBanque == null) 
            {
                MessageBox.Show("Veuillez charger le fichier Data");
            }
            else
            {
                statistiques c = new statistiques(this.laBanque);
                c.Show();
            }
        }
        
    }
}
