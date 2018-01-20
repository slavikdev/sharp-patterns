// Copyright (C) 2018 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace SharpPatterns.Chains
{
    using JetBrains.Annotations;

    /// <summary>
    /// Defines a chain of tasks which don't return any result.
    /// </summary>
    public interface ISimpleTaskChain
    {
        #region Api

        /// <summary>
        /// Runs this chain of tasks.
        /// </summary>
        [UsedImplicitly]
        void Run();

        #endregion
    }
}