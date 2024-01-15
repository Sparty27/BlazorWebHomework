using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebHomework.Models
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; } = string.Empty;
        public string StudentLastName { get; set; } = string.Empty;
        public string StudentGroupName { get; set; } = string.Empty;
        public double StudentAvgScore { get; set; }
        public DateTime StudentRegistrationDate { get; set; }
    }
}
