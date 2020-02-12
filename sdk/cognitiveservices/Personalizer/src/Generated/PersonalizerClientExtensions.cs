// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PersonalizerClient.
    /// </summary>
    public static partial class PersonalizerClientExtensions
    {
            /// <summary>
            /// Post Rank.
            /// </summary>
            /// <remarks>
            /// Submit a Personalizer rank request, to get which of the provided actions
            /// should be used in the provided context.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rankRequest'>
            /// A Personalizer request.
            /// </param>
            public static RankResponse Rank(this IPersonalizerClient operations, RankRequest rankRequest)
            {
                return operations.RankAsync(rankRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Post Rank.
            /// </summary>
            /// <remarks>
            /// Submit a Personalizer rank request, to get which of the provided actions
            /// should be used in the provided context.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rankRequest'>
            /// A Personalizer request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RankResponse> RankAsync(this IPersonalizerClient operations, RankRequest rankRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RankWithHttpMessagesAsync(rankRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Post Rank.
            /// </summary>
            /// <remarks>
            /// Submit a Personalizer rank request, to get which of the provided actions
            /// should be used in the provided context.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='rankRequest'>
            /// A Personalizer request.
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<RankResponse> RankWithHttpMessages(this IPersonalizerClient operations, RankRequest rankRequest, Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.RankWithHttpMessagesAsync(rankRequest, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
