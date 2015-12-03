// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.DataFactories.Core.Registration.Models
{
    /// <summary>
    /// The protocol definition for communication with a ComputeType.
    /// </summary>
    public abstract partial class ComputeTransport
    {
        private string _transportProtocolVersion;
        
        /// <summary>
        /// Optional. The version of the transport protocol for communication
        /// between ADF and the user's compute resource proxy service.
        /// </summary>
        public string TransportProtocolVersion
        {
            get { return this._transportProtocolVersion; }
            set { this._transportProtocolVersion = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ComputeTransport class.
        /// </summary>
        public ComputeTransport()
        {
        }
    }
}