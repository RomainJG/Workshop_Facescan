using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Workshop_Facescan.ViewModel;

namespace Workshop_Facescan
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = new MainWindowVM();

            listEmploye.DataContext=vm.persons;           

        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                imgPhoto.Source = new BitmapImage(new Uri(openFileDialog.FileName));            
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int idPerson = vm.AddAndGetPerson(nom.Text, prenom.Text, role.SelectedValue.ToString());
            vm.AddImage(System.IO.Path.GetFileName(imgPhoto.Source.ToString()), System.IO.Path.GetExtension(imgPhoto.Source.ToString()), 0 , imgPhoto.Source.ToString(), idPerson);
            vm.AddPresence(idPerson);


        }

        
    }
}
