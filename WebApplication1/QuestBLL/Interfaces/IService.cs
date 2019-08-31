using DTOModels.Model;
using EntityModels.Model;
using QuestDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QuestBLL.Interfaces
{
    public interface IService
    {
        Task<List<QuestDTO>> GetQuestsAsync();
    }
}
