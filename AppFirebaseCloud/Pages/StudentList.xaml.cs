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

namespace AppFirebaseCloud.Pages
{
    public partial class StudentList : Page
    {
        Firebase firebase;
        Student student;

        public StudentList()
        {
            InitializeComponent();
            firebase = new Firebase();
            firebase.isConnection();
        }

        private async void dataGridStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                student = dataGridStudents.SelectedItem as Student;
            }
            catch { }
        }

        private async void btnMenuDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(student.Id.ToString());

            bool status = await firebase.Delete(student);

            if (status)
                MessageBox.Show("Deleted");
            else
                MessageBox.Show("Not Deleted");
        }

        private async void btnList_Click(object sender, RoutedEventArgs e)
        {
            dataGridStudents.ItemsSource = await firebase.List();
        }
    }
}
