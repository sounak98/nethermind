// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: src/Nethermind/Nethermind.Grpc/Nethermind.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Nethermind.Grpc {
  public static partial class NethermindService
  {
    static readonly string __ServiceName = "Nethermind.Grpc.NethermindService";

    static readonly grpc::Marshaller<global::Nethermind.Grpc.NdmExtension> __Marshaller_Nethermind_Grpc_NdmExtension = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Nethermind.Grpc.NdmExtension.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Nethermind.Grpc.NdmQuery> __Marshaller_Nethermind_Grpc_NdmQuery = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Nethermind.Grpc.NdmQuery.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Nethermind.Grpc.NdmQueryData> __Marshaller_Nethermind_Grpc_NdmQueryData = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Nethermind.Grpc.NdmQueryData.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Nethermind.Grpc.Empty> __Marshaller_Nethermind_Grpc_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Nethermind.Grpc.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Nethermind.Grpc.NdmDataSubscription> __Marshaller_Nethermind_Grpc_NdmDataSubscription = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Nethermind.Grpc.NdmDataSubscription.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Nethermind.Grpc.NdmDataResponse> __Marshaller_Nethermind_Grpc_NdmDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Nethermind.Grpc.NdmDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Nethermind.Grpc.NdmExtension, global::Nethermind.Grpc.NdmQuery> __Method_InitNdmExtension = new grpc::Method<global::Nethermind.Grpc.NdmExtension, global::Nethermind.Grpc.NdmQuery>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "InitNdmExtension",
        __Marshaller_Nethermind_Grpc_NdmExtension,
        __Marshaller_Nethermind_Grpc_NdmQuery);

    static readonly grpc::Method<global::Nethermind.Grpc.NdmQueryData, global::Nethermind.Grpc.Empty> __Method_SendNdmData = new grpc::Method<global::Nethermind.Grpc.NdmQueryData, global::Nethermind.Grpc.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendNdmData",
        __Marshaller_Nethermind_Grpc_NdmQueryData,
        __Marshaller_Nethermind_Grpc_Empty);

    static readonly grpc::Method<global::Nethermind.Grpc.NdmDataSubscription, global::Nethermind.Grpc.NdmDataResponse> __Method_SubscribeNdmData = new grpc::Method<global::Nethermind.Grpc.NdmDataSubscription, global::Nethermind.Grpc.NdmDataResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "SubscribeNdmData",
        __Marshaller_Nethermind_Grpc_NdmDataSubscription,
        __Marshaller_Nethermind_Grpc_NdmDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Nethermind.Grpc.NethermindReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of NethermindService</summary>
    public abstract partial class NethermindServiceBase
    {
      public virtual global::System.Threading.Tasks.Task InitNdmExtension(global::Nethermind.Grpc.NdmExtension request, grpc::IServerStreamWriter<global::Nethermind.Grpc.NdmQuery> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Nethermind.Grpc.Empty> SendNdmData(global::Nethermind.Grpc.NdmQueryData request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task SubscribeNdmData(global::Nethermind.Grpc.NdmDataSubscription request, grpc::IServerStreamWriter<global::Nethermind.Grpc.NdmDataResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for NethermindService</summary>
    public partial class NethermindServiceClient : grpc::ClientBase<NethermindServiceClient>
    {
      /// <summary>Creates a new client for NethermindService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public NethermindServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for NethermindService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public NethermindServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected NethermindServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected NethermindServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Nethermind.Grpc.NdmQuery> InitNdmExtension(global::Nethermind.Grpc.NdmExtension request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return InitNdmExtension(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Nethermind.Grpc.NdmQuery> InitNdmExtension(global::Nethermind.Grpc.NdmExtension request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_InitNdmExtension, null, options, request);
      }
      public virtual global::Nethermind.Grpc.Empty SendNdmData(global::Nethermind.Grpc.NdmQueryData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendNdmData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Nethermind.Grpc.Empty SendNdmData(global::Nethermind.Grpc.NdmQueryData request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SendNdmData, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Nethermind.Grpc.Empty> SendNdmDataAsync(global::Nethermind.Grpc.NdmQueryData request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendNdmDataAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Nethermind.Grpc.Empty> SendNdmDataAsync(global::Nethermind.Grpc.NdmQueryData request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SendNdmData, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Nethermind.Grpc.NdmDataResponse> SubscribeNdmData(global::Nethermind.Grpc.NdmDataSubscription request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SubscribeNdmData(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Nethermind.Grpc.NdmDataResponse> SubscribeNdmData(global::Nethermind.Grpc.NdmDataSubscription request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_SubscribeNdmData, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override NethermindServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new NethermindServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(NethermindServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_InitNdmExtension, serviceImpl.InitNdmExtension)
          .AddMethod(__Method_SendNdmData, serviceImpl.SendNdmData)
          .AddMethod(__Method_SubscribeNdmData, serviceImpl.SubscribeNdmData).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, NethermindServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_InitNdmExtension, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Nethermind.Grpc.NdmExtension, global::Nethermind.Grpc.NdmQuery>(serviceImpl.InitNdmExtension));
      serviceBinder.AddMethod(__Method_SendNdmData, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Nethermind.Grpc.NdmQueryData, global::Nethermind.Grpc.Empty>(serviceImpl.SendNdmData));
      serviceBinder.AddMethod(__Method_SubscribeNdmData, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Nethermind.Grpc.NdmDataSubscription, global::Nethermind.Grpc.NdmDataResponse>(serviceImpl.SubscribeNdmData));
    }

  }
}
#endregion