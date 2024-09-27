// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> State of a Media Job. </summary>
    public readonly partial struct MediaJobState : IEquatable<MediaJobState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MediaJobState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MediaJobState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CanceledValue = "Canceled";
        private const string CancelingValue = "Canceling";
        private const string ErrorValue = "Error";
        private const string FinishedValue = "Finished";
        private const string ProcessingValue = "Processing";
        private const string QueuedValue = "Queued";
        private const string ScheduledValue = "Scheduled";

        /// <summary> The job was canceled. This is a final state for the job. </summary>
        public static MediaJobState Canceled { get; } = new MediaJobState(CanceledValue);
        /// <summary> The job is in the process of being canceled. This is a transient state for the job. </summary>
        public static MediaJobState Canceling { get; } = new MediaJobState(CancelingValue);
        /// <summary> The job has encountered an error. This is a final state for the job. </summary>
        public static MediaJobState Error { get; } = new MediaJobState(ErrorValue);
        /// <summary> The job is finished. This is a final state for the job. </summary>
        public static MediaJobState Finished { get; } = new MediaJobState(FinishedValue);
        /// <summary> The job is processing. This is a transient state for the job. </summary>
        public static MediaJobState Processing { get; } = new MediaJobState(ProcessingValue);
        /// <summary> The job is in a queued state, waiting for resources to become available. This is a transient state. </summary>
        public static MediaJobState Queued { get; } = new MediaJobState(QueuedValue);
        /// <summary> The job is being scheduled to run on an available resource. This is a transient state, between queued and processing states. </summary>
        public static MediaJobState Scheduled { get; } = new MediaJobState(ScheduledValue);
        /// <summary> Determines if two <see cref="MediaJobState"/> values are the same. </summary>
        public static bool operator ==(MediaJobState left, MediaJobState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MediaJobState"/> values are not the same. </summary>
        public static bool operator !=(MediaJobState left, MediaJobState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MediaJobState"/>. </summary>
        public static implicit operator MediaJobState(string value) => new MediaJobState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MediaJobState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MediaJobState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
