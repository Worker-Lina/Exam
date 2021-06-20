using ExamWpfApp.Data;
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
    /// Логика взаимодействия для ReceiptForm.xaml
    /// </summary>
    public partial class ReceiptForm : Window
    {
        DbDapper service;
        public ReceiptForm()
        {
            InitializeComponent();
            service = new DbDapper();
        }

        private void bt_find_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(dp_start.Text) || string.IsNullOrEmpty(dp_end.Text))
            {
                MessageBox.Show("Выберите дату", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                dg_results.ItemsSource = service.SelectResult(DateTime.Parse(dp_start.Text), DateTime.Parse(dp_end.Text));
            }
        }
    }
}
