using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HidControllers.Sample
{
    public interface IExample
    {
        string FullName { get; }
        IReadOnlyCollection<string> ShortNames { get; }
        Task ExecuteAsync(CancellationToken token = default);
    }
}