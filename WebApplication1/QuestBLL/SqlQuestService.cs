using DTOModels.Model;
using EntityModels.Model;
using QuestBLL.Interfaces;
using QuestDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestBLL
{
    public class SqlQuestService : IService
    {
        IRepository<QuestEntity> _questRepos;

        public SqlQuestService(IRepository<QuestEntity> questRepos)
        {
            _questRepos = questRepos;
        }

        public IEnumerable<QuestDTO> GetQuests()
        {
            return null;
        }
    }
}
