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
	public class WatchBasedRecommendationsProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string TOPIC_IDS = "topicIds";
		public const string ANALYSIS_MEDIA_TYPE_IDS = "analysisMediaTypeIds";
		public const string USER_INTEREST_PLAY_THRESHOLD_IN_PERCENTAGES = "userInterestPlayThresholdInPercentages";
		public const string NUMBER_OF_INTERESTS = "numberOfInterests";
		public const string FALLBACK_CHANNEL_ID = "fallbackChannelId";
		public const string MIN_PLAYBACKS = "minPlaybacks";
		public const string MAX_PLAYBACKS = "maxPlaybacks";
		public const string ALLOWED_RECOMMENDATIONS_KSQL = "allowedRecommendationsKsql";
		public const string PLAYBACK_INTERESTS_CALCULATION_PERIOD_DAYS = "playbackInterestsCalculationPeriodDays";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _Name = null;
		private string _TopicIds = null;
		private string _AnalysisMediaTypeIds = null;
		private int _UserInterestPlayThresholdInPercentages = Int32.MinValue;
		private int _NumberOfInterests = Int32.MinValue;
		private long _FallbackChannelId = long.MinValue;
		private int _MinPlaybacks = Int32.MinValue;
		private int _MaxPlaybacks = Int32.MinValue;
		private string _AllowedRecommendationsKsql = null;
		private int _PlaybackInterestsCalculationPeriodDays = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		/// Use TopicIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TopicIds
		{
			get { return _TopicIds; }
			set 
			{ 
				_TopicIds = value;
				OnPropertyChanged("TopicIds");
			}
		}
		/// <summary>
		/// Use AnalysisMediaTypeIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AnalysisMediaTypeIds
		{
			get { return _AnalysisMediaTypeIds; }
			set 
			{ 
				_AnalysisMediaTypeIds = value;
				OnPropertyChanged("AnalysisMediaTypeIds");
			}
		}
		/// <summary>
		/// Use UserInterestPlayThresholdInPercentagesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UserInterestPlayThresholdInPercentages
		{
			get { return _UserInterestPlayThresholdInPercentages; }
			set 
			{ 
				_UserInterestPlayThresholdInPercentages = value;
				OnPropertyChanged("UserInterestPlayThresholdInPercentages");
			}
		}
		/// <summary>
		/// Use NumberOfInterestsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int NumberOfInterests
		{
			get { return _NumberOfInterests; }
			set 
			{ 
				_NumberOfInterests = value;
				OnPropertyChanged("NumberOfInterests");
			}
		}
		/// <summary>
		/// Use FallbackChannelIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long FallbackChannelId
		{
			get { return _FallbackChannelId; }
			set 
			{ 
				_FallbackChannelId = value;
				OnPropertyChanged("FallbackChannelId");
			}
		}
		/// <summary>
		/// Use MinPlaybacksAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MinPlaybacks
		{
			get { return _MinPlaybacks; }
			set 
			{ 
				_MinPlaybacks = value;
				OnPropertyChanged("MinPlaybacks");
			}
		}
		/// <summary>
		/// Use MaxPlaybacksAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxPlaybacks
		{
			get { return _MaxPlaybacks; }
			set 
			{ 
				_MaxPlaybacks = value;
				OnPropertyChanged("MaxPlaybacks");
			}
		}
		/// <summary>
		/// Use AllowedRecommendationsKsqlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AllowedRecommendationsKsql
		{
			get { return _AllowedRecommendationsKsql; }
			set 
			{ 
				_AllowedRecommendationsKsql = value;
				OnPropertyChanged("AllowedRecommendationsKsql");
			}
		}
		/// <summary>
		/// Use PlaybackInterestsCalculationPeriodDaysAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PlaybackInterestsCalculationPeriodDays
		{
			get { return _PlaybackInterestsCalculationPeriodDays; }
			set 
			{ 
				_PlaybackInterestsCalculationPeriodDays = value;
				OnPropertyChanged("PlaybackInterestsCalculationPeriodDays");
			}
		}
		#endregion

		#region CTor
		public WatchBasedRecommendationsProfile()
		{
		}

		public WatchBasedRecommendationsProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["topicIds"] != null)
			{
				this._TopicIds = node["topicIds"].Value<string>();
			}
			if(node["analysisMediaTypeIds"] != null)
			{
				this._AnalysisMediaTypeIds = node["analysisMediaTypeIds"].Value<string>();
			}
			if(node["userInterestPlayThresholdInPercentages"] != null)
			{
				this._UserInterestPlayThresholdInPercentages = ParseInt(node["userInterestPlayThresholdInPercentages"].Value<string>());
			}
			if(node["numberOfInterests"] != null)
			{
				this._NumberOfInterests = ParseInt(node["numberOfInterests"].Value<string>());
			}
			if(node["fallbackChannelId"] != null)
			{
				this._FallbackChannelId = ParseLong(node["fallbackChannelId"].Value<string>());
			}
			if(node["minPlaybacks"] != null)
			{
				this._MinPlaybacks = ParseInt(node["minPlaybacks"].Value<string>());
			}
			if(node["maxPlaybacks"] != null)
			{
				this._MaxPlaybacks = ParseInt(node["maxPlaybacks"].Value<string>());
			}
			if(node["allowedRecommendationsKsql"] != null)
			{
				this._AllowedRecommendationsKsql = node["allowedRecommendationsKsql"].Value<string>();
			}
			if(node["playbackInterestsCalculationPeriodDays"] != null)
			{
				this._PlaybackInterestsCalculationPeriodDays = ParseInt(node["playbackInterestsCalculationPeriodDays"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWatchBasedRecommendationsProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("topicIds", this._TopicIds);
			kparams.AddIfNotNull("analysisMediaTypeIds", this._AnalysisMediaTypeIds);
			kparams.AddIfNotNull("userInterestPlayThresholdInPercentages", this._UserInterestPlayThresholdInPercentages);
			kparams.AddIfNotNull("numberOfInterests", this._NumberOfInterests);
			kparams.AddIfNotNull("fallbackChannelId", this._FallbackChannelId);
			kparams.AddIfNotNull("minPlaybacks", this._MinPlaybacks);
			kparams.AddIfNotNull("maxPlaybacks", this._MaxPlaybacks);
			kparams.AddIfNotNull("allowedRecommendationsKsql", this._AllowedRecommendationsKsql);
			kparams.AddIfNotNull("playbackInterestsCalculationPeriodDays", this._PlaybackInterestsCalculationPeriodDays);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case TOPIC_IDS:
					return "TopicIds";
				case ANALYSIS_MEDIA_TYPE_IDS:
					return "AnalysisMediaTypeIds";
				case USER_INTEREST_PLAY_THRESHOLD_IN_PERCENTAGES:
					return "UserInterestPlayThresholdInPercentages";
				case NUMBER_OF_INTERESTS:
					return "NumberOfInterests";
				case FALLBACK_CHANNEL_ID:
					return "FallbackChannelId";
				case MIN_PLAYBACKS:
					return "MinPlaybacks";
				case MAX_PLAYBACKS:
					return "MaxPlaybacks";
				case ALLOWED_RECOMMENDATIONS_KSQL:
					return "AllowedRecommendationsKsql";
				case PLAYBACK_INTERESTS_CALCULATION_PERIOD_DAYS:
					return "PlaybackInterestsCalculationPeriodDays";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

