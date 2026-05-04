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
	public class WatchDurationCondition : BaseWatchCondition
	{
		#region Constants
		public const string MIN_DURATION_HOURS = "minDurationHours";
		public const string MAX_DURATION_HOURS = "maxDurationHours";
		#endregion

		#region Private Fields
		private int _MinDurationHours = Int32.MinValue;
		private int _MaxDurationHours = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use MinDurationHoursAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MinDurationHours
		{
			get { return _MinDurationHours; }
			set 
			{ 
				_MinDurationHours = value;
				OnPropertyChanged("MinDurationHours");
			}
		}
		/// <summary>
		/// Use MaxDurationHoursAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxDurationHours
		{
			get { return _MaxDurationHours; }
			set 
			{ 
				_MaxDurationHours = value;
				OnPropertyChanged("MaxDurationHours");
			}
		}
		#endregion

		#region CTor
		public WatchDurationCondition()
		{
		}

		public WatchDurationCondition(JToken node) : base(node)
		{
			if(node["minDurationHours"] != null)
			{
				this._MinDurationHours = ParseInt(node["minDurationHours"].Value<string>());
			}
			if(node["maxDurationHours"] != null)
			{
				this._MaxDurationHours = ParseInt(node["maxDurationHours"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWatchDurationCondition");
			kparams.AddIfNotNull("minDurationHours", this._MinDurationHours);
			kparams.AddIfNotNull("maxDurationHours", this._MaxDurationHours);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MIN_DURATION_HOURS:
					return "MinDurationHours";
				case MAX_DURATION_HOURS:
					return "MaxDurationHours";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

