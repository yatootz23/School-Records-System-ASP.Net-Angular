using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.models
{
    public class Section
    {
        public required string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int GradeLevel { get; set; }
        public string? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public List<Student> Students { get; set; } = [];
        public List<Class> Classes { get; set; } = [];
    }
}