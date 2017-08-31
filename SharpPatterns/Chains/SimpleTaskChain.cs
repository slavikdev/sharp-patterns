// Copyright (C) 2017 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace SharpPatterns.Chains
{
    /// <summary>
    /// The tasks chain which executes tasks in the order 
    /// they were passed to the chain.
    /// </summary>
    /// <seealso cref="SharpPatterns.Chains.ISimpleTaskChain" />
    public sealed class SimpleTaskChain : ISimpleTaskChain
    {
        #region Init

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleTaskChain"/> class.
        /// </summary>
        /// <param name="tasks">
        /// The tasks, sorted in the order they need to be executed.
        /// </param>
        public SimpleTaskChain( params ISimpleChainedTask[] tasks )
        {
            _tasks = tasks;
        }

        #endregion


        #region Api

        /// <summary>
        /// Runs this chain of tasks.
        /// </summary>
        public void Run()
        {
            foreach ( ISimpleChainedTask chained_task in _tasks )
            {
                chained_task.Run();
            }
        }

        #endregion


        #region Fields

        private readonly ISimpleChainedTask[] _tasks;

        #endregion
    }
}
