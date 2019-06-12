﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ConfigureAwaitChecker.Lib;

namespace ConfigureAwaitChecker.Tests.TestClasses
{
	[CheckerTests.ExpectedResult(CheckerProblem.NoProblem)]
	public class AwaitExtensionConfigureAwait_Fine : TestClassBase
	{
		public async Task FooBar()
		{
			await new Awaitable().ConfigureAwait(false);
		}

		public class Awaitable
		{
			public TaskAwaiter GetAwaiter() => default;
		}
	}

	static class AwaitExtensionConfigureAwait_Fine_AwaitableExtensions
	{
		public static ConfiguredTaskAwaitable ConfigureAwait(this AwaitExtensionConfigureAwait_Fine.Awaitable @this, bool continueOnCapturedContext) => default;
	}
}
