// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ratings/ratings_service.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace KillrVideo.Ratings {
  /// <summary>
  ///  Service that manages user's ratings of videos
  /// </summary>
  public static class RatingsService
  {
    static readonly string __ServiceName = "killrvideo.ratings.RatingsService";

    static readonly Marshaller<global::KillrVideo.Ratings.RateVideoRequest> __Marshaller_RateVideoRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Ratings.RateVideoRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Ratings.RateVideoResponse> __Marshaller_RateVideoResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Ratings.RateVideoResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Ratings.GetRatingRequest> __Marshaller_GetRatingRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Ratings.GetRatingRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Ratings.GetRatingResponse> __Marshaller_GetRatingResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Ratings.GetRatingResponse.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Ratings.GetUserRatingRequest> __Marshaller_GetUserRatingRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Ratings.GetUserRatingRequest.Parser.ParseFrom);
    static readonly Marshaller<global::KillrVideo.Ratings.GetUserRatingResponse> __Marshaller_GetUserRatingResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::KillrVideo.Ratings.GetUserRatingResponse.Parser.ParseFrom);

    static readonly Method<global::KillrVideo.Ratings.RateVideoRequest, global::KillrVideo.Ratings.RateVideoResponse> __Method_RateVideo = new Method<global::KillrVideo.Ratings.RateVideoRequest, global::KillrVideo.Ratings.RateVideoResponse>(
        MethodType.Unary,
        __ServiceName,
        "RateVideo",
        __Marshaller_RateVideoRequest,
        __Marshaller_RateVideoResponse);

    static readonly Method<global::KillrVideo.Ratings.GetRatingRequest, global::KillrVideo.Ratings.GetRatingResponse> __Method_GetRating = new Method<global::KillrVideo.Ratings.GetRatingRequest, global::KillrVideo.Ratings.GetRatingResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetRating",
        __Marshaller_GetRatingRequest,
        __Marshaller_GetRatingResponse);

    static readonly Method<global::KillrVideo.Ratings.GetUserRatingRequest, global::KillrVideo.Ratings.GetUserRatingResponse> __Method_GetUserRating = new Method<global::KillrVideo.Ratings.GetUserRatingRequest, global::KillrVideo.Ratings.GetUserRatingResponse>(
        MethodType.Unary,
        __ServiceName,
        "GetUserRating",
        __Marshaller_GetUserRatingRequest,
        __Marshaller_GetUserRatingResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::KillrVideo.Ratings.RatingsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for RatingsService</summary>
    [System.Obsolete("Client side interfaced will be removed in the next release. Use client class directly.")]
    public interface IRatingsServiceClient
    {
      /// <summary>
      ///  Rate a video
      /// </summary>
      global::KillrVideo.Ratings.RateVideoResponse RateVideo(global::KillrVideo.Ratings.RateVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      /// <summary>
      ///  Rate a video
      /// </summary>
      global::KillrVideo.Ratings.RateVideoResponse RateVideo(global::KillrVideo.Ratings.RateVideoRequest request, CallOptions options);
      /// <summary>
      ///  Rate a video
      /// </summary>
      AsyncUnaryCall<global::KillrVideo.Ratings.RateVideoResponse> RateVideoAsync(global::KillrVideo.Ratings.RateVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      /// <summary>
      ///  Rate a video
      /// </summary>
      AsyncUnaryCall<global::KillrVideo.Ratings.RateVideoResponse> RateVideoAsync(global::KillrVideo.Ratings.RateVideoRequest request, CallOptions options);
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      global::KillrVideo.Ratings.GetRatingResponse GetRating(global::KillrVideo.Ratings.GetRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      global::KillrVideo.Ratings.GetRatingResponse GetRating(global::KillrVideo.Ratings.GetRatingRequest request, CallOptions options);
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      AsyncUnaryCall<global::KillrVideo.Ratings.GetRatingResponse> GetRatingAsync(global::KillrVideo.Ratings.GetRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      AsyncUnaryCall<global::KillrVideo.Ratings.GetRatingResponse> GetRatingAsync(global::KillrVideo.Ratings.GetRatingRequest request, CallOptions options);
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      global::KillrVideo.Ratings.GetUserRatingResponse GetUserRating(global::KillrVideo.Ratings.GetUserRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      global::KillrVideo.Ratings.GetUserRatingResponse GetUserRating(global::KillrVideo.Ratings.GetUserRatingRequest request, CallOptions options);
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      AsyncUnaryCall<global::KillrVideo.Ratings.GetUserRatingResponse> GetUserRatingAsync(global::KillrVideo.Ratings.GetUserRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      AsyncUnaryCall<global::KillrVideo.Ratings.GetUserRatingResponse> GetUserRatingAsync(global::KillrVideo.Ratings.GetUserRatingRequest request, CallOptions options);
    }

    /// <summary>Interface of server-side implementations of RatingsService</summary>
    [System.Obsolete("Service implementations should inherit from the generated abstract base class instead.")]
    public interface IRatingsService
    {
      /// <summary>
      ///  Rate a video
      /// </summary>
      global::System.Threading.Tasks.Task<global::KillrVideo.Ratings.RateVideoResponse> RateVideo(global::KillrVideo.Ratings.RateVideoRequest request, ServerCallContext context);
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      global::System.Threading.Tasks.Task<global::KillrVideo.Ratings.GetRatingResponse> GetRating(global::KillrVideo.Ratings.GetRatingRequest request, ServerCallContext context);
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      global::System.Threading.Tasks.Task<global::KillrVideo.Ratings.GetUserRatingResponse> GetUserRating(global::KillrVideo.Ratings.GetUserRatingRequest request, ServerCallContext context);
    }

    /// <summary>Base class for server-side implementations of RatingsService</summary>
    public abstract class RatingsServiceBase
    {
      /// <summary>
      ///  Rate a video
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.Ratings.RateVideoResponse> RateVideo(global::KillrVideo.Ratings.RateVideoRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.Ratings.GetRatingResponse> GetRating(global::KillrVideo.Ratings.GetRatingRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::KillrVideo.Ratings.GetUserRatingResponse> GetUserRating(global::KillrVideo.Ratings.GetUserRatingRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RatingsService</summary>
    #pragma warning disable 0618
    public class RatingsServiceClient : ClientBase<RatingsServiceClient>, IRatingsServiceClient
    #pragma warning restore 0618
    {
      public RatingsServiceClient(Channel channel) : base(channel)
      {
      }
      public RatingsServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      ///<summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RatingsServiceClient() : base()
      {
      }
      ///<summary>Protected constructor to allow creation of configured clients.</summary>
      protected RatingsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Rate a video
      /// </summary>
      public virtual global::KillrVideo.Ratings.RateVideoResponse RateVideo(global::KillrVideo.Ratings.RateVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RateVideo(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Rate a video
      /// </summary>
      public virtual global::KillrVideo.Ratings.RateVideoResponse RateVideo(global::KillrVideo.Ratings.RateVideoRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RateVideo, null, options, request);
      }
      /// <summary>
      ///  Rate a video
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Ratings.RateVideoResponse> RateVideoAsync(global::KillrVideo.Ratings.RateVideoRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RateVideoAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Rate a video
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Ratings.RateVideoResponse> RateVideoAsync(global::KillrVideo.Ratings.RateVideoRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RateVideo, null, options, request);
      }
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      public virtual global::KillrVideo.Ratings.GetRatingResponse GetRating(global::KillrVideo.Ratings.GetRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRating(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      public virtual global::KillrVideo.Ratings.GetRatingResponse GetRating(global::KillrVideo.Ratings.GetRatingRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRating, null, options, request);
      }
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Ratings.GetRatingResponse> GetRatingAsync(global::KillrVideo.Ratings.GetRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRatingAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets the current rating stats for a video
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Ratings.GetRatingResponse> GetRatingAsync(global::KillrVideo.Ratings.GetRatingRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRating, null, options, request);
      }
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      public virtual global::KillrVideo.Ratings.GetUserRatingResponse GetUserRating(global::KillrVideo.Ratings.GetUserRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetUserRating(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      public virtual global::KillrVideo.Ratings.GetUserRatingResponse GetUserRating(global::KillrVideo.Ratings.GetUserRatingRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetUserRating, null, options, request);
      }
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Ratings.GetUserRatingResponse> GetUserRatingAsync(global::KillrVideo.Ratings.GetUserRatingRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetUserRatingAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Gets a user's rating of a specific video and returns 0 if the user hasn't rated the video
      /// </summary>
      public virtual AsyncUnaryCall<global::KillrVideo.Ratings.GetUserRatingResponse> GetUserRatingAsync(global::KillrVideo.Ratings.GetUserRatingRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetUserRating, null, options, request);
      }
      protected override RatingsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RatingsServiceClient(configuration);
      }
    }

    /// <summary>Creates a new client for RatingsService</summary>
    public static RatingsServiceClient NewClient(Channel channel)
    {
      return new RatingsServiceClient(channel);
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    #pragma warning disable 0618
    public static ServerServiceDefinition BindService(IRatingsService serviceImpl)
    #pragma warning restore 0618
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_RateVideo, serviceImpl.RateVideo)
          .AddMethod(__Method_GetRating, serviceImpl.GetRating)
          .AddMethod(__Method_GetUserRating, serviceImpl.GetUserRating).Build();
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    #pragma warning disable 0618
    public static ServerServiceDefinition BindService(RatingsServiceBase serviceImpl)
    #pragma warning restore 0618
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_RateVideo, serviceImpl.RateVideo)
          .AddMethod(__Method_GetRating, serviceImpl.GetRating)
          .AddMethod(__Method_GetUserRating, serviceImpl.GetUserRating).Build();
    }

  }
}
#endregion
