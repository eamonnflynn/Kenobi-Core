using Kenobi.Core.Application.Quotes.Queries.GetQuote;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Kenobi.Core.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return await Mediator.Send(new GetQuoteQuery());
        }
    }
}
