using NArchitecture.Core.Application.Responses;

namespace Application.Features.Fuels.Commands.Create;

public class CreatedFuelResponse : IResponse
{
    public string Name { get; set; }
    public Guid Id { get; set; }
}