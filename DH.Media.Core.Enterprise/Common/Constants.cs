
namespace DH.Media.Core.Enterprise.Common
{
    /// <summary>
    /// Constants Class
    /// </summary>
    public class Constants
    {
        #region Constants Fields

        /// <summary>
        /// Cors-Origin
        /// </summary>
        public const string CorsOrigin = "CorsOrigin";

        /// <summary>
        /// Cors-Headers
        /// </summary>
        public const string CorsHeaders = "CorsHeaders";

        /// <summary>
        /// Cors-Methods
        /// </summary>
        public const string CorsMethods = "CorsMethods";

        /// <summary>
        /// Secret Key
        /// </summary>
        public const string SecretKey = "db3OIsj+BXE9NZDy0t8W3TcNekrF+2d/1sFnWG4HnV8TZY30iTOdtVWJG8abWvB1GlOgJuQZdcF2Luqm/hccMw==";

        /// <summary>
        /// Sign-In
        /// </summary>
        public const string SignIn = "sign-in";

        /// <summary>
        /// Sign-Out
        /// </summary>
        public const string SignOut = "sign-out";

        /// <summary>
        /// Refresh
        /// </summary>
        public const string Refresh = "refresh";

        /// <summary>
        /// Forced Upgrade
        /// </summary>
        public const string ForcedUpgrade = "application-upgrade";

        /// <summary>
        /// Recovery question and Statetoken
        /// </summary>
        public const string RecoveryQuestion = "recoveryquestion-and-statetoken";

        /// <summary>
        /// Validate answer and state token
        /// </summary>
        public const string ValidateAnswer = "validate-answer-statetoken";

        /// <summary>
        /// Reset Password
        /// </summary>
        public const string ResetPassword = "reset-password";

        /// <summary>
        /// presentation
        /// </summary>
        public const string Presentation = "presentation";

        /// <summary>
        /// Attachment
        /// </summary>
        public const string Attachment = "attachment";

        /// <summary>
        /// Picture
        /// </summary>
        public const string Picture = "picture";

        /// <summary>
        /// Number of records to skip
        /// </summary>
        public const string Offset = "offset";

        /// <summary>
        /// Number of records to return
        /// </summary>
        public const string Limit = "limit";

        /// <summary>
        /// Sort
        /// </summary>
        public const string Sort = "sort";

        /// <summary>
        /// Sort Direction
        /// </summary>
        public const string SortDirection = "sortdirection";

        /// <summary>
        /// Order by column
        /// </summary>
        public const string OrderByField = "orderByField";

        /// <summary>
        /// Invalid Text 
        /// </summary>
        public const string InvalidKey = "Invalid ";

        /// <summary>
        /// Order by created on date
        /// </summary>
        public const string CreatedOnOrder = "CreatedOn ";

        /// <summary>
        /// Descend order 
        /// </summary>
        public const string OrderDesc = "Desc";

        /// <summary>
        /// Order by Accepted Date
        /// </summary>
        public const string AcceptedDateOrder = "AcceptedDate ";

        /// <summary>
        /// Order by date field
        /// </summary>
        public const string DateOrder = "Date";

        /// <summary>
        /// Email Pattern
        /// </summary>
        public const string EmailPattern = @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+" +
                                                @"(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)" +
                                                @"*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+" +
                                                @"[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?";

        /// <summary>
        /// Invalid Email
        /// </summary>
        public const string InvalidEmail = "Invalid Email";

        /// <summary>
        /// ApplicationToken not found
        /// </summary>
        public const string ApplicationTokenNotFound = "ApplicationToken not found";

        /// <summary>
        /// Curbside Api Base Url
        /// </summary>
        public const string CurbsideAppBaseUrl = "CurbsideAppBaseUrl";

        /// <summary>
        /// TenantId Query String
        /// </summary>
        public const string TenantIdQueryString = "?tenantId=";

        /// <summary>
        /// ProviderId Query String
        /// </summary>
        public const string ProviderIdQueryString = "&providerId=";

        /// <summary>
        /// System User
        /// </summary>
        public const string SystemUser = "System User";

        /// <summary>
        /// Duplicate User
        /// </summary>
        public const string DuplicateUser = "Duplicate User";

        /// <summary>
        /// Table Name UserClientApplication Table
        /// </summary>
        public const string UserClientApplication = "UserClientApplication";

        /// <summary>
        /// Domain already exists
        /// </summary>
        public const string DomainExists = "Domain already exists";

        /// <summary>
        ///  Table Name DomainClientApplication
        /// </summary>
        public const string DomainClientApplication = "DomainClientApplication";

        /// <summary>
        /// Table Name PatientCaseReviews
        /// </summary>
        public const string PatientCaseReviews = "PatientCaseReviews";

        /// <summary>
        /// Table PatientCaseAttachments.MediaAttachment
        /// </summary>
        public const string PatientCaseMediaAttachments = "PatientCaseAttachments.MediaAttachment";

        /// <summary>
        /// Provider
        /// </summary>
        public const string Provider = "Provider";

        /// <summary>
        /// Status
        /// </summary>
        public const string Status = "Status";

        /// <summary>
        /// Thumb nail
        /// </summary>
        public const string Thumbnail = "Thumbnail";

        /// <summary>
        /// None
        /// </summary>
        public const string None = "none ";

        /// <summary>
        /// Images successfully inserted for the cases
        /// </summary>
        public const string MsgForImagesInsertionString1 = "Successfully inserted the images ";

        /// <summary>
        /// and failed for cases 
        /// </summary>
        public const string MsgForImagesInsertionString2 = "and failed images ";

        /// <summary>
        /// All
        /// </summary>
        public const string ImagesFailedAll = "all";

        /// <summary>
        /// Your case 
        /// </summary>
        public const string UpdateCaseMsgString1 = "Your case ";

        /// <summary>
        ///  has been reviewed.
        /// </summary>
        public const string UpdateCaseMsgString2 = " has been reviewed.";

        /// <summary>
        /// One Space
        /// </summary>
        public const string OneSpace = " ";

        /// <summary>
        /// Presentation Id
        /// </summary>
        public const string QueryParamPresentationId = "presentationId";

        /// <summary>
        /// Minutes To Live
        /// </summary>
        public const string QueryParamMinutesToLive = "minutesToLive";

        /// <summary>
        /// Email Validations
        /// </summary>
        public const string EmailValidations = "EmailValidations";

        /// <summary>
        /// Phone Validations
        /// </summary>
        public const string PhoneValidations = "PhoneValidations";

        /// <summary>
        /// Provider TOS
        /// </summary>
        public const string ProviderTermsOfService = "ProviderTermsOfService";

        /// <summary>
        /// Phone Validations
        /// </summary>
        public const string Numbers = "0123456789";

        /// <summary>
        /// Plus symbol
        /// </summary>
        public const string PlusSymbol = "+";

        /// <summary>
        /// Prokarma
        /// </summary>
        public const string Prokarma = "Prokarma";

        /// <summary>
        /// Request Type
        /// </summary>
        public const string RequestType = "application/json";

        /// <summary>
        /// Header Authorization
        /// </summary>
        public const string HeaderAuthorization = "Authorization";

        /// <summary>
        /// Status Unauthorized
        /// </summary>
        public const string StatusUnauthorized = "Unauthorized";

        /// <summary>
        /// Is Valid
        /// </summary>
        public const string IsValid = "isValid";

        /// <summary>
        /// False
        /// </summary>
        public const string False = "False";

        /// <summary>
        /// Result
        /// </summary>
        public const string Result = "result";

        /// <summary>
        /// Access Token
        /// </summary>
        public const string AccessToken = "accessToken";

        /// <summary>
        /// Refresh Token
        /// </summary>
        public const string RefreshToken = "refreshToken";

        /// <summary>
        /// Session Id
        /// </summary>
        public const string SessionId = "sessionId";

        /// <summary>
        /// Id Token
        /// </summary>
        public const string IdToken = "idToken";

        /// <summary>
        /// User Profile
        /// </summary>
        public const string UserProfile = "userProfile";

        /// <summary>
        /// SignOut Msg
        /// </summary>
        public const string SignOutMsg = "User Successfully signed out.";

        /// <summary>
        /// Self Id
        /// </summary>
        public const string SelfId = "selfId";

        /// <summary>
        /// User Name
        /// </summary>
        public const string UserName = "username";

        /// <summary>
        /// First Name
        /// </summary>
        public const string FirstName = "firstName";

        /// <summary>
        /// Last Name
        /// </summary>
        public const string LastName = "lastName";

        /// <summary>
        /// Specialty
        /// </summary>
        public const string Specialty = "specialty";

        /// <summary>
        /// Degree Credential
        /// </summary>
        public const string DegreeCredential = "degreeCredential";

        /// <summary>
        /// Errors
        /// </summary>
        public const string Errors = "errors";

        /// <summary>
        /// Bearer
        /// </summary>
        public const string Bearer = "Bearer ";

        /// <summary>
        /// {0}{1}
        /// </summary>
        public const string PlaceHolders = "{0}{1}";

        /// <summary>
        /// Basic {0}
        /// </summary>
        public const string BasicHolder = "Basic {0}";

        /// <summary>
        /// {0}:{1}
        /// </summary>
        public const string PlaceHolder = "{0}:{1}";

        /// <summary>
        /// Sfapikey
        /// </summary>
        public const string Sfapikey = "sfapikey";

        /// <summary>
        /// BaseUri
        /// </summary>
        public const string BaseUri = "api/v1";

        /// <summary>
        /// Presentation Url
        /// </summary>
        public const string PresentationUrl = "Presentations?search=ParentFolderId:52dc2798ff184bcea08c8aee6943a55714";

        /// <summary>
        /// AuthorizationTickets
        /// </summary>
        public const string AuthorizationTickets = "AuthorizationTickets";

        /// <summary>
        /// PresentationsPart
        /// </summary>
        public const string PresentationsPart = "Presentations('";

        /// <summary>
        /// SelectPart
        /// </summary>
        public const string SelectPart = "')?$select=full";

        /// <summary>
        /// Select
        /// </summary>
        public const string Select = "$select";

        /// <summary>
        /// Orderby
        /// </summary>
        public const string Orderby = "$orderby";

        /// <summary>
        /// RecordDate Order
        /// </summary>
        public const string RecordDateOrder = " RecordDate ";

        /// <summary>
        /// Skip
        /// </summary>
        public const string Skip = "$skip";

        /// <summary>
        /// Top
        /// </summary>
        public const string Top = "$top";

        /// <summary>
        /// Full
        /// </summary>
        public const string Full = "full";

        /// <summary>
        /// WnsPartOne
        /// </summary>
        public const string WnsPartOne = @"<toast><visual><binding template=""ToastText01""><text id=""1"">";

        /// <summary>
        /// WnsPartTwo
        /// </summary>
        public const string WnsPartTwo = "</text></binding></visual></toast>";

        /// <summary>
        /// From
        /// </summary>
        public const string From = "From ";

        /// <summary>
        /// ApnsPartOne
        /// </summary>
        public const string ApnsPartOne = "{\"aps\":{\"alert\":\"";

        /// <summary>
        /// Adding default sound
        /// </summary>
        public const string Sound = "\",\"sound\":\"default\"";

        /// <summary>
        /// Brace for IOS
        /// </summary>
        public const string BraceIos = "}}";

        /// <summary>
        /// Brace
        /// </summary>
        public const string Brace = "\"}}";

        /// <summary>
        /// Colon
        /// </summary>
        public const string Colon = ": ";

        /// <summary>
        /// Gcmpartone
        /// </summary>
        public const string Gcmpartone = "{ \"data\" : {\"message\":\"";

        /// <summary>
        /// Wns
        /// </summary>
        public const string Wns = "wns";

        /// <summary>
        /// Apns
        /// </summary>
        public const string Apns = "apns";

        /// <summary>
        /// Gcm
        /// </summary>
        public const string Gcm = "gcm";

        /// <summary>
        /// Table Name ApplicationUpgrade
        /// </summary>
        public const string ApplicationUpgrade = "ApplicationUpgrade";

        /// <summary>
        /// Table Name ClientApplication
        /// </summary>
        public const string ClientApplication = "ClientApplication";

        /// <summary>
        /// Table Name ClientApplicationTenant
        /// </summary>
        public const string ClientApplicationTenant = "ClientApplicationTenant";

        /// <summary>
        /// UniqueIdentifier
        /// </summary>
        public const string UniqueIdentifier = "uniqueidentifier";

        /// <summary>
        /// Datetime2
        /// </summary>
        public const string Datetime2 = "datetime2";

        /// <summary>
        /// Table Name Domain
        /// </summary>
        public const string Domain = "Domain";

        /// <summary>
        /// Table Name EmailValidation
        /// </summary>
        public const string EmailValidation = "EmailValidation";

        /// <summary>
        /// Table Name MediaAttachment
        /// </summary>
        public const string MediaAttachment = "MediaAttachment";

        /// <summary>
        /// Table Name PatientCaseAttachment
        /// </summary>
        public const string PatientCaseAttachment = "PatientCaseAttachment";

        /// <summary>
        /// Table Name PatientCaseHistory
        /// </summary>
        public const string PatientCaseHistory = "PatientCaseHistory";

        /// <summary>
        /// Table Name PatientCase
        /// </summary>
        public const string PatientCase = "PatientCase";

        /// <summary>
        /// Table Name PatientCaseReview
        /// </summary>
        public const string PatientCaseReview = "PatientCaseReview";

        /// <summary>
        /// Table Name PhoneValidation
        /// </summary>
        public const string PhoneValidation = "PhoneValidation";

        /// <summary>
        /// Table Name ProviderRole
        /// </summary>
        public const string ProviderRole = "ProviderRole";

        /// <summary>
        /// Table Name Tenant
        /// </summary>
        public const string Tenant = "Tenant";

        /// <summary>
        /// Table Name TermsOfService
        /// </summary>
        public const string TermsOfService = "TermsOfService";

        /// <summary>
        /// Table Name User
        /// </summary>
        public const string User = "User";

        /// <summary>
        /// Table Name UserSession
        /// </summary>
        public const string UserSession = "UserSession";

        /// <summary>
        /// Table Name WhiteListUserHistory
        /// </summary>
        public const string WhiteListUserHistory = "WhiteListUserHistory";

        /// <summary>
        /// Table Name WhitelistUserStatus
        /// </summary>
        public const string WhitelistStatus = "WhitelistStatus";

        /// <summary>
        /// jpg extension
        /// </summary>
        public const string PngExtension = ".jpg";

        /// <summary>
        /// Dignity health logo image file name
        /// </summary>
        public const string DignityHealthLogo = "DG";

        /// <summary>
        /// Images
        /// </summary>
        public const string Images = @"\Images";

        /// <summary>
        /// HtmlContent
        /// </summary>
        public const string HtmlContent = "<strong>Dignity Health is inviting you to register Submitter App</strong>";

        /// <summary>
        /// Empty
        /// </summary>
        public const string Empty = "";

        /// <summary>
        /// Select Statement
        /// </summary>
        public const string SelectStmt = "select count(*) from [dbo].[User] where TenantID = '";

        /// <summary>
        /// Single Quote
        /// </summary>
        public const string SingleQuote = "'";

        /// <summary>
        /// I access the User URL
        /// </summary>
        public const string AccessUrlStmt = "I access the User URL";

        /// <summary>
        /// I get all the users from service
        /// </summary>
        public const string GetUsersStmt = "I get all the users from service";

        /// <summary>
        /// I should see users count as
        /// </summary>
        public const string SeeUsersCntStmt = "I should see users count as";

        /// <summary>
        /// Success
        /// </summary>
        public const string SuccessMessage = "Success";

        /// <summary>
        /// TechTalk.SpecFlow
        /// </summary>
        public const string TechTalkSpecFlow = "TechTalk.SpecFlow";

        /// <summary>
        /// Version
        /// </summary>
        public const string Version = "2.2.0.0";

        /// <summary>
        /// Language
        /// </summary>
        public const string Language = "en-US";

        /// <summary>
        /// WhiteListUser
        /// </summary>
        public const string WhiteListUser = "whiteListUser";

        /// <summary>
        /// Given
        /// </summary>
        public const string Given = "Given ";

        /// <summary>
        /// When
        /// </summary>
        public const string When = "When ";

        /// <summary>
        /// Then
        /// </summary>
        public const string Then = "Then ";

        /// <summary>
        /// amx
        /// </summary>
        public const string AuthenticationScheme = "amx";

        /// <summary>
        /// Email Body
        /// </summary>
        public const string EmailBody = " Thank you for registering with Barrow Neuro Network.  Please click the link below to verify your email address. <BR> ";

        /// <summary>
        /// Email validation link
        /// </summary>
        public const string EmailValidationLink = "<a href=\"{0}\">Click here for email validation</a>";

        /// <summary>
        /// Dignity Heath HTML body
        /// </summary>
        public const string HtmlBody = "Dignity Heath HTML body";

        /// <summary>
        /// Email\Images
        /// </summary>
        public const string EmailImages = @"Email\Images";

        /// <summary>
        /// Thumbnail Width
        /// </summary>
        public const int ThumbnailWidth = 300;

        /// <summary>
        /// Thumbnail Height
        /// </summary>
        public const int ThumbnailHeight = 300;

        /// <summary>
        /// Image Resolution
        /// </summary>
        public const float ImageResolution = 72;

        /// <summary>
        /// BlobConnectionStringName
        /// </summary>
        public const string BlobStorageConnectionString = "BlobStorageConnectionString";

        /// <summary>
        /// BlobContainerName
        /// </summary>
        public const string BlobContainerName = "BlobContainer";

        /// <summary>
        /// ContainerPolicyName
        /// </summary>
        public const string ContainerPolicyName = "ContainerPolicyName";

        /// <summary>
        /// Key
        /// </summary>
        public const string Key = "Key";

        /// <summary>
        /// VerificationCode.Length
        /// </summary>
        public const string VerificationCodeLength = "VerificationCode.Length";

        /// <summary>
        /// AccessPolicyName
        /// </summary>
        public const string AccessPolicyName = "AccessPolicyName";

        /// <summary>
        /// CurbsideConnection
        /// </summary>
        public const string CurbsideConnection = "CurbsideConnection";

        /// <summary>
        /// SendGridAccountKey
        /// </summary>
        public const string SendGridAccountKey = "SendGridAccountKey";

        /// <summary>
        /// BlobContainer
        /// </summary>
        public const string BlobContainer = "BlobContainer";

        /// <summary>
        /// BlobAccountName
        /// </summary>
        public const string BlobAccountName = "BlobAccountName";

        /// <summary>
        /// CurbsideApiBaseURI
        /// </summary>
        public const string CurbsideApiBaseUri = "CurbsideApiBaseURI";

        /// <summary>
        /// ConnectionString
        /// </summary>
        public const string ConnectionString = "ConnectionString";

        /// <summary>
        /// TenentId
        /// </summary>
        public const string TenentId = "TenentId";

        /// <summary>
        /// URL
        /// </summary>
        public const string Url = "URL";

        /// <summary>
        /// MS_UserName
        /// </summary>
        public const string MsUserName = "MS_UserName";

        /// <summary>
        /// MS_Password
        /// </summary>
        public const string MsPassword = "MS_Password";

        /// <summary>
        /// MS_APIKey
        /// </summary>
        public const string MsApiKey = "MS_APIKey";

        /// <summary>
        /// MS_EndPointURI
        /// </summary>
        public const string MsEndPointUri = "MS_EndPointURI";

        /// <summary>
        /// SendGridFromAddress
        /// </summary>
        public const string SendGridFromAddress = "SendGridFromAddress";

        /// <summary>
        /// SendGridFromName
        /// </summary>
        public const string SendGridFromName = "SendGridFromName";

        /// <summary>
        /// CIAM_BaseUrl
        /// </summary>
        public const string CiamBaseUrl = "CIAMBaseUrl";

        /// <summary>
        /// AccountSid
        /// </summary>
        public const string AccountSid = "AccountSid";

        /// <summary>
        /// AuthToken
        /// </summary>
        public const string AuthToken = "AuthToken";

        /// <summary>
        /// SendMessageText
        /// </summary>
        public const string SendMessageText = "SendMessageText";

        /// <summary>
        /// FromPhoneNumber
        /// </summary>
        public const string FromPhoneNumber = "FromPhoneNumber";

        /// <summary>
        /// ThumbPrint
        /// </summary>
        public const string ThumbPrint = "ThumbPrint";

        /// <summary>
        /// ClientId
        /// </summary>
        public const string ClientId = "ClientId";

        /// <summary>
        /// RequestMaxAgeInSeconds
        /// </summary>
        public const string RequestMaxAgeInSeconds = "RequestMaxAgeInSeconds";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string EnableApiSecurity = "EnableAPISecurity";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string AuthPrefixUrl = "/mobile/auth/";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string SignInPostFixUrl = "/sign-in";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string RefreshPostFixUrl = "/refresh";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string SignOutPostFixUrl = "/sign-out";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string EnrollUserUrl = "/users/enrollment";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string RecoveryQuestionUrl = "/users/me/recovery/question";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string StateTokenUrl = "/users/me/recovery/start";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string ResetPasswordUrl = "/users/me/recovery/password";

        /// <summary>
        /// EnableAPISecurity
        /// </summary>
        public const string UpdateProfileUrl = "/users/me";

        /// <summary>
        /// Notifications Connection String
        /// </summary>
        public const string NotificationsConnectionString = "NotificationsConnectionString";

        /// <summary>
        /// Notification Hub Path
        /// </summary>
        public const string NotificationHubPath = "NotificationHubPath";

        /// <summary>
        /// mpns
        /// </summary>
        public const string Mpns = "mpns";

        /// <summary>
        /// result
        /// </summary>
        public const string CiamResult = "result";

        /// <summary>
        /// Refresh Token Expiration Time
        /// </summary>
        public const string RefreshTokenExpirationTime = "RefreshTokenExpirationTime";

        /// <summary>
        /// Refresh Token Expiration Time
        /// </summary>
        public const string RefreshTokenExpirationTimeConsumerUser = "refreshTokenExpirationTime";

        /// <summary>
        /// Status Id
        /// </summary>
        public const string StatusId = "StatusID";

        /// <summary>
        /// Query Model Limit
        /// </summary>
        public const string QueryModelLimit = "sortAndPaginationQueryModel.limit";

        /// <summary>
        /// Image Type
        /// </summary>
        public const string ImageType = "image/jpeg";

        /// <summary>
        /// Boolean value true
        /// </summary>
        public const string True = "true";

        /// <summary>
        /// Code
        /// </summary>
        public const string Code = "code";

        /// <summary>
        /// Error code
        /// </summary>
        public const string ErrorCode = "E0000004";

        /// <summary>
        /// App Setting
        /// </summary>
        public const string AppSettingMissing = "app setting is missing";

        #endregion

        #region Constant Fields for Response codes

        /// <summary>
        /// Display message "Request Process Successfully"
        /// </summary>
        public const string RequestProcessSuccessMessage = "The request was processed successfully";

        /// <summary>
        /// Display message "Invalid Or missing parameters"
        /// </summary>
        public const string InvalidParametersMessage = "Invalid Or missing parameters :";

        /// <summary>
        /// Display message "Unauthorized access"
        /// </summary>
        public const string UnauthorizedAccessMessage = "Unauthorized access";

        /// <summary>
        /// Display message "Invalid json data"
        /// </summary>
        public const string InvalidJsonDataMessage = "Invalid json data";

        /// <summary>
        /// Display message "Invalid tenant id"
        /// </summary>
        public const string InvalidTenantIdMessage = "Invalid tenant id";

        /// <summary>
        /// Display message "Invalid provider id"
        /// </summary>
        public const string InvalidProviderIdMessage = "Invalid provider id";

        /// <summary>
        /// Display message "Invalid case id"
        /// </summary>
        public const string InvalidCaseIdMessage = "Invalid case id";

        /// <summary>
        /// Display message "Invalid email id"
        /// </summary>
        public const string InvalidEmailIdMessage = "Invalid email Id";

        /// <summary>
        /// Display message "Invalid application id for user"
        /// </summary>
        public const string InvalidApplicationIdMessage = "Invalid application id for user";

        /// <summary>
        /// Display message "Case Id Existing"
        /// </summary>
        public const string CaseIdExistingMessage = "Case id Existing";

        /// <summary>
        /// Display message "Resource not found with the given details"
        /// </summary>
        public const string ResourceNotFoundMessage = "Resource not found with the given details";

        /// <summary>
        /// Display message "WhitelistUser not found with the given details"
        /// </summary>
        public const string WhitelistUserNotFoundMessage = "WhitelistUser not found with the given details";

        /// <summary>
        /// Display message "PatientCase not found with the given details"
        /// </summary>
        public const string PatientCaseNotFoundMessage = "PatientCase not found with the given details";

        /// <summary>
        /// Display message "Unable to update whitelist"
        /// </summary>
        public const string WhiteListUpdationFailedMessage = "Unable to update whitelist";

        /// <summary>
        /// Display message "Patient Cases failed to add"
        /// </summary>
        public const string PatientCasesFailedMessage = "Patient Cases failed to add";

        /// <summary>
        /// Display message "Patient cases not found with the given details"
        /// </summary>
        public const string PatientCasesNotAvailableMessage = "Patient cases not found with the given details";

        /// <summary>
        /// Display message "Invalid Application Id or User Id or Tenant Id for User"
        /// </summary>
        public const string UserNotAvailableMessage = "Invalid Application Id or User Id or Tenant Id for User:";

        /// <summary>
        /// Display message "Invalid Provider Id or Tenant Id"
        /// </summary>
        public const string InvalidRequestMessage = "Invalid Provider Id or Tenant Id";

        /// <summary>
        /// Given invalid Id(s)
        /// </summary>
        public const string InvalidRequestIdMessage = "Given Invalid Id(s)";

        /// <summary>
        /// Invalid Handle request
        /// </summary>
        public const string InvalidDeviceHandleMessage = "Invalid Handle request";

        /// <summary>
        /// Display message "Invalid Provider Id or Case Id"
        /// </summary>
        public const string InvalidProviderIdorCaseIdMessage = "Invalid Provider Id or Case Id";

        /// <summary>
        /// Display message "PatientCase Images empty or invalid"
        /// </summary>
        public const string InvalidPatientCaseImageMessage = "PatientCase Images empty or invalid";

        /// <summary>
        /// Display message "Profile picture is empty or invalid"
        /// </summary>
        public const string InvalidProviderPictureMessage = "Profile picture is empty or invalid";

        /// <summary>
        /// Display message "Terms of service not available for the given provider"
        /// </summary>
        public const string InvalidTosRequestMessage = "Terms of service not available for the given provider";

        /// <summary>
        /// Display message "Patient Cases failed to update"
        /// </summary>
        public const string PatientCasesUpdateFailedMessage = "Patient Cases failed to update";

        /// <summary>
        /// Display message "ProviderId already exists"
        /// </summary>
        public const string ProviderIdAlreadyExistsMessage = "ProviderId already exists";

        /// <summary>
        /// Display message "Review already completed for patient case"
        /// </summary>
        public const string PatientCaseReviewAlreadyExistsMessage = "Review already completed for patient case";

        /// <summary>
        /// Display message "Submitter can not review his submitted patient case"
        /// </summary>
        public const string SubmitterCantReviewPatientCaseMessage = "Submitter can not review his submitted patient case";

        /// <summary>
        /// Display message "Review In Progress"
        /// </summary>
        public const string ReviewInProgressMessage = "Review In Progress";

        /// <summary>
        /// Display message "WhitelistUserHistory not found for given user"
        /// </summary>
        public const string WhitelistUserHistoryNotAvailableMessage = "WhitelistUserHistory not found for given user";

        /// <summary>
        /// Display message "Patient case not locked. Please lock the case and then submit review comments"
        /// </summary>
        public const string PatientCaseNotLockedMessage = "Patient case not locked. Please lock the case and then submit review comments";

        /// <summary>
        /// Display message "Patient case is already locked"
        /// </summary>
        public const string PatientCaseAlreadyLockedMessage = "Patient case is already locked";

        /// <summary>
        /// Display message "Patient case is already completed and closed"
        /// </summary>
        public const string PatientCaseAlreadyClosedMessage = "Patient case is already completed and closed";

        /// <summary>
        /// Display message "Given patient case status id is not allowed in this context"
        /// </summary>
        public const string InvalidPatientCaseStatusMessage = "Given patient case status id is not allowed in this context";

        /// <summary>
        /// Display message "Patient case is not in locked mode"
        /// </summary>
        public const string PatientCaseNotLockedInLockedModeMessage = "Patient case is not in locked mode";

        /// <summary>
        /// Display message "Whitelist Users successfully added"
        /// </summary>
        public const string WhiteListUserAddedMessage = "Whitelist Users successfully added";

        /// <summary>
        /// Display message "domain was successfully added"
        /// </summary>
        public const string WhiteListDomainAddedMessage = "Domain was successfully added";

        /// <summary>
        /// Display message "domains were successfully added"
        /// </summary>
        public const string WhiteListDomainsAddedMessage = "Domains were successfully added";

        /// <summary>
        /// Display message "Patient Case successfully added"
        /// </summary>
        public const string PatientCasesAddedMessage = "Patient Case successfully added";

        /// <summary>
        /// Display message "Patient review successfully added"
        /// </summary>
        public const string PatientReviewAddedMessage = "Patient review successfully added";

        /// <summary>
        /// Display message "Patient Case Status successfully updated"
        /// </summary>
        public const string PatientCaseStatusUpdatedMessage = "Patient Case Status successfully updated";

        /// <summary>
        /// Display message "Adding Patient History is failed"
        /// </summary>
        public const string PatientHistoryNotAddedMessage = "Adding Patient History is failed";

        /// <summary>
        /// Display message "Whitelist Users InvalidData"
        /// </summary>
        public const string WhitelistUsersInvalidDataMessage = "Whitelist Users InvalidData";

        /// <summary>
        /// Display message "Device registered successfully "
        /// </summary>
        public const string DeviceRegisteredSuccessfullyMessage = "Device registered successfully ";

        /// <summary>
        /// Display message "Device registered with tag successfully"
        /// </summary>
        public const string DeviceRegisteredWithTagSuccessfullyMessage = "Device registered with tag successfully";

        /// <summary>
        /// Display message "Device registered deleted successfully "
        /// </summary>
        public const string DeviceRegisteredDeletedSuccessfullyMessage = "Device registered deleted successfully ";

        /// <summary>
        /// Display message "Notification sent successfully "
        /// </summary>
        public const string NotificationSentMessage = "Notification sent successfully ";

        /// <summary>
        /// Display message "WhitelistdomainUser not found with the given details"
        /// </summary>
        public const string WhitelistDomainUserNotAvailableMessage = "WhitelistdomainUser not found with the given details";

        /// <summary>
        /// Display message "Whitelist Users successfully updated"
        /// </summary>
        public const string WhitelistUsersUpdatedMessage = "Whitelist Users successfully updated";

        /// <summary>
        /// Display message "Whitelist Domains successfully updated"
        /// </summary>
        public const string WhitelistDomainsUpdatedMessage = "Whitelist Domains successfully updated";

        /// <summary>
        /// Display message "Whitelist details successfully updated"
        /// </summary>
        public const string WhitelistUpdatedMessage = "Whitelist details successfully updated";

        /// <summary>
        /// Display message "Whitelist user successfully updated"
        /// </summary>
        public const string WhitelistUserDeprovisionedMessage = "Whitelist user successfully updated";

        /// <summary>
        /// Display message "Invitation sent successfully"
        /// </summary>
        public const string InvitationSentMessage = "Invitation sent successfully";

        /// <summary>
        /// Display message "Email validation details added successfully"
        /// </summary>
        public const string EmailValidationAddedMessage = "Email validation details added successfully";

        /// <summary>
        /// Display message "Email validation failed. Validation information is missing"
        /// </summary>
        public const string EmailValidationFailedMessage = "Email validation failed. Validation information is missing";

        /// <summary>
        /// Display message "Whitelist domain successfully updated"
        /// </summary>
        public const string WhitelistDomainDeprovisionedMessage = "Whitelist domain successfully updated";

        /// <summary>
        /// Display message "Whitelist Domain not found with the given details"
        /// </summary>
        public const string WhitelistDomainNotAvailableMessage = "Whitelist Domain not found with the given details";

        /// <summary>
        /// Display message "Provider profile updated successfully"
        /// </summary>
        public const string ProfileUpdatedSuccessfullyMessage = "Provider profile updated successfully";

        /// <summary>
        /// Display message "User authentication failed"
        /// </summary>
        public const string UserAuthenticationFailedMessage = "User authentication failed";

        /// <summary>
        /// Display message "Unauthorized or invalid token"
        /// </summary>
        public const string UnAuthorizedTokenMessage = "Unauthorized or invalid token";

        /// <summary>
        /// Display message "Provider/User not found under any Tenant. User not white listed"
        /// </summary>
        public const string ProviderUserNotFoundMessage = "Provider/User not found under any Tenant. User not white listed";

        /// <summary>
        /// Display message "Provider not authorized for requested application"
        /// </summary>
        public const string UnAuthorizedGroupUserMessage = "Provider not authorized for requested application";

        /// <summary>
        /// Display message "Provider profile is missing under curbside. Profile should be added while enrolling process"
        /// </summary>
        public const string ProviderProfileMissingMessage = "Provider profile is missing under curbside. Profile should be added while enrolling process";

        /// <summary>
        /// Display message "Provider does not having accepted terms of services"
        /// </summary>
        public const string ProviderTosNotFoundMessage = "Provider does not having accepted terms of services";

        /// <summary>
        /// Display message "Whitelist Domain already exists or invalid application token"
        /// </summary>
        public const string WhitelistDomainExistsMessage = "Whitelist Domain already exists or invalid application token";

        /// <summary>
        /// Display message "Whitelist user already exists or invalid application token"
        /// </summary>
        public const string WhitelistUserExistsMessage = "Whitelist user already exists or invalid application token";

        /// <summary>
        /// Display message "Invalid UserName"
        /// </summary>
        public const string InvalidUserNameMessage = "Invalid UserName";

        /// <summary>
        /// Display message "User has to accept the terms"
        /// </summary>
        public const string InvalidAcceptedTermsMessage = "User has to accept the terms";

        /// <summary>
        /// Display message "Require atleast one recovery question"
        /// </summary>
        public const string RequireAtleastOneRecoveryQuestionMessage = "Require atleast one recovery question";

        /// <summary>
        /// Display message "User is not whitelisted"
        /// </summary>
        public const string UserNotWhitelistedMessage = "User is not whitelisted";

        /// <summary>
        /// Display message "User enrollment failed"
        /// </summary>
        public const string UserEnrollmentFailedMessage = "User enrollment failed";

        /// <summary>
        /// Display message "UserName not found"
        /// </summary>
        public const string UserNameNotFoundMessage = "UserName not found";

        /// <summary>
        /// Display message "Provider profile update failed"
        /// </summary>
        public const string UpdateProfileFailedMessage = "Provider profile update failed";

        /// <summary>
        /// Display message "Given TenantAppKey not found"
        /// </summary>
        public const string TenantAppKeyNotFoundMessage = "Given TenantAppKey not found";

        /// <summary>
        /// Display message @"No whitelist user matched with given TenantAppKey. Please make sure whether the user is white listed with appropriate Tenant and Application"
        /// </summary>
        public const string UserNotFoundUnderTenantAppKeyMessage = @"No whitelist user matched with given TenantAppKey. Please make sure whether the user is white listed with appropriate Tenant and Application";

        /// <summary>
        /// Display message @"Provider Tenant is not matching with given TenantAppKey"
        /// </summary>
        public const string TenantNotFoundUnderTenantAppKeyMessage = @"Provider Tenant is not matching with given TenantAppKey";

        /// <summary>
        /// Display message "Provider profile update failed at CIAM. Please verify session token"
        /// </summary>
        public const string UpdatedProfileFailedCiamMessage = "Provider profile update failed at CIAM. Please verify session token";

        /// <summary>
        /// Display message "Tenant-Application data not found"
        /// </summary>
        public const string TenantAppDataNotFoundMessage = "Tenant-Application data not found";

        /// <summary>
        /// Display message "Require State Token"
        /// </summary>
        public const string RequireStateTokenMessage = "Require State Token";

        /// <summary>
        /// Display message "Require answer"
        /// </summary>
        public const string InvalidAnswerMessage = "Require answer";

        /// <summary>
        /// Display message "Invalid state token or invalid answer"
        /// </summary>
        public const string InvalidAnswerAndTokenMessage = "Invalid state token or invalid answer";

        /// <summary>
        /// Display message "Invalid state token"
        /// </summary>
        public const string InvalidStateTokenMessage = "Invalid state token";

        /// <summary>
        /// Display message "Require New Password"
        /// </summary>
        public const string InvalidNewPasswordMessage = "Require New Password";

        /// <summary>
        /// Display message "Require Confirm Password"
        /// </summary>
        public const string InvalidConfirmPasswordMessage = "Require Confirm Password";

        /// <summary>
        /// Display message "New password and confirm password are not equal"
        /// </summary>
        public const string PasswordConfirmPasswordNotEqualMessage = "New password and confirm password are not equal";

        /// <summary>
        /// Display message "User not found with the given details"
        /// </summary>
        public const string ProviderNotAvailableMessage = "User not found with the given details";

        /// <summary>
        /// Display message "UserToken is missing"
        /// </summary>
        public const string UserTokenIsMissingMessage = "UserToken is missing";

        /// <summary>
        /// Display message "User session is not valid"
        /// </summary>
        public const string InvalidUserSessionMessage = "User session is not valid";

        /// <summary>
        /// Display message "User preferences updated successfully"
        /// </summary>
        public const string PreferencesUpdatedSuccessfullyMessage = "User preferences updated successfully";

        /// <summary>
        /// Display message "Phone details are not provided for the Provider Id"
        /// </summary>
        public const string PhoneNotAvailableMessage = "Phone details are not provided for the Provider Id";

        /// <summary>
        /// Display message "Email details are not provided for the Provider Id"
        /// </summary>
        public const string EmailNotAvailableMessage = "Email details are not provided for the Provider Id";

        /// <summary>
        /// Display message "SMS Code not found for the given details"
        /// </summary>
        public const string InvalidSmsCodeMessage = "SMS Code not found for the given details";

        /// <summary>
        /// Display message "Presentation video not found"
        /// </summary>
        public const string PresentationVideoNotFoundMessage = "Presentation video not found";

        /// <summary>
        /// Display message "SMS Code has already been used"
        /// </summary>
        public const string SmsCodeAlreadyUsedMessage = "SMS Code has already been used";

        /// <summary>
        /// Display message "ApplicationUpgrade record not found for the given details"
        /// </summary>
        public const string InvalidApplicationUpgradeDetailsMessage = "ApplicationUpgrade record not found for the given details";

        /// <summary>
        /// Display message "Patient case is successfully completed"
        /// </summary>
        public const string PatientCaseCompletedMessage = "Patient case is successfully completed";

        /// <summary>
        ///  Display message "Patient case is already completed"
        /// </summary>
        public const string PatientCaseAlreadyCompletedMessage = "Patient case is already completed";

        /// <summary>
        /// Display message "Provider already has terms of service"
        /// </summary>
        public const string ProviderTosAlreadyExistsMessage = "Provider already has terms of service";

        /// <summary>
        ///  Display message "Provider not found for the given details"
        /// </summary>
        public const string ProviderNotFoundMessage = "Provider not found for the given details";

        /// <summary>
        /// Display message "Invalid access token"
        /// </summary>
        public const string InvalidAccessTokenMessage = "Invalid access token";

        /// <summary>
        /// Display message "Invalid Profile"
        /// </summary>
        public const string InvalidProfileMessage = "Invalid Profile";

        /// <summary>
        /// Display message "Invalid refresh token session"
        /// </summary>
        public const string InvalidRefreshTokenSessionMessage = "Invalid refresh token session";

        /// <summary>
        /// Display message "Patient case review is completed but push notification failed"
        /// </summary>
        public const string PushNotificationFailedMessage = "Patient case review is completed but push notification failed";

        /// <summary>
        /// Display message "An unexpected error occurred. Please contact administrator"
        /// </summary>
        public const string InternalServerErrorMessage = "An unexpected error occurred. Please contact administrator";

        /// <summary>
        /// AppInsightsInstrumentationKey
        /// </summary>
        public const string AppInsightsInstrumentationKey = "AppInsightsInstrumentationKey";

        /// <summary>
        /// Required Group Memberships
        /// </summary>
        public const string RequiredGroupMemberships = "RequiredGroupMemberships";

        /// <summary>
        /// X-Unauthorized-Status
        /// </summary>
        public const string UnauthorizedHeader = "X-Unauthorized-Status";

        /// <summary>
        /// Groups
        /// </summary>
        public const string Groups = "groups";

        /// <summary>
        /// Access token expired
        /// </summary>
        public const string AccessTokenExpiredMessage = "Access token expired";

        /// <summary>
        /// NoAccessToken
        /// </summary>
        public const string NoAccessTokenMessage = "Access token not found with request headers";

        /// <summary>
        /// Unauthorized access token
        /// </summary>
        public const string UnauthorizedAccessTokenMessage = "Unauthorized access token";

        /// <summary>
        /// Insufficient user privileges
        /// </summary>
        public const string InsufficientUserPrivilegesMessage = "Insufficient user privileges";

        /// <summary>
        /// Autofac Json File Name
        /// </summary>
        public const string AutofacJsonFileName = "autofac.json";

        /// <summary>
        /// Issuer Metadata Endpoint
        /// </summary>
        public const string IssuerMetadataEndpoint = "IssuerMetadataEndpoint";

        /// <summary>
        /// Audience Token Validation Parameter
        /// </summary>
        public const string AudienceTokenValidationParameter = "aud";

        /// <summary>
        /// Issuer Token Validation Parameter
        /// </summary>
        public const string IssuerTokenValidationParameter = "iss";

        /// <summary>
        /// Audience
        /// </summary>
        public const string Audience = "Audience";

        /// <summary>
        /// ConsumerAudience
        /// </summary>
        public const string ConsumerAudience = "ConsumerAudience";

        /// <summary>
        ///Issuer
        /// </summary>
        public const string Issuer = "Issuer";

        /// <summary>
        ///ConsumerIssuer
        /// </summary>
        public const string ConsumerIssuer = "ConsumerIssuer";

        /// <summary>
        ///SwaggerNoAuthHeader
        /// </summary>
        public const string SwaggerNoAuthHeader = "SwaggerNoAuthHeader";

        /// <summary>
        /// EnableTrace
        /// </summary>
        public const string EnableTrace = "EnableTrace";

        /// <summary>
        /// Authorization 
        /// </summary>
        public const string Authorization = "Authorization";

        /// <summary>
        /// Auth Header
        /// </summary>
        public const string AuthHeader = "header";

        /// <summary>
        /// Auth Type
        /// </summary>
        public const string AuthType = "string";

        /// <summary>
        /// Auth Description
        /// </summary>
        public const string AuthDescription = "Authorization Access Token. Bearer {access_token}.";

        /// <summary>
        /// Media Site Playback Url
        /// </summary>
        public const string MediaSitePlaybackUrl = "MediaSitePlaybackUrl";

        /// <summary>
        /// Sort fields are not valid
        /// </summary>
        public const string InvalidOrderByField = "Order By field is not valid";

        /// <summary>
        /// At the rate symbol
        /// </summary>
        public const string AtSymbol = "@";
        #endregion
    }
}
