﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace HelloConsole
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for HelloApiService.
    /// </summary>
    public static partial class HelloApiServiceExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> GetAll(this IHelloApiService operations)
            {
                return Task.Factory.StartNew(s => ((IHelloApiService)s).GetAllAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> GetAllAsync(this IHelloApiService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesPost(this IHelloApiService operations, string value = default(string))
            {
                Task.Factory.StartNew(s => ((IHelloApiService)s).ApiValuesPostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesPostAsync(this IHelloApiService operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiValuesByIdGet(this IHelloApiService operations, int id)
            {
                return Task.Factory.StartNew(s => ((IHelloApiService)s).ApiValuesByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiValuesByIdGetAsync(this IHelloApiService operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesByIdPut(this IHelloApiService operations, int id, string value = default(string))
            {
                Task.Factory.StartNew(s => ((IHelloApiService)s).ApiValuesByIdPutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdPutAsync(this IHelloApiService operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiValuesByIdDelete(this IHelloApiService operations, int id)
            {
                Task.Factory.StartNew(s => ((IHelloApiService)s).ApiValuesByIdDeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdDeleteAsync(this IHelloApiService operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
