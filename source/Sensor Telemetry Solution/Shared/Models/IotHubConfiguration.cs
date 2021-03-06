﻿// Copyright © 2015-2016 Daniel Porrey
//
// This file is part of the Sensor Telemetry solution.
// 
// Sensor Telemetry is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Sensor Telemetry is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Sensor Telemetry. If not, see http://www.gnu.org/licenses/.
//
using Porrey.SensorTelemetry.Interfaces;

namespace Porrey.SensorTelemetry.Models
{
	/// <summary>
	/// Defines the properties used to connect to a Microsoft
	/// Azure Iot Hub.
	/// </summary>
	public class IotHubConfiguration : IIotHubConfiguration
	{
		/// <summary>
		/// Gets/sets a ID that uniquely identifies the IoT device
		/// on the Azure IoT Hub.
		/// </summary>
		public string DeviceId { get; set; }

		/// <summary>
		/// Gets/sets the URI for the Azure IoT Hub.
		/// </summary>
		public string ConnectionString { get; set; }
	}
}
