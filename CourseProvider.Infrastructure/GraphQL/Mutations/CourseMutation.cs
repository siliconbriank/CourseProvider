using CourseProvider.Infrastructure.Models;
using CourseProvider.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;

namespace CourseProvider.Infrastructure.GraphQL.Mutations
{
    public class CourseMutation(ICourseService courseService)
    {
        private readonly ICourseService _courseService = courseService;

        [Authorize]
        [GraphQLName("createCourse")]
        public async Task<Course> CreateCourseAsync(CourseCreateRequest input)
        {
            return await _courseService.CreateCourseAsync(input);
        }

        [Authorize]
        [GraphQLName("updateCourse")]
        public async Task<Course> UpdateCourseAsync(CourseUpdateRequest input)
        {
            return await _courseService.UpdateCourseAsync(input);
        }

        [Authorize]
        [GraphQLName("deleteCourse")]
        public async Task<bool> DeleteCourseAsync(string id)
        {
            return await _courseService.DeleteCourseAsync(id);
        }
    }
}
