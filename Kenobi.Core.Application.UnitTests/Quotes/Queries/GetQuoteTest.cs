using Kenobi.Core.Application.Quotes.Queries.GetQuote;
using Shouldly;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Kenobi.Core.Application.UnitTests
{
    public class GetQuoteTest
    {

        [Fact]
        public async Task Handle_ReturnsValue()
        {
            var query = new GetQuoteQuery();

            var handler = new GetQuoteQuery.GetQuoteQueryHandler();

            var result = await handler.Handle(query,CancellationToken.None);

            result.ShouldBeOfType<string>();
           
        }
    }
}
