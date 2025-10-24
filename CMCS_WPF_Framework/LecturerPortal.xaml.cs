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

using System.Linq;
using System.Windows;

namespace CMCS_WPF_Framework
{
    public partial class LecturerPortal : Window
    {
        private CMCSDBEntities _context = new CMCSDBEntities();
        private string _loggedLecturer = " "; 

        public LecturerPortal()
        {
            InitializeComponent();
        }

        // Open the form to submit new claim
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            LecturerClaimForm claimForm = new LecturerClaimForm();
            claimForm.Show();
            this.Close();
        }

        // View all claims submitted by this lecturer
        private void ViewMyClaims_Click(object sender, RoutedEventArgs e)
        {
            var myClaims = _context.Claims
                .Where(c => c.LecturerName == _loggedLecturer)
                .ToList();

            if (myClaims.Any())
            {
                ClaimsDataGrid.ItemsSource = myClaims;
                ClaimsDataGrid.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("No claims found for your name.");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
