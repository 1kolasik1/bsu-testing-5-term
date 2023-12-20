using System.Net;
using API.Dto;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class ComputeController: ControllerBase
{
    [HttpPost]
    public ActionResult Analyze(AnalyzeCodeDto dto)
    {
        double result = Calculator.Calculator.Compute(dto.Code);
        return Ok(result);
    }
}