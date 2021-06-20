using ExamWpfApp.Data;
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
    /// Логика взаимодействия для QuestionForm.xaml
    /// </summary>
    public partial class QuestionForm : Window
    {
        DbDapper service;
        List<Question> questions;
        DateTime startTime;
        public User user;
        
        public QuestionForm()
        {
            InitializeComponent();

            startTime = DateTime.Now;

            service = new DbDapper();

            questions = service.SelectQuestions().ToList();

            lb_q1.Content = questions[0].Issue;
            lb_q2.Content = questions[1].Issue;
            lb_q3.Content = questions[2].Issue;
            lb_q4.Content = questions[3].Issue;
            lb_q5.Content = questions[4].Issue;
        }

        private void bt_result_Click(object sender, RoutedEventArgs e)
        {
            int result = 0;
            if(tb_q1.Text == questions[0].Answer)
            {
                result++;
            }
            if (tb_q2.Text == questions[1].Answer)
            {
                result++;
            }
            if (tb_q3.Text.ToLower() == questions[2].Answer.ToLower())
            {
                result++;
            }
            if (tb_q4.Text == questions[3].Answer)
            {
                result++;
            }
            if (tb_q5.Text.ToLower() == questions[4].Answer.ToLower())
            {
                result++;
            }

            Result result1 = new Result();
            result1.FIO = user.Surname +" "+ user.Name;

            AboutQuestion question = new AboutQuestion();
            question.CountRightAnswer = result;
            question.CountQuestions = questions.Count;
            question.Procent = (result * 100) / questions.Count;
            question.Time = (DateTime.Now.Subtract(startTime)).ToString();

            result1.Procent = (result * 100) / questions.Count;
            result1.Time = (DateTime.Now.Subtract(startTime)).ToString();
            result1.Date = DateTime.Now;

            service.CreateResult(result1);

            ResultForm resultForm = new ResultForm();
            resultForm.aboutQuestion = question;
            resultForm.Show();
            this.Close();
        }

        private void tb_q1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void tb_q2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void tb_q4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
