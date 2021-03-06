// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace jschweda.luisDemo.client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LuisCognitiveServiceAPI.
    /// </summary>
    public static partial class LuisCognitiveServiceAPIExtensions
    {
            /// <summary>
            /// Gets the published endpoint predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='staging'>
            /// A boolean value indicating whether to use the staging endpoint instead of
            /// the default production endpoint.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            public static AppResponseV2 LuisV20AppsByAppIdGet(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, bool? staging = false, double? timezoneOffset = 0, bool? verbose = false, bool? log = true)
            {
                return operations.LuisV20AppsByAppIdGetAsync(appId, q, staging, timezoneOffset, verbose, log).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the published endpoint predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='staging'>
            /// A boolean value indicating whether to use the staging endpoint instead of
            /// the default production endpoint.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppResponseV2> LuisV20AppsByAppIdGetAsync(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, bool? staging = false, double? timezoneOffset = 0, bool? verbose = false, bool? log = true, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LuisV20AppsByAppIdGetWithHttpMessagesAsync(appId, q, staging, timezoneOffset, verbose, log, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the published endpoint predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='staging'>
            /// A boolean value indicating whether to use the staging endpoint instead of
            /// the default production endpoint.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            public static AppResponseV2 LuisV20AppsByAppIdPost(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, bool? staging = false, double? timezoneOffset = 0, bool? verbose = false, bool? log = true)
            {
                return operations.LuisV20AppsByAppIdPostAsync(appId, q, staging, timezoneOffset, verbose, log).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the published endpoint predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='staging'>
            /// A boolean value indicating whether to use the staging endpoint instead of
            /// the default production endpoint.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppResponseV2> LuisV20AppsByAppIdPostAsync(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, bool? staging = false, double? timezoneOffset = 0, bool? verbose = false, bool? log = true, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LuisV20AppsByAppIdPostWithHttpMessagesAsync(appId, q, staging, timezoneOffset, verbose, log, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the trained application predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='versionId'>
            /// The version id of the trained LUIS app.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            public static AppResponseV2 LuisV20AppsByAppIdVersionsByVersionIdGet(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, string versionId, double? timezoneOffset = 0, bool? verbose = false, bool? log = true)
            {
                return operations.LuisV20AppsByAppIdVersionsByVersionIdGetAsync(appId, q, versionId, timezoneOffset, verbose, log).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the trained application predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='versionId'>
            /// The version id of the trained LUIS app.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppResponseV2> LuisV20AppsByAppIdVersionsByVersionIdGetAsync(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, string versionId, double? timezoneOffset = 0, bool? verbose = false, bool? log = true, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LuisV20AppsByAppIdVersionsByVersionIdGetWithHttpMessagesAsync(appId, q, versionId, timezoneOffset, verbose, log, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the trained application predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='versionId'>
            /// The version id of the trained LUIS app.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            public static AppResponseV2 LuisV20AppsByAppIdVersionsByVersionIdPost(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, string versionId, double? timezoneOffset = 0, bool? verbose = false, bool? log = true)
            {
                return operations.LuisV20AppsByAppIdVersionsByVersionIdPostAsync(appId, q, versionId, timezoneOffset, verbose, log).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the trained application predictions for the given query. The current
            /// maximum query size is 500 characters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='appId'>
            /// The identifier of the LUIS app used to extract the intents and entities. A
            /// LUIS app is identified by a GUID and is obtained from the LUIS portal.
            /// </param>
            /// <param name='q'>
            /// The query to extract intents and entities from.
            /// </param>
            /// <param name='versionId'>
            /// The version id of the trained LUIS app.
            /// </param>
            /// <param name='timezoneOffset'>
            /// The timezone offset for the location of the request in minutes.
            /// </param>
            /// <param name='verbose'>
            /// A boolean value indicating whether to return all intents instead of just
            /// the top-scoring intent.
            /// </param>
            /// <param name='log'>
            /// A boolean value indicating whether to log the query.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AppResponseV2> LuisV20AppsByAppIdVersionsByVersionIdPostAsync(this ILuisCognitiveServiceAPI operations, System.Guid appId, string q, string versionId, double? timezoneOffset = 0, bool? verbose = false, bool? log = true, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.LuisV20AppsByAppIdVersionsByVersionIdPostWithHttpMessagesAsync(appId, q, versionId, timezoneOffset, verbose, log, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static ContainerStatus StatusGet(this ILuisCognitiveServiceAPI operations)
            {
                return operations.StatusGetAsync().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerStatus> StatusGetAsync(this ILuisCognitiveServiceAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.StatusGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
