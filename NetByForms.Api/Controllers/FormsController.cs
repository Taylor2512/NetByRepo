using MediatR;
using Microsoft.AspNetCore.Mvc;
using NetByForms.Application.Models.Dto;
using NetByForms.Application.Models.Request.Command;
using NetByForms.Application.Models.Request.Query;

namespace NetByForms.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormsController(IMediator mediator) : ControllerBase
    {
        /// <summary>
        /// Creates a new form.
        /// </summary>
        /// <param name="command">The command containing form data.</param>
        /// <returns>The ID of the created form.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateForm([FromBody] CreateFormCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var formId = await mediator.Send(command);
                return CreatedAtAction(nameof(GetForm), new { id = formId }, formId);
            }
            catch (Exception ex)
            {
                // Detailed error logging
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets all forms.
        /// </summary>
        /// <returns>A list of forms.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FormDto>))]
        public async Task<ActionResult<IEnumerable<FormDto>>> GetAllForms()
        {
            try
            {
                var forms = await mediator.Send(new GetAllFormQuery());
                return Ok(forms);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets a form by ID.
        /// </summary>
        /// <param name="id">The ID of the form.</param>
        /// <returns>The form with the specified ID.</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FormDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<FormDto>> GetForm(Guid id)
        {
            try
            {
                var form = await mediator.Send(new GetFormQuery { Id = id });
                if (form == null)
                {
                    return NotFound();
                }
                return Ok(form);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a form by ID.
        /// </summary>
        /// <param name="id">The ID of the form to delete.</param>
        /// <returns>No content if the form was deleted.</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteForm(Guid id)
        {
            var result = await mediator.Send(new DeleteFormCommand { Id = id });
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}