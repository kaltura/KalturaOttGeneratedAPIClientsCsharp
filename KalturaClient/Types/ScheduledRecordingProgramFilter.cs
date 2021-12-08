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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class ScheduledRecordingProgramFilter : AssetFilter
	{
		#region Constants
		public const string RECORDING_TYPE_EQUAL = "recordingTypeEqual";
		public const string CHANNELS_IN = "channelsIn";
		public const string START_DATE_GREATER_THAN_OR_NULL = "startDateGreaterThanOrNull";
		public const string END_DATE_LESS_THAN_OR_NULL = "endDateLessThanOrNull";
		public const string SERIES_IDS_IN = "seriesIdsIn";
		#endregion

		#region Private Fields
		private ScheduledRecordingAssetType _RecordingTypeEqual = null;
		private string _ChannelsIn = null;
		private long _StartDateGreaterThanOrNull = long.MinValue;
		private long _EndDateLessThanOrNull = long.MinValue;
		private string _SeriesIdsIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use RecordingTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ScheduledRecordingAssetType RecordingTypeEqual
		{
			get { return _RecordingTypeEqual; }
			set 
			{ 
				_RecordingTypeEqual = value;
				OnPropertyChanged("RecordingTypeEqual");
			}
		}
		/// <summary>
		/// Use ChannelsInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ChannelsIn
		{
			get { return _ChannelsIn; }
			set 
			{ 
				_ChannelsIn = value;
				OnPropertyChanged("ChannelsIn");
			}
		}
		/// <summary>
		/// Use StartDateGreaterThanOrNullAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long StartDateGreaterThanOrNull
		{
			get { return _StartDateGreaterThanOrNull; }
			set 
			{ 
				_StartDateGreaterThanOrNull = value;
				OnPropertyChanged("StartDateGreaterThanOrNull");
			}
		}
		/// <summary>
		/// Use EndDateLessThanOrNullAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EndDateLessThanOrNull
		{
			get { return _EndDateLessThanOrNull; }
			set 
			{ 
				_EndDateLessThanOrNull = value;
				OnPropertyChanged("EndDateLessThanOrNull");
			}
		}
		/// <summary>
		/// Use SeriesIdsInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SeriesIdsIn
		{
			get { return _SeriesIdsIn; }
			set 
			{ 
				_SeriesIdsIn = value;
				OnPropertyChanged("SeriesIdsIn");
			}
		}
		#endregion

		#region CTor
		public ScheduledRecordingProgramFilter()
		{
		}

		public ScheduledRecordingProgramFilter(JToken node) : base(node)
		{
			if(node["recordingTypeEqual"] != null)
			{
				this._RecordingTypeEqual = (ScheduledRecordingAssetType)StringEnum.Parse(typeof(ScheduledRecordingAssetType), node["recordingTypeEqual"].Value<string>());
			}
			if(node["channelsIn"] != null)
			{
				this._ChannelsIn = node["channelsIn"].Value<string>();
			}
			if(node["startDateGreaterThanOrNull"] != null)
			{
				this._StartDateGreaterThanOrNull = ParseLong(node["startDateGreaterThanOrNull"].Value<string>());
			}
			if(node["endDateLessThanOrNull"] != null)
			{
				this._EndDateLessThanOrNull = ParseLong(node["endDateLessThanOrNull"].Value<string>());
			}
			if(node["seriesIdsIn"] != null)
			{
				this._SeriesIdsIn = node["seriesIdsIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduledRecordingProgramFilter");
			kparams.AddIfNotNull("recordingTypeEqual", this._RecordingTypeEqual);
			kparams.AddIfNotNull("channelsIn", this._ChannelsIn);
			kparams.AddIfNotNull("startDateGreaterThanOrNull", this._StartDateGreaterThanOrNull);
			kparams.AddIfNotNull("endDateLessThanOrNull", this._EndDateLessThanOrNull);
			kparams.AddIfNotNull("seriesIdsIn", this._SeriesIdsIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RECORDING_TYPE_EQUAL:
					return "RecordingTypeEqual";
				case CHANNELS_IN:
					return "ChannelsIn";
				case START_DATE_GREATER_THAN_OR_NULL:
					return "StartDateGreaterThanOrNull";
				case END_DATE_LESS_THAN_OR_NULL:
					return "EndDateLessThanOrNull";
				case SERIES_IDS_IN:
					return "SeriesIdsIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

