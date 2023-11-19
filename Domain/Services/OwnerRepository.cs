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

    public async Task<List<Owner>> GetAllAsync()
    {
        return await _vetClinicContext.Owners
            .Include(owner => owner.Pets)
            .ThenInclude(pet => pet.Visits)
            .ThenInclude(visit => visit.Procedures)
            .ToListAsync();
    }

    public async Task<Owner?> GetByIdAsync(int id)
    {
        return await _vetClinicContext.Owners
            .Where(owner => owner.Id == id)
            .Include(owner => owner.Pets)
            .ThenInclude(pet => pet.Visits)
            .ThenInclude(visit => visit.Procedures)
            .FirstOrDefaultAsync();
    }

    public async Task<Owner> CreateAsync(Owner owner)
    {
        await _vetClinicContext.Owners.AddAsync(owner);
        await _vetClinicContext.SaveChangesAsync();
        return owner;
    }

    public async Task<Owner> UpdateAsync(Owner updatedOwner)
    {
        _vetClinicContext.Owners.Entry(updatedOwner).State = EntityState.Modified;
        await _vetClinicContext.SaveChangesAsync();
        return updatedOwner;
    }

    public async Task<bool> DeleteAsync(int id)
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
            .Where(pet => pet.Owner.Id == ownerId)
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
        throw new NotImplementedException();
    }

    public async Task<Visit> CreateVisitAsync(Visit visit)
    {
        await _vetClinicContext.Visits.AddAsync(visit);
        await _vetClinicContext.SaveChangesAsync();
        return visit;
    }

    public async Task<List<Visit>> GetVisitsByPetIdAsync(int petId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CancelVisitAsync(int visitId)
    {
        throw new NotImplementedException();
    }
}