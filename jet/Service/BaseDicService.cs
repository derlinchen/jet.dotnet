﻿using jet.Bean.dto;
using jet.Bean.model;
using jet.Bean.vo;
using jet.Repository.interfaces;
using jet.Service.interfaces;
using jet.Utils;

namespace jet.Service
{
    public class BaseDicService : IBaseDicService
    {
        private IBaseDicRepository _baseDicRepository;

        public BaseDicService(IBaseDicRepository baseDicRepository)
        {
            _baseDicRepository = baseDicRepository;
        }


        public void SaveBaseDic(BaseDicDto item)
        {
            BaseDic baseDic = BeanUtils<BaseDicDto, BaseDic>.Trans(item);
            _baseDicRepository.SaveItem(baseDic);
        }


        public void DeleteBaseDic(string id)
        {
            _baseDicRepository.DeleteItemById(id);
        }

        public void UpdateBaseDic(BaseDicDto item)
        {
            BaseDic baseDic = BeanUtils<BaseDicDto,BaseDic>.Trans(item);
            _baseDicRepository.UpdateItem(baseDic);
        }

        public List<BaseDicVo> GetBaseDicList(BaseDicDto item)
        {
            return _baseDicRepository.GetBaseDicList(item);
        }
    }
}
