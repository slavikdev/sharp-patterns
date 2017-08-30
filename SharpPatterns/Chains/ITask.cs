// Copyright (C) 2017 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com

namespace SharpPatterns.Chains
{
    using JetBrains.Annotations;


    /// <summary>
    /// Defines a task which can be executed in a chain.
    /// </summary>
    public interface ITask<T>
    {
        /// <summary>
        /// Runs this task.
        /// </summary>
        /// <param name="previous">The previous task result.</param>
        /// <returns>Task result.</returns>
        [UsedImplicitly]
        T Run( T previous );
    }
}
