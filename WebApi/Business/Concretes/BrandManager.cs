﻿using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //business rules
            Brand brand = new();
            brand.Name = createBrandRequest.Name;

            _brandDal.Add(brand);

            CreatedBrandResponse 
        }

        public List<GetAllBrandResponse> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
