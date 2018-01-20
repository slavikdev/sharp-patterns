// Copyright (C) 2018 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace SharpPatterns.Chains
{
    using JetBrains.Annotations;

    /// <summary>
    /// Defines a task which can be executed in a chain.
    /// </summary>
    public interface IChainedTask<T>
    {
        #region Api

        /// <summary>
        /// Runs this task.
        /// </summary>
        /// <param name="previous">The previous task result.</param>
        /// <returns>Task result.</returns>
        [UsedImplicitly]
        T Run( T previous );

        #endregion
    }
}