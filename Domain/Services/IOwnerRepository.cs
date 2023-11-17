using mirea_vetclinic.Domain.Models;

namespace mirea_vetclinic.Domain.Services;

public interface IOwnerRepository
{
    // CRUD Operations for Owner
    Task<List<Owner?>> GetAllOwnersAsync();
    Task<Owner?> GetOwnerByIdAsync(int id);
    Task<Owner?> CreateOwnerAsync(Owner? owner);
    Task<Owner?> UpdateOwnerAsync(Owner? updatedOwner);
    Task<bool> DeleteOwnerAsync(int id);
    
    // CRUD Operations for Pet
    Task<List<Pet?>> GetAllPetsByOwnerIdAsync(int ownerId);
    Task<Pet?> GetPetByIdAsync(int petId);
    Task<Pet?> CreatePetAsync(Pet? pet);
    Task<Pet?> UpdatePetAsync(Pet? updatedPet);
    Task<bool> DeletePetAsync(int petId);
    
    // Operations related to Appointments
    Task<List<Visit>> GetOwnerVisitsAsync(int ownerId);
    Task<Visit> CreateVisitAsync(Visit visit);
    Task<List<Visit>> GetVisitsByPetIdAsync(int petId);
    Task<bool> CancelVisitAsync(int visitId);
}