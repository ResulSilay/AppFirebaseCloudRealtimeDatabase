using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public partial class StudentInsert : Page
    {
        Firebase firebase;

        public StudentInsert()
        {
            InitializeComponent();
            firebase = new Firebase();
        }

        private async void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student()
            {
                Id = int.Parse(txtStudentId.Text),
                Name = txtStudentName.Text,
                Department = txtStudentDepartment.Text,
                Mail = txtStudentMail.Text,
                Phone = txtStudentPhone.Text,
                Address = txtStudentAddress.Text
            };

            bool status = await firebase.Insert(student);

            if (status)
                MessageBox.Show("Saved");
            else
                MessageBox.Show("Not Saved");
        }
    }
}