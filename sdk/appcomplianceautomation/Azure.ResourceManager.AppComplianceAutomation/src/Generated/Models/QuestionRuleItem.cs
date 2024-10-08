// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Scoping question rule. </summary>
    public readonly partial struct QuestionRuleItem : IEquatable<QuestionRuleItem>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="QuestionRuleItem"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QuestionRuleItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RequiredValue = "Required";
        private const string CharLengthValue = "CharLength";
        private const string UrlValue = "Url";
        private const string UrlsValue = "Urls";
        private const string DomainsValue = "Domains";
        private const string USPrivacyShieldValue = "USPrivacyShield";
        private const string PublicSOXValue = "PublicSOX";
        private const string CreditCardPCIValue = "CreditCardPCI";
        private const string AzureApplicationValue = "AzureApplication";
        private const string ValidGuidValue = "ValidGuid";
        private const string PublisherVerificationValue = "PublisherVerification";
        private const string DynamicDropdownValue = "DynamicDropdown";
        private const string PreventNonEnglishCharValue = "PreventNonEnglishChar";
        private const string ValidEmailValue = "ValidEmail";

        /// <summary> The question is required to answer. </summary>
        public static QuestionRuleItem Required { get; } = new QuestionRuleItem(RequiredValue);
        /// <summary> The question answer length is limited. </summary>
        public static QuestionRuleItem CharLength { get; } = new QuestionRuleItem(CharLengthValue);
        /// <summary> The question answer should be an Url. </summary>
        public static QuestionRuleItem Url { get; } = new QuestionRuleItem(UrlValue);
        /// <summary> The question answer should be Urls. </summary>
        public static QuestionRuleItem Urls { get; } = new QuestionRuleItem(UrlsValue);
        /// <summary> The question answer should be domains. </summary>
        public static QuestionRuleItem Domains { get; } = new QuestionRuleItem(DomainsValue);
        /// <summary> The question answer should be a UsPrivacyShield. </summary>
        public static QuestionRuleItem USPrivacyShield { get; } = new QuestionRuleItem(USPrivacyShieldValue);
        /// <summary> The question answer should be a PublicSOX. </summary>
        public static QuestionRuleItem PublicSOX { get; } = new QuestionRuleItem(PublicSOXValue);
        /// <summary> The question answer should be a CreditCardPCI. </summary>
        public static QuestionRuleItem CreditCardPCI { get; } = new QuestionRuleItem(CreditCardPCIValue);
        /// <summary> The question answer should be an AzureApplication. </summary>
        public static QuestionRuleItem AzureApplication { get; } = new QuestionRuleItem(AzureApplicationValue);
        /// <summary> The question answer should be a valid guid. </summary>
        public static QuestionRuleItem ValidGuid { get; } = new QuestionRuleItem(ValidGuidValue);
        /// <summary> The question answer should be publisher verification. </summary>
        public static QuestionRuleItem PublisherVerification { get; } = new QuestionRuleItem(PublisherVerificationValue);
        /// <summary> The question answer should be dynamic dropdown. </summary>
        public static QuestionRuleItem DynamicDropdown { get; } = new QuestionRuleItem(DynamicDropdownValue);
        /// <summary> The question answer should prevent non-english char. </summary>
        public static QuestionRuleItem PreventNonEnglishChar { get; } = new QuestionRuleItem(PreventNonEnglishCharValue);
        /// <summary> The question answer should be a valid email. </summary>
        public static QuestionRuleItem ValidEmail { get; } = new QuestionRuleItem(ValidEmailValue);
        /// <summary> Determines if two <see cref="QuestionRuleItem"/> values are the same. </summary>
        public static bool operator ==(QuestionRuleItem left, QuestionRuleItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QuestionRuleItem"/> values are not the same. </summary>
        public static bool operator !=(QuestionRuleItem left, QuestionRuleItem right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="QuestionRuleItem"/>. </summary>
        public static implicit operator QuestionRuleItem(string value) => new QuestionRuleItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QuestionRuleItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QuestionRuleItem other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
