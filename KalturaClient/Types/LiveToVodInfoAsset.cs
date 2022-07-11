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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class LiveToVodInfoAsset : ObjectBase
	{
		#region Constants
		public const string LINEAR_ASSET_ID = "linearAssetId";
		public const string EPG_ID = "epgId";
		public const string EPG_CHANNEL_ID = "epgChannelId";
		public const string CRID = "crid";
		public const string ORIGINAL_START_DATE = "originalStartDate";
		public const string ORIGINAL_END_DATE = "originalEndDate";
		public const string PADDING_BEFORE_PROGRAM_STARTS = "paddingBeforeProgramStarts";
		public const string PADDING_AFTER_PROGRAM_ENDS = "paddingAfterProgramEnds";
		#endregion

		#region Private Fields
		private long _LinearAssetId = long.MinValue;
		private string _EpgId = null;
		private long _EpgChannelId = long.MinValue;
		private string _Crid = null;
		private long _OriginalStartDate = long.MinValue;
		private long _OriginalEndDate = long.MinValue;
		private long _PaddingBeforeProgramStarts = long.MinValue;
		private long _PaddingAfterProgramEnds = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use LinearAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long LinearAssetId
		{
			get { return _LinearAssetId; }
			set 
			{ 
				_LinearAssetId = value;
				OnPropertyChanged("LinearAssetId");
			}
		}
		/// <summary>
		/// Use EpgIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EpgId
		{
			get { return _EpgId; }
			set 
			{ 
				_EpgId = value;
				OnPropertyChanged("EpgId");
			}
		}
		/// <summary>
		/// Use EpgChannelIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EpgChannelId
		{
			get { return _EpgChannelId; }
			set 
			{ 
				_EpgChannelId = value;
				OnPropertyChanged("EpgChannelId");
			}
		}
		/// <summary>
		/// Use CridAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Crid
		{
			get { return _Crid; }
			set 
			{ 
				_Crid = value;
				OnPropertyChanged("Crid");
			}
		}
		/// <summary>
		/// Use OriginalStartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long OriginalStartDate
		{
			get { return _OriginalStartDate; }
			set 
			{ 
				_OriginalStartDate = value;
				OnPropertyChanged("OriginalStartDate");
			}
		}
		/// <summary>
		/// Use OriginalEndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long OriginalEndDate
		{
			get { return _OriginalEndDate; }
			set 
			{ 
				_OriginalEndDate = value;
				OnPropertyChanged("OriginalEndDate");
			}
		}
		/// <summary>
		/// Use PaddingBeforeProgramStartsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PaddingBeforeProgramStarts
		{
			get { return _PaddingBeforeProgramStarts; }
			set 
			{ 
				_PaddingBeforeProgramStarts = value;
				OnPropertyChanged("PaddingBeforeProgramStarts");
			}
		}
		/// <summary>
		/// Use PaddingAfterProgramEndsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PaddingAfterProgramEnds
		{
			get { return _PaddingAfterProgramEnds; }
			set 
			{ 
				_PaddingAfterProgramEnds = value;
				OnPropertyChanged("PaddingAfterProgramEnds");
			}
		}
		#endregion

		#region CTor
		public LiveToVodInfoAsset()
		{
		}

		public LiveToVodInfoAsset(JToken node) : base(node)
		{
			if(node["linearAssetId"] != null)
			{
				this._LinearAssetId = ParseLong(node["linearAssetId"].Value<string>());
			}
			if(node["epgId"] != null)
			{
				this._EpgId = node["epgId"].Value<string>();
			}
			if(node["epgChannelId"] != null)
			{
				this._EpgChannelId = ParseLong(node["epgChannelId"].Value<string>());
			}
			if(node["crid"] != null)
			{
				this._Crid = node["crid"].Value<string>();
			}
			if(node["originalStartDate"] != null)
			{
				this._OriginalStartDate = ParseLong(node["originalStartDate"].Value<string>());
			}
			if(node["originalEndDate"] != null)
			{
				this._OriginalEndDate = ParseLong(node["originalEndDate"].Value<string>());
			}
			if(node["paddingBeforeProgramStarts"] != null)
			{
				this._PaddingBeforeProgramStarts = ParseLong(node["paddingBeforeProgramStarts"].Value<string>());
			}
			if(node["paddingAfterProgramEnds"] != null)
			{
				this._PaddingAfterProgramEnds = ParseLong(node["paddingAfterProgramEnds"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveToVodInfoAsset");
			kparams.AddIfNotNull("linearAssetId", this._LinearAssetId);
			kparams.AddIfNotNull("epgId", this._EpgId);
			kparams.AddIfNotNull("epgChannelId", this._EpgChannelId);
			kparams.AddIfNotNull("crid", this._Crid);
			kparams.AddIfNotNull("originalStartDate", this._OriginalStartDate);
			kparams.AddIfNotNull("originalEndDate", this._OriginalEndDate);
			kparams.AddIfNotNull("paddingBeforeProgramStarts", this._PaddingBeforeProgramStarts);
			kparams.AddIfNotNull("paddingAfterProgramEnds", this._PaddingAfterProgramEnds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LINEAR_ASSET_ID:
					return "LinearAssetId";
				case EPG_ID:
					return "EpgId";
				case EPG_CHANNEL_ID:
					return "EpgChannelId";
				case CRID:
					return "Crid";
				case ORIGINAL_START_DATE:
					return "OriginalStartDate";
				case ORIGINAL_END_DATE:
					return "OriginalEndDate";
				case PADDING_BEFORE_PROGRAM_STARTS:
					return "PaddingBeforeProgramStarts";
				case PADDING_AFTER_PROGRAM_ENDS:
					return "PaddingAfterProgramEnds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

