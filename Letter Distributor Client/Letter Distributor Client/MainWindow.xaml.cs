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
using Microsoft.Win32;

namespace Letter_Distributor_Client
{
    public partial class MainWindow : Window
    {
        private FileLoader _fileLoader;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            string fileAsBase64String = _fileLoader.GetFileAsBase64String();
            var fileVerifier = new FileVerifier();

            if (!fileVerifier.IsPDFHeader(selectedText.Content.ToString()))
            {
                MessageBox.Show("Error: Could not load the selected file");
            }
            else
            {
                var letter = new Letter(name.Text, address.Text, int.Parse(postalCode.Text), referenceId.Text, fileAsBase64String);
                SendService.SendLetter(letter);
            }
        }

        private void SelectFile_Click(object sender, RoutedEventArgs e)
        {
            _fileLoader = new FileLoader();
            _fileLoader.SelectFile();
            selectedText.Content = _fileLoader.getFilePath();
        }
    }
}
