﻿using Dk.DataAccess.Abstract;
using Dk.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dk.DataAccess.Concrete.EntityFramework
{

    //GEREKLİ OLAN OPERASYONLARI GERÇEKLEŞTİRİR VE TABLOLAR İÇİN BURDAN ÇEKERİZ. REPOSİTORY İMPLEMENTASYONU YAPIYORUZ.
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        public void Add(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }


        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using(TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using(TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() :   //FİLTERE BOŞ MU "?" DİYE BAK ,BOŞSA HEPSİNİ LİSTELE.
                context.Set<TEntity>().Where(filter).ToList();              //":"DEĞİLSE ŞARTIMIZ İLE FİLTREYE GÖRE LİSTELE. 
            }
            
            
        }

        
    }
}
