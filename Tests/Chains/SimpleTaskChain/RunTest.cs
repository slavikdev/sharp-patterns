// Copyright (C) 2018 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace Tests.Chains.SimpleTaskChain
{
    using System.Collections.Generic;
    using NUnit.Framework;
    using SharpPatterns.Chains;
    using TestTasks;

    [TestFixture]
    public sealed class RunTest
    {
        [Test]
        public void Run()
        {
            var list = new List<int>();
            ISimpleChainedTask[] tasks = {
                new Stackker( list ),
                new Stackker( list )
            };
            var chain = new SimpleTaskChain( tasks );
            chain.Run();

            Assert.AreEqual( tasks.Length, list.Count );
        }
    }
}