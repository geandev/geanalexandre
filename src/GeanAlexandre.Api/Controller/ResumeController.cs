using System.Threading.Tasks;
using GeanAlexandre.Context.Domain.Query;
using GeanAlexandre.Context.Domain.QueryHandler;
using Microsoft.AspNetCore.Mvc;

namespace GeanAlexandre.Api.Controller
{
    [Route("api/[controller]")]
    public class ResumeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IGetUserQueryHandler _getUserQueryHandler;

        public ResumeController(
            IGetUserQueryHandler getUserQueryHandler
        )
        {
            _getUserQueryHandler = getUserQueryHandler;
        }

        [HttpGet]
        [Route("{userName}")]
        public async Task<IActionResult> Get(string userName)
        {
            try
            {
                return await _getUserQueryHandler.ExecuteAsync(GetUserQuery.CreateCommand(userName))
                    .ContinueWith(task => Ok(task.Result));
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}