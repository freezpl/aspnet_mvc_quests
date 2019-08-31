using System;
using System.Collections.Generic;
using System.Text;

namespace DTOModels.Model
{
    public class CompanyDTO
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public List<QuestDTO> Quest { get; set; }
    }
}
