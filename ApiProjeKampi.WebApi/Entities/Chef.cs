using ApiProjeKampi.WebApi.Controllers;
using System.ComponentModel.DataAnnotations;

namespace ApiProjeKampi.WebApi.Entities
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        // Many-to-many navigation
        public List<EmployeeTaskChef> EmployeeTaskChefs { get; set; }
    }
}
