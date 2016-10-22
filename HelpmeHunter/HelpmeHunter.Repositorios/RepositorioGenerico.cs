using HelpmeHunter.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace HelpmeHunter.Repositorios
{
    public class RepositorioGenerico<T> where T : class
    {
        internal readonly HelpmeHunterEntities context;
        internal readonly DbSet<T> dbSet;

        public RepositorioGenerico(HelpmeHunterEntities context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

        public virtual IQueryable<T> Query(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).AsQueryable();
            }
            else
            {
                return query;
            }
        }

        public virtual IEnumerable<T> Listar(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            return Query(filter, orderBy, includeProperties).AsEnumerable();
        }

        public virtual T Obtener(
            Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter).FirstOrDefault();
        }

        public virtual T Obtener(object id)
        {
            return dbSet.Find(id);
        }

        public virtual void Agregar(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Eliminar(object id)
        {
            T entityToDelete = Obtener(id);
            Eliminar(entityToDelete);
        }

        public virtual void Eliminar(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Actualizar(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Actualizar(T entityToUpdate, Func<T, int> getKey)
        {
            var entry = context.Entry<T>(entityToUpdate);

            if (entry.State == EntityState.Detached)
            {
                T attachedEntity = dbSet.Find(getKey(entityToUpdate));

                if (attachedEntity != null)
                {
                    var attachedEntry = context.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entityToUpdate);
                }
                else
                {
                    entry.State = EntityState.Modified;
                }
            }
        }

        public virtual void Desmarcar(T entity)
        {
            context.Entry(entity).State = EntityState.Unchanged;
        }

        public virtual IQueryable<T> Queryable()
        {
            return dbSet.AsQueryable<T>();
        }

        public virtual void Guardar()
        {
            context.SaveChanges();
        }
    }
}
