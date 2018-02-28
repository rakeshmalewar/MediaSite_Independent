using System.Web.Http;
using Swashbuckle.Application;
using Swashbuckle.Swagger;
using System.Web.Http.Description;
using System.Collections.Generic;
using DH.Media.Core.Enterprise.Common;

namespace DH.Media.API
{
    /// <summary>
    /// Swagger Configuration
    /// </summary>
    public static class SwaggerConfig
    {
        /// <summary>
        /// Register Method
        /// </summary>
        public static void Register(HttpConfiguration configuration)
        {
            configuration.EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "DH.Curbside.API");
                var docFile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "App_Data\\CurbsideApiDoc.xml");
                c.IncludeXmlComments(docFile);
                c.OperationFilter<RequiredHeaderParameter>();
                c.DescribeAllEnumsAsStrings();
            })
                .EnableSwaggerUi(c =>
                {
                    c.EnableDiscoveryUrlSelector();
                });
        }
    }

    /// <summary>
    /// Adds header parameters to swagger
    /// </summary>
    public class RequiredHeaderParameter : IOperationFilter
    {
        /// <summary>
        /// Applying Header parameters to Swagger UI
        /// </summary>
        /// <param name="operation">Operation Object</param>
        /// <param name="schemaRegistry">SchemaRegistry Object</param>
        /// <param name="apiDescription">ApiDescription Object</param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
            {
                operation.parameters = new List<Parameter>();
            }

            if (!ConfigurationHelper.SwaggerNoAuthHeader.Contains(apiDescription.ActionDescriptor.ActionName.ToLower()))
            {
                operation.parameters.Add(new Parameter
                {
                    name = Constants.Authorization,
                    @in = Constants.AuthHeader,
                    type = Constants.AuthType,
                    description = Constants.AuthDescription,
                    required = true
                });
            }
        }
    }
}