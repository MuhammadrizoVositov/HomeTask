using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace result
{
    public class resultmodel
    {
        public Guid UserId { get; set; }
        public Guid TestId { get; set; }
        public Guid ExamId { get; set; }
        public Guid CategoryId { get; set; }
        public decimal TestResult { get; set; }
        public decimal ExamResult { get; set; }
        public bool IsDelete { get; set; }
    }
}
