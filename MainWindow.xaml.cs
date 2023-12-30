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

namespace WpfBasics
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

        private void applyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is {this.descriptionInputBox.Text}");
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            this.weldCheckbox.IsChecked = this.assemblyCheckbox.IsChecked = this.plasmaCheckbox.IsChecked = this.laserCheckbox.IsChecked
                = this.purchseCheckbox.IsChecked = this.latheCheckbox.IsChecked = this.drillCheckbox.IsChecked = this.foldCheckbox.IsChecked
                = this.rollCheckbox.IsChecked = this.sawCheckbox.IsChecked = false;
            this.lengthTextBox.Text = this.massTextBox.Text= this.supplierNameTextBox.Text = "";
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.lengthTextBox.Text += (String)((CheckBox)sender).Content + " ";
        }

        private void FinishComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.noteText == null) 
                return;

            var combo = (ComboBox)sender;   

            var value = (ComboBoxItem)combo.SelectedValue;

            this.noteText.Text = (String)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishComboBox_SelectionChanged(this.finishCombobox, null);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.massTextBox.Text = this.supplierNameTextBox.Text;
        }
    }

}
