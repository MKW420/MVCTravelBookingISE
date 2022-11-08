using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using MVCTravelBookingISE.Models;
using System.Threading.Tasks;

namespace MVCTravelBookingISE.Authorization
{
    public class AccomodationIsOwnerAuthorizationHandler
                : AuthorizationHandler<OperationAuthorizationRequirement, AccomodationModel>
    {
        UserManager<IdentityUser> _userManager;

        public AccomodationIsOwnerAuthorizationHandler(UserManager<IdentityUser>
            userManager)
        {
            _userManager = userManager;
        }

        protected override Task
            HandleRequirementAsync(AuthorizationHandlerContext context,
                                   OperationAuthorizationRequirement requirement,
                                   AccomodationModel resource)
        {
            if (context.User == null || resource == null)
            {
                return Task.CompletedTask;
            }

            // If not asking for CRUD permission, return.

            if (requirement.Name != Constants.CreateOperationName &&
                requirement.Name != Constants.ReadOperationName &&
                requirement.Name != Constants.UpdateOperationName &&
                requirement.Name != Constants.DeleteOperationName)
            {
                return Task.CompletedTask;
            }

            //if (resource.OwnerID == _userManager.GetUserId(context.User))
            //{
            //    context.Succeed(requirement);
            //}

            return Task.CompletedTask;
        }
    }
}