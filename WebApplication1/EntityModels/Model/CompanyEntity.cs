using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModels.Model
{
    public class CompanyEntity : BaseModel
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string Logo { get; set; }

        public List<QuestEntity> Quest { get; set; }
    }
}
