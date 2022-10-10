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

namespace Wpf_Basics
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: " + DescriptionText.Text);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            WeldCheckbox.IsChecked = AssemblyCheckbox.IsChecked = PlasmaCheckbox.IsChecked = LaserCheckbox.IsChecked = PurchaseCheckbox.IsChecked = LatheCheckbox.IsChecked = DrillCheckbox.IsChecked = FoldCheckbox.IsChecked = RollCheckbox.IsChecked = SawCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            LengthText.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(NoteText == null)
            {
                return;
            }

            NoteText.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }
    }
}
