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
	public class WatchCountCondition : BaseWatchCondition
	{
		#region Constants
		public const string MIN_COUNT = "minCount";
		public const string MAX_COUNT = "maxCount";
		#endregion

		#region Private Fields
		private int _MinCount = Int32.MinValue;
		private int _MaxCount = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use MinCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MinCount
		{
			get { return _MinCount; }
			set 
			{ 
				_MinCount = value;
				OnPropertyChanged("MinCount");
			}
		}
		/// <summary>
		/// Use MaxCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxCount
		{
			get { return _MaxCount; }
			set 
			{ 
				_MaxCount = value;
				OnPropertyChanged("MaxCount");
			}
		}
		#endregion

		#region CTor
		public WatchCountCondition()
		{
		}

		public WatchCountCondition(JToken node) : base(node)
		{
			if(node["minCount"] != null)
			{
				this._MinCount = ParseInt(node["minCount"].Value<string>());
			}
			if(node["maxCount"] != null)
			{
				this._MaxCount = ParseInt(node["maxCount"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWatchCountCondition");
			kparams.AddIfNotNull("minCount", this._MinCount);
			kparams.AddIfNotNull("maxCount", this._MaxCount);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MIN_COUNT:
					return "MinCount";
				case MAX_COUNT:
					return "MaxCount";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

