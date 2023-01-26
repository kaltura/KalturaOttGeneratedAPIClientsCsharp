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
	public class IngestProgramResultsByRefineFilter : IngestEpgProgramResultFilter
	{
		#region Constants
		public const string INGEST_STATUS_IN = "ingestStatusIn";
		public const string START_DATE_GREATER_THAN = "startDateGreaterThan";
		public const string START_DATE_SMALLER_THAN = "startDateSmallerThan";
		#endregion

		#region Private Fields
		private string _IngestStatusIn = null;
		private long _StartDateGreaterThan = long.MinValue;
		private long _StartDateSmallerThan = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IngestStatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IngestStatusIn
		{
			get { return _IngestStatusIn; }
			set 
			{ 
				_IngestStatusIn = value;
				OnPropertyChanged("IngestStatusIn");
			}
		}
		/// <summary>
		/// Use StartDateGreaterThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long StartDateGreaterThan
		{
			get { return _StartDateGreaterThan; }
			set 
			{ 
				_StartDateGreaterThan = value;
				OnPropertyChanged("StartDateGreaterThan");
			}
		}
		/// <summary>
		/// Use StartDateSmallerThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long StartDateSmallerThan
		{
			get { return _StartDateSmallerThan; }
			set 
			{ 
				_StartDateSmallerThan = value;
				OnPropertyChanged("StartDateSmallerThan");
			}
		}
		#endregion

		#region CTor
		public IngestProgramResultsByRefineFilter()
		{
		}

		public IngestProgramResultsByRefineFilter(JToken node) : base(node)
		{
			if(node["ingestStatusIn"] != null)
			{
				this._IngestStatusIn = node["ingestStatusIn"].Value<string>();
			}
			if(node["startDateGreaterThan"] != null)
			{
				this._StartDateGreaterThan = ParseLong(node["startDateGreaterThan"].Value<string>());
			}
			if(node["startDateSmallerThan"] != null)
			{
				this._StartDateSmallerThan = ParseLong(node["startDateSmallerThan"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIngestProgramResultsByRefineFilter");
			kparams.AddIfNotNull("ingestStatusIn", this._IngestStatusIn);
			kparams.AddIfNotNull("startDateGreaterThan", this._StartDateGreaterThan);
			kparams.AddIfNotNull("startDateSmallerThan", this._StartDateSmallerThan);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INGEST_STATUS_IN:
					return "IngestStatusIn";
				case START_DATE_GREATER_THAN:
					return "StartDateGreaterThan";
				case START_DATE_SMALLER_THAN:
					return "StartDateSmallerThan";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

