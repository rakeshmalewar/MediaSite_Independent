using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DH.Media.Core.Persistence
{
    public interface IMediaRepository<TEntity> where TEntity : class
    {
        #region Interface Methods
        /// <summary>
        /// Saves all transaction changes 
        /// </summary>
        /// <returns></returns>
        Task<bool> SaveChangesAsync();
        /// <summary>
        /// Gets all objects
        /// </summary>
        /// <returns>Returns IQueryable object</returns>
        IQueryable<TEntity> All();

        /// <summary>
        /// Finds the object based on expression
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>Returns object</returns>
        TEntity FindBy(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// FilterBy passed expression and returns IQueryable objects
        /// </summary>
        /// <param name="expression">expression</param>
        /// <returns>Returns IQueryable objects</returns>
        IQueryable<TEntity> FilterBy(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Finds entity by passed Id
        /// </summary>
        /// <param name="id">Primary key Id</param>
        /// <returns>Entity object</returns>
        TEntity FindBy(int id);

        /// <summary>
        /// Adds new entity
        /// </summary>
        /// <param name="entity">entity object</param>       
        /// <returns>Primary Key Id generated</returns>
        void Add(TEntity entity);

        /// <summary>
        /// Adds collection of entities
        /// </summary>
        /// <param name="items">IEnumerable objects</param>        
        /// <returns>returns Boolean</returns>
        void Add(IEnumerable<TEntity> items);

        /// <summary>
        /// Updates Entity
        /// </summary>
        /// <param name="entity">entity object</param>       
        /// <returns>returns Boolean</returns>
        void Update(TEntity entity);

        /// <summary>
        /// Updates list of Entities
        /// </summary>
        /// <param name="items">IEnumerable objects</param>    
        /// <returns></returns>
        void Update(IEnumerable<TEntity> items);

        /// <summary>
        /// Deletes passed entity
        /// </summary>
        /// <param name="entity"></param>      
        /// <returns>returns Boolean</returns>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes all the passed IEnumerable entities.
        /// </summary>
        /// <param name="entities">IEnumerable objects</param>      
        /// <returns>returns Boolean</returns>
        void Delete(IEnumerable<TEntity> entities);

        /// <summary>
        /// gets entity based on includes and filter 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, params string[] includes);

        #endregion
    }
}
