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

using gagve = Google.Ads.GoogleAds.V11.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssetServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateAssetsRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                ValidateOnly = true,
                PartialFailure = false,
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse response = client.MutateAssets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAssetsRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                ValidateOnly = true,
                PartialFailure = false,
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse responseCallSettings = await client.MutateAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetsResponse responseCancellationToken = await client.MutateAssetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateAssets()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse response = client.MutateAssets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAssetsAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse responseCallSettings = await client.MutateAssetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetsResponse responseCancellationToken = await client.MutateAssetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
