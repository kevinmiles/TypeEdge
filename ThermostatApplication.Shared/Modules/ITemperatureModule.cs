﻿using System;
using System.Threading.Tasks;
using Microsoft.Azure.IoT.TypeEdge;
using Microsoft.Azure.IoT.TypeEdge.Hubs;
using Microsoft.Azure.IoT.TypeEdge.Modules;
using ThermostatApplication.Messages;

namespace ThermostatApplication.Modules
{
    public interface ITemperatureModule
    {
        Output<TemperatureModuleOutput> Temperature { get; set; }                
    }
}