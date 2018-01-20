// Copyright (C) 2018 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace SharpPatterns.Chains
{
    using JetBrains.Annotations;

    /// <summary>
    /// Defines a chain of tasks.
    /// </summary>
    public interface ITaskChain<out T>
    {
        #region Api

        /// <summary>
        /// Runs this chain of tasks.
        /// </summary>
        /// <returns>The result of the last task in chain.</returns>
        [UsedImplicitly]
        T Run();

        #endregion
    }
}