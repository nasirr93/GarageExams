using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GarageExams
{
    internal class Exam
    {
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public int Point { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
