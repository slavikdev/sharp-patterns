// Copyright (C) 2017 Viacheslav Shynkarenko (aka Slavik Shynkarenko).
// All Rights Reserved.
// slavik@slavikdev.com
// https://www.slavikdev.com

namespace Tests.Chains.TaskChain
{
    using NUnit.Framework;
    using SharpPatterns.Chains;
    using TestTasks;


    [TestFixture]
    public sealed class RunTest
    {
        [Test]
        public void Run()
        {
            ITask<int>[] tasks = {
                new Incrementor(),
                new Incrementor(),
                new Incrementor()
            };
            var chain = new TaskChain<int>( 0, tasks );
            int result = chain.Run();

            Assert.AreEqual( tasks.Length, result );
        }
    }
}
