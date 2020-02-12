// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object model for updating an application's publish settings.
    /// </summary>
    public partial class PublishSettingUpdateObject
    {
        /// <summary>
        /// Initializes a new instance of the PublishSettingUpdateObject class.
        /// </summary>
        public PublishSettingUpdateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishSettingUpdateObject class.
        /// </summary>
        /// <param name="sentimentAnalysis">Setting sentiment analysis as true
        /// returns the Sentiment of the input utterance along with the
        /// response</param>
        /// <param name="speech">Setting speech as public enables speech
        /// priming in your app</param>
        /// <param name="spellChecker">Setting spell checker as public enables
        /// spell checking the input utterance.</param>
        public PublishSettingUpdateObject(bool sentimentAnalysis = default(bool), bool speech = default(bool), bool spellChecker = default(bool))
        {
            SentimentAnalysis = sentimentAnalysis;
            Speech = speech;
            SpellChecker = spellChecker;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets setting sentiment analysis as true returns the
        /// Sentiment of the input utterance along with the response
        /// </summary>
        [JsonProperty(PropertyName = "sentimentAnalysis")]
        public bool SentimentAnalysis { get; set; }

        /// <summary>
        /// Gets or sets setting speech as public enables speech priming in
        /// your app
        /// </summary>
        [JsonProperty(PropertyName = "speech")]
        public bool Speech { get; set; }

        /// <summary>
        /// Gets or sets setting spell checker as public enables spell checking
        /// the input utterance.
        /// </summary>
        [JsonProperty(PropertyName = "spellChecker")]
        public bool SpellChecker { get; set; }

    }
}
