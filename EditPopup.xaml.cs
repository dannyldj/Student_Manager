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

namespace Student_Manager
{
    /// <summary>
    /// Interaction logic for EditPopup.xaml
    /// </summary>
    public partial class EditPopup : Window
    {
        public EditPopup(StudentItem item)
        {
            InitializeComponent();
            DataContext = item;
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (!Department.Text.Trim().Equals(string.Empty))
            {
                (DataContext as StudentItem).Department = Department.Text.Trim();
                Close();
            }
        }
    }
}
