using Auctions.Application.Bets;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuctionsApp.Controllers.Bets
{
    /// <summary>
    /// Контроллер для работы со ставками
    /// </summary>
    [Route("api/v1/auctions/lots/bets")]
    public class BetsController : BaseController
    {
        private readonly IMediator _mediator;

        public BetsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Сделать ставку
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> DoBetAsync(DoBetCommand command, CancellationToken cancellationToken)
        {
            return ConvertToActionResult(await _mediator.Send(command, cancellationToken));
        }
    }
}
