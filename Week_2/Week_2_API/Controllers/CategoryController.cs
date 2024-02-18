using Application.CategortServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Week_2_API.Controllers;

[Route("api/[controller]")]
public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoryController (ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult GetAll ()
    {
        List<Category> response = _categoryService.GetAll();
        return Ok(response);
    }

    [HttpGet("GetById/{id}")]
    public IActionResult GetById ([FromRoute] int id)
    {
        Category response = _categoryService.GetById(id);
        return Ok(response);
    }

    [HttpPost("Add")]
    public IActionResult Add ([FromBody] Category category)
    {
        string? response = _categoryService.Add(category);
        return Ok(response);
    }

    [HttpPut("Update")]
    public IActionResult Update ([FromBody] Category category)
    {
        string? response = _categoryService.Update(category);
        return Ok(response);
    }

    [HttpPut("Delete/{id}")]
    public IActionResult Update ([FromBody] int id)
    {
        string? response = _categoryService.Delete(id);
        return Ok(response);
    }
}

