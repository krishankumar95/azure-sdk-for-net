// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The TemplateName. </summary>
    public readonly partial struct TemplateName : IEquatable<TemplateName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TemplateName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TemplateName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApplicationApprovedNotificationMessageValue = "applicationApprovedNotificationMessage";
        private const string AccountClosedDeveloperValue = "accountClosedDeveloper";
        private const string QuotaLimitApproachingDeveloperNotificationMessageValue = "quotaLimitApproachingDeveloperNotificationMessage";
        private const string NewDeveloperNotificationMessageValue = "newDeveloperNotificationMessage";
        private const string EmailChangeIdentityDefaultValue = "emailChangeIdentityDefault";
        private const string InviteUserNotificationMessageValue = "inviteUserNotificationMessage";
        private const string NewCommentNotificationMessageValue = "newCommentNotificationMessage";
        private const string ConfirmSignUpIdentityDefaultValue = "confirmSignUpIdentityDefault";
        private const string NewIssueNotificationMessageValue = "newIssueNotificationMessage";
        private const string PurchaseDeveloperNotificationMessageValue = "purchaseDeveloperNotificationMessage";
        private const string PasswordResetIdentityDefaultValue = "passwordResetIdentityDefault";
        private const string PasswordResetByAdminNotificationMessageValue = "passwordResetByAdminNotificationMessage";
        private const string RejectDeveloperNotificationMessageValue = "rejectDeveloperNotificationMessage";
        private const string RequestDeveloperNotificationMessageValue = "requestDeveloperNotificationMessage";

        /// <summary> applicationApprovedNotificationMessage. </summary>
        public static TemplateName ApplicationApprovedNotificationMessage { get; } = new TemplateName(ApplicationApprovedNotificationMessageValue);
        /// <summary> accountClosedDeveloper. </summary>
        public static TemplateName AccountClosedDeveloper { get; } = new TemplateName(AccountClosedDeveloperValue);
        /// <summary> quotaLimitApproachingDeveloperNotificationMessage. </summary>
        public static TemplateName QuotaLimitApproachingDeveloperNotificationMessage { get; } = new TemplateName(QuotaLimitApproachingDeveloperNotificationMessageValue);
        /// <summary> newDeveloperNotificationMessage. </summary>
        public static TemplateName NewDeveloperNotificationMessage { get; } = new TemplateName(NewDeveloperNotificationMessageValue);
        /// <summary> emailChangeIdentityDefault. </summary>
        public static TemplateName EmailChangeIdentityDefault { get; } = new TemplateName(EmailChangeIdentityDefaultValue);
        /// <summary> inviteUserNotificationMessage. </summary>
        public static TemplateName InviteUserNotificationMessage { get; } = new TemplateName(InviteUserNotificationMessageValue);
        /// <summary> newCommentNotificationMessage. </summary>
        public static TemplateName NewCommentNotificationMessage { get; } = new TemplateName(NewCommentNotificationMessageValue);
        /// <summary> confirmSignUpIdentityDefault. </summary>
        public static TemplateName ConfirmSignUpIdentityDefault { get; } = new TemplateName(ConfirmSignUpIdentityDefaultValue);
        /// <summary> newIssueNotificationMessage. </summary>
        public static TemplateName NewIssueNotificationMessage { get; } = new TemplateName(NewIssueNotificationMessageValue);
        /// <summary> purchaseDeveloperNotificationMessage. </summary>
        public static TemplateName PurchaseDeveloperNotificationMessage { get; } = new TemplateName(PurchaseDeveloperNotificationMessageValue);
        /// <summary> passwordResetIdentityDefault. </summary>
        public static TemplateName PasswordResetIdentityDefault { get; } = new TemplateName(PasswordResetIdentityDefaultValue);
        /// <summary> passwordResetByAdminNotificationMessage. </summary>
        public static TemplateName PasswordResetByAdminNotificationMessage { get; } = new TemplateName(PasswordResetByAdminNotificationMessageValue);
        /// <summary> rejectDeveloperNotificationMessage. </summary>
        public static TemplateName RejectDeveloperNotificationMessage { get; } = new TemplateName(RejectDeveloperNotificationMessageValue);
        /// <summary> requestDeveloperNotificationMessage. </summary>
        public static TemplateName RequestDeveloperNotificationMessage { get; } = new TemplateName(RequestDeveloperNotificationMessageValue);
        /// <summary> Determines if two <see cref="TemplateName"/> values are the same. </summary>
        public static bool operator ==(TemplateName left, TemplateName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TemplateName"/> values are not the same. </summary>
        public static bool operator !=(TemplateName left, TemplateName right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="TemplateName"/>. </summary>
        public static implicit operator TemplateName(string value) => new TemplateName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TemplateName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TemplateName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
