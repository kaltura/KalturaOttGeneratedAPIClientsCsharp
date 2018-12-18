// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2018  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class ConcurrencyPartnerConfig : PartnerConfiguration
	{
		#region Constants
		public const string DEVICE_FAMILY_IDS = "deviceFamilyIds";
		public const string EVICTION_POLICY = "evictionPolicy";
		#endregion

		#region Private Fields
		private string _DeviceFamilyIds = null;
		private EvictionPolicyType _EvictionPolicy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string DeviceFamilyIds
		{
			get { return _DeviceFamilyIds; }
			set 
			{ 
				_DeviceFamilyIds = value;
				OnPropertyChanged("DeviceFamilyIds");
			}
		}
		[JsonProperty]
		public EvictionPolicyType EvictionPolicy
		{
			get { return _EvictionPolicy; }
			set 
			{ 
				_EvictionPolicy = value;
				OnPropertyChanged("EvictionPolicy");
			}
		}
		#endregion

		#region CTor
		public ConcurrencyPartnerConfig()
		{
		}

		public ConcurrencyPartnerConfig(JToken node) : base(node)
		{
			if(node["deviceFamilyIds"] != null)
			{
				this._DeviceFamilyIds = node["deviceFamilyIds"].Value<string>();
			}
			if(node["evictionPolicy"] != null)
			{
				this._EvictionPolicy = (EvictionPolicyType)StringEnum.Parse(typeof(EvictionPolicyType), node["evictionPolicy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConcurrencyPartnerConfig");
			kparams.AddIfNotNull("deviceFamilyIds", this._DeviceFamilyIds);
			kparams.AddIfNotNull("evictionPolicy", this._EvictionPolicy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DEVICE_FAMILY_IDS:
					return "DeviceFamilyIds";
				case EVICTION_POLICY:
					return "EvictionPolicy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

