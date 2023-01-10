using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UserTaskService.Api.Application.Commands.UserTask;
using TrialsSystem.UserTaskService.Api.Application.Queries.UserTask;
using TrialsSystem.UserTaskService.Infrastructure.Models.UserTaskDTOs;

namespace TrialsSystem.UserTaskService.Api.Controllers.v1
{
    [Route("api/v1/{userId}/[controller]")]
    //[ServiceFilter(typeof(UserExceptionFilter))]
    [ApiController]
    public class UserTasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserTasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetUserTasksResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null)
        {
            var response = await _mediator.Send(new UserTasksQuery(take, skip));
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new UserTaskQuery(id));
            return Ok(response);
        }


        [HttpPost]
        [ProducesResponseType(typeof(CreateUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(CreateUserTaskRequest request)
        {
            var response = await _mediator.Send(new CreateUserTaskCommand(request.Email,
                                                                             request.Name,
                                                                             request.Surname,
                                                                             request.CityId,
                                                                             request.BirthDate,
                                                                             request.Weight,
                                                                             request.Height,
                                                                             request.GenderId));
            return Ok(response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(string id, UpdateUserTaskRequest request)
        {
            var response = await _mediator.Send(new UpdateUserTaskCommand(
                id,
                request.Name,
                request.Surname,
                request.CityId,
                request.BirthDate,
                request.Weight,
                request.Height));

            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var response = await _mediator.Send(new DeleteUserTaskCommand(id));
            return Ok(response);
        }
    }
}
