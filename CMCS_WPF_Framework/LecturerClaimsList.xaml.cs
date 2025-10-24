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
    public partial class LecturerClaimsList : Window
    {
        private CMCSDBEntities _context = new CMCSDBEntities();

        public LecturerClaimsList()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Load all claims (later you can filter by lecturer name if you want)
            var claims = _context.Claims.ToList();
            ClaimsDataGrid.ItemsSource = claims;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            LecturerPortal portal = new LecturerPortal();
            portal.Show();
            this.Close();
        }
    }
}