using SEDC.TimeTracking.Domain.Entities;
using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Interfaces
{
    public interface IDb<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetUserById(int id);
        int Insert(T entity);
        void UpdateUser(T entity);
        void RemoveUser(int id);
        
    }
}
