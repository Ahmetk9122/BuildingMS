using BuildingMS.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMS.Entity.Dto
{
    public class DtoLoginU : DtoBase
    {
        [Required]
        [StringLength(maximumLength: 200)]
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.Password)]
        public string UserPass { get; set; }
    }
}
