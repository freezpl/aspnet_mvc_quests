using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityModels.Model
{

    public class QuestEntity : BaseModel
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "Text")]
        public string Description { get; set; }

        public TimeSpan WalkTime { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int MinAge { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [MaxLength(255)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [Range(0.0, 10.0)]
        public double Raiting { get; set; }

        [Range(0, 5)]
        public int FearLevel { get; set; }

        [Range(0, 5)]
        public int HardLevel { get; set; }

        //Navigation properties
       // public int CompanyId { get; set; }
        public CompanyEntity Company { get; set; }
        public List<ImageEntity> Images { get; set; }
    }
}