using System.Threading.Tasks;


namespace CSharpFunctionalExtensions
{
    public static class AsyncMaybeExtensions
    {
        public static async Task<Result<T>> ToValidResult<T>(this Task<Maybe<T>> maybeTask, string errorMessage, bool continueOnCapturedContext = true)
            where T : class
        {
            Maybe<T> maybe = await maybeTask.ConfigureAwait(continueOnCapturedContext);
            return maybe.ToValidResult(errorMessage);
        }
    }
}
