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
	public class RecordingAsset : ProgramAsset
	{
		#region Constants
		public const string RECORDING_ID = "recordingId";
		public const string RECORDING_TYPE = "recordingType";
		public const string VIEWABLE_UNTIL_DATE = "viewableUntilDate";
		public const string MULTI_RECORD = "multiRecord";
		#endregion

		#region Private Fields
		private string _RecordingId = null;
		private RecordingType _RecordingType = null;
		private long _ViewableUntilDate = long.MinValue;
		private bool? _MultiRecord = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use RecordingIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RecordingId
		{
			get { return _RecordingId; }
			set 
			{ 
				_RecordingId = value;
				OnPropertyChanged("RecordingId");
			}
		}
		/// <summary>
		/// Use RecordingTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RecordingType RecordingType
		{
			get { return _RecordingType; }
			set 
			{ 
				_RecordingType = value;
				OnPropertyChanged("RecordingType");
			}
		}
		/// <summary>
		/// Use ViewableUntilDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ViewableUntilDate
		{
			get { return _ViewableUntilDate; }
			set 
			{ 
				_ViewableUntilDate = value;
				OnPropertyChanged("ViewableUntilDate");
			}
		}
		/// <summary>
		/// Use MultiRecordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? MultiRecord
		{
			get { return _MultiRecord; }
			set 
			{ 
				_MultiRecord = value;
				OnPropertyChanged("MultiRecord");
			}
		}
		#endregion

		#region CTor
		public RecordingAsset()
		{
		}

		public RecordingAsset(JToken node) : base(node)
		{
			if(node["recordingId"] != null)
			{
				this._RecordingId = node["recordingId"].Value<string>();
			}
			if(node["recordingType"] != null)
			{
				this._RecordingType = (RecordingType)StringEnum.Parse(typeof(RecordingType), node["recordingType"].Value<string>());
			}
			if(node["viewableUntilDate"] != null)
			{
				this._ViewableUntilDate = ParseLong(node["viewableUntilDate"].Value<string>());
			}
			if(node["multiRecord"] != null)
			{
				this._MultiRecord = ParseBool(node["multiRecord"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRecordingAsset");
			kparams.AddIfNotNull("recordingId", this._RecordingId);
			kparams.AddIfNotNull("recordingType", this._RecordingType);
			kparams.AddIfNotNull("viewableUntilDate", this._ViewableUntilDate);
			kparams.AddIfNotNull("multiRecord", this._MultiRecord);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RECORDING_ID:
					return "RecordingId";
				case RECORDING_TYPE:
					return "RecordingType";
				case VIEWABLE_UNTIL_DATE:
					return "ViewableUntilDate";
				case MULTI_RECORD:
					return "MultiRecord";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

