using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Services.DTOs;
using Task.Services.Services.Implementations;
using Task.Services.Services.Interfaces;

namespace WebApiTask.Controllers
{
    [Route("api/Instructions")]
    [ApiController]
    public class InstructionsController : ControllerBase
    {
        IInstructionsServices instructionsServices;

        public InstructionsController(IInstructionsServices _instructionsServices)
        {
            instructionsServices = _instructionsServices;
        }

        [HttpGet]
        [Route("GetTaskDetails")]
        public string GetTaskDetails()
        {   
            return this.instructionsServices.TaskDetails();  
        }

        [HttpGet]
        [Route("GetFirstStep")]
        public List<InstructionsDTO> GetFirstStep(int pageSize)
        {
            return this.instructionsServices.FirstSteps(pageSize);
        }

    }
}
