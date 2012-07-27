using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FormUtility;

namespace StubbyTheWonderApp
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StringTable gender = new StringTable();
            gender.setIndexes(
                StringTableEntry.NumericCode, 
                StringTableEntry.LetterCode, 
                StringTableEntry.FullText, 
                "requireSecondOfficer"
                );
            gender.addItem("1", "m", "Male", "false");
            gender.addItem("2", "f", "Female", "true");
            gender.addItem("99", "u", "Unknown", "true");

            gender["Male", StringTableEntry.FullText][StringTableEntry.NumericCode] = "3";

            int value = int.Parse(gender["Male", StringTableEntry.FullText][StringTableEntry.NumericCode]); //retrieve numeric code for a Male            
            
            StringTable bob = new StringTable();

            MessageBox.Show(value.ToString());
        }
    }
}
