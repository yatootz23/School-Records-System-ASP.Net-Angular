using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Patterns;

namespace backend.models
{
    public class Grade
    {
        public required string Id { get; set; }
        public required string SubjectId { get; set; }
        public required Subject Subject { get; set; }
        public required string StudentId { get; set; }
        public required Student Student { get; set; }
        public required string TeacherId { get; set; }
        public required Teacher Teacher { get; set; }
        public int Quarter { get; set; }
        public double FinalGrade { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}