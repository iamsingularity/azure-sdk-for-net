// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Flexibly separates text into terms via a regular expression pattern.
    /// This analyzer is implemented using Apache Lucene.
    /// <see
    /// href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/PatternAnalyzer.html"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.PatternAnalyzer")]
    public partial class PatternAnalyzer : Analyzer
    {
        /// <summary>
        /// Initializes a new instance of the PatternAnalyzer class.
        /// </summary>
        public PatternAnalyzer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatternAnalyzer class.
        /// </summary>
        /// <param name="name">The name of the analyzer. It must only contain
        /// letters, digits, spaces, dashes or underscores, can only start and
        /// end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="lowerCaseTerms">A value indicating whether terms
        /// should be lower-cased. Default is true.</param>
        /// <param name="pattern">A regular expression pattern to match token
        /// separators. Default is an expression that matches one or more
        /// whitespace characters.</param>
        /// <param name="flags">Regular expression flags. Possible values
        /// include: 'CANON_EQ', 'CASE_INSENSITIVE', 'COMMENTS', 'DOTALL',
        /// 'LITERAL', 'MULTILINE', 'UNICODE_CASE', 'UNIX_LINES'</param>
        /// <param name="stopwords">A list of stopwords.</param>
        public PatternAnalyzer(string name, bool? lowerCaseTerms = default(bool?), string pattern = default(string), RegexFlags? flags = default(RegexFlags?), IList<string> stopwords = default(IList<string>))
            : base(name)
        {
            LowerCaseTerms = lowerCaseTerms;
            Pattern = pattern;
            Flags = flags;
            Stopwords = stopwords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating whether terms should be
        /// lower-cased. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "lowercase")]
        public bool? LowerCaseTerms { get; set; }

        /// <summary>
        /// Gets or sets a regular expression pattern to match token
        /// separators. Default is an expression that matches one or more
        /// whitespace characters.
        /// </summary>
        [JsonProperty(PropertyName = "pattern")]
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets regular expression flags. Possible values include:
        /// 'CANON_EQ', 'CASE_INSENSITIVE', 'COMMENTS', 'DOTALL', 'LITERAL',
        /// 'MULTILINE', 'UNICODE_CASE', 'UNIX_LINES'
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public RegexFlags? Flags { get; set; }

        /// <summary>
        /// Gets or sets a list of stopwords.
        /// </summary>
        [JsonProperty(PropertyName = "stopwords")]
        public IList<string> Stopwords { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
