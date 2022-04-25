﻿using jet.Bean.model;
using jet.Config;
using jet.Repository.interfaces;

using Microsoft.EntityFrameworkCore;

namespace jet.Repository
{
    public class BaseDicRepository : IBaseDicRepository
    {
        private readonly EFCoreContext _dbContext;

        public BaseDicRepository(EFCoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public BaseDic GetById(string id)
        {
            return _dbContext.Set<BaseDic>().FromSqlRaw("select * from base_dic where id = ?", id).Single();
        }
    }
}