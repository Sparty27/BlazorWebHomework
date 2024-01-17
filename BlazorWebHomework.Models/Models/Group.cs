using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebHomework.Models 
{ 
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public int GroupFacultyId { get; set; }
        public string GroupFacultyName { get; set; } = string.Empty;
        public int GroupNumStudents { get; set; }
        public double GroupAvgScore { get; set; }
    }
}
