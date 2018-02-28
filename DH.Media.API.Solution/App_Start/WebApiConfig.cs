using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DH.Media.API
{
    public static class WebApiConfig
    {
        /// <summary>
        /// Initializes WebAPI routing
        /// </summary>
        /// <param name="config">HttpConfiguration object</param>
        public static void Register(HttpConfiguration config)
        {
            config.AddApiVersioning();

            var constraintResolver = new DefaultInlineConstraintResolver
            {
                ConstraintMap =
                {
                    ["apiVersion"] = typeof( ApiVersionRouteConstraint )
                }
            };

            config.AddApiVersioning(x => x.AssumeDefaultVersionWhenUnspecified = true);

            config.MapHttpAttributeRoutes(constraintResolver);

            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;

            config.Filters.Add(new ValidationActionFilterAttribute());
            config.Filters.Add(new HandleApiExceptionFilterAttribute());
            config.Services.Replace(typeof(IExceptionHandler), new UnhandledExceptionHandler());
            config.Services.Replace(typeof(IExceptionLogger), new CurbsideExceptionLogger());

            config.Routes.MapHttpRoute(
                         "DefaultApi",
                         "{controller}/{id}",
                         new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                         "Swagger UI",
                         "",
                         null,
                         null,
                         new RedirectHandler(SwaggerDocsConfig.DefaultRootUrlResolver, "swagger/ui/index"));

            // Enable CORS to allow all Origins,Methods(Get,Post,Put,Delete) and Headers(Content-Type)
            config.EnableCors(new EnableCorsAttribute(ConfigurationHelper.CorsOrigin, ConfigurationHelper.CorsHeaders, ConfigurationHelper.CorsMethods));

        }
    }
}
