﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Data_Access_Layer.Repository.Contracts.Interfaces
{
    public interface IGenericRepository<T>
    {
        public Task<IEnumerable<T>> Get_Information();
    }
}
