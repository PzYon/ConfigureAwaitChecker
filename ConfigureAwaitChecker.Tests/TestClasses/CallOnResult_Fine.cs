﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigureAwaitChecker.Tests.TestClasses
{
    public class CallOnResult_Fine : TestClassBase
    {
        public async Task FooBar()
        {
            var array = (await Enumerable().ConfigureAwait(false)).ToArray();
        }
    }
}