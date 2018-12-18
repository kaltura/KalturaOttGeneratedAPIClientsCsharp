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
	public class HouseholdDevice : ObjectBase
	{
		#region Constants
		public const string HOUSEHOLD_ID = "householdId";
		public const string UDID = "udid";
		public const string NAME = "name";
		public const string BRAND_ID = "brandId";
		public const string ACTIVATED_ON = "activatedOn";
		public const string STATUS = "status";
		public const string DEVICE_FAMILY_ID = "deviceFamilyId";
		public const string DRM = "drm";
		#endregion

		#region Private Fields
		private int _HouseholdId = Int32.MinValue;
		private string _Udid = null;
		private string _Name = null;
		private int _BrandId = Int32.MinValue;
		private long _ActivatedOn = long.MinValue;
		private DeviceStatus _Status = null;
		private long _DeviceFamilyId = long.MinValue;
		private CustomDrmPlaybackPluginData _Drm;
		#endregion

		#region Properties
		[JsonProperty]
		public int HouseholdId
		{
			get { return _HouseholdId; }
			set 
			{ 
				_HouseholdId = value;
				OnPropertyChanged("HouseholdId");
			}
		}
		[JsonProperty]
		public string Udid
		{
			get { return _Udid; }
			set 
			{ 
				_Udid = value;
				OnPropertyChanged("Udid");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public int BrandId
		{
			get { return _BrandId; }
			set 
			{ 
				_BrandId = value;
				OnPropertyChanged("BrandId");
			}
		}
		[JsonProperty]
		public long ActivatedOn
		{
			get { return _ActivatedOn; }
			set 
			{ 
				_ActivatedOn = value;
				OnPropertyChanged("ActivatedOn");
			}
		}
		[JsonProperty]
		public DeviceStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public long DeviceFamilyId
		{
			get { return _DeviceFamilyId; }
			private set 
			{ 
				_DeviceFamilyId = value;
				OnPropertyChanged("DeviceFamilyId");
			}
		}
		[JsonProperty]
		public CustomDrmPlaybackPluginData Drm
		{
			get { return _Drm; }
			private set 
			{ 
				_Drm = value;
				OnPropertyChanged("Drm");
			}
		}
		#endregion

		#region CTor
		public HouseholdDevice()
		{
		}

		public HouseholdDevice(JToken node) : base(node)
		{
			if(node["householdId"] != null)
			{
				this._HouseholdId = ParseInt(node["householdId"].Value<string>());
			}
			if(node["udid"] != null)
			{
				this._Udid = node["udid"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["brandId"] != null)
			{
				this._BrandId = ParseInt(node["brandId"].Value<string>());
			}
			if(node["activatedOn"] != null)
			{
				this._ActivatedOn = ParseLong(node["activatedOn"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (DeviceStatus)StringEnum.Parse(typeof(DeviceStatus), node["status"].Value<string>());
			}
			if(node["deviceFamilyId"] != null)
			{
				this._DeviceFamilyId = ParseLong(node["deviceFamilyId"].Value<string>());
			}
			if(node["drm"] != null)
			{
				this._Drm = ObjectFactory.Create<CustomDrmPlaybackPluginData>(node["drm"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHouseholdDevice");
			kparams.AddIfNotNull("householdId", this._HouseholdId);
			kparams.AddIfNotNull("udid", this._Udid);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("brandId", this._BrandId);
			kparams.AddIfNotNull("activatedOn", this._ActivatedOn);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("deviceFamilyId", this._DeviceFamilyId);
			kparams.AddIfNotNull("drm", this._Drm);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HOUSEHOLD_ID:
					return "HouseholdId";
				case UDID:
					return "Udid";
				case NAME:
					return "Name";
				case BRAND_ID:
					return "BrandId";
				case ACTIVATED_ON:
					return "ActivatedOn";
				case STATUS:
					return "Status";
				case DEVICE_FAMILY_ID:
					return "DeviceFamilyId";
				case DRM:
					return "Drm";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

