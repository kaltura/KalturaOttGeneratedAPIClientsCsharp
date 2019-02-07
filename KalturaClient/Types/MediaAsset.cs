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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class MediaAsset : Asset
	{
		#region Constants
		public const string EXTERNAL_IDS = "externalIds";
		public const string CATCH_UP_BUFFER = "catchUpBuffer";
		public const string TRICK_PLAY_BUFFER = "trickPlayBuffer";
		public const string ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL = "enableRecordingPlaybackNonEntitledChannel";
		public const string TYPE_DESCRIPTION = "typeDescription";
		public const string ENTRY_ID = "entryId";
		public const string DEVICE_RULE = "deviceRule";
		public const string GEO_BLOCK_RULE = "geoBlockRule";
		public const string WATCH_PERMISSION_RULE = "watchPermissionRule";
		#endregion

		#region Private Fields
		private string _ExternalIds = null;
		private long _CatchUpBuffer = long.MinValue;
		private long _TrickPlayBuffer = long.MinValue;
		private bool? _EnableRecordingPlaybackNonEntitledChannel = null;
		private string _TypeDescription = null;
		private string _EntryId = null;
		private string _DeviceRule = null;
		private string _GeoBlockRule = null;
		private string _WatchPermissionRule = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string ExternalIds
		{
			get { return _ExternalIds; }
			set 
			{ 
				_ExternalIds = value;
				OnPropertyChanged("ExternalIds");
			}
		}
		[JsonProperty]
		public long CatchUpBuffer
		{
			get { return _CatchUpBuffer; }
			set 
			{ 
				_CatchUpBuffer = value;
				OnPropertyChanged("CatchUpBuffer");
			}
		}
		[JsonProperty]
		public long TrickPlayBuffer
		{
			get { return _TrickPlayBuffer; }
			set 
			{ 
				_TrickPlayBuffer = value;
				OnPropertyChanged("TrickPlayBuffer");
			}
		}
		[JsonProperty]
		public bool? EnableRecordingPlaybackNonEntitledChannel
		{
			get { return _EnableRecordingPlaybackNonEntitledChannel; }
			private set 
			{ 
				_EnableRecordingPlaybackNonEntitledChannel = value;
				OnPropertyChanged("EnableRecordingPlaybackNonEntitledChannel");
			}
		}
		[JsonProperty]
		public string TypeDescription
		{
			get { return _TypeDescription; }
			set 
			{ 
				_TypeDescription = value;
				OnPropertyChanged("TypeDescription");
			}
		}
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public string DeviceRule
		{
			get { return _DeviceRule; }
			set 
			{ 
				_DeviceRule = value;
				OnPropertyChanged("DeviceRule");
			}
		}
		[JsonProperty]
		public string GeoBlockRule
		{
			get { return _GeoBlockRule; }
			set 
			{ 
				_GeoBlockRule = value;
				OnPropertyChanged("GeoBlockRule");
			}
		}
		[JsonProperty]
		public string WatchPermissionRule
		{
			get { return _WatchPermissionRule; }
			set 
			{ 
				_WatchPermissionRule = value;
				OnPropertyChanged("WatchPermissionRule");
			}
		}
		#endregion

		#region CTor
		public MediaAsset()
		{
		}

		public MediaAsset(JToken node) : base(node)
		{
			if(node["externalIds"] != null)
			{
				this._ExternalIds = node["externalIds"].Value<string>();
			}
			if(node["catchUpBuffer"] != null)
			{
				this._CatchUpBuffer = ParseLong(node["catchUpBuffer"].Value<string>());
			}
			if(node["trickPlayBuffer"] != null)
			{
				this._TrickPlayBuffer = ParseLong(node["trickPlayBuffer"].Value<string>());
			}
			if(node["enableRecordingPlaybackNonEntitledChannel"] != null)
			{
				this._EnableRecordingPlaybackNonEntitledChannel = ParseBool(node["enableRecordingPlaybackNonEntitledChannel"].Value<string>());
			}
			if(node["typeDescription"] != null)
			{
				this._TypeDescription = node["typeDescription"].Value<string>();
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["deviceRule"] != null)
			{
				this._DeviceRule = node["deviceRule"].Value<string>();
			}
			if(node["geoBlockRule"] != null)
			{
				this._GeoBlockRule = node["geoBlockRule"].Value<string>();
			}
			if(node["watchPermissionRule"] != null)
			{
				this._WatchPermissionRule = node["watchPermissionRule"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaAsset");
			kparams.AddIfNotNull("externalIds", this._ExternalIds);
			kparams.AddIfNotNull("catchUpBuffer", this._CatchUpBuffer);
			kparams.AddIfNotNull("trickPlayBuffer", this._TrickPlayBuffer);
			kparams.AddIfNotNull("enableRecordingPlaybackNonEntitledChannel", this._EnableRecordingPlaybackNonEntitledChannel);
			kparams.AddIfNotNull("typeDescription", this._TypeDescription);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("deviceRule", this._DeviceRule);
			kparams.AddIfNotNull("geoBlockRule", this._GeoBlockRule);
			kparams.AddIfNotNull("watchPermissionRule", this._WatchPermissionRule);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXTERNAL_IDS:
					return "ExternalIds";
				case CATCH_UP_BUFFER:
					return "CatchUpBuffer";
				case TRICK_PLAY_BUFFER:
					return "TrickPlayBuffer";
				case ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL:
					return "EnableRecordingPlaybackNonEntitledChannel";
				case TYPE_DESCRIPTION:
					return "TypeDescription";
				case ENTRY_ID:
					return "EntryId";
				case DEVICE_RULE:
					return "DeviceRule";
				case GEO_BLOCK_RULE:
					return "GeoBlockRule";
				case WATCH_PERMISSION_RULE:
					return "WatchPermissionRule";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

