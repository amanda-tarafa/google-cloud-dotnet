// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gscv = Google.Shopping.Css.V1;
using sys = System;

namespace Google.Shopping.Css.V1
{
    /// <summary>Resource name for the <c>QuotaGroup</c> resource.</summary>
    public sealed partial class QuotaGroupName : gax::IResourceName, sys::IEquatable<QuotaGroupName>
    {
        /// <summary>The possible contents of <see cref="QuotaGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>accounts/{account}/quotaGroups/{quota_group}</c>.</summary>
            AccountQuotaGroup = 1,
        }

        private static gax::PathTemplate s_accountQuotaGroup = new gax::PathTemplate("accounts/{account}/quotaGroups/{quota_group}");

        /// <summary>Creates a <see cref="QuotaGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QuotaGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QuotaGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QuotaGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QuotaGroupName"/> with the pattern <c>accounts/{account}/quotaGroups/{quota_group}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaGroupId">The <c>QuotaGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuotaGroupName"/> constructed from the provided ids.</returns>
        public static QuotaGroupName FromAccountQuotaGroup(string accountId, string quotaGroupId) =>
            new QuotaGroupName(ResourceNameType.AccountQuotaGroup, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), quotaGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaGroupId, nameof(quotaGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaGroupName"/> with pattern
        /// <c>accounts/{account}/quotaGroups/{quota_group}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaGroupId">The <c>QuotaGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaGroupName"/> with pattern
        /// <c>accounts/{account}/quotaGroups/{quota_group}</c>.
        /// </returns>
        public static string Format(string accountId, string quotaGroupId) => FormatAccountQuotaGroup(accountId, quotaGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaGroupName"/> with pattern
        /// <c>accounts/{account}/quotaGroups/{quota_group}</c>.
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaGroupId">The <c>QuotaGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaGroupName"/> with pattern
        /// <c>accounts/{account}/quotaGroups/{quota_group}</c>.
        /// </returns>
        public static string FormatAccountQuotaGroup(string accountId, string quotaGroupId) =>
            s_accountQuotaGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotaGroupId, nameof(quotaGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="QuotaGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/quotaGroups/{quota_group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="quotaGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QuotaGroupName"/> if successful.</returns>
        public static QuotaGroupName Parse(string quotaGroupName) => Parse(quotaGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QuotaGroupName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/quotaGroups/{quota_group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotaGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QuotaGroupName"/> if successful.</returns>
        public static QuotaGroupName Parse(string quotaGroupName, bool allowUnparsed) =>
            TryParse(quotaGroupName, allowUnparsed, out QuotaGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotaGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/quotaGroups/{quota_group}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="quotaGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotaGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotaGroupName, out QuotaGroupName result) =>
            TryParse(quotaGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotaGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>accounts/{account}/quotaGroups/{quota_group}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotaGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotaGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotaGroupName, bool allowUnparsed, out QuotaGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(quotaGroupName, nameof(quotaGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_accountQuotaGroup.TryParseName(quotaGroupName, out resourceName))
            {
                result = FromAccountQuotaGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(quotaGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QuotaGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountId = null, string quotaGroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountId = accountId;
            QuotaGroupId = quotaGroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QuotaGroupName"/> class from the component parts of pattern
        /// <c>accounts/{account}/quotaGroups/{quota_group}</c>
        /// </summary>
        /// <param name="accountId">The <c>Account</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaGroupId">The <c>QuotaGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public QuotaGroupName(string accountId, string quotaGroupId) : this(ResourceNameType.AccountQuotaGroup, accountId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountId, nameof(accountId)), quotaGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaGroupId, nameof(quotaGroupId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Account</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountId { get; }

        /// <summary>
        /// The <c>QuotaGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QuotaGroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.AccountQuotaGroup: return s_accountQuotaGroup.Expand(AccountId, QuotaGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QuotaGroupName);

        /// <inheritdoc/>
        public bool Equals(QuotaGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QuotaGroupName a, QuotaGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QuotaGroupName a, QuotaGroupName b) => !(a == b);
    }

    public partial class QuotaGroup
    {
        /// <summary>
        /// <see cref="gscv::QuotaGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gscv::QuotaGroupName QuotaGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gscv::QuotaGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListQuotaGroupsRequest
    {
        /// <summary>
        /// <see cref="AccountName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AccountName ParentAsAccountName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AccountName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
