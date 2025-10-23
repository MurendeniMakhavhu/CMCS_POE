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

namespace CMCS_WPF_Framework
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

        private void Lecturer_Click(object sender, RoutedEventArgs e)
        {
            LecturerPortal lecturerPortal = new LecturerPortal();
            lecturerPortal.Show();
            this.Close();
        }

        private void Coordinator_Click(object sender, RoutedEventArgs e)
        {
            CoordinatorPortal coordinatorPortal = new CoordinatorPortal();
            coordinatorPortal.Show();
            this.Close();
        }

    }
}

