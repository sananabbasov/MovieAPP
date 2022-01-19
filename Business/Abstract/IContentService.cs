﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContentService
    {
        List<Content> GetAll();
        List<Content> GetAllByCategoryById(int categoryId);
        List<HomeContentsDto> GetFreeFilms(string lang);
        List<ContentListDto> GetContenstDetails();
        List<MovieDetailDto> GetContentDetails(int id, string langs);
        List<MovieDetailDto> GetSubscriberContentDetails(int id, string langs);
    }
}
