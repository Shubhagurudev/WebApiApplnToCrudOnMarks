using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarksWebApi.Models
{
    public class StudentModel
    {
        public int StudentRollNo { get; set; }
        public string StudentName { get; set; }
        public string ClassId { get; set; }
        public string SubjectName { get; set; }
    }
}