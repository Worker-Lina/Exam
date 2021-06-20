using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWpfApp.Models
{
    public class Result
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Time {get;set;}
        public string FIO { get; set; }
        public int Procent { get; set; }
    }
}
