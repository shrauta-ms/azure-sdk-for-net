// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Email channel definition. </summary>
    public partial class EmailChannel : BotChannelProperties
    {
        /// <summary> Initializes a new instance of <see cref="EmailChannel"/>. </summary>
        public EmailChannel()
        {
            ChannelName = "EmailChannel";
        }

        /// <summary> Initializes a new instance of <see cref="EmailChannel"/>. </summary>
        /// <param name="channelName"> The channel name. </param>
        /// <param name="etag"> Entity Tag of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> The set of properties specific to email channel resource. </param>
        internal EmailChannel(string channelName, ETag? etag, string provisioningState, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData, EmailChannelProperties properties) : base(channelName, etag, provisioningState, location, serializedAdditionalRawData)
        {
            Properties = properties;
            ChannelName = channelName ?? "EmailChannel";
        }

        /// <summary> The set of properties specific to email channel resource. </summary>
        public EmailChannelProperties Properties { get; set; }
    }
}
