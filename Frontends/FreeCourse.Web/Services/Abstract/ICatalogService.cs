using FreeCourse.Web.Models.Catalog;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Abstract
{
    public interface ICatalogService
    {
        Task<List<CourseViewModel>> GetAllCourse();
        Task<List<CategoryViewModel>> GetAllCategory();
        Task<List<CourseViewModel>> GetAllCourseByUserId(string userId);
        Task<CourseViewModel> GetByCourseId(string courseId);

        Task<bool> CreateCourse(CourseCreateInput courseCreateInput);
        Task<bool> UpdateCourse(CourseUpdateInput courseUpdateInput);
        Task<bool> DeleteCourse(string courseId);
    }
}
