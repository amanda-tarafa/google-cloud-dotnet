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
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Shopping.Merchant.Accounts.V1Beta
{
    /// <summary>Settings for <see cref="LfpProvidersServiceClient"/> instances.</summary>
    public sealed partial class LfpProvidersServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LfpProvidersServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LfpProvidersServiceSettings"/>.</returns>
        public static LfpProvidersServiceSettings GetDefault() => new LfpProvidersServiceSettings();

        /// <summary>Constructs a new <see cref="LfpProvidersServiceSettings"/> object with default settings.</summary>
        public LfpProvidersServiceSettings()
        {
        }

        private LfpProvidersServiceSettings(LfpProvidersServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FindLfpProvidersSettings = existing.FindLfpProvidersSettings;
            LinkLfpProviderSettings = existing.LinkLfpProviderSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LfpProvidersServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpProvidersServiceClient.FindLfpProviders</c> and <c>LfpProvidersServiceClient.FindLfpProvidersAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FindLfpProvidersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LfpProvidersServiceClient.LinkLfpProvider</c> and <c>LfpProvidersServiceClient.LinkLfpProviderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LinkLfpProviderSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LfpProvidersServiceSettings"/> object.</returns>
        public LfpProvidersServiceSettings Clone() => new LfpProvidersServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LfpProvidersServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class LfpProvidersServiceClientBuilder : gaxgrpc::ClientBuilderBase<LfpProvidersServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LfpProvidersServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LfpProvidersServiceClientBuilder() : base(LfpProvidersServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LfpProvidersServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LfpProvidersServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LfpProvidersServiceClient Build()
        {
            LfpProvidersServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LfpProvidersServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LfpProvidersServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LfpProvidersServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LfpProvidersServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LfpProvidersServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LfpProvidersServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LfpProvidersServiceClient.ChannelPool;
    }

    /// <summary>LfpProvidersService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's LFP provider settings.
    /// This API defines the following resource model:
    /// - [LfpProvider][google.shopping.merchant.accounts.v1.LfpProvider]
    /// </remarks>
    public abstract partial class LfpProvidersServiceClient
    {
        /// <summary>
        /// The default endpoint for the LfpProvidersService service, which is a host of "merchantapi.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default LfpProvidersService scopes.</summary>
        /// <remarks>
        /// The default LfpProvidersService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LfpProvidersService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LfpProvidersServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="LfpProvidersServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LfpProvidersServiceClient"/>.</returns>
        public static stt::Task<LfpProvidersServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LfpProvidersServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LfpProvidersServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="LfpProvidersServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LfpProvidersServiceClient"/>.</returns>
        public static LfpProvidersServiceClient Create() => new LfpProvidersServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LfpProvidersServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LfpProvidersServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LfpProvidersServiceClient"/>.</returns>
        internal static LfpProvidersServiceClient Create(grpccore::CallInvoker callInvoker, LfpProvidersServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LfpProvidersService.LfpProvidersServiceClient grpcClient = new LfpProvidersService.LfpProvidersServiceClient(callInvoker);
            return new LfpProvidersServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LfpProvidersService client</summary>
        public virtual LfpProvidersService.LfpProvidersServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LfpProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProviders(FindLfpProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LfpProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProvidersAsync(FindLfpProvidersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the LFP providers are
        /// found. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`.
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
        /// <returns>A pageable sequence of <see cref="LfpProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProviders(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FindLfpProvidersRequest request = new FindLfpProvidersRequest
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
            return FindLfpProviders(request, callSettings);
        }

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the LFP providers are
        /// found. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LfpProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProvidersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FindLfpProvidersRequest request = new FindLfpProvidersRequest
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
            return FindLfpProvidersAsync(request, callSettings);
        }

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the LFP providers are
        /// found. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`.
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
        /// <returns>A pageable sequence of <see cref="LfpProvider"/> resources.</returns>
        public virtual gax::PagedEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProviders(OmnichannelSettingName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FindLfpProvidersRequest request = new FindLfpProvidersRequest
            {
                ParentAsOmnichannelSettingName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FindLfpProviders(request, callSettings);
        }

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource under which the LFP providers are
        /// found. Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="LfpProvider"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProvidersAsync(OmnichannelSettingName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FindLfpProvidersRequest request = new FindLfpProvidersRequest
            {
                ParentAsOmnichannelSettingName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return FindLfpProvidersAsync(request, callSettings);
        }

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LinkLfpProviderResponse LinkLfpProvider(LinkLfpProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkLfpProviderResponse> LinkLfpProviderAsync(LinkLfpProviderRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkLfpProviderResponse> LinkLfpProviderAsync(LinkLfpProviderRequest request, st::CancellationToken cancellationToken) =>
            LinkLfpProviderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LFP provider resource to link.
        /// Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}/lfpProviders/{lfp_provider}`.
        /// The `lfp_provider` is the LFP provider ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LinkLfpProviderResponse LinkLfpProvider(string name, gaxgrpc::CallSettings callSettings = null) =>
            LinkLfpProvider(new LinkLfpProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LFP provider resource to link.
        /// Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}/lfpProviders/{lfp_provider}`.
        /// The `lfp_provider` is the LFP provider ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkLfpProviderResponse> LinkLfpProviderAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            LinkLfpProviderAsync(new LinkLfpProviderRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LFP provider resource to link.
        /// Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}/lfpProviders/{lfp_provider}`.
        /// The `lfp_provider` is the LFP provider ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkLfpProviderResponse> LinkLfpProviderAsync(string name, st::CancellationToken cancellationToken) =>
            LinkLfpProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LFP provider resource to link.
        /// Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}/lfpProviders/{lfp_provider}`.
        /// The `lfp_provider` is the LFP provider ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LinkLfpProviderResponse LinkLfpProvider(LfpProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            LinkLfpProvider(new LinkLfpProviderRequest
            {
                LfpProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LFP provider resource to link.
        /// Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}/lfpProviders/{lfp_provider}`.
        /// The `lfp_provider` is the LFP provider ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkLfpProviderResponse> LinkLfpProviderAsync(LfpProviderName name, gaxgrpc::CallSettings callSettings = null) =>
            LinkLfpProviderAsync(new LinkLfpProviderRequest
            {
                LfpProviderName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the LFP provider resource to link.
        /// Format:
        /// `accounts/{account}/omnichannelSettings/{omnichannel_setting}/lfpProviders/{lfp_provider}`.
        /// The `lfp_provider` is the LFP provider ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LinkLfpProviderResponse> LinkLfpProviderAsync(LfpProviderName name, st::CancellationToken cancellationToken) =>
            LinkLfpProviderAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LfpProvidersService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service facilitates the management of a merchant's LFP provider settings.
    /// This API defines the following resource model:
    /// - [LfpProvider][google.shopping.merchant.accounts.v1.LfpProvider]
    /// </remarks>
    public sealed partial class LfpProvidersServiceClientImpl : LfpProvidersServiceClient
    {
        private readonly gaxgrpc::ApiCall<FindLfpProvidersRequest, FindLfpProvidersResponse> _callFindLfpProviders;

        private readonly gaxgrpc::ApiCall<LinkLfpProviderRequest, LinkLfpProviderResponse> _callLinkLfpProvider;

        /// <summary>
        /// Constructs a client wrapper for the LfpProvidersService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LfpProvidersServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LfpProvidersServiceClientImpl(LfpProvidersService.LfpProvidersServiceClient grpcClient, LfpProvidersServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LfpProvidersServiceSettings effectiveSettings = settings ?? LfpProvidersServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callFindLfpProviders = clientHelper.BuildApiCall<FindLfpProvidersRequest, FindLfpProvidersResponse>("FindLfpProviders", grpcClient.FindLfpProvidersAsync, grpcClient.FindLfpProviders, effectiveSettings.FindLfpProvidersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFindLfpProviders);
            Modify_FindLfpProvidersApiCall(ref _callFindLfpProviders);
            _callLinkLfpProvider = clientHelper.BuildApiCall<LinkLfpProviderRequest, LinkLfpProviderResponse>("LinkLfpProvider", grpcClient.LinkLfpProviderAsync, grpcClient.LinkLfpProvider, effectiveSettings.LinkLfpProviderSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLinkLfpProvider);
            Modify_LinkLfpProviderApiCall(ref _callLinkLfpProvider);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FindLfpProvidersApiCall(ref gaxgrpc::ApiCall<FindLfpProvidersRequest, FindLfpProvidersResponse> call);

        partial void Modify_LinkLfpProviderApiCall(ref gaxgrpc::ApiCall<LinkLfpProviderRequest, LinkLfpProviderResponse> call);

        partial void OnConstruction(LfpProvidersService.LfpProvidersServiceClient grpcClient, LfpProvidersServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LfpProvidersService client</summary>
        public override LfpProvidersService.LfpProvidersServiceClient GrpcClient { get; }

        partial void Modify_FindLfpProvidersRequest(ref FindLfpProvidersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LinkLfpProviderRequest(ref LinkLfpProviderRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LfpProvider"/> resources.</returns>
        public override gax::PagedEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProviders(FindLfpProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindLfpProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FindLfpProvidersRequest, FindLfpProvidersResponse, LfpProvider>(_callFindLfpProviders, request, callSettings);
        }

        /// <summary>
        /// Find the LFP provider candidates in a given country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LfpProvider"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FindLfpProvidersResponse, LfpProvider> FindLfpProvidersAsync(FindLfpProvidersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FindLfpProvidersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FindLfpProvidersRequest, FindLfpProvidersResponse, LfpProvider>(_callFindLfpProviders, request, callSettings);
        }

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LinkLfpProviderResponse LinkLfpProvider(LinkLfpProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LinkLfpProviderRequest(ref request, ref callSettings);
            return _callLinkLfpProvider.Sync(request, callSettings);
        }

        /// <summary>
        /// Link the specified merchant to a LFP provider for the specified country.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LinkLfpProviderResponse> LinkLfpProviderAsync(LinkLfpProviderRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LinkLfpProviderRequest(ref request, ref callSettings);
            return _callLinkLfpProvider.Async(request, callSettings);
        }
    }

    public partial class FindLfpProvidersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FindLfpProvidersResponse : gaxgrpc::IPageResponse<LfpProvider>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LfpProvider> GetEnumerator() => LfpProviders.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
