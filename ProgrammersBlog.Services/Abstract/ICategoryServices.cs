﻿using ProgrammersBlog.Entities.Concreate;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Dtos;

namespace ProgrammersBlog.Services.Abstract
{
   public interface ICategoryServices
   {
       Task<IDataResult<Category>> Get(int categoryId);
       Task<IDataResult<IList<Category>>> GetAll();
       Task<IDataResult<IList<Category>>> GetAllByNonDeleted(); 
       Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
       Task<IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
       Task<IResult> Delete(int categoryId);
       Task<IResult> HardDelete(int categoryId);
   }
}
