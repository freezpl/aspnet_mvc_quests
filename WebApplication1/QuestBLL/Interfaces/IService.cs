using DTOModels.Model;
using EntityModels.Model;
using QuestDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestBLL.Interfaces
{
    public interface IService
    {
        IEnumerable<QuestDTO> GetQuests();
    }
}
