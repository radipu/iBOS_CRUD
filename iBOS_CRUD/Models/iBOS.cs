using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iBOS_CRUD.Models
{
    public class iBOS
    {
        [Key]
        public int intColdDrinksId { get; set; }
        [Required(ErrorMessage ="Please enter drink name")]
        public string strColdDrinksName { get; set; }
        public decimal numQuantity { get; set; }
        public decimal numUnitPrice { get; set; }
    }
}
