using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SuperShop.Helper
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string folder);
    }
}
