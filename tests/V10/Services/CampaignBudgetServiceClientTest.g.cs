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

using gagve = Google.Ads.GoogleAds.V10.Enums;
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
    public sealed class GeneratedCampaignBudgetServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateCampaignBudgetsRequestObject()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse response = client.MutateCampaignBudgets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignBudgetsRequestObjectAsync()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignBudgetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse responseCallSettings = await client.MutateCampaignBudgetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignBudgetsResponse responseCancellationToken = await client.MutateCampaignBudgetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateCampaignBudgets()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse response = client.MutateCampaignBudgets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignBudgetsAsync()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignBudgetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse responseCallSettings = await client.MutateCampaignBudgetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignBudgetsResponse responseCancellationToken = await client.MutateCampaignBudgetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
