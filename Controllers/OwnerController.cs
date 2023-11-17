using Microsoft.AspNetCore.Mvc;
using mirea_vetclinic.Domain.Models;
using mirea_vetclinic.Domain.Services;

namespace mirea_vetclinic.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OwnerController : Controller
{
    private readonly IOwnerRepository _ownerRepository;

    public OwnerController(IOwnerRepository ownerRepository)
    {
        _ownerRepository = ownerRepository;
    }

    [HttpGet]
    [Route("")]
    public async Task<List<Owner?>> GetAllOwners()
    {
        return await _ownerRepository.GetAllOwnersAsync();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Route("{ownerId:int}")]
    public async Task<IActionResult> FindOwner(int ownerId)
    {
        var owner = await _ownerRepository.GetOwnerByIdAsync(ownerId);
        return owner == null ? new NotFoundResult() : new JsonResult(owner);
    }
}