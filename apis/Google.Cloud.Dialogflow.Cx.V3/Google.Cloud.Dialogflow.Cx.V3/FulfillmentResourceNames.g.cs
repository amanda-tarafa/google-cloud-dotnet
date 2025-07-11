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

namespace Google.Cloud.Dialogflow.Cx.V3
{
    public partial class Fulfillment
    {
        /// <summary>
        /// <see cref="WebhookName"/>-typed view over the <see cref="Webhook"/> resource name property.
        /// </summary>
        public WebhookName WebhookAsWebhookName
        {
            get => string.IsNullOrEmpty(Webhook) ? null : WebhookName.Parse(Webhook, allowUnparsed: true);
            set => Webhook = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class GeneratorSettings
            {
                /// <summary>
                /// <see cref="GeneratorName"/>-typed view over the <see cref="Generator"/> resource name property.
                /// </summary>
                public GeneratorName GeneratorAsGeneratorName
                {
                    get => string.IsNullOrEmpty(Generator) ? null : GeneratorName.Parse(Generator, allowUnparsed: true);
                    set => Generator = value?.ToString() ?? "";
                }
            }
        }
    }
}
