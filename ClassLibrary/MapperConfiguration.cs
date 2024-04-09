using AutoMapper;
using ClassLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MapperConfiguration :Profile
    {
        public MapperConfiguration()
        {
            CreateMap<Author, AuthorDtoCreate>();
            CreateMap<AuthorDtoCreate, Author>();

            //edit
            CreateMap<Author,AuthorDtoEdit>().ReverseMap();

        }
    }
}
