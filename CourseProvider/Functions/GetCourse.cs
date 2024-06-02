using CourseProvider.Infrastructure.Models;
using CourseProvider.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace CourseFunctionApp
{
    public class Function
    {
        private readonly ICourseService _courseService;

        public Function(ICourseService courseService)
        {
            _courseService = courseService ?? throw new ArgumentNullException(nameof(courseService));
        }

        [Function("GetCourseById")]
        [Authorize]
        public async Task<HttpResponseData> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "courses/{id}")] HttpRequestData req,
            string id,
            FunctionContext context)
        {
            var logger = context.GetLogger<Function>();
            var response = req.CreateResponse();

            try
            {
                var course = await _courseService.GetCourseByIdAsync(id);

                if (course == null)
                {
                    response.StatusCode = HttpStatusCode.NotFound;
                    await response.WriteStringAsync($"Course with id '{id}' not found.");
                    return response;
                }

                await response.WriteAsJsonAsync(course);
                return response;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error retrieving course by id.");
                response.StatusCode = HttpStatusCode.InternalServerError;
                await response.WriteStringAsync("An error occurred while processing your request.");
                return response;
            }
        }
    }
}

