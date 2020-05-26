using Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class GenericService<T> where T: class, new()
    {
       
        DataContext dataContext;

        public GenericService(DataContext Context)
        {
            dataContext = Context;
        }

        public T GetNew()
        {
            try
            {
                return new T();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<T> GetAll()
        {
            try
            {
                return dataContext.Set<T>().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Get(object Id)
        {
            try
            {
                return dataContext.Set<T>().Find(Id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
