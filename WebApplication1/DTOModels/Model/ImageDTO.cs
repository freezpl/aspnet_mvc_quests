using System;
using System.Collections.Generic;
using System.Text;

namespace DTOModels.Model
{
    public class ImageDTO
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public QuestDTO Quest { get; set; }
    }
}
