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
	public class SeriesInfo : ObjectBase
	{
		#region Constants
		public const string SERIES_ID_METADATA_NAME = "seriesIdMetadataName";
		public const string SERIES_TYPE_ID = "seriesTypeId";
		public const string EPISODE_TYPE_ID = "episodeTypeId";
		#endregion

		#region Private Fields
		private string _SeriesIdMetadataName = null;
		private long _SeriesTypeId = long.MinValue;
		private long _EpisodeTypeId = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use SeriesIdMetadataNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SeriesIdMetadataName
		{
			get { return _SeriesIdMetadataName; }
			set 
			{ 
				_SeriesIdMetadataName = value;
				OnPropertyChanged("SeriesIdMetadataName");
			}
		}
		/// <summary>
		/// Use SeriesTypeIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long SeriesTypeId
		{
			get { return _SeriesTypeId; }
			set 
			{ 
				_SeriesTypeId = value;
				OnPropertyChanged("SeriesTypeId");
			}
		}
		/// <summary>
		/// Use EpisodeTypeIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EpisodeTypeId
		{
			get { return _EpisodeTypeId; }
			set 
			{ 
				_EpisodeTypeId = value;
				OnPropertyChanged("EpisodeTypeId");
			}
		}
		#endregion

		#region CTor
		public SeriesInfo()
		{
		}

		public SeriesInfo(JToken node) : base(node)
		{
			if(node["seriesIdMetadataName"] != null)
			{
				this._SeriesIdMetadataName = node["seriesIdMetadataName"].Value<string>();
			}
			if(node["seriesTypeId"] != null)
			{
				this._SeriesTypeId = ParseLong(node["seriesTypeId"].Value<string>());
			}
			if(node["episodeTypeId"] != null)
			{
				this._EpisodeTypeId = ParseLong(node["episodeTypeId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSeriesInfo");
			kparams.AddIfNotNull("seriesIdMetadataName", this._SeriesIdMetadataName);
			kparams.AddIfNotNull("seriesTypeId", this._SeriesTypeId);
			kparams.AddIfNotNull("episodeTypeId", this._EpisodeTypeId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SERIES_ID_METADATA_NAME:
					return "SeriesIdMetadataName";
				case SERIES_TYPE_ID:
					return "SeriesTypeId";
				case EPISODE_TYPE_ID:
					return "EpisodeTypeId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

