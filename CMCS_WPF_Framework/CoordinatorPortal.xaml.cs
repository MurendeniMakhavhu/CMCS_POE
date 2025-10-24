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
    public partial class CoordinatorPortal : Window
    {
        private CMCSDBEntities _context = new CMCSDBEntities();

        public CoordinatorPortal()
        {
            InitializeComponent();
        }

        private void ViewPendingClaims_Click(object sender, RoutedEventArgs e)
        {
            var pendingClaims = _context.Claims
                .Where(c => c.Status == "Pending")
                .ToList();

            ClaimsDataGrid.ItemsSource = pendingClaims;
            ClaimsDataGrid.Visibility = Visibility.Visible;
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            var claim = (sender as Button).DataContext as Claim;
            if (claim != null)
            {
                claim.Status = "Approved";
                _context.SaveChanges();
                MessageBox.Show("✅ Claim approved!");
                ViewPendingClaims_Click(null, null); // Refresh list
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            var claim = (sender as Button).DataContext as Claim;
            if (claim != null)
            {
                claim.Status = "Rejected";
                _context.SaveChanges();
                MessageBox.Show("❌ Claim rejected!");
                ViewPendingClaims_Click(null, null); // Refresh list
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