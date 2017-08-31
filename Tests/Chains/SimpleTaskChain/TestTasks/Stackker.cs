// Copyright (C) 2017 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace Tests.Chains.SimpleTaskChain.TestTasks
{
    using System;
    using System.Collections.Generic;
    using SharpPatterns.Chains;


    public sealed class Stackker : ISimpleChainedTask
    {
        #region Init

        public Stackker( IList<int> list )
        {
            _list = list;
        }

        #endregion


        #region Api

        public void Run()
        {
            _list.Add( new Random().Next() );
        }

        #endregion


        #region Fields

        private readonly IList<int> _list;

        #endregion
    }
}
