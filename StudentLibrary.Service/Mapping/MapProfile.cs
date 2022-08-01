﻿using AutoMapper;
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
        public MapProfile()
        {
            CreateMap<AuthorAddDto, Author>();
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>();
        }
    }
}