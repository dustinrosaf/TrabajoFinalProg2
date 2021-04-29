using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public interface IQueryHandler<in TMessage, TResult>
    {
        Task<TResult> Handle(TMessage message, CancellationToken cancellationToken);
    }
}