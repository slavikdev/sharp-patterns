﻿// Copyright (C) 2017 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com

namespace Tests.Chains.TaskChain.TestTasks
{
    using SharpPatterns.Chains;


    public sealed class Incrementor : ITask<int>
    {
        #region Api

        public int Run( int previous )
        {
            return ++previous;
        }

        #endregion
    }
}