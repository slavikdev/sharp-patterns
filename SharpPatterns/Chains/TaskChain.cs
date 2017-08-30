// Copyright (C) 2017 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com

namespace SharpPatterns.Chains
{
    using System.Linq;


    /// <summary>
    /// The tasks chain which executes tasks in the order 
    /// they were passed to the chain.
    /// </summary>
    /// <typeparam name="T">Task return type.</typeparam>
    /// <seealso cref="SharpPatterns.Chains.ITaskChain{T}" />
    public sealed class TaskChain<T> : ITaskChain<T>
    {
        #region Init

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskChain{T}"/> class.
        /// </summary>
        /// <param name="initial">The initial value passed to the first task.</param>
        /// <param name="tasks">
        /// The tasks, sorted in the order they need to be executed.
        /// </param>
        public TaskChain( T initial, params ITask<T>[] tasks )
        {
            _initial = initial;
            _tasks = tasks;
        }

        #endregion


        #region Api

        /// <summary>
        /// Runs this chain of tasks.
        /// </summary>
        /// <returns>Last task result.</returns>
        public T Run()
        {
            return _tasks.Aggregate( 
                _initial, 
                ( current, task ) => task.Run( current ) 
            );
        }

        #endregion


        #region Fields

        private readonly ITask<T>[] _tasks;
        private readonly T _initial;

        #endregion
    }
}
