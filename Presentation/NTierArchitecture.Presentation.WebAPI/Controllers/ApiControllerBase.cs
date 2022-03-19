using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NTierArchitecture.Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ApiControllerBase<T> : ControllerBase
    {
        protected readonly ILogger<T> _logger;

        public ApiControllerBase(
            ILogger<T> logger
        )
        {
            _logger = logger;

        }
    }
}
