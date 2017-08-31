// Copyright (C) 2017 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace SharpPatterns.Chains
{
    using JetBrains.Annotations;


    /// <summary>
    /// Defines a task which can be executed in a chain and doesn't produce any result.
    /// </summary>
    public interface ISimpleChainedTask
    {
        #region Api

        /// <summary>
        /// Runs this task.
        /// </summary>
        [UsedImplicitly]
        void Run();

        #endregion
    }
}
