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
	public class RegionChannelNumber : ObjectBase
	{
		#region Constants
		public const string REGION_ID = "regionId";
		public const string CHANNEL_NUMBER = "channelNumber";
		public const string DYNAMIC_DATA = "dynamicData";
		#endregion

		#region Private Fields
		private int _RegionId = Int32.MinValue;
		private int _ChannelNumber = Int32.MinValue;
		private IDictionary<string, StringValue> _DynamicData;
		#endregion

		#region Properties
		/// <summary>
		/// Use RegionIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RegionId
		{
			get { return _RegionId; }
			set 
			{ 
				_RegionId = value;
				OnPropertyChanged("RegionId");
			}
		}
		/// <summary>
		/// Use ChannelNumberAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ChannelNumber
		{
			get { return _ChannelNumber; }
			set 
			{ 
				_ChannelNumber = value;
				OnPropertyChanged("ChannelNumber");
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
		#endregion

		#region CTor
		public RegionChannelNumber()
		{
		}

		public RegionChannelNumber(JToken node) : base(node)
		{
			if(node["regionId"] != null)
			{
				this._RegionId = ParseInt(node["regionId"].Value<string>());
			}
			if(node["channelNumber"] != null)
			{
				this._ChannelNumber = ParseInt(node["channelNumber"].Value<string>());
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
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRegionChannelNumber");
			kparams.AddIfNotNull("regionId", this._RegionId);
			kparams.AddIfNotNull("channelNumber", this._ChannelNumber);
			kparams.AddIfNotNull("dynamicData", this._DynamicData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case REGION_ID:
					return "RegionId";
				case CHANNEL_NUMBER:
					return "ChannelNumber";
				case DYNAMIC_DATA:
					return "DynamicData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

