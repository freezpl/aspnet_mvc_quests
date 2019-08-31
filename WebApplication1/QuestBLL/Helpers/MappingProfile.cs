using AutoMapper;
using DTOModels.Model;
using EntityModels.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuestBLL.Helpers
{
    class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<QuestEntity, QuestDTO>().ForMember(nameof(QuestDTO.MainImage), opt => opt.MapFrom(src=>
                (src.Images == null || src.Images.Count == 0) ? "default.jpg" : src.Images[0].Path));

            CreateMap<ImageEntity, ImageDTO>();
            CreateMap<CompanyEntity, CompanyDTO>();
        }
    }
}
