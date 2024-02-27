using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.models
{
    public class Class
    {
        public required string Id { get; set; }
        public required string SectionId { get; set; }
        public required Section Section { get; set; }
        public required string SubjectId { get; set; }
        public required Subject Subject { get; set; }
        public string? TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

    }
}