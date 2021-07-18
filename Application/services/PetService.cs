using Application.abstraction;
using Application.Helpers;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
  public class PetService:BaseService<Pet>, IPetService
  {
    private IPetRepository _petrepo;
    private IFileHelper _fileHelper;
    public PetService(IPetRepository petRepo,IFileHelper fileHelper):base(petRepo)
    {
      _petrepo = petRepo;
      this._fileHelper = fileHelper;
    }
    public async Task<IEnumerable<Pet>> GetPetsByEmail(string email)
    {
      return await _petrepo.GetPetsByEmail(email);
    }
    public async Task<IEnumerable<Pet>> SearchPets(double latitude, double longitude, string filterType,
      string filterValue, int startIndex, int count)
    {
      return await _petrepo.SearchPets(latitude,longitude,filterType,filterValue, startIndex, count);
    }
    public new async Task Add(Pet pet)
    {
      var image = pet.Image;
      if (image != null)
      {
        var fileName = DateTime.Now.Ticks.ToString() + "_" + image.FileName;
         await _fileHelper.UploadFile(image.OpenReadStream(),fileName);
         pet.FileName = fileName;
      } 
      pet.PrepareForInsertion();
      await base.Add(pet);
    }
  }
}
