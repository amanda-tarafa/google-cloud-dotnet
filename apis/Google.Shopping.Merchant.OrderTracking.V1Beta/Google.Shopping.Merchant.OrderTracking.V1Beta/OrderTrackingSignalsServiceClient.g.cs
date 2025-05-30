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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Shopping.Merchant.OrderTracking.V1Beta
{
    /// <summary>Settings for <see cref="OrderTrackingSignalsServiceClient"/> instances.</summary>
    public sealed partial class OrderTrackingSignalsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OrderTrackingSignalsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OrderTrackingSignalsServiceSettings"/>.</returns>
        public static OrderTrackingSignalsServiceSettings GetDefault() => new OrderTrackingSignalsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OrderTrackingSignalsServiceSettings"/> object with default settings.
        /// </summary>
        public OrderTrackingSignalsServiceSettings()
        {
        }

        private OrderTrackingSignalsServiceSettings(OrderTrackingSignalsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateOrderTrackingSignalSettings = existing.CreateOrderTrackingSignalSettings;
            OnCopy(existing);
        }

        partial void OnCopy(OrderTrackingSignalsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OrderTrackingSignalsServiceClient.CreateOrderTrackingSignal</c> and
        /// <c>OrderTrackingSignalsServiceClient.CreateOrderTrackingSignalAsync</c>.
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
        public gaxgrpc::CallSettings CreateOrderTrackingSignalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OrderTrackingSignalsServiceSettings"/> object.</returns>
        public OrderTrackingSignalsServiceSettings Clone() => new OrderTrackingSignalsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OrderTrackingSignalsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class OrderTrackingSignalsServiceClientBuilder : gaxgrpc::ClientBuilderBase<OrderTrackingSignalsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OrderTrackingSignalsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public OrderTrackingSignalsServiceClientBuilder() : base(OrderTrackingSignalsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref OrderTrackingSignalsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OrderTrackingSignalsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OrderTrackingSignalsServiceClient Build()
        {
            OrderTrackingSignalsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OrderTrackingSignalsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OrderTrackingSignalsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OrderTrackingSignalsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OrderTrackingSignalsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<OrderTrackingSignalsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OrderTrackingSignalsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OrderTrackingSignalsServiceClient.ChannelPool;
    }

    /// <summary>OrderTrackingSignalsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to serve order tracking signals public API.
    /// </remarks>
    public abstract partial class OrderTrackingSignalsServiceClient
    {
        /// <summary>
        /// The default endpoint for the OrderTrackingSignalsService service, which is a host of
        /// "merchantapi.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "merchantapi.googleapis.com:443";

        /// <summary>The default OrderTrackingSignalsService scopes.</summary>
        /// <remarks>
        /// The default OrderTrackingSignalsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/content</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/content",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(OrderTrackingSignalsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="OrderTrackingSignalsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrderTrackingSignalsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OrderTrackingSignalsServiceClient"/>.</returns>
        public static stt::Task<OrderTrackingSignalsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OrderTrackingSignalsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OrderTrackingSignalsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OrderTrackingSignalsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OrderTrackingSignalsServiceClient"/>.</returns>
        public static OrderTrackingSignalsServiceClient Create() => new OrderTrackingSignalsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OrderTrackingSignalsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OrderTrackingSignalsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="OrderTrackingSignalsServiceClient"/>.</returns>
        internal static OrderTrackingSignalsServiceClient Create(grpccore::CallInvoker callInvoker, OrderTrackingSignalsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OrderTrackingSignalsService.OrderTrackingSignalsServiceClient grpcClient = new OrderTrackingSignalsService.OrderTrackingSignalsServiceClient(callInvoker);
            return new OrderTrackingSignalsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC OrderTrackingSignalsService client</summary>
        public virtual OrderTrackingSignalsService.OrderTrackingSignalsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrderTrackingSignal CreateOrderTrackingSignal(CreateOrderTrackingSignalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrderTrackingSignal> CreateOrderTrackingSignalAsync(CreateOrderTrackingSignalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrderTrackingSignal> CreateOrderTrackingSignalAsync(CreateOrderTrackingSignalRequest request, st::CancellationToken cancellationToken) =>
            CreateOrderTrackingSignalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="parent">
        /// Required. The account of the business for which the order signal is
        /// created. Format: accounts/{account}
        /// </param>
        /// <param name="orderTrackingSignalId">
        /// Output only. The ID that uniquely identifies this order tracking signal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrderTrackingSignal CreateOrderTrackingSignal(string parent, string orderTrackingSignalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrderTrackingSignal(new CreateOrderTrackingSignalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrderTrackingSignalId = orderTrackingSignalId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="parent">
        /// Required. The account of the business for which the order signal is
        /// created. Format: accounts/{account}
        /// </param>
        /// <param name="orderTrackingSignalId">
        /// Output only. The ID that uniquely identifies this order tracking signal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrderTrackingSignal> CreateOrderTrackingSignalAsync(string parent, string orderTrackingSignalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrderTrackingSignalAsync(new CreateOrderTrackingSignalRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OrderTrackingSignalId = orderTrackingSignalId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="parent">
        /// Required. The account of the business for which the order signal is
        /// created. Format: accounts/{account}
        /// </param>
        /// <param name="orderTrackingSignalId">
        /// Output only. The ID that uniquely identifies this order tracking signal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrderTrackingSignal> CreateOrderTrackingSignalAsync(string parent, string orderTrackingSignalId, st::CancellationToken cancellationToken) =>
            CreateOrderTrackingSignalAsync(parent, orderTrackingSignalId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="parent">
        /// Required. The account of the business for which the order signal is
        /// created. Format: accounts/{account}
        /// </param>
        /// <param name="orderTrackingSignalId">
        /// Output only. The ID that uniquely identifies this order tracking signal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual OrderTrackingSignal CreateOrderTrackingSignal(AccountName parent, string orderTrackingSignalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrderTrackingSignal(new CreateOrderTrackingSignalRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderTrackingSignalId = orderTrackingSignalId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="parent">
        /// Required. The account of the business for which the order signal is
        /// created. Format: accounts/{account}
        /// </param>
        /// <param name="orderTrackingSignalId">
        /// Output only. The ID that uniquely identifies this order tracking signal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrderTrackingSignal> CreateOrderTrackingSignalAsync(AccountName parent, string orderTrackingSignalId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOrderTrackingSignalAsync(new CreateOrderTrackingSignalRequest
            {
                ParentAsAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OrderTrackingSignalId = orderTrackingSignalId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="parent">
        /// Required. The account of the business for which the order signal is
        /// created. Format: accounts/{account}
        /// </param>
        /// <param name="orderTrackingSignalId">
        /// Output only. The ID that uniquely identifies this order tracking signal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<OrderTrackingSignal> CreateOrderTrackingSignalAsync(AccountName parent, string orderTrackingSignalId, st::CancellationToken cancellationToken) =>
            CreateOrderTrackingSignalAsync(parent, orderTrackingSignalId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OrderTrackingSignalsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to serve order tracking signals public API.
    /// </remarks>
    public sealed partial class OrderTrackingSignalsServiceClientImpl : OrderTrackingSignalsServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateOrderTrackingSignalRequest, OrderTrackingSignal> _callCreateOrderTrackingSignal;

        /// <summary>
        /// Constructs a client wrapper for the OrderTrackingSignalsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OrderTrackingSignalsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public OrderTrackingSignalsServiceClientImpl(OrderTrackingSignalsService.OrderTrackingSignalsServiceClient grpcClient, OrderTrackingSignalsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            OrderTrackingSignalsServiceSettings effectiveSettings = settings ?? OrderTrackingSignalsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateOrderTrackingSignal = clientHelper.BuildApiCall<CreateOrderTrackingSignalRequest, OrderTrackingSignal>("CreateOrderTrackingSignal", grpcClient.CreateOrderTrackingSignalAsync, grpcClient.CreateOrderTrackingSignal, effectiveSettings.CreateOrderTrackingSignalSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOrderTrackingSignal);
            Modify_CreateOrderTrackingSignalApiCall(ref _callCreateOrderTrackingSignal);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateOrderTrackingSignalApiCall(ref gaxgrpc::ApiCall<CreateOrderTrackingSignalRequest, OrderTrackingSignal> call);

        partial void OnConstruction(OrderTrackingSignalsService.OrderTrackingSignalsServiceClient grpcClient, OrderTrackingSignalsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OrderTrackingSignalsService client</summary>
        public override OrderTrackingSignalsService.OrderTrackingSignalsServiceClient GrpcClient { get; }

        partial void Modify_CreateOrderTrackingSignalRequest(ref CreateOrderTrackingSignalRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override OrderTrackingSignal CreateOrderTrackingSignal(CreateOrderTrackingSignalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrderTrackingSignalRequest(ref request, ref callSettings);
            return _callCreateOrderTrackingSignal.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates new order tracking signal.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<OrderTrackingSignal> CreateOrderTrackingSignalAsync(CreateOrderTrackingSignalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOrderTrackingSignalRequest(ref request, ref callSettings);
            return _callCreateOrderTrackingSignal.Async(request, callSettings);
        }
    }
}
