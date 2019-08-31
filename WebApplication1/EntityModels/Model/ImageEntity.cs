using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityModels.Model
{
    public class ImageEntity : BaseModel
    {
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string Path { get; set; }

        public int QuestId { get; set; }
        public QuestEntity Quest { get; set; }
    }
}
