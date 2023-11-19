using Microsoft.EntityFrameworkCore;
using mirea_vetclinic.Domain.Models;

namespace mirea_vetclinic.Domain.Services;

public class OwnerRepository : IOwnerRepository
{
    private readonly VetClinicContext _vetClinicContext;

    public OwnerRepository(VetClinicContext vetClinicContext)
    {
        _vetClinicContext = vetClinicContext;
    }

    public async Task<List<Owner>> GetAllOwnersAsync()
    {
        return await _vetClinicContext.Owners.Include(owner => owner.Pets).ToListAsync();
    }

    public async Task<Owner?> GetOwnerByIdAsync(int id)
    {
        return await _vetClinicContext.Owners.Where(owner => owner.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Owner> CreateOwnerAsync(Owner owner)
    {
        await _vetClinicContext.Owners.AddAsync(owner);
        await _vetClinicContext.SaveChangesAsync();
        return owner;
    }

    public async Task<Owner> UpdateOwnerAsync(Owner updatedOwner)
    {
        _vetClinicContext.Owners.Entry(updatedOwner).State = EntityState.Modified;
        await _vetClinicContext.SaveChangesAsync();
        return updatedOwner;
    }

    public async Task<bool> DeleteOwnerAsync(int id)
    {
        var owner = await _vetClinicContext.Owners.FindAsync(id);

        if (owner == null)
        {
            return false;
        }

        _vetClinicContext.Owners.Remove(owner);
        await _vetClinicContext.SaveChangesAsync();
        return true;
    }

    public async Task<List<Pet>> GetAllPetsByOwnerIdAsync(int ownerId)
    {
        return await _vetClinicContext.Pets
            .Where(pet => pet.OwnerId == ownerId)
            .ToListAsync();
    }

    public async Task<Pet?> GetPetByIdAsync(int petId)
    {
        return await _vetClinicContext.Pets.Where(pet => pet.Id == petId).FirstOrDefaultAsync();
    }

    public async Task<Pet> CreatePetAsync(Pet pet)
    {
        await _vetClinicContext.Pets.AddAsync(pet);
        await _vetClinicContext.SaveChangesAsync();
        return pet;
    }

    public async Task<Pet> UpdatePetAsync(Pet updatedPet)
    {
        _vetClinicContext.Pets.Entry(updatedPet).State = EntityState.Modified;
        await _vetClinicContext.SaveChangesAsync();
        return updatedPet;
    }

    public async Task<bool> DeletePetAsync(int petId)
    {
        var pet = await _vetClinicContext.Pets.FindAsync(petId);
        if (pet == null)
        {
            return false;
        }

        _vetClinicContext.Pets.Remove(pet);
        await _vetClinicContext.SaveChangesAsync();
        return true;
    }

    public async Task<List<Visit>> GetOwnerVisitsAsync(int ownerId)
    {
        return await _vetClinicContext.Visits.Where(visit => visit.OwnerId == ownerId).ToListAsync();
    }

    public async Task<Visit> CreateVisitAsync(Visit visit)
    {
        await _vetClinicContext.Visits.AddAsync(visit);
        await _vetClinicContext.SaveChangesAsync();
        return visit;
    }

    public async Task<List<Visit>> GetVisitsByPetIdAsync(int petId)
    {
        return await _vetClinicContext.Visits.Where(visit => visit.PetId == petId).ToListAsync();
    }

    public Task<bool> CancelVisitAsync(int visitId)
    {
        throw new NotImplementedException();
    }
}