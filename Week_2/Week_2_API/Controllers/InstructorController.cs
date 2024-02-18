using Application.InstructorServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
namespace Week_2_API.Controllers;

[Route("api/[controller]")]
public class InstructorController : Controller
{
    private readonly IInstructorService _instructorService;

    public InstructorController (IInstructorService instructorService)
    {
        _instructorService = instructorService;
    }

    [HttpGet]
    public IActionResult GetAll ()
    {
        List<Instructor> response = _instructorService.GetAll();
        return Ok(response);
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById ([FromRoute] int id)
    {
        Instructor response = _instructorService.GetById(id);
        return Ok(response);
    }

    [HttpPost("Add")]
    public IActionResult Add ([FromBody] Instructor instructor)
    {
        string? response = _instructorService.Add(instructor);
        return Ok(response);
    }

    [HttpPut("Update")]
    public IActionResult Update ([FromBody] Instructor instructor)
    {
        string? response = _instructorService.Update(instructor);
        return Ok(response);
    }

    [HttpPut("Delete/{id}")]
    public IActionResult Update ([FromBody] int id)
    {
        string? response = _instructorService.Delete(id);
        return Ok(response);
    }
}