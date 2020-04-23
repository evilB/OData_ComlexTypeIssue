using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ComplexTypeIssue.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;

namespace ComplexTypeIssue
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // New code:
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
            builder.EntitySet<TestModel>("TestModels");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "api/",
                model: builder.GetEdmModel());
        }
    }
}
