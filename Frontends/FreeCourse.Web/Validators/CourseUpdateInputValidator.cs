using FluentValidation;
using FreeCourse.Web.Models.Catalog;

namespace FreeCourse.Web.Validators
{
    public class CourseUpdateInputValidator : AbstractValidator<CourseUpdateInput>
    {
        public CourseUpdateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kurs ismi boş olamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş olamaz");
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1, int.MaxValue).WithMessage("Kurs süresi boş olamaz");

            //$$$$.$$
            RuleFor(x => x.Price).NotEmpty().WithMessage("Kurs fiyatı boş olamaz").ScalePrecision(2, 6).WithMessage("Hatalı para formatı");
        }
    }
}
