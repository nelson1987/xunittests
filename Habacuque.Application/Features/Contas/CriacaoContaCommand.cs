using System;

namespace Habacuque.Application.Features.Contas;

public record CriacaoContaCommand(string Numero);
public record AlteracaoContaCommand(string Numero);
public record BuscaContaQuery(int Id, string Numero);
