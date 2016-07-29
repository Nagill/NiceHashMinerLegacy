﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NiceHashMiner.Configs
{
    /// <summary>
    /// DeviceDetectionConfig is used to enable/disable detection of certain GPU type devices 
    /// </summary>
    /// 
    [Serializable]
    public class DeviceDetectionConfig
    {
        public bool DisableDetectionNVidia5X { get; set; }
        public bool DisableDetectionNVidia3X { get; set; }
        public bool DisableDetectionNVidia2X { get; set; }
        public bool DisableDetectionAMD { get; set; }

        // TODO no need to initialize to false but just mirroring legacy for now
        public DeviceDetectionConfig()
        {
            DisableDetectionNVidia5X = false;
            DisableDetectionNVidia3X = false;
            DisableDetectionNVidia2X = false;
            DisableDetectionAMD = false;
        }
    }
}
