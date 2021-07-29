using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Kenobi.Core.Application.Quotes.Queries.GetQuote
{
    public class GetQuoteQuery: IRequest<string>
    {
        public class GetQuoteQueryHandler : IRequestHandler<GetQuoteQuery, string>
        {
            Random random = new Random();
            List<string> quotes = new List<string> { "Who’s the more foolish? The fool or the fool who follows him?", "An elegant weapon for a more civilized age", "These aren’t the droids you’re looking for.", "Mos Eisley spaceport.You will never find a more wretched hive of scum and villainy." , "The Force will be with you... always" };


            public async Task<string> Handle(GetQuoteQuery request, CancellationToken cancellationToken) => await GetQuoteAsync(cancellationToken);

            private async ValueTask<string> GetQuoteAsync(CancellationToken cancellationToken)
            {
                await Task.Delay(5);
                int index = random.Next(quotes.Count);
                return quotes[index];
            }
        }
    }
}
