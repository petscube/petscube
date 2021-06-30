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
    public async Task<IEnumerable<Pet>> SearchPets(string category, string breed,
      string pinCode, int startIndex, int count)
    {
      return await _petrepo.SearchPets(category, breed,
       pinCode,  startIndex, count);
    }
    public new async Task Add(Pet pet)
    {
      var image = pet.Image;
      if (image != null)
      {
         await _fileHelper.UploadFile(image.OpenReadStream(),DateTime.Now.Ticks.ToString()+image.FileName);
      }

      pet.FileName = image.FileName;
      pet.Image = null;
      await base.Add(pet);
    }
  }
}
