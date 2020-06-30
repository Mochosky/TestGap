using Appointments.Models;
using Appointments.Services.DataObjects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Appointments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpGet]
        public List<PatientDto> Get()
        {
            List<PatientDto> rst = new List<PatientDto>();
            rst.Add(new PatientDto
            {
                DateOfBirth = DateTime.Now.AddYears(-33),
                Document = "1128050484",
                DocumentType = DocType.CC,
                Email = "mochosky@gmail.com",
                Name = "Jaime",
                Surname = "Echenique",
                Telephone = "3006893236"
            });

            return rst;
        }
    }
}
