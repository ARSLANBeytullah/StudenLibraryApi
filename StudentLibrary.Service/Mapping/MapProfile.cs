using AutoMapper;
using StudentLibrary.Core.Dtos;
using StudentLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Service.Mapping
{
    internal class MapProfile : Profile
    {
        public MapProfile()  //Code Refactoring yapılacak. AuthorMapping,StudentMapping vs. sınıfları oluşturulup ilgili entity'nin ilgili kodları kendi sınıfına yazılacak.
                      
        {
            CreateMap<AuthorAddDto, Author>();
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>();

            CreateMap<StudentDto, Student>().ReverseMap();
            CreateMap<StudentUpdateDto, Student>();
            CreateMap<StudentAddDto, Student>();

            CreateMap<OperationDto, Operation>().ReverseMap();
            CreateMap<OperationUpdateDto, Operation>();
            CreateMap<OperationAddDto, Operation>();


            CreateMap<BookDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>();
            CreateMap<BookAddDto, Book>();


        }
    }
}
