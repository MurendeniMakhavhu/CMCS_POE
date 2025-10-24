using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
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
    public partial class LecturerClaimForm : Window
    {
        private CMCSDBEntities _context = new CMCSDBEntities();
        private string _uploadedFilePath = null;

        public LecturerClaimForm()
        {
            InitializeComponent();
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Documents (*.pdf;*.docx;*.xlsx)|*.pdf;*.docx;*.xlsx",
                Title = "Select Supporting Document"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string projectFolder = AppDomain.CurrentDomain.BaseDirectory;
                string uploadFolder = System.IO.Path.Combine(projectFolder, "Uploads");

                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                string fileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                string destination = System.IO.Path.Combine(uploadFolder, fileName);

                File.Copy(openFileDialog.FileName, destination, true);

                _uploadedFilePath = destination;
                lblFileName.Text = fileName;

                MessageBox.Show("📎 File uploaded successfully!");
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 var claim = new Claim
                {
                    LecturerName = txtLecturerName.Text,
                    HoursWorked = Convert.ToDecimal(txtHours.Text),
                    HourlyRate = Convert.ToDecimal(txtRate.Text),
                    Status = "Pending",
                    SupportingDocumentPath = _uploadedFilePath
                };


                _context.Claims.Add(claim);
                _context.SaveChanges();

                MessageBox.Show("✅ Claim submitted successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error submitting claim: {ex.Message}");
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            LecturerPortal lecturerPortal = new LecturerPortal();
            lecturerPortal.Show();
            this.Close();
        }
    }
}