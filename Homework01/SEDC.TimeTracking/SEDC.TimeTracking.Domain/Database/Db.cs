using SEDC.TimeTracking.Domain.Entities;
using SEDC.TimeTracking.Domain.Enums;
using SEDC.TimeTracking.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TimeTracking.Domain.Database
{
    public class Db<T> : IDb<T> where T : BaseEntity
    {
        private List<T> _dB;
        public int _idCount;
        public Db()
        {
            _dB = new List<T>();
            _idCount = 1;
        }
        

        public List<T> GetAll()
        {
            return _dB;
        }
                

        public T GetUserById(int id)
        {
            return _dB.FirstOrDefault(user => user.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = _idCount;
            _dB.Add(entity);
            _idCount++;
            return entity.Id;
        }

        public void RemoveUser(int id)
        {
            T entity = _dB.FirstOrDefault(user => user.Id == id);
            if(entity != null)
            {
                _dB.Remove(entity);
            }
        }

        public void UpdateUser(T entity)
        {
            T user = _dB.FirstOrDefault(user => user.Id == entity.Id);
            user = entity;
        }
       
    }
}
