using ExamWpfApp.Data;
using ExamWpfApp.Models;
using NLog;
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

namespace ExamWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DbDapper service;
        static Logger logger = LogManager.GetCurrentClassLogger();
        public MainWindow()
        {
            InitializeComponent();
            service = new DbDapper();
        }

        private void bt_next_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User user = new User();
                user.Age = int.Parse(tb_age.Text);
                user.Surname = tb_surname.Text;
                user.Name = tb_name.Text;
                service.CreateUser(user);
                logger.Info("Добавлен пользователь");

                QuestionForm questionForm = new QuestionForm();
                questionForm.user = user;
                questionForm.Show();
                this.Close();
            }catch(Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
