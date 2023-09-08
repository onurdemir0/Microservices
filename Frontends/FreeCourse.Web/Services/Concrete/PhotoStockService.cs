using FreeCourse.Web.Models.PhotoStocks;
using FreeCourse.Web.Services.Abstract;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Concrete
{
    public class PhotoStockService : IPhotoStockService
    {
        public Task<bool> DeletePhoto(string photoUrl)
        {
            throw new System.NotImplementedException();
        }

        public Task<PhotoViewModel> UploadPhoto(IFormFile photo)
        {
            throw new System.NotImplementedException();
        }
    }
}
