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

namespace Student_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentList sl = new StudentList();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = sl;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!SName.Text.Trim().Equals(string.Empty) && !Department.Text.Trim().Equals(string.Empty))
            {
                sl.Additem(SName.Text.Trim(), Department.Text.Trim());
            }
            else
            {
                MessageBox.Show("Enter the Box.", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            SName.Text = "";
            Department.Text = "";
            StudentListView.Items.Refresh();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            sl.Save();
        }

        private void EditMenuClick(object sender, RoutedEventArgs e)
        {
            if (StudentListView.SelectedItem != null)
            {
                EditPopup ep = new EditPopup(StudentListView.SelectedItem as StudentItem);
                ep.Owner = this;
                ep.ShowDialog();
                StudentListView.Items.Refresh();
            }
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (StudentListView.SelectedItem != null)
            {
                MessageBoxResult del = MessageBox.Show("Delete this Student?", "Delete?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
                if (del == MessageBoxResult.Yes)
                {
                    sl.DeleteItem(StudentListView.SelectedItem as StudentItem);
                }
                StudentListView.Items.Refresh();
            }
        }
    }
}
