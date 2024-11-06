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
	public class WatchBasedRecommendationsAdminConfiguration : ObjectBase
	{
		#region Constants
		public const string MAX_PROFILES = "maxProfiles";
		public const string ACTIVE_USER_DURATION_DAYS = "activeUserDurationDays";
		public const string RECOMMENDATIONS_CACHING_TIME_DAYS = "recommendationsCachingTimeDays";
		#endregion

		#region Private Fields
		private int _MaxProfiles = Int32.MinValue;
		private int _ActiveUserDurationDays = Int32.MinValue;
		private int _RecommendationsCachingTimeDays = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use MaxProfilesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxProfiles
		{
			get { return _MaxProfiles; }
			set 
			{ 
				_MaxProfiles = value;
				OnPropertyChanged("MaxProfiles");
			}
		}
		/// <summary>
		/// Use ActiveUserDurationDaysAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ActiveUserDurationDays
		{
			get { return _ActiveUserDurationDays; }
			set 
			{ 
				_ActiveUserDurationDays = value;
				OnPropertyChanged("ActiveUserDurationDays");
			}
		}
		/// <summary>
		/// Use RecommendationsCachingTimeDaysAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RecommendationsCachingTimeDays
		{
			get { return _RecommendationsCachingTimeDays; }
			set 
			{ 
				_RecommendationsCachingTimeDays = value;
				OnPropertyChanged("RecommendationsCachingTimeDays");
			}
		}
		#endregion

		#region CTor
		public WatchBasedRecommendationsAdminConfiguration()
		{
		}

		public WatchBasedRecommendationsAdminConfiguration(JToken node) : base(node)
		{
			if(node["maxProfiles"] != null)
			{
				this._MaxProfiles = ParseInt(node["maxProfiles"].Value<string>());
			}
			if(node["activeUserDurationDays"] != null)
			{
				this._ActiveUserDurationDays = ParseInt(node["activeUserDurationDays"].Value<string>());
			}
			if(node["recommendationsCachingTimeDays"] != null)
			{
				this._RecommendationsCachingTimeDays = ParseInt(node["recommendationsCachingTimeDays"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWatchBasedRecommendationsAdminConfiguration");
			kparams.AddIfNotNull("maxProfiles", this._MaxProfiles);
			kparams.AddIfNotNull("activeUserDurationDays", this._ActiveUserDurationDays);
			kparams.AddIfNotNull("recommendationsCachingTimeDays", this._RecommendationsCachingTimeDays);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MAX_PROFILES:
					return "MaxProfiles";
				case ACTIVE_USER_DURATION_DAYS:
					return "ActiveUserDurationDays";
				case RECOMMENDATIONS_CACHING_TIME_DAYS:
					return "RecommendationsCachingTimeDays";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

