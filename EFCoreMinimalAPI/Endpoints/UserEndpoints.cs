using EFCoreMinimalAPI.Models;
using EFCoreMinimalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreMinimalAPI.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/users");

            group.MapGet("/", async (UserService userService) =>
            {
                var users = await userService.GetAllUsersAsync();
                return Results.Ok(users);
            });

            group.MapGet("/{id}", async (string id, UserService userService) =>
            {
                var user = await userService.GetUserByIdAsync(id);
                return user is null ? Results.NotFound() : Results.Ok(user);
            });

            group.MapPost("/register", async ([FromBody] RegisterUserDto model, UserService userService) =>
            {
                var result = await userService.RegisterUserAsync(model);
                return result.Succeeded ? Results.Ok("User Created") : Results.BadRequest(result.Errors);
            });

            group.MapDelete("/{id}", async (string id, UserService userService) =>
            {
                var deleted = await userService.DeleteUserAsync(id);
                return deleted ? Results.Ok("User Deleted") : Results.NotFound("User Not Found");
            });
        }
    }
}
