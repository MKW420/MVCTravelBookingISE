using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Authorization
{
    public class AccomodationAdministratorsAuthorizationHandler
                    : AuthorizationHandler<OperationAuthorizationRequirement, AccomodationModel>
    {
        protected override Task HandleRequirementAsync(
                                              AuthorizationHandlerContext context,
                                    OperationAuthorizationRequirement requirement,
                                     AccomodationModel resource)
        {
            if (context.User == null)
            {
                return Task.CompletedTask;
            }

            // Administrators can do anything.
            if (context.User.IsInRole(Constants.AccomodationAdministratorsRole))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}