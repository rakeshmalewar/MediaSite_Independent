using System;
using System.Configuration;

namespace DH.Media.Core.Enterprise.Common
{
    public interface IConfigurationProxy
    {

    }

    public class ConfigurationProxy : IConfigurationProxy
    {

    }

    /// <summary>
    /// Gets configuration related settings
    /// </summary>
    public static class ConfigurationHelper
    {
        public static IConfigurationProxy Configuration = new ConfigurationProxy();

        #region Fields

        /// <summary>
        /// Gets Cors Origin
        /// </summary>
        public static string CorsOrigin => GetAppSetting<string>(Constants.CorsOrigin);

        /// <summary>
        /// Gets Cors Headers
        /// </summary>
        public static string CorsHeaders => GetAppSetting<string>(Constants.CorsHeaders);

        /// <summary>
        /// Gets Cors Methods
        /// </summary>
        public static string CorsMethods => GetAppSetting<string>(Constants.CorsMethods);

        /// <summary>
        /// Gets Blob Connection Storage Name
        /// </summary>
        public static string BlobConnectionStringName => GetAppSetting<string>(Constants.BlobStorageConnectionString);

        /// <summary>
        /// Gets Blob Container Name
        /// </summary>
        public static string BlobContainerName => GetAppSetting<string>(Constants.BlobContainerName);

        /// <summary>
        /// Gets Container Policy Name
        /// </summary>
        public static string ContainerPolicyName => GetAppSetting<string>(Constants.ContainerPolicyName);

        /// <summary>
        /// Gets Key
        /// </summary>
        public static string Key => GetAppSetting<string>(Constants.Key);

        /// <summary>
        /// Gets Verification Code Length
        /// </summary>
        public static string VerificationCodeLength => GetAppSetting<string>(Constants.VerificationCodeLength);

        /// <summary>
        /// Gets Curbside App Base Url
        /// </summary>
        public static string CurbsideAppBaseUrl => GetAppSetting<string>(Constants.CurbsideAppBaseUrl);

        /// <summary>
        /// Gets Access Policy Name
        /// </summary>
        public static string AccessPolicyName => GetAppSetting<string>(Constants.AccessPolicyName);

        /// <summary>
        /// Curbside Connection
        /// </summary>
        public static string CurbsideConnection => GetAppSetting<string>(Constants.CurbsideConnection);

        /// <summary>
        /// Gets Send Grid Account Key
        /// </summary>
        public static string SendGridAccountKey => GetAppSetting<string>(Constants.SendGridAccountKey);

        /// <summary>
        /// Blob Container
        /// </summary>
        public static string BlobContainer => GetAppSetting<string>(Constants.BlobContainer);

        /// <summary>
        /// Gets Blob Account Name
        /// </summary>
        public static string BlobAccountName => GetAppSetting<string>(Constants.BlobAccountName);

        /// <summary>
        /// Gets Curbside Api Base URI
        /// </summary>
        public static string CurbsideApiBaseUri => GetAppSetting<string>(Constants.CurbsideApiBaseUri);

        /// <summary>
        /// Gets Connection String
        /// </summary>
        public static string ConnectionString => GetAppSetting<string>(Constants.ConnectionString);

        /// <summary>
        /// Gets Tenent Id
        /// </summary>
        public static string TenentId => GetAppSetting<string>(Constants.TenentId);

        /// <summary>
        /// Gets URL
        /// </summary>
        public static string Url => GetAppSetting<string>(Constants.Url);

        /// <summary>
        /// Gets MS_UserName
        /// </summary>
        public static string MsUserName => GetAppSetting<string>(Constants.MsUserName);

        /// <summary>
        /// Get MS_Password
        /// </summary>
        public static string MsPassword => GetAppSetting<string>(Constants.MsPassword);

        /// <summary>
        /// Gets MS_APIKey
        /// </summary>
        public static string MsApiKey => GetAppSetting<string>(Constants.MsApiKey);

        /// <summary>
        /// Gets MS_EndPointURI
        /// </summary>
        public static string MsEndPointUri => GetAppSetting<string>(Constants.MsEndPointUri);

        /// <summary>
        /// Gets Send Grid Account Key
        /// </summary>
        public static string ContentUrl => GetAppSetting<string>(Constants.SendGridAccountKey);

        /// <summary>
        /// Get Send Grid From Address
        /// </summary>
        public static string SendGridFromAddress => GetAppSetting<string>(Constants.SendGridFromAddress);

        /// <summary>
        /// Gets Send Grid From Name
        /// </summary>
        public static string SendGridFromName => GetAppSetting<string>(Constants.SendGridFromName);

        /// <summary>
        /// Gets CIAM_BaseUrl
        /// </summary>
        public static string CiamBaseUrl => GetAppSetting<string>(Constants.CiamBaseUrl);

        /// <summary>
        /// Gets AccountSid
        /// </summary>
        public static string AccountSid => GetAppSetting<string>(Constants.AccountSid);

        /// <summary>
        /// Gets AuthToken
        /// </summary>
        public static string AuthToken => GetAppSetting<string>(Constants.AuthToken);


        /// <summary>
        /// Gets Send Message Text
        /// </summary>
        public static string SendMessageText => GetAppSetting<string>(Constants.SendMessageText);

        /// <summary>
        /// Gets Phone Number
        /// </summary>
        public static string FromPhoneNumber => GetAppSetting<string>(Constants.FromPhoneNumber);

        /// <summary>
        /// Thumb print for azure key vault
        /// </summary>
        public static string ThumbPrint => GetAppSetting<string>(Constants.ThumbPrint);

        /// <summary>
        /// Client Id
        /// </summary>
        public static string ClientId => GetAppSetting<string>(Constants.ClientId);

        /// <summary>
        /// Gets Notification ConnectionString
        /// </summary>
        public static string NotificationsConnectionString => GetAppSetting<string>(Constants.NotificationsConnectionString);

        /// <summary>
        /// Gets Notification Hub Path
        /// </summary>
        public static string NotificationHubPath => GetAppSetting<string>(Constants.NotificationHubPath);

        /// <summary>
        /// Gets AppInsightsInstrumentationKey
        /// </summary>
        public static string AppInsightsInstrumentationKey => GetAppSetting<string>(Constants.AppInsightsInstrumentationKey);

        /// <summary>
        /// Gets AudienceKey
        /// </summary>
        public static string Audience => GetAppSetting<string>(Constants.Audience);

        /// <summary>
        /// Gets Consumer AudienceKey
        /// </summary>
        public static string ConsumerAudience => GetAppSetting<string>(Constants.ConsumerAudience);

        /// <summary>
        /// Gets IssuerKey
        /// </summary>
        public static string Issuer => GetAppSetting<string>(Constants.Issuer);

        /// <summary>
        /// Gets IssuerKey
        /// </summary>
        public static string ConsumerIssuer => GetAppSetting<string>(Constants.ConsumerIssuer);

        /// <summary>
        /// Gets IssuerMetadataEndpointKey
        /// </summary>
        public static string IssuerMetadataEndpoint => GetAppSetting<string>(Constants.IssuerMetadataEndpoint);

        /// <summary>
        /// Gets SwaggerNoAuthHeaderKey
        /// </summary>
        public static string SwaggerNoAuthHeader => GetAppSetting<string>(Constants.SwaggerNoAuthHeader);

        /// <summary>
        /// Gets EnableTraceKey
        /// </summary>
        public static bool EnableTrace => GetAppSetting<bool>(Constants.EnableTrace);

        /// <summary>
        /// Gets MediaSite Playback Url
        /// </summary>
        public static string MediaSitePlaybackUrl => GetAppSetting<string>(Constants.MediaSitePlaybackUrl);
        #endregion

        #region Getting values from Web.Config file

        /// <summary>
        /// Generic version of GetAppSetting()
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="key">The key</param>
        /// <returns></returns>
        public static T GetAppSetting<T>(string key)
        {
            var value = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ConfigurationErrorsException($"{key} " + Constants.AppSettingMissing);
            }

            var theType = typeof(T);
            if (theType.IsEnum)
            {
                return (T)Enum.Parse(theType, value, true);
            }
            return (T)Convert.ChangeType(value, theType);
        }


        #endregion
    }
}
