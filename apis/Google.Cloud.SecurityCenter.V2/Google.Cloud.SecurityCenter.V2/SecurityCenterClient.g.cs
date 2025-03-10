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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.SecurityCenter.V2
{
    /// <summary>Settings for <see cref="SecurityCenterClient"/> instances.</summary>
    public sealed partial class SecurityCenterSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SecurityCenterSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SecurityCenterSettings"/>.</returns>
        public static SecurityCenterSettings GetDefault() => new SecurityCenterSettings();

        /// <summary>Constructs a new <see cref="SecurityCenterSettings"/> object with default settings.</summary>
        public SecurityCenterSettings()
        {
        }

        private SecurityCenterSettings(SecurityCenterSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BatchCreateResourceValueConfigsSettings = existing.BatchCreateResourceValueConfigsSettings;
            BulkMuteFindingsSettings = existing.BulkMuteFindingsSettings;
            BulkMuteFindingsOperationsSettings = existing.BulkMuteFindingsOperationsSettings.Clone();
            CreateBigQueryExportSettings = existing.CreateBigQueryExportSettings;
            CreateFindingSettings = existing.CreateFindingSettings;
            CreateMuteConfigSettings = existing.CreateMuteConfigSettings;
            CreateNotificationConfigSettings = existing.CreateNotificationConfigSettings;
            CreateSourceSettings = existing.CreateSourceSettings;
            DeleteBigQueryExportSettings = existing.DeleteBigQueryExportSettings;
            DeleteMuteConfigSettings = existing.DeleteMuteConfigSettings;
            DeleteNotificationConfigSettings = existing.DeleteNotificationConfigSettings;
            DeleteResourceValueConfigSettings = existing.DeleteResourceValueConfigSettings;
            GetBigQueryExportSettings = existing.GetBigQueryExportSettings;
            GetSimulationSettings = existing.GetSimulationSettings;
            GetValuedResourceSettings = existing.GetValuedResourceSettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            GetMuteConfigSettings = existing.GetMuteConfigSettings;
            GetNotificationConfigSettings = existing.GetNotificationConfigSettings;
            GetResourceValueConfigSettings = existing.GetResourceValueConfigSettings;
            GetSourceSettings = existing.GetSourceSettings;
            GroupFindingsSettings = existing.GroupFindingsSettings;
            ListAttackPathsSettings = existing.ListAttackPathsSettings;
            ListBigQueryExportsSettings = existing.ListBigQueryExportsSettings;
            ListFindingsSettings = existing.ListFindingsSettings;
            ListMuteConfigsSettings = existing.ListMuteConfigsSettings;
            ListNotificationConfigsSettings = existing.ListNotificationConfigsSettings;
            ListResourceValueConfigsSettings = existing.ListResourceValueConfigsSettings;
            ListSourcesSettings = existing.ListSourcesSettings;
            ListValuedResourcesSettings = existing.ListValuedResourcesSettings;
            SetFindingStateSettings = existing.SetFindingStateSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            SetMuteSettings = existing.SetMuteSettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            UpdateBigQueryExportSettings = existing.UpdateBigQueryExportSettings;
            UpdateExternalSystemSettings = existing.UpdateExternalSystemSettings;
            UpdateFindingSettings = existing.UpdateFindingSettings;
            UpdateMuteConfigSettings = existing.UpdateMuteConfigSettings;
            UpdateNotificationConfigSettings = existing.UpdateNotificationConfigSettings;
            UpdateResourceValueConfigSettings = existing.UpdateResourceValueConfigSettings;
            UpdateSecurityMarksSettings = existing.UpdateSecurityMarksSettings;
            UpdateSourceSettings = existing.UpdateSourceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SecurityCenterSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.BatchCreateResourceValueConfigs</c> and
        /// <c>SecurityCenterClient.BatchCreateResourceValueConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateResourceValueConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.BulkMuteFindings</c> and <c>SecurityCenterClient.BulkMuteFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BulkMuteFindingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>SecurityCenterClient.BulkMuteFindings</c> and
        /// <c>SecurityCenterClient.BulkMuteFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BulkMuteFindingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.CreateBigQueryExport</c> and <c>SecurityCenterClient.CreateBigQueryExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBigQueryExportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.CreateFinding</c> and <c>SecurityCenterClient.CreateFindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.CreateMuteConfig</c> and <c>SecurityCenterClient.CreateMuteConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMuteConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.CreateNotificationConfig</c> and
        /// <c>SecurityCenterClient.CreateNotificationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateNotificationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.CreateSource</c> and <c>SecurityCenterClient.CreateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.DeleteBigQueryExport</c> and <c>SecurityCenterClient.DeleteBigQueryExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBigQueryExportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.DeleteMuteConfig</c> and <c>SecurityCenterClient.DeleteMuteConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMuteConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.DeleteNotificationConfig</c> and
        /// <c>SecurityCenterClient.DeleteNotificationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteNotificationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.DeleteResourceValueConfig</c> and
        /// <c>SecurityCenterClient.DeleteResourceValueConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteResourceValueConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetBigQueryExport</c> and <c>SecurityCenterClient.GetBigQueryExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBigQueryExportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetSimulation</c> and <c>SecurityCenterClient.GetSimulationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSimulationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetValuedResource</c> and <c>SecurityCenterClient.GetValuedResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetValuedResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetIamPolicy</c> and <c>SecurityCenterClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetMuteConfig</c> and <c>SecurityCenterClient.GetMuteConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMuteConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetNotificationConfig</c> and <c>SecurityCenterClient.GetNotificationConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNotificationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetResourceValueConfig</c> and <c>SecurityCenterClient.GetResourceValueConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetResourceValueConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GetSource</c> and <c>SecurityCenterClient.GetSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.GroupFindings</c> and <c>SecurityCenterClient.GroupFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GroupFindingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListAttackPaths</c> and <c>SecurityCenterClient.ListAttackPathsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAttackPathsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListBigQueryExports</c> and <c>SecurityCenterClient.ListBigQueryExportsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBigQueryExportsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListFindings</c> and <c>SecurityCenterClient.ListFindingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFindingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListMuteConfigs</c> and <c>SecurityCenterClient.ListMuteConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMuteConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListNotificationConfigs</c> and <c>SecurityCenterClient.ListNotificationConfigsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNotificationConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListResourceValueConfigs</c> and
        /// <c>SecurityCenterClient.ListResourceValueConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListResourceValueConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListSources</c> and <c>SecurityCenterClient.ListSourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.ListValuedResources</c> and <c>SecurityCenterClient.ListValuedResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListValuedResourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.SetFindingState</c> and <c>SecurityCenterClient.SetFindingStateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetFindingStateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.SetIamPolicy</c> and <c>SecurityCenterClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.SetMute</c> and <c>SecurityCenterClient.SetMuteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetMuteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.TestIamPermissions</c> and <c>SecurityCenterClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateBigQueryExport</c> and <c>SecurityCenterClient.UpdateBigQueryExportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBigQueryExportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateExternalSystem</c> and <c>SecurityCenterClient.UpdateExternalSystemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateExternalSystemSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateFinding</c> and <c>SecurityCenterClient.UpdateFindingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFindingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateMuteConfig</c> and <c>SecurityCenterClient.UpdateMuteConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateMuteConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateNotificationConfig</c> and
        /// <c>SecurityCenterClient.UpdateNotificationConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNotificationConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateResourceValueConfig</c> and
        /// <c>SecurityCenterClient.UpdateResourceValueConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateResourceValueConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateSecurityMarks</c> and <c>SecurityCenterClient.UpdateSecurityMarksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSecurityMarksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterClient.UpdateSource</c> and <c>SecurityCenterClient.UpdateSourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SecurityCenterSettings"/> object.</returns>
        public SecurityCenterSettings Clone() => new SecurityCenterSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SecurityCenterClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class SecurityCenterClientBuilder : gaxgrpc::ClientBuilderBase<SecurityCenterClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SecurityCenterSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SecurityCenterClientBuilder() : base(SecurityCenterClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SecurityCenterClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SecurityCenterClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SecurityCenterClient Build()
        {
            SecurityCenterClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SecurityCenterClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SecurityCenterClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SecurityCenterClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SecurityCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SecurityCenterClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SecurityCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SecurityCenterClient.ChannelPool;
    }

    /// <summary>SecurityCenter client wrapper, for convenient use.</summary>
    /// <remarks>
    /// V2 APIs for Security Center service.
    /// </remarks>
    public abstract partial class SecurityCenterClient
    {
        /// <summary>
        /// The default endpoint for the SecurityCenter service, which is a host of "securitycenter.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "securitycenter.googleapis.com:443";

        /// <summary>The default SecurityCenter scopes.</summary>
        /// <remarks>
        /// The default SecurityCenter scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SecurityCenter.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SecurityCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SecurityCenterClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SecurityCenterClient"/>.</returns>
        public static stt::Task<SecurityCenterClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SecurityCenterClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SecurityCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SecurityCenterClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SecurityCenterClient"/>.</returns>
        public static SecurityCenterClient Create() => new SecurityCenterClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SecurityCenterClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SecurityCenterSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SecurityCenterClient"/>.</returns>
        internal static SecurityCenterClient Create(grpccore::CallInvoker callInvoker, SecurityCenterSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SecurityCenter.SecurityCenterClient grpcClient = new SecurityCenter.SecurityCenterClient(callInvoker);
            return new SecurityCenterClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC SecurityCenter client</summary>
        public virtual SecurityCenter.SecurityCenterClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateResourceValueConfigsResponse BatchCreateResourceValueConfigs(BatchCreateResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(BatchCreateResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(BatchCreateResourceValueConfigsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateResourceValueConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateResourceValueConfigsResponse BatchCreateResourceValueConfigs(string parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateResourceValueConfigs(new BatchCreateResourceValueConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(string parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateResourceValueConfigsAsync(new BatchCreateResourceValueConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(string parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateResourceValueConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateResourceValueConfigsResponse BatchCreateResourceValueConfigs(gagr::OrganizationName parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateResourceValueConfigs(new BatchCreateResourceValueConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(gagr::OrganizationName parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateResourceValueConfigsAsync(new BatchCreateResourceValueConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(gagr::OrganizationName parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateResourceValueConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateResourceValueConfigsResponse BatchCreateResourceValueConfigs(OrganizationLocationName parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateResourceValueConfigs(new BatchCreateResourceValueConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(OrganizationLocationName parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateResourceValueConfigsAsync(new BatchCreateResourceValueConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new ResourceValueConfig's parent.
        /// The parent field in the CreateResourceValueConfigRequest
        /// messages must either be empty or match this field.
        /// </param>
        /// <param name="requests">
        /// Required. The resource value configs to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(OrganizationLocationName parent, scg::IEnumerable<CreateResourceValueConfigRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateResourceValueConfigsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkMuteFindingsResponse, wkt::Empty> BulkMuteFindings(BulkMuteFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> BulkMuteFindingsAsync(BulkMuteFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> BulkMuteFindingsAsync(BulkMuteFindingsRequest request, st::CancellationToken cancellationToken) =>
            BulkMuteFindingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BulkMuteFindings</c>.</summary>
        public virtual lro::OperationsClient BulkMuteFindingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BulkMuteFindings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BulkMuteFindingsResponse, wkt::Empty> PollOnceBulkMuteFindings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkMuteFindingsResponse, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkMuteFindingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BulkMuteFindings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> PollOnceBulkMuteFindingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BulkMuteFindingsResponse, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BulkMuteFindingsOperationsClient, callSettings);

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, at which bulk action needs to be applied. If no
        /// location is specified, findings are updated in global. The following list
        /// shows some examples:
        /// 
        /// + `organizations/[organization_id]`
        /// + `organizations/[organization_id]/locations/[location_id]`
        /// + `folders/[folder_id]`
        /// + `folders/[folder_id]/locations/[location_id]`
        /// + `projects/[project_id]`
        /// + `projects/[project_id]/locations/[location_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkMuteFindingsResponse, wkt::Empty> BulkMuteFindings(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkMuteFindings(new BulkMuteFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, at which bulk action needs to be applied. If no
        /// location is specified, findings are updated in global. The following list
        /// shows some examples:
        /// 
        /// + `organizations/[organization_id]`
        /// + `organizations/[organization_id]/locations/[location_id]`
        /// + `folders/[folder_id]`
        /// + `folders/[folder_id]/locations/[location_id]`
        /// + `projects/[project_id]`
        /// + `projects/[project_id]/locations/[location_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> BulkMuteFindingsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkMuteFindingsAsync(new BulkMuteFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, at which bulk action needs to be applied. If no
        /// location is specified, findings are updated in global. The following list
        /// shows some examples:
        /// 
        /// + `organizations/[organization_id]`
        /// + `organizations/[organization_id]/locations/[location_id]`
        /// + `folders/[folder_id]`
        /// + `folders/[folder_id]/locations/[location_id]`
        /// + `projects/[project_id]`
        /// + `projects/[project_id]/locations/[location_id]`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> BulkMuteFindingsAsync(string parent, st::CancellationToken cancellationToken) =>
            BulkMuteFindingsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, at which bulk action needs to be applied. If no
        /// location is specified, findings are updated in global. The following list
        /// shows some examples:
        /// 
        /// + `organizations/[organization_id]`
        /// + `organizations/[organization_id]/locations/[location_id]`
        /// + `folders/[folder_id]`
        /// + `folders/[folder_id]/locations/[location_id]`
        /// + `projects/[project_id]`
        /// + `projects/[project_id]/locations/[location_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BulkMuteFindingsResponse, wkt::Empty> BulkMuteFindings(gax::IResourceName parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkMuteFindings(new BulkMuteFindingsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, at which bulk action needs to be applied. If no
        /// location is specified, findings are updated in global. The following list
        /// shows some examples:
        /// 
        /// + `organizations/[organization_id]`
        /// + `organizations/[organization_id]/locations/[location_id]`
        /// + `folders/[folder_id]`
        /// + `folders/[folder_id]/locations/[location_id]`
        /// + `projects/[project_id]`
        /// + `projects/[project_id]/locations/[location_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> BulkMuteFindingsAsync(gax::IResourceName parent, gaxgrpc::CallSettings callSettings = null) =>
            BulkMuteFindingsAsync(new BulkMuteFindingsRequest
            {
                ParentAsResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, at which bulk action needs to be applied. If no
        /// location is specified, findings are updated in global. The following list
        /// shows some examples:
        /// 
        /// + `organizations/[organization_id]`
        /// + `organizations/[organization_id]/locations/[location_id]`
        /// + `folders/[folder_id]`
        /// + `folders/[folder_id]/locations/[location_id]`
        /// + `projects/[project_id]`
        /// + `projects/[project_id]/locations/[location_id]`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> BulkMuteFindingsAsync(gax::IResourceName parent, st::CancellationToken cancellationToken) =>
            BulkMuteFindingsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport CreateBigQueryExport(CreateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(CreateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(CreateBigQueryExportRequest request, st::CancellationToken cancellationToken) =>
            CreateBigQueryExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport CreateBigQueryExport(string parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExport(new CreateBigQueryExportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(string parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExportAsync(new CreateBigQueryExportRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(string parent, BigQueryExport bigQueryExport, string bigQueryExportId, st::CancellationToken cancellationToken) =>
            CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport CreateBigQueryExport(OrganizationLocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExport(new CreateBigQueryExportRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(OrganizationLocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExportAsync(new CreateBigQueryExportRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(OrganizationLocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, st::CancellationToken cancellationToken) =>
            CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport CreateBigQueryExport(FolderLocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExport(new CreateBigQueryExportRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(FolderLocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExportAsync(new CreateBigQueryExportRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(FolderLocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, st::CancellationToken cancellationToken) =>
            CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport CreateBigQueryExport(gagr::LocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExport(new CreateBigQueryExportRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(gagr::LocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBigQueryExportAsync(new CreateBigQueryExportRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                BigQueryExportId = gax::GaxPreconditions.CheckNotNullOrEmpty(bigQueryExportId, nameof(bigQueryExportId)),
            }, callSettings);

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource of the new BigQuery export. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being created.
        /// </param>
        /// <param name="bigQueryExportId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> CreateBigQueryExportAsync(gagr::LocationName parent, BigQueryExport bigQueryExport, string bigQueryExportId, st::CancellationToken cancellationToken) =>
            CreateBigQueryExportAsync(parent, bigQueryExport, bigQueryExportId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding CreateFinding(CreateFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> CreateFindingAsync(CreateFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> CreateFindingAsync(CreateFindingRequest request, st::CancellationToken cancellationToken) =>
            CreateFindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new finding's parent. The following list
        /// shows some examples of the format:
        /// +
        /// `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// </param>
        /// <param name="finding">
        /// Required. The Finding being created. The name and security_marks will be
        /// ignored as they are both output only fields on this resource.
        /// </param>
        /// <param name="findingId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding CreateFinding(string parent, Finding finding, string findingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFinding(new CreateFindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
            }, callSettings);

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new finding's parent. The following list
        /// shows some examples of the format:
        /// +
        /// `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// </param>
        /// <param name="finding">
        /// Required. The Finding being created. The name and security_marks will be
        /// ignored as they are both output only fields on this resource.
        /// </param>
        /// <param name="findingId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> CreateFindingAsync(string parent, Finding finding, string findingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFindingAsync(new CreateFindingRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
            }, callSettings);

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new finding's parent. The following list
        /// shows some examples of the format:
        /// +
        /// `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// </param>
        /// <param name="finding">
        /// Required. The Finding being created. The name and security_marks will be
        /// ignored as they are both output only fields on this resource.
        /// </param>
        /// <param name="findingId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> CreateFindingAsync(string parent, Finding finding, string findingId, st::CancellationToken cancellationToken) =>
            CreateFindingAsync(parent, finding, findingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new finding's parent. The following list
        /// shows some examples of the format:
        /// +
        /// `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// </param>
        /// <param name="finding">
        /// Required. The Finding being created. The name and security_marks will be
        /// ignored as they are both output only fields on this resource.
        /// </param>
        /// <param name="findingId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding CreateFinding(SourceName parent, Finding finding, string findingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFinding(new CreateFindingRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
            }, callSettings);

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new finding's parent. The following list
        /// shows some examples of the format:
        /// +
        /// `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// </param>
        /// <param name="finding">
        /// Required. The Finding being created. The name and security_marks will be
        /// ignored as they are both output only fields on this resource.
        /// </param>
        /// <param name="findingId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> CreateFindingAsync(SourceName parent, Finding finding, string findingId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFindingAsync(new CreateFindingRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FindingId = gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)),
                Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
            }, callSettings);

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new finding's parent. The following list
        /// shows some examples of the format:
        /// +
        /// `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// </param>
        /// <param name="finding">
        /// Required. The Finding being created. The name and security_marks will be
        /// ignored as they are both output only fields on this resource.
        /// </param>
        /// <param name="findingId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must be alphanumeric and less than or equal to 32 characters and
        /// greater than 0 characters in length.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> CreateFindingAsync(SourceName parent, Finding finding, string findingId, st::CancellationToken cancellationToken) =>
            CreateFindingAsync(parent, finding, findingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(CreateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(CreateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(CreateMuteConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(string parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfig(new CreateMuteConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(string parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfigAsync(new CreateMuteConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(string parent, MuteConfig muteConfig, string muteConfigId, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(parent, muteConfig, muteConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(gagr::OrganizationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfig(new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::OrganizationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfigAsync(new CreateMuteConfigRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::OrganizationName parent, MuteConfig muteConfig, string muteConfigId, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(parent, muteConfig, muteConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(OrganizationLocationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfig(new CreateMuteConfigRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(OrganizationLocationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfigAsync(new CreateMuteConfigRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(OrganizationLocationName parent, MuteConfig muteConfig, string muteConfigId, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(parent, muteConfig, muteConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(gagr::FolderName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfig(new CreateMuteConfigRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::FolderName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfigAsync(new CreateMuteConfigRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::FolderName parent, MuteConfig muteConfig, string muteConfigId, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(parent, muteConfig, muteConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(FolderLocationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfig(new CreateMuteConfigRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(FolderLocationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfigAsync(new CreateMuteConfigRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(FolderLocationName parent, MuteConfig muteConfig, string muteConfigId, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(parent, muteConfig, muteConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(gagr::ProjectName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfig(new CreateMuteConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::ProjectName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfigAsync(new CreateMuteConfigRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::ProjectName parent, MuteConfig muteConfig, string muteConfigId, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(parent, muteConfig, muteConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig CreateMuteConfig(gagr::LocationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfig(new CreateMuteConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::LocationName parent, MuteConfig muteConfig, string muteConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMuteConfigAsync(new CreateMuteConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                MuteConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(muteConfigId, nameof(muteConfigId)),
            }, callSettings);

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new mute configs's parent. Its format is
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="muteConfig">
        /// Required. The mute config being created.
        /// </param>
        /// <param name="muteConfigId">
        /// Required. Unique identifier provided by the client within the parent scope.
        /// It must consist of only lowercase letters, numbers, and hyphens, must start
        /// with a letter, must end with either a letter or a number, and must be 63
        /// characters or less.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> CreateMuteConfigAsync(gagr::LocationName parent, MuteConfig muteConfig, string muteConfigId, st::CancellationToken cancellationToken) =>
            CreateMuteConfigAsync(parent, muteConfig, muteConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(CreateNotificationConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(string parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfig(new CreateNotificationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(string parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfigAsync(new CreateNotificationConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(string parent, NotificationConfig notificationConfig, string configId, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(parent, notificationConfig, configId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(OrganizationLocationName parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfig(new CreateNotificationConfigRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(OrganizationLocationName parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfigAsync(new CreateNotificationConfigRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(OrganizationLocationName parent, NotificationConfig notificationConfig, string configId, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(parent, notificationConfig, configId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(FolderLocationName parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfig(new CreateNotificationConfigRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(FolderLocationName parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfigAsync(new CreateNotificationConfigRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(FolderLocationName parent, NotificationConfig notificationConfig, string configId, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(parent, notificationConfig, configId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig CreateNotificationConfig(gagr::LocationName parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfig(new CreateNotificationConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(gagr::LocationName parent, NotificationConfig notificationConfig, string configId, gaxgrpc::CallSettings callSettings = null) =>
            CreateNotificationConfigAsync(new CreateNotificationConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(configId, nameof(configId)),
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new notification config's parent. Its format
        /// is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="notificationConfig">
        /// Required. The notification config being created. The name and the service
        /// account will be ignored as they are both output only fields on this
        /// resource.
        /// </param>
        /// <param name="configId">
        /// Required.
        /// Unique identifier provided by the client within the parent scope.
        /// It must be between 1 and 128 characters and contain alphanumeric
        /// characters, underscores, or hyphens only.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> CreateNotificationConfigAsync(gagr::LocationName parent, NotificationConfig notificationConfig, string configId, st::CancellationToken cancellationToken) =>
            CreateNotificationConfigAsync(parent, notificationConfig, configId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source CreateSource(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> CreateSourceAsync(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> CreateSourceAsync(CreateSourceRequest request, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new source's parent. Its format should be
        /// `organizations/[organization_id]`.
        /// </param>
        /// <param name="source">
        /// Required. The Source being created, only the display_name and description
        /// will be used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source CreateSource(string parent, Source source, gaxgrpc::CallSettings callSettings = null) =>
            CreateSource(new CreateSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new source's parent. Its format should be
        /// `organizations/[organization_id]`.
        /// </param>
        /// <param name="source">
        /// Required. The Source being created, only the display_name and description
        /// will be used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> CreateSourceAsync(string parent, Source source, gaxgrpc::CallSettings callSettings = null) =>
            CreateSourceAsync(new CreateSourceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new source's parent. Its format should be
        /// `organizations/[organization_id]`.
        /// </param>
        /// <param name="source">
        /// Required. The Source being created, only the display_name and description
        /// will be used. All other fields will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> CreateSourceAsync(string parent, Source source, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(parent, source, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new source's parent. Its format should be
        /// `organizations/[organization_id]`.
        /// </param>
        /// <param name="source">
        /// Required. The Source being created, only the display_name and description
        /// will be used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source CreateSource(gagr::OrganizationName parent, Source source, gaxgrpc::CallSettings callSettings = null) =>
            CreateSource(new CreateSourceRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new source's parent. Its format should be
        /// `organizations/[organization_id]`.
        /// </param>
        /// <param name="source">
        /// Required. The Source being created, only the display_name and description
        /// will be used. All other fields will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> CreateSourceAsync(gagr::OrganizationName parent, Source source, gaxgrpc::CallSettings callSettings = null) =>
            CreateSourceAsync(new CreateSourceRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
            }, callSettings);

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the new source's parent. Its format should be
        /// `organizations/[organization_id]`.
        /// </param>
        /// <param name="source">
        /// Required. The Source being created, only the display_name and description
        /// will be used. All other fields will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> CreateSourceAsync(gagr::OrganizationName parent, Source source, st::CancellationToken cancellationToken) =>
            CreateSourceAsync(parent, source, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBigQueryExport(DeleteBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBigQueryExportAsync(DeleteBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBigQueryExportAsync(DeleteBigQueryExportRequest request, st::CancellationToken cancellationToken) =>
            DeleteBigQueryExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BigQuery export to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}/locations/{location}/bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBigQueryExport(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBigQueryExport(new DeleteBigQueryExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BigQuery export to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}/locations/{location}/bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBigQueryExportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBigQueryExportAsync(new DeleteBigQueryExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BigQuery export to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}/locations/{location}/bigQueryExports/{export_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBigQueryExportAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteBigQueryExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BigQuery export to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}/locations/{location}/bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBigQueryExport(BigQueryExportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBigQueryExport(new DeleteBigQueryExportRequest
            {
                BigQueryExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BigQuery export to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}/locations/{location}/bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBigQueryExportAsync(BigQueryExportName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBigQueryExportAsync(new DeleteBigQueryExportRequest
            {
                BigQueryExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the BigQuery export to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}/locations/{location}/bigQueryExports/{export_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBigQueryExportAsync(BigQueryExportName name, st::CancellationToken cancellationToken) =>
            DeleteBigQueryExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMuteConfig(DeleteMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMuteConfigAsync(DeleteMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMuteConfigAsync(DeleteMuteConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to delete. The following list shows some
        /// examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMuteConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMuteConfig(new DeleteMuteConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to delete. The following list shows some
        /// examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMuteConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMuteConfigAsync(new DeleteMuteConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to delete. The following list shows some
        /// examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMuteConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteMuteConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to delete. The following list shows some
        /// examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMuteConfig(MuteConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMuteConfig(new DeleteMuteConfigRequest
            {
                MuteConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to delete. The following list shows some
        /// examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMuteConfigAsync(MuteConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteMuteConfigAsync(new DeleteMuteConfigRequest
            {
                MuteConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to delete. The following list shows some
        /// examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteMuteConfigAsync(MuteConfigName name, st::CancellationToken cancellationToken) =>
            DeleteMuteConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationConfig(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(DeleteNotificationConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfig(new DeleteNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfigAsync(new DeleteNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteNotificationConfig(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfig(new DeleteNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteNotificationConfigAsync(new DeleteNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to delete. The following list
        /// shows some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]notificationConfigs/[config_id]`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteNotificationConfigAsync(NotificationConfigName name, st::CancellationToken cancellationToken) =>
            DeleteNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteResourceValueConfig(DeleteResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteResourceValueConfigAsync(DeleteResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteResourceValueConfigAsync(DeleteResourceValueConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteResourceValueConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ResourceValueConfig to delete
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteResourceValueConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceValueConfig(new DeleteResourceValueConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ResourceValueConfig to delete
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteResourceValueConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceValueConfigAsync(new DeleteResourceValueConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ResourceValueConfig to delete
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteResourceValueConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteResourceValueConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ResourceValueConfig to delete
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteResourceValueConfig(ResourceValueConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceValueConfig(new DeleteResourceValueConfigRequest
            {
                ResourceValueConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ResourceValueConfig to delete
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteResourceValueConfigAsync(ResourceValueConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceValueConfigAsync(new DeleteResourceValueConfigRequest
            {
                ResourceValueConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the ResourceValueConfig to delete
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteResourceValueConfigAsync(ResourceValueConfigName name, st::CancellationToken cancellationToken) =>
            DeleteResourceValueConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport GetBigQueryExport(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(GetBigQueryExportRequest request, st::CancellationToken cancellationToken) =>
            GetBigQueryExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the BigQuery export to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}locations/{location}//bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport GetBigQueryExport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExport(new GetBigQueryExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the BigQuery export to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}locations/{location}//bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExportAsync(new GetBigQueryExportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the BigQuery export to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}locations/{location}//bigQueryExports/{export_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(string name, st::CancellationToken cancellationToken) =>
            GetBigQueryExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the BigQuery export to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}locations/{location}//bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport GetBigQueryExport(BigQueryExportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExport(new GetBigQueryExportRequest
            {
                BigQueryExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the BigQuery export to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}locations/{location}//bigQueryExports/{export_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(BigQueryExportName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBigQueryExportAsync(new GetBigQueryExportRequest
            {
                BigQueryExportName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the BigQuery export to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/{organization}/locations/{location}/bigQueryExports/{export_id}`
        /// + `folders/{folder}/locations/{location}/bigQueryExports/{export_id}`
        /// + `projects/{project}locations/{location}//bigQueryExports/{export_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> GetBigQueryExportAsync(BigQueryExportName name, st::CancellationToken cancellationToken) =>
            GetBigQueryExportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Simulation GetSimulation(GetSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Simulation> GetSimulationAsync(GetSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Simulation> GetSimulationAsync(GetSimulationRequest request, st::CancellationToken cancellationToken) =>
            GetSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="name">
        /// Required. The organization name or simulation name of this simulation
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/latest`
        /// `organizations/{organization}/simulations/{simulation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Simulation GetSimulation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSimulation(new GetSimulationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="name">
        /// Required. The organization name or simulation name of this simulation
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/latest`
        /// `organizations/{organization}/simulations/{simulation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Simulation> GetSimulationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSimulationAsync(new GetSimulationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="name">
        /// Required. The organization name or simulation name of this simulation
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/latest`
        /// `organizations/{organization}/simulations/{simulation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Simulation> GetSimulationAsync(string name, st::CancellationToken cancellationToken) =>
            GetSimulationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="name">
        /// Required. The organization name or simulation name of this simulation
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/latest`
        /// `organizations/{organization}/simulations/{simulation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Simulation GetSimulation(SimulationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSimulation(new GetSimulationRequest
            {
                SimulationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="name">
        /// Required. The organization name or simulation name of this simulation
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/latest`
        /// `organizations/{organization}/simulations/{simulation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Simulation> GetSimulationAsync(SimulationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSimulationAsync(new GetSimulationRequest
            {
                SimulationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="name">
        /// Required. The organization name or simulation name of this simulation
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/latest`
        /// `organizations/{organization}/simulations/{simulation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Simulation> GetSimulationAsync(SimulationName name, st::CancellationToken cancellationToken) =>
            GetSimulationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValuedResource GetValuedResource(GetValuedResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValuedResource> GetValuedResourceAsync(GetValuedResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValuedResource> GetValuedResourceAsync(GetValuedResourceRequest request, st::CancellationToken cancellationToken) =>
            GetValuedResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="name">
        /// Required. The name of this valued resource
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValuedResource GetValuedResource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetValuedResource(new GetValuedResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="name">
        /// Required. The name of this valued resource
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValuedResource> GetValuedResourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetValuedResourceAsync(new GetValuedResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="name">
        /// Required. The name of this valued resource
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValuedResource> GetValuedResourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetValuedResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="name">
        /// Required. The name of this valued resource
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValuedResource GetValuedResource(ValuedResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetValuedResource(new GetValuedResourceRequest
            {
                ValuedResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="name">
        /// Required. The name of this valued resource
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValuedResource> GetValuedResourceAsync(ValuedResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetValuedResourceAsync(new GetValuedResourceRequest
            {
                ValuedResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="name">
        /// Required. The name of this valued resource
        /// 
        /// Valid format:
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValuedResource> GetValuedResourceAsync(ValuedResourceName name, st::CancellationToken cancellationToken) =>
            GetValuedResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(string resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy GetIamPolicy(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicy(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, gaxgrpc::CallSettings callSettings = null) =>
            GetIamPolicyAsync(new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> GetIamPolicyAsync(gax::IResourceName resource, st::CancellationToken cancellationToken) =>
            GetIamPolicyAsync(resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig GetMuteConfig(GetMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> GetMuteConfigAsync(GetMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> GetMuteConfigAsync(GetMuteConfigRequest request, st::CancellationToken cancellationToken) =>
            GetMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig GetMuteConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMuteConfig(new GetMuteConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> GetMuteConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMuteConfigAsync(new GetMuteConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> GetMuteConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetMuteConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig GetMuteConfig(MuteConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMuteConfig(new GetMuteConfigRequest
            {
                MuteConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> GetMuteConfigAsync(MuteConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMuteConfigAsync(new GetMuteConfigRequest
            {
                MuteConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the mute config to retrieve. The following list shows
        /// some examples of the format:
        /// 
        /// + `organizations/{organization}/muteConfigs/{config_id}`
        /// +
        /// `organizations/{organization}/locations/{location}/muteConfigs/{config_id}`
        /// + `folders/{folder}/muteConfigs/{config_id}`
        /// + `folders/{folder}/locations/{location}/muteConfigs/{config_id}`
        /// + `projects/{project}/muteConfigs/{config_id}`
        /// + `projects/{project}/locations/{location}/muteConfigs/{config_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> GetMuteConfigAsync(MuteConfigName name, st::CancellationToken cancellationToken) =>
            GetMuteConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig GetNotificationConfig(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(GetNotificationConfigRequest request, st::CancellationToken cancellationToken) =>
            GetNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to get. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig GetNotificationConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfig(new GetNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to get. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfigAsync(new GetNotificationConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to get. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to get. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig GetNotificationConfig(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfig(new GetNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to get. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(NotificationConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNotificationConfigAsync(new GetNotificationConfigRequest
            {
                NotificationConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the notification config to get. The following list shows
        /// some examples of the format:
        /// 
        /// +
        /// `organizations/[organization_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `folders/[folder_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// +
        /// `projects/[project_id]/locations/[location_id]/notificationConfigs/[config_id]`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> GetNotificationConfigAsync(NotificationConfigName name, st::CancellationToken cancellationToken) =>
            GetNotificationConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceValueConfig GetResourceValueConfig(GetResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> GetResourceValueConfigAsync(GetResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> GetResourceValueConfigAsync(GetResourceValueConfigRequest request, st::CancellationToken cancellationToken) =>
            GetResourceValueConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource value config to retrieve. Its format is
        /// organizations/{organization}/resourceValueConfigs/{config_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceValueConfig GetResourceValueConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceValueConfig(new GetResourceValueConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource value config to retrieve. Its format is
        /// organizations/{organization}/resourceValueConfigs/{config_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> GetResourceValueConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceValueConfigAsync(new GetResourceValueConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource value config to retrieve. Its format is
        /// organizations/{organization}/resourceValueConfigs/{config_id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> GetResourceValueConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetResourceValueConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource value config to retrieve. Its format is
        /// organizations/{organization}/resourceValueConfigs/{config_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceValueConfig GetResourceValueConfig(ResourceValueConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceValueConfig(new GetResourceValueConfigRequest
            {
                ResourceValueConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource value config to retrieve. Its format is
        /// organizations/{organization}/resourceValueConfigs/{config_id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> GetResourceValueConfigAsync(ResourceValueConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceValueConfigAsync(new GetResourceValueConfigRequest
            {
                ResourceValueConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource value config to retrieve. Its format is
        /// organizations/{organization}/resourceValueConfigs/{config_id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> GetResourceValueConfigAsync(ResourceValueConfigName name, st::CancellationToken cancellationToken) =>
            GetResourceValueConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(GetSourceRequest request, st::CancellationToken cancellationToken) =>
            GetSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Required. Relative resource name of the source. Its format is
        /// `organizations/[organization_id]/source/[source_id]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSource(new GetSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Required. Relative resource name of the source. Its format is
        /// `organizations/[organization_id]/source/[source_id]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSourceAsync(new GetSourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Required. Relative resource name of the source. Its format is
        /// `organizations/[organization_id]/source/[source_id]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Required. Relative resource name of the source. Its format is
        /// `organizations/[organization_id]/source/[source_id]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source GetSource(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSource(new GetSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Required. Relative resource name of the source. Its format is
        /// `organizations/[organization_id]/source/[source_id]`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(SourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSourceAsync(new GetSourceRequest
            {
                SourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="name">
        /// Required. Relative resource name of the source. Its format is
        /// `organizations/[organization_id]/source/[source_id]`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> GetSourceAsync(SourceName name, st::CancellationToken cancellationToken) =>
            GetSourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GroupResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(GroupFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GroupResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(GroupFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source to groupBy. If no location is specified,
        /// finding is assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To groupBy across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/[location_id]`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-/locations/[location_id]`
        /// + `projects/{project_id}/sources/-`
        /// + `projects/{project_id}/sources/-/locations/[location_id]`
        /// </param>
        /// <param name="groupBy">
        /// Required. Expression that defines what assets fields to use for grouping.
        /// The string value should follow SQL syntax: comma separated list of fields.
        /// For example: "parent,resource_name".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GroupResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(string parent, string groupBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return GroupFindings(request, callSettings);
        }

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source to groupBy. If no location is specified,
        /// finding is assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To groupBy across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/[location_id]`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-/locations/[location_id]`
        /// + `projects/{project_id}/sources/-`
        /// + `projects/{project_id}/sources/-/locations/[location_id]`
        /// </param>
        /// <param name="groupBy">
        /// Required. Expression that defines what assets fields to use for grouping.
        /// The string value should follow SQL syntax: comma separated list of fields.
        /// For example: "parent,resource_name".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GroupResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(string parent, string groupBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return GroupFindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source to groupBy. If no location is specified,
        /// finding is assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To groupBy across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/[location_id]`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-/locations/[location_id]`
        /// + `projects/{project_id}/sources/-`
        /// + `projects/{project_id}/sources/-/locations/[location_id]`
        /// </param>
        /// <param name="groupBy">
        /// Required. Expression that defines what assets fields to use for grouping.
        /// The string value should follow SQL syntax: comma separated list of fields.
        /// For example: "parent,resource_name".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GroupResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(SourceName parent, string groupBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return GroupFindings(request, callSettings);
        }

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source to groupBy. If no location is specified,
        /// finding is assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To groupBy across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/[location_id]`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-/locations/[location_id]`
        /// + `projects/{project_id}/sources/-`
        /// + `projects/{project_id}/sources/-/locations/[location_id]`
        /// </param>
        /// <param name="groupBy">
        /// Required. Expression that defines what assets fields to use for grouping.
        /// The string value should follow SQL syntax: comma separated list of fields.
        /// For example: "parent,resource_name".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GroupResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(SourceName parent, string groupBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            GroupFindingsRequest request = new GroupFindingsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                GroupBy = gax::GaxPreconditions.CheckNotNullOrEmpty(groupBy, nameof(groupBy)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return GroupFindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPaths(ListAttackPathsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPathsAsync(ListAttackPathsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list attack paths.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPaths(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttackPaths(request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list attack paths.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPathsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttackPathsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list attack paths.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPaths(OrganizationValuedResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                ParentAsOrganizationValuedResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttackPaths(request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list attack paths.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPathsAsync(OrganizationValuedResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                ParentAsOrganizationValuedResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttackPathsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list attack paths.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPaths(ValuedResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                ParentAsValuedResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttackPaths(request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list attack paths.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// `organizations/{organization}/simulations/{simulation}/valuedResources/{valued_resource}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AttackPath"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPathsAsync(ValuedResourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAttackPathsRequest request = new ListAttackPathsRequest
            {
                ParentAsValuedResourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAttackPathsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExports(ListBigQueryExportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExportsAsync(ListBigQueryExportsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExports(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExports(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExportsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExports(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExports(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExportsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExports(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExports(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExportsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExports(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExports(request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of BigQuery exports. Its
        /// format is `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`, or
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BigQueryExport"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExportsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBigQueryExportsRequest request = new ListBigQueryExportsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBigQueryExportsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindings(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindingsAsync(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source the findings belong to. If no location is
        /// specified, the default is global. The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To list across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/{location_id}`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-locations/{location_id}`
        /// + `projects/{projects_id}/sources/-`
        /// + `projects/{projects_id}/sources/-/locations/{location_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindings(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindings(request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source the findings belong to. If no location is
        /// specified, the default is global. The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To list across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/{location_id}`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-locations/{location_id}`
        /// + `projects/{projects_id}/sources/-`
        /// + `projects/{projects_id}/sources/-/locations/{location_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindingsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source the findings belong to. If no location is
        /// specified, the default is global. The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To list across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/{location_id}`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-locations/{location_id}`
        /// + `projects/{projects_id}/sources/-`
        /// + `projects/{projects_id}/sources/-/locations/{location_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindings(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindings(request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the source the findings belong to. If no location is
        /// specified, the default is global. The following list shows some examples:
        /// 
        /// + `organizations/[organization_id]/sources/[source_id]`
        /// +
        /// `organizations/[organization_id]/sources/[source_id]/locations/[location_id]`
        /// + `folders/[folder_id]/sources/[source_id]`
        /// + `folders/[folder_id]/sources/[source_id]/locations/[location_id]`
        /// + `projects/[project_id]/sources/[source_id]`
        /// + `projects/[project_id]/sources/[source_id]/locations/[location_id]`
        /// 
        /// To list across all sources provide a source_id of `-`. The following
        /// list shows some examples:
        /// 
        /// + `organizations/{organization_id}/sources/-`
        /// + `organizations/{organization_id}/sources/-/locations/{location_id}`
        /// + `folders/{folder_id}/sources/-`
        /// + `folders/{folder_id}/sources/-locations/{location_id}`
        /// + `projects/{projects_id}/sources/-`
        /// + `projects/{projects_id}/sources/-/locations/{location_id}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindingsAsync(SourceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFindingsRequest request = new ListFindingsRequest
            {
                ParentAsSourceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFindingsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(ListMuteConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(ListMuteConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of mute configs. Its format
        /// is `organizations/[organization_id]", "folders/[folder_id]`,
        /// `projects/[project_id]`,
        /// `organizations/[organization_id]/locations/[location_id]`,
        /// `folders/[folder_id]/locations/[location_id]`,
        /// `projects/[project_id]/locations/[location_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMuteConfigsRequest request = new ListMuteConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListMuteConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent in which to list the notification
        /// configurations. Its format is
        /// "organizations/[organization_id]/locations/[location_id]",
        /// "folders/[folder_id]/locations/[location_id]", or
        /// "projects/[project_id]/locations/[location_id]".
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListNotificationConfigsRequest request = new ListNotificationConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListNotificationConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigs(ListResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigsAsync(ListResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of resource value configs.
        /// Its format is
        /// `organizations/[organization_id]`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceValueConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of resource value configs.
        /// Its format is
        /// `organizations/[organization_id]`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceValueConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of resource value configs.
        /// Its format is
        /// `organizations/[organization_id]`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigs(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceValueConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of resource value configs.
        /// Its format is
        /// `organizations/[organization_id]`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceValueConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of resource value configs.
        /// Its format is
        /// `organizations/[organization_id]`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigs(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceValueConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns the collection of resource value configs.
        /// Its format is
        /// `organizations/[organization_id]`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceValueConfigsRequest request = new ListResourceValueConfigsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourceValueConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSources(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSources(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSources(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSources(request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent of sources to list. Its format should
        /// be `organizations/[organization_id]`, `folders/[folder_id]`, or
        /// `projects/[project_id]`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSourcesRequest request = new ListSourcesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ValuedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResources(ListValuedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ValuedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResourcesAsync(ListValuedResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list exposed resources.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ValuedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListValuedResourcesRequest request = new ListValuedResourcesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListValuedResources(request, callSettings);
        }

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list exposed resources.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ValuedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListValuedResourcesRequest request = new ListValuedResourcesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListValuedResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list exposed resources.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ValuedResource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResources(SimulationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListValuedResourcesRequest request = new ListValuedResourcesRequest
            {
                ParentAsSimulationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListValuedResources(request, callSettings);
        }

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list exposed resources.
        /// 
        /// Valid formats:
        /// `organizations/{organization}`,
        /// `organizations/{organization}/simulations/{simulation}`
        /// `organizations/{organization}/simulations/{simulation}/attackExposureResults/{attack_exposure_result_v2}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ValuedResource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResourcesAsync(SimulationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListValuedResourcesRequest request = new ListValuedResourcesRequest
            {
                ParentAsSimulationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListValuedResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding SetFindingState(SetFindingStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(SetFindingStateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(SetFindingStateRequest request, st::CancellationToken cancellationToken) =>
            SetFindingStateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="state">
        /// Required. The desired State of the finding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding SetFindingState(string name, Finding.Types.State state, gaxgrpc::CallSettings callSettings = null) =>
            SetFindingState(new SetFindingStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                State = state,
            }, callSettings);

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="state">
        /// Required. The desired State of the finding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(string name, Finding.Types.State state, gaxgrpc::CallSettings callSettings = null) =>
            SetFindingStateAsync(new SetFindingStateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                State = state,
            }, callSettings);

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="state">
        /// Required. The desired State of the finding.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(string name, Finding.Types.State state, st::CancellationToken cancellationToken) =>
            SetFindingStateAsync(name, state, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="state">
        /// Required. The desired State of the finding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding SetFindingState(FindingName name, Finding.Types.State state, gaxgrpc::CallSettings callSettings = null) =>
            SetFindingState(new SetFindingStateRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                State = state,
            }, callSettings);

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="state">
        /// Required. The desired State of the finding.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(FindingName name, Finding.Types.State state, gaxgrpc::CallSettings callSettings = null) =>
            SetFindingStateAsync(new SetFindingStateRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                State = state,
            }, callSettings);

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="state">
        /// Required. The desired State of the finding.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetFindingStateAsync(FindingName name, Finding.Types.State state, st::CancellationToken cancellationToken) =>
            SetFindingStateAsync(name, state, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(string resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::Policy SetIamPolicy(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicy(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, gaxgrpc::CallSettings callSettings = null) =>
            SetIamPolicyAsync(new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::Policy> SetIamPolicyAsync(gax::IResourceName resource, gciv::Policy policy, st::CancellationToken cancellationToken) =>
            SetIamPolicyAsync(resource, policy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding SetMute(SetMuteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetMuteAsync(SetMuteRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetMuteAsync(SetMuteRequest request, st::CancellationToken cancellationToken) =>
            SetMuteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="mute">
        /// Required. The desired state of the Mute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding SetMute(string name, Finding.Types.Mute mute, gaxgrpc::CallSettings callSettings = null) =>
            SetMute(new SetMuteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Mute = mute,
            }, callSettings);

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="mute">
        /// Required. The desired state of the Mute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetMuteAsync(string name, Finding.Types.Mute mute, gaxgrpc::CallSettings callSettings = null) =>
            SetMuteAsync(new SetMuteRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Mute = mute,
            }, callSettings);

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="mute">
        /// Required. The desired state of the Mute.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetMuteAsync(string name, Finding.Types.Mute mute, st::CancellationToken cancellationToken) =>
            SetMuteAsync(name, mute, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="mute">
        /// Required. The desired state of the Mute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding SetMute(FindingName name, Finding.Types.Mute mute, gaxgrpc::CallSettings callSettings = null) =>
            SetMute(new SetMuteRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Mute = mute,
            }, callSettings);

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="mute">
        /// Required. The desired state of the Mute.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetMuteAsync(FindingName name, Finding.Types.Mute mute, gaxgrpc::CallSettings callSettings = null) =>
            SetMuteAsync(new SetMuteRequest
            {
                FindingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Mute = mute,
            }, callSettings);

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="name">
        /// Required. The [relative resource
        /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name)
        /// of the finding. If no location is specified, finding is assumed to be in
        /// global. The following list shows some examples:
        /// 
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `organizations/{organization_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `folders/{folder_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `folders/{folder_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// + `projects/{project_id}/sources/{source_id}/findings/{finding_id}`
        /// +
        /// `projects/{project_id}/sources/{source_id}/locations/{location_id}/findings/{finding_id}`
        /// </param>
        /// <param name="mute">
        /// Required. The desired state of the Mute.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> SetMuteAsync(FindingName name, Finding.Types.Mute mute, st::CancellationToken cancellationToken) =>
            SetMuteAsync(name, mute, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(string resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gciv::TestIamPermissionsResponse TestIamPermissions(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissions(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, gaxgrpc::CallSettings callSettings = null) =>
            TestIamPermissionsAsync(new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                Permissions =
                {
                    gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gax::IResourceName resource, scg::IEnumerable<string> permissions, st::CancellationToken cancellationToken) =>
            TestIamPermissionsAsync(resource, permissions, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport UpdateBigQueryExport(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(UpdateBigQueryExportRequest request, st::CancellationToken cancellationToken) =>
            UpdateBigQueryExportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BigQueryExport UpdateBigQueryExport(BigQueryExport bigQueryExport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBigQueryExport(new UpdateBigQueryExportRequest
            {
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(BigQueryExport bigQueryExport, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBigQueryExportAsync(new UpdateBigQueryExportRequest
            {
                BigQueryExport = gax::GaxPreconditions.CheckNotNull(bigQueryExport, nameof(bigQueryExport)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="bigQueryExport">
        /// Required. The BigQuery export being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BigQueryExport> UpdateBigQueryExportAsync(BigQueryExport bigQueryExport, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBigQueryExportAsync(bigQueryExport, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalSystem UpdateExternalSystem(UpdateExternalSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalSystem> UpdateExternalSystemAsync(UpdateExternalSystemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalSystem> UpdateExternalSystemAsync(UpdateExternalSystemRequest request, st::CancellationToken cancellationToken) =>
            UpdateExternalSystemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="externalSystem">
        /// Required. The external system resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the external system resource.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExternalSystem UpdateExternalSystem(ExternalSystem externalSystem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExternalSystem(new UpdateExternalSystemRequest
            {
                ExternalSystem = gax::GaxPreconditions.CheckNotNull(externalSystem, nameof(externalSystem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="externalSystem">
        /// Required. The external system resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the external system resource.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalSystem> UpdateExternalSystemAsync(ExternalSystem externalSystem, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateExternalSystemAsync(new UpdateExternalSystemRequest
            {
                ExternalSystem = gax::GaxPreconditions.CheckNotNull(externalSystem, nameof(externalSystem)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="externalSystem">
        /// Required. The external system resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the external system resource.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExternalSystem> UpdateExternalSystemAsync(ExternalSystem externalSystem, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateExternalSystemAsync(externalSystem, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding UpdateFinding(UpdateFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> UpdateFindingAsync(UpdateFindingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> UpdateFindingAsync(UpdateFindingRequest request, st::CancellationToken cancellationToken) =>
            UpdateFindingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="finding">
        /// Required. The finding resource to update or create if it does not already
        /// exist. parent, security_marks, and update_time will be ignored.
        /// 
        /// In the case of creation, the finding id portion of the name must be
        /// alphanumeric and less than or equal to 32 characters and greater than 0
        /// characters in length.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the finding resource. This field should
        /// not be specified when creating a finding.
        /// 
        /// When updating a finding, an empty mask is treated as updating all mutable
        /// fields and replacing source_properties.  Individual source_properties can
        /// be added/updated by using "source_properties.&lt;property key&gt;" in the field
        /// mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Finding UpdateFinding(Finding finding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFinding(new UpdateFindingRequest
            {
                Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="finding">
        /// Required. The finding resource to update or create if it does not already
        /// exist. parent, security_marks, and update_time will be ignored.
        /// 
        /// In the case of creation, the finding id portion of the name must be
        /// alphanumeric and less than or equal to 32 characters and greater than 0
        /// characters in length.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the finding resource. This field should
        /// not be specified when creating a finding.
        /// 
        /// When updating a finding, an empty mask is treated as updating all mutable
        /// fields and replacing source_properties.  Individual source_properties can
        /// be added/updated by using "source_properties.&lt;property key&gt;" in the field
        /// mask.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> UpdateFindingAsync(Finding finding, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFindingAsync(new UpdateFindingRequest
            {
                Finding = gax::GaxPreconditions.CheckNotNull(finding, nameof(finding)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="finding">
        /// Required. The finding resource to update or create if it does not already
        /// exist. parent, security_marks, and update_time will be ignored.
        /// 
        /// In the case of creation, the finding id portion of the name must be
        /// alphanumeric and less than or equal to 32 characters and greater than 0
        /// characters in length.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the finding resource. This field should
        /// not be specified when creating a finding.
        /// 
        /// When updating a finding, an empty mask is treated as updating all mutable
        /// fields and replacing source_properties.  Individual source_properties can
        /// be added/updated by using "source_properties.&lt;property key&gt;" in the field
        /// mask.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Finding> UpdateFindingAsync(Finding finding, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFindingAsync(finding, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig UpdateMuteConfig(UpdateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> UpdateMuteConfigAsync(UpdateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> UpdateMuteConfigAsync(UpdateMuteConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateMuteConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="muteConfig">
        /// Required. The mute config being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MuteConfig UpdateMuteConfig(MuteConfig muteConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMuteConfig(new UpdateMuteConfigRequest
            {
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="muteConfig">
        /// Required. The mute config being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> UpdateMuteConfigAsync(MuteConfig muteConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateMuteConfigAsync(new UpdateMuteConfigRequest
            {
                MuteConfig = gax::GaxPreconditions.CheckNotNull(muteConfig, nameof(muteConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="muteConfig">
        /// Required. The mute config being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MuteConfig> UpdateMuteConfigAsync(MuteConfig muteConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateMuteConfigAsync(muteConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig UpdateNotificationConfig(UpdateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> UpdateNotificationConfigAsync(UpdateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> UpdateNotificationConfigAsync(UpdateNotificationConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateNotificationConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="notificationConfig">
        /// Required. The notification config to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the notification config.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationConfig UpdateNotificationConfig(NotificationConfig notificationConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotificationConfig(new UpdateNotificationConfigRequest
            {
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="notificationConfig">
        /// Required. The notification config to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the notification config.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> UpdateNotificationConfigAsync(NotificationConfig notificationConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNotificationConfigAsync(new UpdateNotificationConfigRequest
            {
                NotificationConfig = gax::GaxPreconditions.CheckNotNull(notificationConfig, nameof(notificationConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="notificationConfig">
        /// Required. The notification config to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the notification config.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationConfig> UpdateNotificationConfigAsync(NotificationConfig notificationConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNotificationConfigAsync(notificationConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceValueConfig UpdateResourceValueConfig(UpdateResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> UpdateResourceValueConfigAsync(UpdateResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> UpdateResourceValueConfigAsync(UpdateResourceValueConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateResourceValueConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="resourceValueConfig">
        /// Required. The resource value config being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// 
        /// To update nested fields, include the top level field in the mask
        /// For example, to update gcp_metadata.resource_type, include the
        /// "gcp_metadata" field mask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceValueConfig UpdateResourceValueConfig(ResourceValueConfig resourceValueConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateResourceValueConfig(new UpdateResourceValueConfigRequest
            {
                ResourceValueConfig = gax::GaxPreconditions.CheckNotNull(resourceValueConfig, nameof(resourceValueConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="resourceValueConfig">
        /// Required. The resource value config being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// 
        /// To update nested fields, include the top level field in the mask
        /// For example, to update gcp_metadata.resource_type, include the
        /// "gcp_metadata" field mask
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> UpdateResourceValueConfigAsync(ResourceValueConfig resourceValueConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateResourceValueConfigAsync(new UpdateResourceValueConfigRequest
            {
                ResourceValueConfig = gax::GaxPreconditions.CheckNotNull(resourceValueConfig, nameof(resourceValueConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="resourceValueConfig">
        /// Required. The resource value config being updated.
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated.
        /// If empty all mutable fields will be updated.
        /// 
        /// To update nested fields, include the top level field in the mask
        /// For example, to update gcp_metadata.resource_type, include the
        /// "gcp_metadata" field mask
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceValueConfig> UpdateResourceValueConfigAsync(ResourceValueConfig resourceValueConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateResourceValueConfigAsync(resourceValueConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityMarks UpdateSecurityMarks(UpdateSecurityMarksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(UpdateSecurityMarksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(UpdateSecurityMarksRequest request, st::CancellationToken cancellationToken) =>
            UpdateSecurityMarksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="securityMarks">
        /// Required. The security marks resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the security marks resource.
        /// 
        /// The field mask must not contain duplicate fields.
        /// If empty or set to "marks", all marks will be replaced.  Individual
        /// marks can be updated using "marks.&lt;mark_key&gt;".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityMarks UpdateSecurityMarks(SecurityMarks securityMarks, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityMarks(new UpdateSecurityMarksRequest
            {
                SecurityMarks = gax::GaxPreconditions.CheckNotNull(securityMarks, nameof(securityMarks)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="securityMarks">
        /// Required. The security marks resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the security marks resource.
        /// 
        /// The field mask must not contain duplicate fields.
        /// If empty or set to "marks", all marks will be replaced.  Individual
        /// marks can be updated using "marks.&lt;mark_key&gt;".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(SecurityMarks securityMarks, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityMarksAsync(new UpdateSecurityMarksRequest
            {
                SecurityMarks = gax::GaxPreconditions.CheckNotNull(securityMarks, nameof(securityMarks)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="securityMarks">
        /// Required. The security marks resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the security marks resource.
        /// 
        /// The field mask must not contain duplicate fields.
        /// If empty or set to "marks", all marks will be replaced.  Individual
        /// marks can be updated using "marks.&lt;mark_key&gt;".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityMarks> UpdateSecurityMarksAsync(SecurityMarks securityMarks, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSecurityMarksAsync(securityMarks, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source UpdateSource(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> UpdateSourceAsync(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> UpdateSourceAsync(UpdateSourceRequest request, st::CancellationToken cancellationToken) =>
            UpdateSourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="source">
        /// Required. The source resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the source resource.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Source UpdateSource(Source source, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSource(new UpdateSourceRequest
            {
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="source">
        /// Required. The source resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the source resource.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> UpdateSourceAsync(Source source, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSourceAsync(new UpdateSourceRequest
            {
                Source = gax::GaxPreconditions.CheckNotNull(source, nameof(source)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="source">
        /// Required. The source resource to update.
        /// </param>
        /// <param name="updateMask">
        /// The FieldMask to use when updating the source resource.
        /// 
        /// If empty all mutable fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Source> UpdateSourceAsync(Source source, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSourceAsync(source, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SecurityCenter client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// V2 APIs for Security Center service.
    /// </remarks>
    public sealed partial class SecurityCenterClientImpl : SecurityCenterClient
    {
        private readonly gaxgrpc::ApiCall<BatchCreateResourceValueConfigsRequest, BatchCreateResourceValueConfigsResponse> _callBatchCreateResourceValueConfigs;

        private readonly gaxgrpc::ApiCall<BulkMuteFindingsRequest, lro::Operation> _callBulkMuteFindings;

        private readonly gaxgrpc::ApiCall<CreateBigQueryExportRequest, BigQueryExport> _callCreateBigQueryExport;

        private readonly gaxgrpc::ApiCall<CreateFindingRequest, Finding> _callCreateFinding;

        private readonly gaxgrpc::ApiCall<CreateMuteConfigRequest, MuteConfig> _callCreateMuteConfig;

        private readonly gaxgrpc::ApiCall<CreateNotificationConfigRequest, NotificationConfig> _callCreateNotificationConfig;

        private readonly gaxgrpc::ApiCall<CreateSourceRequest, Source> _callCreateSource;

        private readonly gaxgrpc::ApiCall<DeleteBigQueryExportRequest, wkt::Empty> _callDeleteBigQueryExport;

        private readonly gaxgrpc::ApiCall<DeleteMuteConfigRequest, wkt::Empty> _callDeleteMuteConfig;

        private readonly gaxgrpc::ApiCall<DeleteNotificationConfigRequest, wkt::Empty> _callDeleteNotificationConfig;

        private readonly gaxgrpc::ApiCall<DeleteResourceValueConfigRequest, wkt::Empty> _callDeleteResourceValueConfig;

        private readonly gaxgrpc::ApiCall<GetBigQueryExportRequest, BigQueryExport> _callGetBigQueryExport;

        private readonly gaxgrpc::ApiCall<GetSimulationRequest, Simulation> _callGetSimulation;

        private readonly gaxgrpc::ApiCall<GetValuedResourceRequest, ValuedResource> _callGetValuedResource;

        private readonly gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> _callGetIamPolicy;

        private readonly gaxgrpc::ApiCall<GetMuteConfigRequest, MuteConfig> _callGetMuteConfig;

        private readonly gaxgrpc::ApiCall<GetNotificationConfigRequest, NotificationConfig> _callGetNotificationConfig;

        private readonly gaxgrpc::ApiCall<GetResourceValueConfigRequest, ResourceValueConfig> _callGetResourceValueConfig;

        private readonly gaxgrpc::ApiCall<GetSourceRequest, Source> _callGetSource;

        private readonly gaxgrpc::ApiCall<GroupFindingsRequest, GroupFindingsResponse> _callGroupFindings;

        private readonly gaxgrpc::ApiCall<ListAttackPathsRequest, ListAttackPathsResponse> _callListAttackPaths;

        private readonly gaxgrpc::ApiCall<ListBigQueryExportsRequest, ListBigQueryExportsResponse> _callListBigQueryExports;

        private readonly gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> _callListFindings;

        private readonly gaxgrpc::ApiCall<ListMuteConfigsRequest, ListMuteConfigsResponse> _callListMuteConfigs;

        private readonly gaxgrpc::ApiCall<ListNotificationConfigsRequest, ListNotificationConfigsResponse> _callListNotificationConfigs;

        private readonly gaxgrpc::ApiCall<ListResourceValueConfigsRequest, ListResourceValueConfigsResponse> _callListResourceValueConfigs;

        private readonly gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> _callListSources;

        private readonly gaxgrpc::ApiCall<ListValuedResourcesRequest, ListValuedResourcesResponse> _callListValuedResources;

        private readonly gaxgrpc::ApiCall<SetFindingStateRequest, Finding> _callSetFindingState;

        private readonly gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> _callSetIamPolicy;

        private readonly gaxgrpc::ApiCall<SetMuteRequest, Finding> _callSetMute;

        private readonly gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> _callTestIamPermissions;

        private readonly gaxgrpc::ApiCall<UpdateBigQueryExportRequest, BigQueryExport> _callUpdateBigQueryExport;

        private readonly gaxgrpc::ApiCall<UpdateExternalSystemRequest, ExternalSystem> _callUpdateExternalSystem;

        private readonly gaxgrpc::ApiCall<UpdateFindingRequest, Finding> _callUpdateFinding;

        private readonly gaxgrpc::ApiCall<UpdateMuteConfigRequest, MuteConfig> _callUpdateMuteConfig;

        private readonly gaxgrpc::ApiCall<UpdateNotificationConfigRequest, NotificationConfig> _callUpdateNotificationConfig;

        private readonly gaxgrpc::ApiCall<UpdateResourceValueConfigRequest, ResourceValueConfig> _callUpdateResourceValueConfig;

        private readonly gaxgrpc::ApiCall<UpdateSecurityMarksRequest, SecurityMarks> _callUpdateSecurityMarks;

        private readonly gaxgrpc::ApiCall<UpdateSourceRequest, Source> _callUpdateSource;

        /// <summary>
        /// Constructs a client wrapper for the SecurityCenter service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SecurityCenterSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SecurityCenterClientImpl(SecurityCenter.SecurityCenterClient grpcClient, SecurityCenterSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SecurityCenterSettings effectiveSettings = settings ?? SecurityCenterSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            BulkMuteFindingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BulkMuteFindingsOperationsSettings, logger);
            _callBatchCreateResourceValueConfigs = clientHelper.BuildApiCall<BatchCreateResourceValueConfigsRequest, BatchCreateResourceValueConfigsResponse>("BatchCreateResourceValueConfigs", grpcClient.BatchCreateResourceValueConfigsAsync, grpcClient.BatchCreateResourceValueConfigs, effectiveSettings.BatchCreateResourceValueConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateResourceValueConfigs);
            Modify_BatchCreateResourceValueConfigsApiCall(ref _callBatchCreateResourceValueConfigs);
            _callBulkMuteFindings = clientHelper.BuildApiCall<BulkMuteFindingsRequest, lro::Operation>("BulkMuteFindings", grpcClient.BulkMuteFindingsAsync, grpcClient.BulkMuteFindings, effectiveSettings.BulkMuteFindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBulkMuteFindings);
            Modify_BulkMuteFindingsApiCall(ref _callBulkMuteFindings);
            _callCreateBigQueryExport = clientHelper.BuildApiCall<CreateBigQueryExportRequest, BigQueryExport>("CreateBigQueryExport", grpcClient.CreateBigQueryExportAsync, grpcClient.CreateBigQueryExport, effectiveSettings.CreateBigQueryExportSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBigQueryExport);
            Modify_CreateBigQueryExportApiCall(ref _callCreateBigQueryExport);
            _callCreateFinding = clientHelper.BuildApiCall<CreateFindingRequest, Finding>("CreateFinding", grpcClient.CreateFindingAsync, grpcClient.CreateFinding, effectiveSettings.CreateFindingSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFinding);
            Modify_CreateFindingApiCall(ref _callCreateFinding);
            _callCreateMuteConfig = clientHelper.BuildApiCall<CreateMuteConfigRequest, MuteConfig>("CreateMuteConfig", grpcClient.CreateMuteConfigAsync, grpcClient.CreateMuteConfig, effectiveSettings.CreateMuteConfigSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateMuteConfigRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent).WithExtractedParameter("location", "^organizations/[^/]+/locations/([^/]+)/?$", request => request.Parent).WithExtractedParameter("location", "^folders/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateMuteConfig);
            Modify_CreateMuteConfigApiCall(ref _callCreateMuteConfig);
            _callCreateNotificationConfig = clientHelper.BuildApiCall<CreateNotificationConfigRequest, NotificationConfig>("CreateNotificationConfig", grpcClient.CreateNotificationConfigAsync, grpcClient.CreateNotificationConfig, effectiveSettings.CreateNotificationConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateNotificationConfig);
            Modify_CreateNotificationConfigApiCall(ref _callCreateNotificationConfig);
            _callCreateSource = clientHelper.BuildApiCall<CreateSourceRequest, Source>("CreateSource", grpcClient.CreateSourceAsync, grpcClient.CreateSource, effectiveSettings.CreateSourceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSource);
            Modify_CreateSourceApiCall(ref _callCreateSource);
            _callDeleteBigQueryExport = clientHelper.BuildApiCall<DeleteBigQueryExportRequest, wkt::Empty>("DeleteBigQueryExport", grpcClient.DeleteBigQueryExportAsync, grpcClient.DeleteBigQueryExport, effectiveSettings.DeleteBigQueryExportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteBigQueryExport);
            Modify_DeleteBigQueryExportApiCall(ref _callDeleteBigQueryExport);
            _callDeleteMuteConfig = clientHelper.BuildApiCall<DeleteMuteConfigRequest, wkt::Empty>("DeleteMuteConfig", grpcClient.DeleteMuteConfigAsync, grpcClient.DeleteMuteConfig, effectiveSettings.DeleteMuteConfigSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteMuteConfigRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.Name).WithExtractedParameter("location", "^organizations/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.Name).WithExtractedParameter("location", "^folders/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteMuteConfig);
            Modify_DeleteMuteConfigApiCall(ref _callDeleteMuteConfig);
            _callDeleteNotificationConfig = clientHelper.BuildApiCall<DeleteNotificationConfigRequest, wkt::Empty>("DeleteNotificationConfig", grpcClient.DeleteNotificationConfigAsync, grpcClient.DeleteNotificationConfig, effectiveSettings.DeleteNotificationConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteNotificationConfig);
            Modify_DeleteNotificationConfigApiCall(ref _callDeleteNotificationConfig);
            _callDeleteResourceValueConfig = clientHelper.BuildApiCall<DeleteResourceValueConfigRequest, wkt::Empty>("DeleteResourceValueConfig", grpcClient.DeleteResourceValueConfigAsync, grpcClient.DeleteResourceValueConfig, effectiveSettings.DeleteResourceValueConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteResourceValueConfig);
            Modify_DeleteResourceValueConfigApiCall(ref _callDeleteResourceValueConfig);
            _callGetBigQueryExport = clientHelper.BuildApiCall<GetBigQueryExportRequest, BigQueryExport>("GetBigQueryExport", grpcClient.GetBigQueryExportAsync, grpcClient.GetBigQueryExport, effectiveSettings.GetBigQueryExportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBigQueryExport);
            Modify_GetBigQueryExportApiCall(ref _callGetBigQueryExport);
            _callGetSimulation = clientHelper.BuildApiCall<GetSimulationRequest, Simulation>("GetSimulation", grpcClient.GetSimulationAsync, grpcClient.GetSimulation, effectiveSettings.GetSimulationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSimulation);
            Modify_GetSimulationApiCall(ref _callGetSimulation);
            _callGetValuedResource = clientHelper.BuildApiCall<GetValuedResourceRequest, ValuedResource>("GetValuedResource", grpcClient.GetValuedResourceAsync, grpcClient.GetValuedResource, effectiveSettings.GetValuedResourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetValuedResource);
            Modify_GetValuedResourceApiCall(ref _callGetValuedResource);
            _callGetIamPolicy = clientHelper.BuildApiCall<gciv::GetIamPolicyRequest, gciv::Policy>("GetIamPolicy", grpcClient.GetIamPolicyAsync, grpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            _callGetMuteConfig = clientHelper.BuildApiCall<GetMuteConfigRequest, MuteConfig>("GetMuteConfig", grpcClient.GetMuteConfigAsync, grpcClient.GetMuteConfig, effectiveSettings.GetMuteConfigSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetMuteConfigRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.Name).WithExtractedParameter("location", "^organizations/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.Name).WithExtractedParameter("location", "^folders/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callGetMuteConfig);
            Modify_GetMuteConfigApiCall(ref _callGetMuteConfig);
            _callGetNotificationConfig = clientHelper.BuildApiCall<GetNotificationConfigRequest, NotificationConfig>("GetNotificationConfig", grpcClient.GetNotificationConfigAsync, grpcClient.GetNotificationConfig, effectiveSettings.GetNotificationConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNotificationConfig);
            Modify_GetNotificationConfigApiCall(ref _callGetNotificationConfig);
            _callGetResourceValueConfig = clientHelper.BuildApiCall<GetResourceValueConfigRequest, ResourceValueConfig>("GetResourceValueConfig", grpcClient.GetResourceValueConfigAsync, grpcClient.GetResourceValueConfig, effectiveSettings.GetResourceValueConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetResourceValueConfig);
            Modify_GetResourceValueConfigApiCall(ref _callGetResourceValueConfig);
            _callGetSource = clientHelper.BuildApiCall<GetSourceRequest, Source>("GetSource", grpcClient.GetSourceAsync, grpcClient.GetSource, effectiveSettings.GetSourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSource);
            Modify_GetSourceApiCall(ref _callGetSource);
            _callGroupFindings = clientHelper.BuildApiCall<GroupFindingsRequest, GroupFindingsResponse>("GroupFindings", grpcClient.GroupFindingsAsync, grpcClient.GroupFindings, effectiveSettings.GroupFindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGroupFindings);
            Modify_GroupFindingsApiCall(ref _callGroupFindings);
            _callListAttackPaths = clientHelper.BuildApiCall<ListAttackPathsRequest, ListAttackPathsResponse>("ListAttackPaths", grpcClient.ListAttackPathsAsync, grpcClient.ListAttackPaths, effectiveSettings.ListAttackPathsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAttackPaths);
            Modify_ListAttackPathsApiCall(ref _callListAttackPaths);
            _callListBigQueryExports = clientHelper.BuildApiCall<ListBigQueryExportsRequest, ListBigQueryExportsResponse>("ListBigQueryExports", grpcClient.ListBigQueryExportsAsync, grpcClient.ListBigQueryExports, effectiveSettings.ListBigQueryExportsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBigQueryExports);
            Modify_ListBigQueryExportsApiCall(ref _callListBigQueryExports);
            _callListFindings = clientHelper.BuildApiCall<ListFindingsRequest, ListFindingsResponse>("ListFindings", grpcClient.ListFindingsAsync, grpcClient.ListFindings, effectiveSettings.ListFindingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFindings);
            Modify_ListFindingsApiCall(ref _callListFindings);
            _callListMuteConfigs = clientHelper.BuildApiCall<ListMuteConfigsRequest, ListMuteConfigsResponse>("ListMuteConfigs", grpcClient.ListMuteConfigsAsync, grpcClient.ListMuteConfigs, effectiveSettings.ListMuteConfigsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListMuteConfigsRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/muteConfigs/?$", request => request.Parent).WithExtractedParameter("location", "^organizations/[^/]+/locations/([^/]+)/muteConfigs/?$", request => request.Parent).WithExtractedParameter("location", "^folders/[^/]+/locations/([^/]+)/muteConfigs/?$", request => request.Parent));
            Modify_ApiCall(ref _callListMuteConfigs);
            Modify_ListMuteConfigsApiCall(ref _callListMuteConfigs);
            _callListNotificationConfigs = clientHelper.BuildApiCall<ListNotificationConfigsRequest, ListNotificationConfigsResponse>("ListNotificationConfigs", grpcClient.ListNotificationConfigsAsync, grpcClient.ListNotificationConfigs, effectiveSettings.ListNotificationConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListNotificationConfigs);
            Modify_ListNotificationConfigsApiCall(ref _callListNotificationConfigs);
            _callListResourceValueConfigs = clientHelper.BuildApiCall<ListResourceValueConfigsRequest, ListResourceValueConfigsResponse>("ListResourceValueConfigs", grpcClient.ListResourceValueConfigsAsync, grpcClient.ListResourceValueConfigs, effectiveSettings.ListResourceValueConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListResourceValueConfigs);
            Modify_ListResourceValueConfigsApiCall(ref _callListResourceValueConfigs);
            _callListSources = clientHelper.BuildApiCall<ListSourcesRequest, ListSourcesResponse>("ListSources", grpcClient.ListSourcesAsync, grpcClient.ListSources, effectiveSettings.ListSourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSources);
            Modify_ListSourcesApiCall(ref _callListSources);
            _callListValuedResources = clientHelper.BuildApiCall<ListValuedResourcesRequest, ListValuedResourcesResponse>("ListValuedResources", grpcClient.ListValuedResourcesAsync, grpcClient.ListValuedResources, effectiveSettings.ListValuedResourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListValuedResources);
            Modify_ListValuedResourcesApiCall(ref _callListValuedResources);
            _callSetFindingState = clientHelper.BuildApiCall<SetFindingStateRequest, Finding>("SetFindingState", grpcClient.SetFindingStateAsync, grpcClient.SetFindingState, effectiveSettings.SetFindingStateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSetFindingState);
            Modify_SetFindingStateApiCall(ref _callSetFindingState);
            _callSetIamPolicy = clientHelper.BuildApiCall<gciv::SetIamPolicyRequest, gciv::Policy>("SetIamPolicy", grpcClient.SetIamPolicyAsync, grpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            _callSetMute = clientHelper.BuildApiCall<SetMuteRequest, Finding>("SetMute", grpcClient.SetMuteAsync, grpcClient.SetMute, effectiveSettings.SetMuteSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSetMute);
            Modify_SetMuteApiCall(ref _callSetMute);
            _callTestIamPermissions = clientHelper.BuildApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse>("TestIamPermissions", grpcClient.TestIamPermissionsAsync, grpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings).WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            _callUpdateBigQueryExport = clientHelper.BuildApiCall<UpdateBigQueryExportRequest, BigQueryExport>("UpdateBigQueryExport", grpcClient.UpdateBigQueryExportAsync, grpcClient.UpdateBigQueryExport, effectiveSettings.UpdateBigQueryExportSettings).WithGoogleRequestParam("big_query_export.name", request => request.BigQueryExport?.Name);
            Modify_ApiCall(ref _callUpdateBigQueryExport);
            Modify_UpdateBigQueryExportApiCall(ref _callUpdateBigQueryExport);
            _callUpdateExternalSystem = clientHelper.BuildApiCall<UpdateExternalSystemRequest, ExternalSystem>("UpdateExternalSystem", grpcClient.UpdateExternalSystemAsync, grpcClient.UpdateExternalSystem, effectiveSettings.UpdateExternalSystemSettings).WithGoogleRequestParam("external_system.name", request => request.ExternalSystem?.Name);
            Modify_ApiCall(ref _callUpdateExternalSystem);
            Modify_UpdateExternalSystemApiCall(ref _callUpdateExternalSystem);
            _callUpdateFinding = clientHelper.BuildApiCall<UpdateFindingRequest, Finding>("UpdateFinding", grpcClient.UpdateFindingAsync, grpcClient.UpdateFinding, effectiveSettings.UpdateFindingSettings).WithGoogleRequestParam("finding.name", request => request.Finding?.Name);
            Modify_ApiCall(ref _callUpdateFinding);
            Modify_UpdateFindingApiCall(ref _callUpdateFinding);
            _callUpdateMuteConfig = clientHelper.BuildApiCall<UpdateMuteConfigRequest, MuteConfig>("UpdateMuteConfig", grpcClient.UpdateMuteConfigAsync, grpcClient.UpdateMuteConfig, effectiveSettings.UpdateMuteConfigSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateMuteConfigRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.MuteConfig?.Name).WithExtractedParameter("location", "^organizations/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.MuteConfig?.Name).WithExtractedParameter("location", "^folders/[^/]+/locations/([^/]+)/muteConfigs/[^/]+/?$", request => request.MuteConfig?.Name));
            Modify_ApiCall(ref _callUpdateMuteConfig);
            Modify_UpdateMuteConfigApiCall(ref _callUpdateMuteConfig);
            _callUpdateNotificationConfig = clientHelper.BuildApiCall<UpdateNotificationConfigRequest, NotificationConfig>("UpdateNotificationConfig", grpcClient.UpdateNotificationConfigAsync, grpcClient.UpdateNotificationConfig, effectiveSettings.UpdateNotificationConfigSettings).WithGoogleRequestParam("notification_config.name", request => request.NotificationConfig?.Name);
            Modify_ApiCall(ref _callUpdateNotificationConfig);
            Modify_UpdateNotificationConfigApiCall(ref _callUpdateNotificationConfig);
            _callUpdateResourceValueConfig = clientHelper.BuildApiCall<UpdateResourceValueConfigRequest, ResourceValueConfig>("UpdateResourceValueConfig", grpcClient.UpdateResourceValueConfigAsync, grpcClient.UpdateResourceValueConfig, effectiveSettings.UpdateResourceValueConfigSettings).WithGoogleRequestParam("resource_value_config.name", request => request.ResourceValueConfig?.Name);
            Modify_ApiCall(ref _callUpdateResourceValueConfig);
            Modify_UpdateResourceValueConfigApiCall(ref _callUpdateResourceValueConfig);
            _callUpdateSecurityMarks = clientHelper.BuildApiCall<UpdateSecurityMarksRequest, SecurityMarks>("UpdateSecurityMarks", grpcClient.UpdateSecurityMarksAsync, grpcClient.UpdateSecurityMarks, effectiveSettings.UpdateSecurityMarksSettings).WithGoogleRequestParam("security_marks.name", request => request.SecurityMarks?.Name);
            Modify_ApiCall(ref _callUpdateSecurityMarks);
            Modify_UpdateSecurityMarksApiCall(ref _callUpdateSecurityMarks);
            _callUpdateSource = clientHelper.BuildApiCall<UpdateSourceRequest, Source>("UpdateSource", grpcClient.UpdateSourceAsync, grpcClient.UpdateSource, effectiveSettings.UpdateSourceSettings).WithGoogleRequestParam("source.name", request => request.Source?.Name);
            Modify_ApiCall(ref _callUpdateSource);
            Modify_UpdateSourceApiCall(ref _callUpdateSource);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_BatchCreateResourceValueConfigsApiCall(ref gaxgrpc::ApiCall<BatchCreateResourceValueConfigsRequest, BatchCreateResourceValueConfigsResponse> call);

        partial void Modify_BulkMuteFindingsApiCall(ref gaxgrpc::ApiCall<BulkMuteFindingsRequest, lro::Operation> call);

        partial void Modify_CreateBigQueryExportApiCall(ref gaxgrpc::ApiCall<CreateBigQueryExportRequest, BigQueryExport> call);

        partial void Modify_CreateFindingApiCall(ref gaxgrpc::ApiCall<CreateFindingRequest, Finding> call);

        partial void Modify_CreateMuteConfigApiCall(ref gaxgrpc::ApiCall<CreateMuteConfigRequest, MuteConfig> call);

        partial void Modify_CreateNotificationConfigApiCall(ref gaxgrpc::ApiCall<CreateNotificationConfigRequest, NotificationConfig> call);

        partial void Modify_CreateSourceApiCall(ref gaxgrpc::ApiCall<CreateSourceRequest, Source> call);

        partial void Modify_DeleteBigQueryExportApiCall(ref gaxgrpc::ApiCall<DeleteBigQueryExportRequest, wkt::Empty> call);

        partial void Modify_DeleteMuteConfigApiCall(ref gaxgrpc::ApiCall<DeleteMuteConfigRequest, wkt::Empty> call);

        partial void Modify_DeleteNotificationConfigApiCall(ref gaxgrpc::ApiCall<DeleteNotificationConfigRequest, wkt::Empty> call);

        partial void Modify_DeleteResourceValueConfigApiCall(ref gaxgrpc::ApiCall<DeleteResourceValueConfigRequest, wkt::Empty> call);

        partial void Modify_GetBigQueryExportApiCall(ref gaxgrpc::ApiCall<GetBigQueryExportRequest, BigQueryExport> call);

        partial void Modify_GetSimulationApiCall(ref gaxgrpc::ApiCall<GetSimulationRequest, Simulation> call);

        partial void Modify_GetValuedResourceApiCall(ref gaxgrpc::ApiCall<GetValuedResourceRequest, ValuedResource> call);

        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::GetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_GetMuteConfigApiCall(ref gaxgrpc::ApiCall<GetMuteConfigRequest, MuteConfig> call);

        partial void Modify_GetNotificationConfigApiCall(ref gaxgrpc::ApiCall<GetNotificationConfigRequest, NotificationConfig> call);

        partial void Modify_GetResourceValueConfigApiCall(ref gaxgrpc::ApiCall<GetResourceValueConfigRequest, ResourceValueConfig> call);

        partial void Modify_GetSourceApiCall(ref gaxgrpc::ApiCall<GetSourceRequest, Source> call);

        partial void Modify_GroupFindingsApiCall(ref gaxgrpc::ApiCall<GroupFindingsRequest, GroupFindingsResponse> call);

        partial void Modify_ListAttackPathsApiCall(ref gaxgrpc::ApiCall<ListAttackPathsRequest, ListAttackPathsResponse> call);

        partial void Modify_ListBigQueryExportsApiCall(ref gaxgrpc::ApiCall<ListBigQueryExportsRequest, ListBigQueryExportsResponse> call);

        partial void Modify_ListFindingsApiCall(ref gaxgrpc::ApiCall<ListFindingsRequest, ListFindingsResponse> call);

        partial void Modify_ListMuteConfigsApiCall(ref gaxgrpc::ApiCall<ListMuteConfigsRequest, ListMuteConfigsResponse> call);

        partial void Modify_ListNotificationConfigsApiCall(ref gaxgrpc::ApiCall<ListNotificationConfigsRequest, ListNotificationConfigsResponse> call);

        partial void Modify_ListResourceValueConfigsApiCall(ref gaxgrpc::ApiCall<ListResourceValueConfigsRequest, ListResourceValueConfigsResponse> call);

        partial void Modify_ListSourcesApiCall(ref gaxgrpc::ApiCall<ListSourcesRequest, ListSourcesResponse> call);

        partial void Modify_ListValuedResourcesApiCall(ref gaxgrpc::ApiCall<ListValuedResourcesRequest, ListValuedResourcesResponse> call);

        partial void Modify_SetFindingStateApiCall(ref gaxgrpc::ApiCall<SetFindingStateRequest, Finding> call);

        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<gciv::SetIamPolicyRequest, gciv::Policy> call);

        partial void Modify_SetMuteApiCall(ref gaxgrpc::ApiCall<SetMuteRequest, Finding> call);

        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<gciv::TestIamPermissionsRequest, gciv::TestIamPermissionsResponse> call);

        partial void Modify_UpdateBigQueryExportApiCall(ref gaxgrpc::ApiCall<UpdateBigQueryExportRequest, BigQueryExport> call);

        partial void Modify_UpdateExternalSystemApiCall(ref gaxgrpc::ApiCall<UpdateExternalSystemRequest, ExternalSystem> call);

        partial void Modify_UpdateFindingApiCall(ref gaxgrpc::ApiCall<UpdateFindingRequest, Finding> call);

        partial void Modify_UpdateMuteConfigApiCall(ref gaxgrpc::ApiCall<UpdateMuteConfigRequest, MuteConfig> call);

        partial void Modify_UpdateNotificationConfigApiCall(ref gaxgrpc::ApiCall<UpdateNotificationConfigRequest, NotificationConfig> call);

        partial void Modify_UpdateResourceValueConfigApiCall(ref gaxgrpc::ApiCall<UpdateResourceValueConfigRequest, ResourceValueConfig> call);

        partial void Modify_UpdateSecurityMarksApiCall(ref gaxgrpc::ApiCall<UpdateSecurityMarksRequest, SecurityMarks> call);

        partial void Modify_UpdateSourceApiCall(ref gaxgrpc::ApiCall<UpdateSourceRequest, Source> call);

        partial void OnConstruction(SecurityCenter.SecurityCenterClient grpcClient, SecurityCenterSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SecurityCenter client</summary>
        public override SecurityCenter.SecurityCenterClient GrpcClient { get; }

        partial void Modify_BatchCreateResourceValueConfigsRequest(ref BatchCreateResourceValueConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BulkMuteFindingsRequest(ref BulkMuteFindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBigQueryExportRequest(ref CreateBigQueryExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFindingRequest(ref CreateFindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateMuteConfigRequest(ref CreateMuteConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateNotificationConfigRequest(ref CreateNotificationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSourceRequest(ref CreateSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBigQueryExportRequest(ref DeleteBigQueryExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteMuteConfigRequest(ref DeleteMuteConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteNotificationConfigRequest(ref DeleteNotificationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteResourceValueConfigRequest(ref DeleteResourceValueConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBigQueryExportRequest(ref GetBigQueryExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSimulationRequest(ref GetSimulationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetValuedResourceRequest(ref GetValuedResourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIamPolicyRequest(ref gciv::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMuteConfigRequest(ref GetMuteConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNotificationConfigRequest(ref GetNotificationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetResourceValueConfigRequest(ref GetResourceValueConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSourceRequest(ref GetSourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GroupFindingsRequest(ref GroupFindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAttackPathsRequest(ref ListAttackPathsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBigQueryExportsRequest(ref ListBigQueryExportsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFindingsRequest(ref ListFindingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMuteConfigsRequest(ref ListMuteConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNotificationConfigsRequest(ref ListNotificationConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListResourceValueConfigsRequest(ref ListResourceValueConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSourcesRequest(ref ListSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListValuedResourcesRequest(ref ListValuedResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetFindingStateRequest(ref SetFindingStateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetIamPolicyRequest(ref gciv::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetMuteRequest(ref SetMuteRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestIamPermissionsRequest(ref gciv::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBigQueryExportRequest(ref UpdateBigQueryExportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateExternalSystemRequest(ref UpdateExternalSystemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFindingRequest(ref UpdateFindingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateMuteConfigRequest(ref UpdateMuteConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNotificationConfigRequest(ref UpdateNotificationConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateResourceValueConfigRequest(ref UpdateResourceValueConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSecurityMarksRequest(ref UpdateSecurityMarksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSourceRequest(ref UpdateSourceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateResourceValueConfigsResponse BatchCreateResourceValueConfigs(BatchCreateResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateResourceValueConfigsRequest(ref request, ref callSettings);
            return _callBatchCreateResourceValueConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a ResourceValueConfig for an organization. Maps user's tags to
        /// difference resource values for use by the attack path simulation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateResourceValueConfigsResponse> BatchCreateResourceValueConfigsAsync(BatchCreateResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateResourceValueConfigsRequest(ref request, ref callSettings);
            return _callBatchCreateResourceValueConfigs.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BulkMuteFindings</c>.</summary>
        public override lro::OperationsClient BulkMuteFindingsOperationsClient { get; }

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BulkMuteFindingsResponse, wkt::Empty> BulkMuteFindings(BulkMuteFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkMuteFindingsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkMuteFindingsResponse, wkt::Empty>(_callBulkMuteFindings.Sync(request, callSettings), BulkMuteFindingsOperationsClient);
        }

        /// <summary>
        /// Kicks off an LRO to bulk mute findings for a parent based on a filter. If
        /// no location is specified, findings are muted in global. The parent
        /// can be either an organization, folder, or project. The findings matched by
        /// the filter will be muted after the LRO is done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BulkMuteFindingsResponse, wkt::Empty>> BulkMuteFindingsAsync(BulkMuteFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BulkMuteFindingsRequest(ref request, ref callSettings);
            return new lro::Operation<BulkMuteFindingsResponse, wkt::Empty>(await _callBulkMuteFindings.Async(request, callSettings).ConfigureAwait(false), BulkMuteFindingsOperationsClient);
        }

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BigQueryExport CreateBigQueryExport(CreateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBigQueryExportRequest(ref request, ref callSettings);
            return _callCreateBigQueryExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BigQueryExport> CreateBigQueryExportAsync(CreateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBigQueryExportRequest(ref request, ref callSettings);
            return _callCreateBigQueryExport.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Finding CreateFinding(CreateFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFindingRequest(ref request, ref callSettings);
            return _callCreateFinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a finding in a location. The corresponding source must exist for
        /// finding creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Finding> CreateFindingAsync(CreateFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFindingRequest(ref request, ref callSettings);
            return _callCreateFinding.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MuteConfig CreateMuteConfig(CreateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMuteConfigRequest(ref request, ref callSettings);
            return _callCreateMuteConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a mute config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MuteConfig> CreateMuteConfigAsync(CreateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMuteConfigRequest(ref request, ref callSettings);
            return _callCreateMuteConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationConfig CreateNotificationConfig(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationConfigRequest(ref request, ref callSettings);
            return _callCreateNotificationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationConfig> CreateNotificationConfigAsync(CreateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateNotificationConfigRequest(ref request, ref callSettings);
            return _callCreateNotificationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Source CreateSource(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSourceRequest(ref request, ref callSettings);
            return _callCreateSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Source> CreateSourceAsync(CreateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSourceRequest(ref request, ref callSettings);
            return _callCreateSource.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBigQueryExport(DeleteBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBigQueryExportRequest(ref request, ref callSettings);
            _callDeleteBigQueryExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBigQueryExportAsync(DeleteBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBigQueryExportRequest(ref request, ref callSettings);
            return _callDeleteBigQueryExport.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMuteConfig(DeleteMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMuteConfigRequest(ref request, ref callSettings);
            _callDeleteMuteConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an existing mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteMuteConfigAsync(DeleteMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMuteConfigRequest(ref request, ref callSettings);
            return _callDeleteMuteConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteNotificationConfig(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationConfigRequest(ref request, ref callSettings);
            _callDeleteNotificationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteNotificationConfigAsync(DeleteNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteNotificationConfigRequest(ref request, ref callSettings);
            return _callDeleteNotificationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteResourceValueConfig(DeleteResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteResourceValueConfigRequest(ref request, ref callSettings);
            _callDeleteResourceValueConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteResourceValueConfigAsync(DeleteResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteResourceValueConfigRequest(ref request, ref callSettings);
            return _callDeleteResourceValueConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BigQueryExport GetBigQueryExport(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBigQueryExportRequest(ref request, ref callSettings);
            return _callGetBigQueryExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BigQueryExport> GetBigQueryExportAsync(GetBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBigQueryExportRequest(ref request, ref callSettings);
            return _callGetBigQueryExport.Async(request, callSettings);
        }

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Simulation GetSimulation(GetSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSimulationRequest(ref request, ref callSettings);
            return _callGetSimulation.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the simulation by name or the latest simulation for the given
        /// organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Simulation> GetSimulationAsync(GetSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSimulationRequest(ref request, ref callSettings);
            return _callGetSimulation.Async(request, callSettings);
        }

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValuedResource GetValuedResource(GetValuedResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetValuedResourceRequest(ref request, ref callSettings);
            return _callGetValuedResource.Sync(request, callSettings);
        }

        /// <summary>
        /// Get the valued resource by name
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValuedResource> GetValuedResourceAsync(GetValuedResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetValuedResourceRequest(ref request, ref callSettings);
            return _callGetValuedResource.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy GetIamPolicy(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> GetIamPolicyAsync(gciv::GetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MuteConfig GetMuteConfig(GetMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMuteConfigRequest(ref request, ref callSettings);
            return _callGetMuteConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MuteConfig> GetMuteConfigAsync(GetMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMuteConfigRequest(ref request, ref callSettings);
            return _callGetMuteConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationConfig GetNotificationConfig(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationConfigRequest(ref request, ref callSettings);
            return _callGetNotificationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a notification config.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationConfig> GetNotificationConfigAsync(GetNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNotificationConfigRequest(ref request, ref callSettings);
            return _callGetNotificationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceValueConfig GetResourceValueConfig(GetResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceValueConfigRequest(ref request, ref callSettings);
            return _callGetResourceValueConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a ResourceValueConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceValueConfig> GetResourceValueConfigAsync(GetResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceValueConfigRequest(ref request, ref callSettings);
            return _callGetResourceValueConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Source GetSource(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSourceRequest(ref request, ref callSettings);
            return _callGetSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Source> GetSourceAsync(GetSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSourceRequest(ref request, ref callSettings);
            return _callGetSource.Async(request, callSettings);
        }

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GroupResult"/> resources.</returns>
        public override gax::PagedEnumerable<GroupFindingsResponse, GroupResult> GroupFindings(GroupFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GroupFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GroupFindingsRequest, GroupFindingsResponse, GroupResult>(_callGroupFindings, request, callSettings);
        }

        /// <summary>
        /// Filters an organization or source's findings and groups them by their
        /// specified properties in a location. If no location is specified, findings
        /// are assumed to be in global
        /// 
        /// To group across all sources provide a `-` as the source id.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/folders/{folder_id}/sources/-/findings`
        /// + `/v2/folders/{folder_id}/sources/-/locations/{location_id}/findings`
        /// + `/v2/projects/{project_id}/sources/-/findings`
        /// + `/v2/projects/{project_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GroupResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<GroupFindingsResponse, GroupResult> GroupFindingsAsync(GroupFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GroupFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GroupFindingsRequest, GroupFindingsResponse, GroupResult>(_callGroupFindings, request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AttackPath"/> resources.</returns>
        public override gax::PagedEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPaths(ListAttackPathsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttackPathsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAttackPathsRequest, ListAttackPathsResponse, AttackPath>(_callListAttackPaths, request, callSettings);
        }

        /// <summary>
        /// Lists the attack paths for a set of simulation results or valued resources
        /// and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AttackPath"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAttackPathsResponse, AttackPath> ListAttackPathsAsync(ListAttackPathsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAttackPathsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAttackPathsRequest, ListAttackPathsResponse, AttackPath>(_callListAttackPaths, request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BigQueryExport"/> resources.</returns>
        public override gax::PagedEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExports(ListBigQueryExportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBigQueryExportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBigQueryExportsRequest, ListBigQueryExportsResponse, BigQueryExport>(_callListBigQueryExports, request, callSettings);
        }

        /// <summary>
        /// Lists BigQuery exports. Note that when requesting BigQuery exports at a
        /// given level all exports under that level are also returned e.g. if
        /// requesting BigQuery exports under a folder, then all BigQuery exports
        /// immediately under the folder plus the ones created under the projects
        /// within the folder are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BigQueryExport"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBigQueryExportsResponse, BigQueryExport> ListBigQueryExportsAsync(ListBigQueryExportsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBigQueryExportsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBigQueryExportsRequest, ListBigQueryExportsResponse, BigQueryExport>(_callListBigQueryExports, request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindings(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFindingsRequest, ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// Lists an organization or source's findings.
        /// 
        /// To list across all sources for a given location provide a `-` as the source
        /// id. If no location is specified, finding are assumed to be in global.
        /// The following list shows some examples:
        /// 
        /// + `/v2/organizations/{organization_id}/sources/-/findings`
        /// +
        /// `/v2/organizations/{organization_id}/sources/-/locations/{location_id}/findings`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ListFindingsResponse.Types.ListFindingsResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult> ListFindingsAsync(ListFindingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFindingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFindingsRequest, ListFindingsResponse, ListFindingsResponse.Types.ListFindingsResult>(_callListFindings, request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MuteConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigs(ListMuteConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMuteConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMuteConfigsRequest, ListMuteConfigsResponse, MuteConfig>(_callListMuteConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists mute configs. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MuteConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMuteConfigsResponse, MuteConfig> ListMuteConfigsAsync(ListMuteConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMuteConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMuteConfigsRequest, ListMuteConfigsResponse, MuteConfig>(_callListMuteConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigs(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNotificationConfigsRequest, ListNotificationConfigsResponse, NotificationConfig>(_callListNotificationConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists notification configs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNotificationConfigsResponse, NotificationConfig> ListNotificationConfigsAsync(ListNotificationConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNotificationConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNotificationConfigsRequest, ListNotificationConfigsResponse, NotificationConfig>(_callListNotificationConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigs(ListResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceValueConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListResourceValueConfigsRequest, ListResourceValueConfigsResponse, ResourceValueConfig>(_callListResourceValueConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists all ResourceValueConfigs.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceValueConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListResourceValueConfigsResponse, ResourceValueConfig> ListResourceValueConfigsAsync(ListResourceValueConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceValueConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListResourceValueConfigsRequest, ListResourceValueConfigsResponse, ResourceValueConfig>(_callListResourceValueConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Source"/> resources.</returns>
        public override gax::PagedEnumerable<ListSourcesResponse, Source> ListSources(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSourcesRequest, ListSourcesResponse, Source>(_callListSources, request, callSettings);
        }

        /// <summary>
        /// Lists all sources belonging to an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Source"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSourcesResponse, Source> ListSourcesAsync(ListSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSourcesRequest, ListSourcesResponse, Source>(_callListSources, request, callSettings);
        }

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ValuedResource"/> resources.</returns>
        public override gax::PagedEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResources(ListValuedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListValuedResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListValuedResourcesRequest, ListValuedResourcesResponse, ValuedResource>(_callListValuedResources, request, callSettings);
        }

        /// <summary>
        /// Lists the valued resources for a set of simulation results and filter.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ValuedResource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListValuedResourcesResponse, ValuedResource> ListValuedResourcesAsync(ListValuedResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListValuedResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListValuedResourcesRequest, ListValuedResourcesResponse, ValuedResource>(_callListValuedResources, request, callSettings);
        }

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Finding SetFindingState(SetFindingStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetFindingStateRequest(ref request, ref callSettings);
            return _callSetFindingState.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the state of a finding. If no location is specified, finding is
        /// assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Finding> SetFindingStateAsync(SetFindingStateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetFindingStateRequest(ref request, ref callSettings);
            return _callSetFindingState.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::Policy SetIamPolicy(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified Source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::Policy> SetIamPolicyAsync(gciv::SetIamPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Finding SetMute(SetMuteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMuteRequest(ref request, ref callSettings);
            return _callSetMute.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the mute state of a finding. If no location is specified, finding
        /// is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Finding> SetMuteAsync(SetMuteRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetMuteRequest(ref request, ref callSettings);
            return _callSetMute.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gciv::TestIamPermissionsResponse TestIamPermissions(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the permissions that a caller has on the specified source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gciv::TestIamPermissionsResponse> TestIamPermissionsAsync(gciv::TestIamPermissionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BigQueryExport UpdateBigQueryExport(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBigQueryExportRequest(ref request, ref callSettings);
            return _callUpdateBigQueryExport.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a BigQuery export.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BigQueryExport> UpdateBigQueryExportAsync(UpdateBigQueryExportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBigQueryExportRequest(ref request, ref callSettings);
            return _callUpdateBigQueryExport.Async(request, callSettings);
        }

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExternalSystem UpdateExternalSystem(UpdateExternalSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExternalSystemRequest(ref request, ref callSettings);
            return _callUpdateExternalSystem.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates external system. This is for a given finding. If no location is
        /// specified, finding is assumed to be in global
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExternalSystem> UpdateExternalSystemAsync(UpdateExternalSystemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExternalSystemRequest(ref request, ref callSettings);
            return _callUpdateExternalSystem.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Finding UpdateFinding(UpdateFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingRequest(ref request, ref callSettings);
            return _callUpdateFinding.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a finding. If no location is specified, finding is
        /// assumed to be in global. The corresponding source must exist for a finding
        /// creation to succeed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Finding> UpdateFindingAsync(UpdateFindingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFindingRequest(ref request, ref callSettings);
            return _callUpdateFinding.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MuteConfig UpdateMuteConfig(UpdateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMuteConfigRequest(ref request, ref callSettings);
            return _callUpdateMuteConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a mute config. If no location is specified, default is
        /// global.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MuteConfig> UpdateMuteConfigAsync(UpdateMuteConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateMuteConfigRequest(ref request, ref callSettings);
            return _callUpdateMuteConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationConfig UpdateNotificationConfig(UpdateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationConfigRequest(ref request, ref callSettings);
            return _callUpdateNotificationConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a notification config. The following update
        /// fields are allowed: description, pubsub_topic, streaming_config.filter
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationConfig> UpdateNotificationConfigAsync(UpdateNotificationConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNotificationConfigRequest(ref request, ref callSettings);
            return _callUpdateNotificationConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceValueConfig UpdateResourceValueConfig(UpdateResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateResourceValueConfigRequest(ref request, ref callSettings);
            return _callUpdateResourceValueConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing ResourceValueConfigs with new rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceValueConfig> UpdateResourceValueConfigAsync(UpdateResourceValueConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateResourceValueConfigRequest(ref request, ref callSettings);
            return _callUpdateResourceValueConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityMarks UpdateSecurityMarks(UpdateSecurityMarksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityMarksRequest(ref request, ref callSettings);
            return _callUpdateSecurityMarks.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates security marks. For Finding Security marks, if no location is
        /// specified, finding is assumed to be in global. Assets Security Marks can
        /// only be accessed through global endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityMarks> UpdateSecurityMarksAsync(UpdateSecurityMarksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityMarksRequest(ref request, ref callSettings);
            return _callUpdateSecurityMarks.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Source UpdateSource(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSourceRequest(ref request, ref callSettings);
            return _callUpdateSource.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Source> UpdateSourceAsync(UpdateSourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSourceRequest(ref request, ref callSettings);
            return _callUpdateSource.Async(request, callSettings);
        }
    }

    public partial class GroupFindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAttackPathsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBigQueryExportsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFindingsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMuteConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNotificationConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListResourceValueConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListValuedResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class GroupFindingsResponse : gaxgrpc::IPageResponse<GroupResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GroupResult> GetEnumerator() => GroupByResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAttackPathsResponse : gaxgrpc::IPageResponse<AttackPath>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AttackPath> GetEnumerator() => AttackPaths.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBigQueryExportsResponse : gaxgrpc::IPageResponse<BigQueryExport>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BigQueryExport> GetEnumerator() => BigQueryExports.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFindingsResponse : gaxgrpc::IPageResponse<ListFindingsResponse.Types.ListFindingsResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.ListFindingsResult> GetEnumerator() => ListFindingsResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMuteConfigsResponse : gaxgrpc::IPageResponse<MuteConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MuteConfig> GetEnumerator() => MuteConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotificationConfigsResponse : gaxgrpc::IPageResponse<NotificationConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotificationConfig> GetEnumerator() => NotificationConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListResourceValueConfigsResponse : gaxgrpc::IPageResponse<ResourceValueConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ResourceValueConfig> GetEnumerator() => ResourceValueConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSourcesResponse : gaxgrpc::IPageResponse<Source>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Source> GetEnumerator() => Sources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListValuedResourcesResponse : gaxgrpc::IPageResponse<ValuedResource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ValuedResource> GetEnumerator() => ValuedResources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SecurityCenter
    {
        public partial class SecurityCenterClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
