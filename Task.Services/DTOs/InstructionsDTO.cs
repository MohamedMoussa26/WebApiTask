using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Services.DTOs
{
    public class InstructionsDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string describtion { get; set; }
        public string details { get; set; }
        public int order { get; set; }
    }
}
