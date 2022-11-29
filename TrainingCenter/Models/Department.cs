using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainingCenter.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        
        //Navigation Property
        public List<Student> Students { get; set; }
        // Navigation
        public int Manager { get; set; }
        public Instructor ManagerId { get; set; }

        public DateTime HireDate { get; set; }

        
    }
}
