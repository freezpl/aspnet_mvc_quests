using AutoMapper;
using DTOModels.Model;
using EntityModels.Model;
using QuestBLL.Helpers;
using QuestBLL.Interfaces;
using QuestDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace QuestBLL
{
    public class SqlQuestService : IService
    {
        IRepository<QuestEntity> _questRepos;
        IMapper _mapper;

        public SqlQuestService(IRepository<QuestEntity> questRepos)
        {
            _questRepos = questRepos;

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            _mapper = mappingConfig.CreateMapper();
        }

        public async Task<List<QuestDTO>> GetQuestsAsync()
        {
            IEnumerable<QuestEntity> questsEntities = _questRepos.GetWithInclude(q=>q.Company, i=>i.Images); 
            return _mapper.Map<IEnumerable<QuestDTO>>(questsEntities).ToList();
        }
    }
}