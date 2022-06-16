using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAY1.DTO
{
    public class TaskModelDTO
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public bool IsCompeted { get; set; }
    }
}