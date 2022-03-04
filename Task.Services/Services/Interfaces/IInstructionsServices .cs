using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Services.DTOs;

namespace Task.Services.Services.Interfaces
{
    public interface IInstructionsServices
    {
        public string TaskDetails();
        public List<InstructionsDTO> FirstSteps(int pageSize);
    }
}
