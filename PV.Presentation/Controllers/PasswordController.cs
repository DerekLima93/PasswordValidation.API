using Microsoft.AspNetCore.Mvc;
using PV.Domain;
using PV.Domain.Interface;
using System.ComponentModel.DataAnnotations;

namespace PV.Presentation.Controllers
{
    public class PasswordController : ControllerBase
    {
        private IRepository _repository;
        public PasswordController(IRepository repository) => _repository = repository;

        /// <summary>
        /// Check if the password is valid
        /// </summary>
        /// <param name="password">Text</param>
        /// <returns>True|False</returns>
        [HttpGet]
        [Route("password/{password}")]
        public IActionResult Get([Required]string password)
        {
            if (password== null)
            {
                return NotFound();
            }

            return Ok(_repository.Validation(password));
        }
    }
}
