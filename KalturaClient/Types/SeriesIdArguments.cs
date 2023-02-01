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
	public class SeriesIdArguments : ObjectBase
	{
		#region Constants
		public const string ASSET_TYPE_ID_IN = "assetTypeIdIn";
		public const string SERIES_ID = "seriesId";
		public const string SERIES_ID_META_NAME = "seriesIdMetaName";
		public const string SEASON_NUMBER_META_NAME = "seasonNumberMetaName";
		public const string EPISODE_NUMBER_META_NAME = "episodeNumberMetaName";
		#endregion

		#region Private Fields
		private string _AssetTypeIdIn = null;
		private string _SeriesId = null;
		private string _SeriesIdMetaName = null;
		private string _SeasonNumberMetaName = null;
		private string _EpisodeNumberMetaName = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetTypeIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetTypeIdIn
		{
			get { return _AssetTypeIdIn; }
			set 
			{ 
				_AssetTypeIdIn = value;
				OnPropertyChanged("AssetTypeIdIn");
			}
		}
		/// <summary>
		/// Use SeriesIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SeriesId
		{
			get { return _SeriesId; }
			set 
			{ 
				_SeriesId = value;
				OnPropertyChanged("SeriesId");
			}
		}
		/// <summary>
		/// Use SeriesIdMetaNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SeriesIdMetaName
		{
			get { return _SeriesIdMetaName; }
			set 
			{ 
				_SeriesIdMetaName = value;
				OnPropertyChanged("SeriesIdMetaName");
			}
		}
		/// <summary>
		/// Use SeasonNumberMetaNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SeasonNumberMetaName
		{
			get { return _SeasonNumberMetaName; }
			set 
			{ 
				_SeasonNumberMetaName = value;
				OnPropertyChanged("SeasonNumberMetaName");
			}
		}
		/// <summary>
		/// Use EpisodeNumberMetaNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EpisodeNumberMetaName
		{
			get { return _EpisodeNumberMetaName; }
			set 
			{ 
				_EpisodeNumberMetaName = value;
				OnPropertyChanged("EpisodeNumberMetaName");
			}
		}
		#endregion

		#region CTor
		public SeriesIdArguments()
		{
		}

		public SeriesIdArguments(JToken node) : base(node)
		{
			if(node["assetTypeIdIn"] != null)
			{
				this._AssetTypeIdIn = node["assetTypeIdIn"].Value<string>();
			}
			if(node["seriesId"] != null)
			{
				this._SeriesId = node["seriesId"].Value<string>();
			}
			if(node["seriesIdMetaName"] != null)
			{
				this._SeriesIdMetaName = node["seriesIdMetaName"].Value<string>();
			}
			if(node["seasonNumberMetaName"] != null)
			{
				this._SeasonNumberMetaName = node["seasonNumberMetaName"].Value<string>();
			}
			if(node["episodeNumberMetaName"] != null)
			{
				this._EpisodeNumberMetaName = node["episodeNumberMetaName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSeriesIdArguments");
			kparams.AddIfNotNull("assetTypeIdIn", this._AssetTypeIdIn);
			kparams.AddIfNotNull("seriesId", this._SeriesId);
			kparams.AddIfNotNull("seriesIdMetaName", this._SeriesIdMetaName);
			kparams.AddIfNotNull("seasonNumberMetaName", this._SeasonNumberMetaName);
			kparams.AddIfNotNull("episodeNumberMetaName", this._EpisodeNumberMetaName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_TYPE_ID_IN:
					return "AssetTypeIdIn";
				case SERIES_ID:
					return "SeriesId";
				case SERIES_ID_META_NAME:
					return "SeriesIdMetaName";
				case SEASON_NUMBER_META_NAME:
					return "SeasonNumberMetaName";
				case EPISODE_NUMBER_META_NAME:
					return "EpisodeNumberMetaName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

