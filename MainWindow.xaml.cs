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
using System.Text.RegularExpressions;

namespace SOUKSAMLANE_LEXTRAIT_TP2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // the "??" operator checks for nullability and value all at once.
            // because ConvertCheckBox.IsChecked is of type __bool ?__ which
            // is a nullable boolean, so it can either be true, false or null
            var toDecrypt = ConvertCheckBox.IsChecked ?? false;
            var inputText = InputTextBox.Text;
            var encryptionmethod = EncryptionComboBox.Text;
            var vigener_Key = vigenere_key.Text;

            if (toDecrypt)
            {
                Result.Content = $"Decrypted with : {encryptionmethod} algorithm";
            }
            else
            {
                Result.Content = $"Encrypted with : {encryptionmethod} algorithm";
            }

            //If the user choose to use the Caesar encryption
            if (encryptionmethod == "Caesar")
            {
                OutputTextBox.Text = Caesar.Code(inputText, toDecrypt);
            }

            //If the user choose to use the Binary encryption
            if (encryptionmethod == "Binary")
            {
                //If the user choose to decrypt an input text
                if (toDecrypt)
                {
                    //If the input is not in binary language (0,1), we send an error
                    if (Regex.IsMatch(inputText, "^[01]*$"))
                    {
                        OutputTextBox.Text = Binary.Code(inputText, toDecrypt);
                    }
                    else
                    {
                        Result.Content = "¤¤¤¤¤¤ ERROR ¤¤¤¤¤¤";
                        OutputTextBox.Text = "Please enter only 0 and/or 1";
                    }
                }
                else
                {
                    OutputTextBox.Text = Binary.Code(inputText, toDecrypt);
                }
            }

            //If the user choose to use the Vigenere encryption
            if (encryptionmethod == "Vigenere")
            {
                //Secured input which excludes spaces, special characters, and converts all lower case letter into uper case letter
                if ((Regex.IsMatch(vigenere_key.Text, "^[A-Za-z]*$")) && (Regex.IsMatch(inputText, "^[A-Za-z]*$")))
                {
                    OutputTextBox.Text = Vigenere.Code(inputText.ToUpper(), vigener_Key.ToUpper(), toDecrypt);
                }
                else
                {
                    Result.Content = "¤¤¤¤¤¤ ERROR ¤¤¤¤¤¤";
                    OutputTextBox.Text = "Please enter only CAPITAL letters such as A, B or Z";
                }
                
            }
        }
        private void Checkbox_Clic(object sender, RoutedEventArgs e)         
        {
            var toDecrypt = ConvertCheckBox.IsChecked ?? false; 
            
            if (toDecrypt)
            {
                decodeButton.Content = "Decrypt !";
            }            
            else 
            {
                decodeButton.Content = "Encrypt !"; 
            }                          
        }         
        private void ComboBox_Change(object sender, RoutedEventArgs e)         
        {             
            
            string text = ((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string;             
            if (vigenere_key != null)             
            {                 
                if (text == "Vigenere") 
                { 
                    vigenere_keyBox.Visibility = Visibility.Visible; 
                }                 
                else 
                { 
                    vigenere_keyBox.Visibility = Visibility.Collapsed; 
                }              
            }          
        }
        private void EncryptionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
