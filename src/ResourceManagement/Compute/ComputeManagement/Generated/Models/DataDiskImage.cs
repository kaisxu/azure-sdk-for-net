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

namespace Microsoft.Azure.Management.Compute.Models
{
    /// <summary>
    /// Contains the data disk images information.
    /// </summary>
    public partial class DataDiskImage
    {
        private int _lun;
        
        /// <summary>
        /// Required. Gets the LUN number for a data disk.This value is used to
        /// identify data disk image inside the VMImage therefore it must be
        /// unique for each data disk.The allowed character for the value is
        /// digit.
        /// </summary>
        public int Lun
        {
            get { return this._lun; }
            set { this._lun = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DataDiskImage class.
        /// </summary>
        public DataDiskImage()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DataDiskImage class with required
        /// arguments.
        /// </summary>
        public DataDiskImage(int lun)
            : this()
        {
            this.Lun = lun;
        }
    }
}