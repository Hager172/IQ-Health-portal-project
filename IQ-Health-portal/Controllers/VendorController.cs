using IQHealthPortal.Application.Features.vendor.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IQ_Health_portal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VendorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{vendorId}/services")]
        public async Task<IActionResult> GetVendorWithServices(string vendorId)
        {
            var result = await _mediator.Send(
                new GetVendorWithServicesQuery(vendorId));

            return Ok(result);
        }

    }
}
