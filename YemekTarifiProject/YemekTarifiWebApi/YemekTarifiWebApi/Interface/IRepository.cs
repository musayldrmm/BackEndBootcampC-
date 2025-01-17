﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Interface
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
      List<TEntity> GetAll();

        Task<TEntity> GetById(int id);
        Task Create (TEntity entity);
        Task Update (TEntity entity);
        Task Delete (int id);
    }
}
