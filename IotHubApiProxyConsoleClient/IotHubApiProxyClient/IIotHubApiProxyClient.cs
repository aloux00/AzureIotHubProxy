﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using IotHubApiProxy;
using Microsoft.Rest;

namespace IotHubApiProxy

{
    public partial interface IIotHubApiProxyClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        ServiceClientCredentials Credentials
        {
            get; set; 
        }
        
        IDevice Device
        {
            get; 
        }
    }
}
