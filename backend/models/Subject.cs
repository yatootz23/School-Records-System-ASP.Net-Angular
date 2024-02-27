using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.models
{
    public class Subject
    {
        public required string Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int GradeLevel { get; set; }
        public string? Sylabus { get; set; }
    }
}