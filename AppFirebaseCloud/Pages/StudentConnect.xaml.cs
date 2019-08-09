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
    public partial class StudentConnect : Page
    {
        Firebase firebase;

        public StudentConnect()
        {
            InitializeComponent();
            firebase = new Firebase();
            var status = firebase.isConnection();

            if (status)
                lblConnecStatus.Content = "Ayarlar yüklendi.";
            else
                lblConnecStatus.Content = "Ayarlar yüklenemedi.";
        }
    }
}
