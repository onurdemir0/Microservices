using FreeCourse.Web.Models;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;

namespace FreeCourse.Web.Helpers
{
    public class PhotoHelper
    {
        private readonly ServiceApiSettings _settings;

        public PhotoHelper(IOptions<ServiceApiSettings> settings)
        {
            _settings = settings.Value;
        }

        public string GetPhotoStockUrl(string photoUrl)
        {
            return $"{_settings.PhotoStockUri}/photos/{photoUrl}";
        }
    }
}
