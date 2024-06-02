using CourseProvider.Infrastructure.Models;
using CourseProvider.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;

namespace CourseProvider.Infrastructure.GraphQL
{
    public class CourseQuery(ICourseService courseService)
    {
        private readonly ICourseService _courseService = courseService;

        [Authorize]
        [GraphQLName("getCourses")]
        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await _courseService.GetCoursesAsync();
        }

        [Authorize]
        [GraphQLName("getCourseById")]
        public async Task<Course> GetCourseByIdAsync(string id)
        {
            return await _courseService.GetCourseByIdAsync(id);
        }
    }
}