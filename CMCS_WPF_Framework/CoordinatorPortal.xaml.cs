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
        private List<Claim> _claims;

        public CoordinatorPortal()
        {
            InitializeComponent();
        }

        private void ViewPendingClaims_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get all pending claims from the database
                _claims = _context.Claims
                    .Where(c => c.Status == "Pending")
                    .ToList();

                if (_claims.Count == 0)
                {
                    MessageBox.Show("No pending claims found.");
                    return;
                }

                ClaimsDataGrid.ItemsSource = _claims;
                ClaimsDataGrid.Visibility = Visibility.Visible;
            }
            catch
            {
                MessageBox.Show("⚠️ Error loading claims. Check your database connection.");
            }
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            if (ClaimsDataGrid.SelectedItem is Claim selectedClaim)
            {
                selectedClaim.Status = "Approved";
                _context.SaveChanges();
                MessageBox.Show("✅ Claim approved!");
                ViewPendingClaims_Click(sender, e); // Refresh grid
            }
            else
            {
                MessageBox.Show("Please select a claim first.");
            }
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            if (ClaimsDataGrid.SelectedItem is Claim selectedClaim)
            {
                selectedClaim.Status = "Rejected";
                _context.SaveChanges();
                MessageBox.Show("❌ Claim rejected.");
                ViewPendingClaims_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a claim first.");
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