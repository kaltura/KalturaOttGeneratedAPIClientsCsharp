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
	public class SeriesRecordingOption : ObjectBase
	{
		#region Constants
		public const string MIN_SEASON_NUMBER = "minSeasonNumber";
		public const string MIN_EPISODE_NUMBER = "minEpisodeNumber";
		#endregion

		#region Private Fields
		private int _MinSeasonNumber = Int32.MinValue;
		private int _MinEpisodeNumber = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int MinSeasonNumber
		{
			get { return _MinSeasonNumber; }
			set 
			{ 
				_MinSeasonNumber = value;
				OnPropertyChanged("MinSeasonNumber");
			}
		}
		[JsonProperty]
		public int MinEpisodeNumber
		{
			get { return _MinEpisodeNumber; }
			set 
			{ 
				_MinEpisodeNumber = value;
				OnPropertyChanged("MinEpisodeNumber");
			}
		}
		#endregion

		#region CTor
		public SeriesRecordingOption()
		{
		}

		public SeriesRecordingOption(JToken node) : base(node)
		{
			if(node["minSeasonNumber"] != null)
			{
				this._MinSeasonNumber = ParseInt(node["minSeasonNumber"].Value<string>());
			}
			if(node["minEpisodeNumber"] != null)
			{
				this._MinEpisodeNumber = ParseInt(node["minEpisodeNumber"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSeriesRecordingOption");
			kparams.AddIfNotNull("minSeasonNumber", this._MinSeasonNumber);
			kparams.AddIfNotNull("minEpisodeNumber", this._MinEpisodeNumber);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MIN_SEASON_NUMBER:
					return "MinSeasonNumber";
				case MIN_EPISODE_NUMBER:
					return "MinEpisodeNumber";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

