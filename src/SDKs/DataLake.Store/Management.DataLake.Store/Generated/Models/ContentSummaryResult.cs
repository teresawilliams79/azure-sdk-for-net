// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Data Lake Store filesystem content summary information response.
    /// </summary>
    public partial class ContentSummaryResult
    {
        /// <summary>
        /// Initializes a new instance of the ContentSummaryResult class.
        /// </summary>
        public ContentSummaryResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContentSummaryResult class.
        /// </summary>
        /// <param name="contentSummary">the content summary for the specified
        /// path</param>
        public ContentSummaryResult(ContentSummary contentSummary = default(ContentSummary))
        {
            ContentSummary = contentSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the content summary for the specified path
        /// </summary>
        [JsonProperty(PropertyName = "contentSummary")]
        public ContentSummary ContentSummary { get; private set; }

    }
}
