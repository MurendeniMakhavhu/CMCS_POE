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
using Microsoft.Win32;

namespace CMCS_WPF_Framework
{
    /// <summary>
    /// Interaction logic for LecturerClaimForm.xaml
    /// </summary>
    public partial class LecturerClaimForm : Window
    {
        public LecturerClaimForm()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            // File dialog to pick supporting document
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documents|*.pdf;*.docx;*.xlsx";

            if (openFileDialog.ShowDialog() == true)
            {
                txtFileName.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim submitted successfully! (Prototype only)");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            LecturerPortal lecturerPortal = new LecturerPortal();
            lecturerPortal.Show();
            this.Close();
        }

    }
}
