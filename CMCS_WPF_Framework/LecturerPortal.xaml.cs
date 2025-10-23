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
    public partial class LecturerPortal : Window
    {
        public LecturerPortal()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Open the Lecturer Claim Form
            LecturerClaimForm form = new LecturerClaimForm();
            form.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // Go back to Main Menu
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}