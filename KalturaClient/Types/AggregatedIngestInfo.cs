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
	public class AggregatedIngestInfo : ObjectBase
	{
		#region Constants
		public const string RESULTS_COUNT = "resultsCount";
		public const string TOTAL_FAILURE_COUNT = "totalFailureCount";
		public const string PARTIAL_FAILURE_COUNT = "partialFailureCount";
		public const string WARNINGS_COUNT = "warningsCount";
		#endregion

		#region Private Fields
		private long _ResultsCount = long.MinValue;
		private long _TotalFailureCount = long.MinValue;
		private long _PartialFailureCount = long.MinValue;
		private long _WarningsCount = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use ResultsCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ResultsCount
		{
			get { return _ResultsCount; }
			set 
			{ 
				_ResultsCount = value;
				OnPropertyChanged("ResultsCount");
			}
		}
		/// <summary>
		/// Use TotalFailureCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long TotalFailureCount
		{
			get { return _TotalFailureCount; }
			set 
			{ 
				_TotalFailureCount = value;
				OnPropertyChanged("TotalFailureCount");
			}
		}
		/// <summary>
		/// Use PartialFailureCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PartialFailureCount
		{
			get { return _PartialFailureCount; }
			set 
			{ 
				_PartialFailureCount = value;
				OnPropertyChanged("PartialFailureCount");
			}
		}
		/// <summary>
		/// Use WarningsCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long WarningsCount
		{
			get { return _WarningsCount; }
			set 
			{ 
				_WarningsCount = value;
				OnPropertyChanged("WarningsCount");
			}
		}
		#endregion

		#region CTor
		public AggregatedIngestInfo()
		{
		}

		public AggregatedIngestInfo(JToken node) : base(node)
		{
			if(node["resultsCount"] != null)
			{
				this._ResultsCount = ParseLong(node["resultsCount"].Value<string>());
			}
			if(node["totalFailureCount"] != null)
			{
				this._TotalFailureCount = ParseLong(node["totalFailureCount"].Value<string>());
			}
			if(node["partialFailureCount"] != null)
			{
				this._PartialFailureCount = ParseLong(node["partialFailureCount"].Value<string>());
			}
			if(node["warningsCount"] != null)
			{
				this._WarningsCount = ParseLong(node["warningsCount"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAggregatedIngestInfo");
			kparams.AddIfNotNull("resultsCount", this._ResultsCount);
			kparams.AddIfNotNull("totalFailureCount", this._TotalFailureCount);
			kparams.AddIfNotNull("partialFailureCount", this._PartialFailureCount);
			kparams.AddIfNotNull("warningsCount", this._WarningsCount);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RESULTS_COUNT:
					return "ResultsCount";
				case TOTAL_FAILURE_COUNT:
					return "TotalFailureCount";
				case PARTIAL_FAILURE_COUNT:
					return "PartialFailureCount";
				case WARNINGS_COUNT:
					return "WarningsCount";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

