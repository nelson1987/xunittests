using Habacuque.Application;
using Habacuque.Application.Features.Contas;
using Habacuque.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Habacuque.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ContaController : ControllerBase
{
    private readonly ILogger<ContaController> _logger;

    public ContaController(ILogger<ContaController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<Conta> Post(CriacaoContaCommand command)
    {
        command = new CriacaoContaCommand("ABC-12345");
        ContaCreateHandler handler = new ContaCreateHandler();
        return await handler.Handle(command);
    }
}