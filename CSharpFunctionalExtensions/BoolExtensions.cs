using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFunctionalExtensions
{
	public static class BoolExtensions
	{
		/// <summary>
		/// When bool value is true returns Result.Success otherwise Result.Fail 
		/// </summary>
		/// <param name="val"></param>
		/// <param name="error"></param>
		/// <returns></returns>
		public static Result ToResult(this bool val, string error)
		{
			return Maybe<bool>.From(val).ToValidResult(error)
				.OnSuccess(x => x ? Result.Success() : Result.Fail(error));
		}
	}
}
