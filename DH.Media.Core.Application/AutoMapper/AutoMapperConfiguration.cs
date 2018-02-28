using AutoMapper;


namespace DH.Media.Core.Application.AutoMapper
{
    /// <summary>
    /// AutoMapperConfig Static Class
    /// </summary>
    public static class AutoMapperConfig
    {
        /// <summary>
        /// IMapper 
        /// </summary>
        public static IMapper Mapper;

        /// <summary>
        /// Configures and create mapper
        /// </summary>
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            Mapper = config.CreateMapper();
        }
    }
}
