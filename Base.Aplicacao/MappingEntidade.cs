﻿using AutoMapper;
using Base.Aplicacao.DTO;
using Base.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Prato, PratoDTO>();
            CreateMap<PratoDTO, Prato>();
        }
    }
}
