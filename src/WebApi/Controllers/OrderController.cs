using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace HypePrint.OrderApi.WebApi.Controllers;

[Route("api/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
[ApiController]
public class OrderController : ControllerBase
{
}