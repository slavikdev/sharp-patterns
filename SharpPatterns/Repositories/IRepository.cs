// Copyright (C) 2018 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace SharpPatterns.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines a repository which can add, remove and get objects from a storage.
    /// </summary>
    /// <typeparam name="TEntity">The type of entities managed by the repository.</typeparam>
    /// <typeparam name="TId">The type of entity ID.</typeparam>
    public interface IRepository<TEntity, in TId> where TEntity : class
    {
        #region Public Methods

        /// <summary>
        /// Adds entity to the repository.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add( TEntity entity );

        /// <summary>
        /// Adds a set of entities to the repository.
        /// </summary>
        /// <param name="entities">The set of entities.</param>
        void AddRange( IEnumerable<TEntity> entities );

        /// <summary>
        /// Finds entities in the repository by given condition.
        /// </summary>
        /// <param name="predicate">The condition.</param>
        /// <returns>Set of entities which match given condition.</returns>
        IEnumerable<TEntity> Find( Expression<Func<TEntity, bool>> predicate );

        /// <summary>
        /// Gets a single entity by given ID.
        /// </summary>
        /// <param name="id">The ID.</param>
        /// <returns>Entity with given ID.</returns>
        TEntity Get( TId id );

        /// <summary>
        /// Gets all entities stored in the repository.
        /// </summary>
        /// <returns>List of entities.</returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Removes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        void Remove( TEntity entity );

        /// <summary>
        /// Removes a range of entities from the repository.
        /// </summary>
        /// <param name="entities">The entities to remove.</param>
        void RemoveRange( IEnumerable<TEntity> entities );

        #endregion
    }
}