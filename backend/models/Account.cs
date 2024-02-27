using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace backend.models
{
    public class Account: IdentityUser
    {
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string? Suffix { get; set; }
        public string Gender { get; set; } = string.Empty;
        public DateOnly DoB { get; set; }
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class Student: Account{
        public int GradeLevel { get; set; }
        public string? SectionId { get; set; }
        public Section? Section { get; set; }
        public List<Grade> Grades { get; set; } =[];
    }

    public class Teacher: Account{
        public string? SectionId { get; set; }
        public Section? Section { get; set; }
        public List<Class> Classes { get; set; } = [];
        public List<Grade> Grades { get; set; } =[];
        
    }
}