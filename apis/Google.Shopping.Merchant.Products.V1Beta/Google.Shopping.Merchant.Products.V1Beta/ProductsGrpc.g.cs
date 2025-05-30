// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/shopping/merchant/products/v1beta/products.proto
// </auto-generated>
// Original file comments:
// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Shopping.Merchant.Products.V1Beta {
  /// <summary>
  /// Service to use Product resource.
  /// </summary>
  public static partial class ProductsService
  {
    static readonly string __ServiceName = "google.shopping.merchant.products.v1beta.ProductsService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest> __Marshaller_google_shopping_merchant_products_v1beta_GetProductRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Products.V1Beta.Product> __Marshaller_google_shopping_merchant_products_v1beta_Product = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Products.V1Beta.Product.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest> __Marshaller_google_shopping_merchant_products_v1beta_ListProductsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse> __Marshaller_google_shopping_merchant_products_v1beta_ListProductsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest, global::Google.Shopping.Merchant.Products.V1Beta.Product> __Method_GetProduct = new grpc::Method<global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest, global::Google.Shopping.Merchant.Products.V1Beta.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProduct",
        __Marshaller_google_shopping_merchant_products_v1beta_GetProductRequest,
        __Marshaller_google_shopping_merchant_products_v1beta_Product);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest, global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse> __Method_ListProducts = new grpc::Method<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest, global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListProducts",
        __Marshaller_google_shopping_merchant_products_v1beta_ListProductsRequest,
        __Marshaller_google_shopping_merchant_products_v1beta_ListProductsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Shopping.Merchant.Products.V1Beta.ProductsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductsService</summary>
    [grpc::BindServiceMethod(typeof(ProductsService), "BindService")]
    public abstract partial class ProductsServiceBase
    {
      /// <summary>
      /// Retrieves the processed product from your Merchant Center account.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated final product can be retrieved.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Products.V1Beta.Product> GetProduct(global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Lists the processed products in your Merchant Center account. The response
      /// might contain fewer items than specified by `pageSize`. Rely on `pageToken`
      /// to determine if there are more items to be requested.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated processed product can be retrieved.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse> ListProducts(global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProductsService</summary>
    public partial class ProductsServiceClient : grpc::ClientBase<ProductsServiceClient>
    {
      /// <summary>Creates a new client for ProductsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves the processed product from your Merchant Center account.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated final product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Products.V1Beta.Product GetProduct(global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProduct(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the processed product from your Merchant Center account.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated final product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Products.V1Beta.Product GetProduct(global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProduct, null, options, request);
      }
      /// <summary>
      /// Retrieves the processed product from your Merchant Center account.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated final product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Products.V1Beta.Product> GetProductAsync(global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the processed product from your Merchant Center account.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated final product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Products.V1Beta.Product> GetProductAsync(global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProduct, null, options, request);
      }
      /// <summary>
      /// Lists the processed products in your Merchant Center account. The response
      /// might contain fewer items than specified by `pageSize`. Rely on `pageToken`
      /// to determine if there are more items to be requested.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated processed product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse ListProducts(global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListProducts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the processed products in your Merchant Center account. The response
      /// might contain fewer items than specified by `pageSize`. Rely on `pageToken`
      /// to determine if there are more items to be requested.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated processed product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse ListProducts(global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListProducts, null, options, request);
      }
      /// <summary>
      /// Lists the processed products in your Merchant Center account. The response
      /// might contain fewer items than specified by `pageSize`. Rely on `pageToken`
      /// to determine if there are more items to be requested.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated processed product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse> ListProductsAsync(global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListProductsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the processed products in your Merchant Center account. The response
      /// might contain fewer items than specified by `pageSize`. Rely on `pageToken`
      /// to determine if there are more items to be requested.
      ///
      /// After inserting, updating, or deleting a product input, it may take several
      /// minutes before the updated processed product can be retrieved.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse> ListProductsAsync(global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListProducts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProductsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ProductsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProduct, serviceImpl.GetProduct)
          .AddMethod(__Method_ListProducts, serviceImpl.ListProducts).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProduct, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Products.V1Beta.GetProductRequest, global::Google.Shopping.Merchant.Products.V1Beta.Product>(serviceImpl.GetProduct));
      serviceBinder.AddMethod(__Method_ListProducts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Shopping.Merchant.Products.V1Beta.ListProductsRequest, global::Google.Shopping.Merchant.Products.V1Beta.ListProductsResponse>(serviceImpl.ListProducts));
    }

  }
}
#endregion
