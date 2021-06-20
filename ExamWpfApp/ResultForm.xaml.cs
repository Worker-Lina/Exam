using ExamWpfApp.Models;
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
    /// Логика взаимодействия для ResultForm.xaml
    /// </summary>
    public partial class ResultForm : Window
    {
        public AboutQuestion aboutQuestion;

        public ResultForm()
        {
            InitializeComponent();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tb_count.Content = aboutQuestion.CountQuestions.ToString();
            tb_answer.Content = aboutQuestion.CountRightAnswer.ToString();
            tb_procent.Content = aboutQuestion.Procent.ToString() + "%";
            tb_time.Content = aboutQuestion.Time.ToString();
        }
    }
}
