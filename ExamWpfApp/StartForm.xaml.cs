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

namespace ExamWpfApp
{
    /// <summary>
    /// Логика взаимодействия для StartForm.xaml
    /// </summary>
    public partial class StartForm : Window
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void mi_receipt_Click(object sender, RoutedEventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            receiptForm.ShowDialog();
        }

        private void mi_data_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void bt_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
