using MediatR;

namespace BuildingBlocks.CQRS;



public interface IQueryHandler<in TQuery, TRespense> 
    : IRequestHandler<TQuery, TRespense>
    where TQuery : IQuery<TRespense>
    where TRespense : notnull
{
}
