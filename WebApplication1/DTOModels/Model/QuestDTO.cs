using System;
using System.Collections.Generic;
using System.Text;

namespace DTOModels.Model
{
    public class QuestDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainImage { get; set; }

        public TimeSpan WalkTime { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int MinAge { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Raiting { get; set; }
        public int FearLevel { get; set; }
        public int HardLevel { get; set; }

        public CompanyDTO Company { get; set; }
        public List<ImageDTO> Images { get; set; }
    }
}
