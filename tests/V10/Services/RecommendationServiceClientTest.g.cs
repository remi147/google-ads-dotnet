// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V10.Services;

namespace Google.Ads.GoogleAds.Tests.V10.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRecommendationServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void ApplyRecommendationRequestObject()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
                PartialFailure = false,
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse response = client.ApplyRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task ApplyRecommendationRequestObjectAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
                PartialFailure = false,
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApplyRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse responseCallSettings = await client.ApplyRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ApplyRecommendationResponse responseCancellationToken = await client.ApplyRecommendationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void ApplyRecommendation()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse response = client.ApplyRecommendation(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task ApplyRecommendationAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApplyRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse responseCallSettings = await client.ApplyRecommendationAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ApplyRecommendationResponse responseCancellationToken = await client.ApplyRecommendationAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void DismissRecommendationRequestObject()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                PartialFailure = false,
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse response = client.DismissRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task DismissRecommendationRequestObjectAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                PartialFailure = false,
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DismissRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse responseCallSettings = await client.DismissRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            DismissRecommendationResponse responseCancellationToken = await client.DismissRecommendationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void DismissRecommendation()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse response = client.DismissRecommendation(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task DismissRecommendationAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DismissRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse responseCallSettings = await client.DismissRecommendationAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            DismissRecommendationResponse responseCancellationToken = await client.DismissRecommendationAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
