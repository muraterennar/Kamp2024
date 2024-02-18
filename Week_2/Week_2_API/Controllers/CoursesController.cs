using Application.CourseServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Week_2_API.Controllers;

[Route("api/[controller]")]
public class CoursesController : Controller
{
    private readonly ICourseService _courseService;

    public CoursesController (ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public IActionResult GetAll ()
    {
        List<Course> response = _courseService.GetAll();
        return Ok(response);
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById ([FromRoute] int id)
    {
        Course response = _courseService.GetById(id);
        return Ok(response);
    }

    [HttpPost("Add")]
    public IActionResult Add ([FromBody] Course course)
    {
        string? response = _courseService.Add(course);
        return Ok(response);
    }

    [HttpPut("Update")]
    public IActionResult Update ([FromBody] Course course)
    {
        string? response = _courseService.Update(course);
        return Ok(response);
    }

    [HttpDelete("Delete/{id}")]
    public IActionResult Delete ([FromRoute] int id)
    {
        string? response = _courseService.Delete(id);
        return Ok(response);
    }
}