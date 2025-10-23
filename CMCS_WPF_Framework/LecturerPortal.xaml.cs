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

namespace CMCS_WPF_Framework
{
    /// <summary>
    /// Interaction logic for LecturerPortal.xaml
    /// </summary>
    public partial class LecturerPortal : Window
    {
        public LecturerPortal()
        {
            InitializeComponent();
        }

        // This is the logic for your Back button
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // Create a new MainWindow instance
            MainWindow main = new MainWindow();

            // Show the Main Menu again
            main.Show();

            // Close the current Lecturer Portal window
            this.Close();
        }

    }
}
