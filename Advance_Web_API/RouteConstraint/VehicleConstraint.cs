using Advance_Web_API.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;

namespace Advance_Web_API.Constraints
{
    public class VehicleConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            var candidate = values[routeKey]?.ToString();
            return Enum.TryParse(candidate, out VehicleEnum result);
        }
    }
}
