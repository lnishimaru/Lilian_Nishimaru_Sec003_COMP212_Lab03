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

namespace Lilian_Nishimaru_Sec003_COMP212_Lab03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double total = 0;
            double[] hst = { 0.07, 0.13, 0.06 };
           
            if (ValidateEntries())
            {
                //calculate services 
                if (flossingCheckBox.IsChecked == true)
                {
                    total = total + 20;
                }
                if (rootCanalCheckBox.IsChecked == true)
                {
                    total = total + 75;
                }
                if (fillingCheckBox.IsChecked == true)
                {
                    total = total + 150;
                }

                //calculate discount 
                if (seniorRadioButton.IsChecked == true)
                {
                    total = total * 0.90;
                }
                if (kidsRadioButton.IsChecked== true)
                {
                    total = total * 0.85;
                }

                //calculate HST
                total = total * (1 + hst[provinceComboBox.SelectedIndex]);

                resultTextBox.Text = $"Your total is {total:C}";
            }
        }
        public bool ValidateEntries()
        {
            if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                resultTextBox.Text = "Please, inform the patient's name";
                nameTextBox.Focus();
                return false;
            } 
            if (String.IsNullOrEmpty(addressTextBox.Text))
            {
                resultTextBox.Text = "Please, inform the patient's address";
                addressTextBox.Focus();
                return false;
            }
            if (provinceComboBox.SelectedIndex == -1)
            {
                resultTextBox.Text = "Please, select one Province";
                provinceComboBox.Focus();
                return false;
            }
            if (flossingCheckBox.IsChecked == false &&
                rootCanalCheckBox.IsChecked == false &&
                fillingCheckBox.IsChecked == false)
            {
                resultTextBox.Text = "Please, select at least one service";
                flossingCheckBox.Focus();
                return false;
            }
            resultTextBox.Clear();
            return true;
        }
        
    }
}
