// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class HouseholdDevice : OTTObjectSupportNullable
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
		public const string EXTERNAL_ID = "externalId";
		public const string MAC_ADDRESS = "macAddress";
		public const string DYNAMIC_DATA = "dynamicData";
		public const string MODEL = "model";
		public const string MANUFACTURER = "manufacturer";
		public const string MANUFACTURER_ID = "manufacturerId";
		public const string LAST_ACTIVITY_TIME = "lastActivityTime";
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
		private string _ExternalId = null;
		private string _MacAddress = null;
		private IDictionary<string, StringValue> _DynamicData;
		private string _Model = null;
		private string _Manufacturer = null;
		private long _ManufacturerId = long.MinValue;
		private long _LastActivityTime = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use HouseholdIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UdidAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use BrandIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ActivatedOnAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DeviceFamilyIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DrmAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ExternalIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalId
		{
			get { return _ExternalId; }
			set 
			{ 
				_ExternalId = value;
				OnPropertyChanged("ExternalId");
			}
		}
		/// <summary>
		/// Use MacAddressAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MacAddress
		{
			get { return _MacAddress; }
			set 
			{ 
				_MacAddress = value;
				OnPropertyChanged("MacAddress");
			}
		}
		/// <summary>
		/// Use DynamicDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IDictionary<string, StringValue> DynamicData
		{
			get { return _DynamicData; }
			set 
			{ 
				_DynamicData = value;
				OnPropertyChanged("DynamicData");
			}
		}
		/// <summary>
		/// Use ModelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Model
		{
			get { return _Model; }
			set 
			{ 
				_Model = value;
				OnPropertyChanged("Model");
			}
		}
		/// <summary>
		/// Use ManufacturerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Manufacturer
		{
			get { return _Manufacturer; }
			set 
			{ 
				_Manufacturer = value;
				OnPropertyChanged("Manufacturer");
			}
		}
		/// <summary>
		/// Use ManufacturerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ManufacturerId
		{
			get { return _ManufacturerId; }
			private set 
			{ 
				_ManufacturerId = value;
				OnPropertyChanged("ManufacturerId");
			}
		}
		/// <summary>
		/// Use LastActivityTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long LastActivityTime
		{
			get { return _LastActivityTime; }
			private set 
			{ 
				_LastActivityTime = value;
				OnPropertyChanged("LastActivityTime");
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
			if(node["externalId"] != null)
			{
				this._ExternalId = node["externalId"].Value<string>();
			}
			if(node["macAddress"] != null)
			{
				this._MacAddress = node["macAddress"].Value<string>();
			}
			if(node["dynamicData"] != null)
			{
				{
					string key;
					this._DynamicData = new Dictionary<string, StringValue>();
					foreach(var arrayNode in node["dynamicData"].Children<JProperty>())
					{
						key = arrayNode.Name;
						this._DynamicData[key] = ObjectFactory.Create<StringValue>(arrayNode.Value);
					}
				}
			}
			if(node["model"] != null)
			{
				this._Model = node["model"].Value<string>();
			}
			if(node["manufacturer"] != null)
			{
				this._Manufacturer = node["manufacturer"].Value<string>();
			}
			if(node["manufacturerId"] != null)
			{
				this._ManufacturerId = ParseLong(node["manufacturerId"].Value<string>());
			}
			if(node["lastActivityTime"] != null)
			{
				this._LastActivityTime = ParseLong(node["lastActivityTime"].Value<string>());
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
			kparams.AddIfNotNull("externalId", this._ExternalId);
			kparams.AddIfNotNull("macAddress", this._MacAddress);
			kparams.AddIfNotNull("dynamicData", this._DynamicData);
			kparams.AddIfNotNull("model", this._Model);
			kparams.AddIfNotNull("manufacturer", this._Manufacturer);
			kparams.AddIfNotNull("manufacturerId", this._ManufacturerId);
			kparams.AddIfNotNull("lastActivityTime", this._LastActivityTime);
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
				case EXTERNAL_ID:
					return "ExternalId";
				case MAC_ADDRESS:
					return "MacAddress";
				case DYNAMIC_DATA:
					return "DynamicData";
				case MODEL:
					return "Model";
				case MANUFACTURER:
					return "Manufacturer";
				case MANUFACTURER_ID:
					return "ManufacturerId";
				case LAST_ACTIVITY_TIME:
					return "LastActivityTime";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

