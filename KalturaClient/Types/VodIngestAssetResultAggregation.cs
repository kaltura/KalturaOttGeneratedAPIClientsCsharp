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
	public class VodIngestAssetResultAggregation : ObjectBase
	{
		#region Constants
		public const string INGEST_DATE_FROM = "ingestDateFrom";
		public const string INGEST_DATE_TO = "ingestDateTo";
		public const string FAILURE_COUNT = "failureCount";
		public const string SUCCESS_COUNT = "successCount";
		public const string EXTERNAL_FAILURE_COUNT = "externalFailureCount";
		public const string SUCCESS_WITH_WARNING_COUNT = "successWithWarningCount";
		#endregion

		#region Private Fields
		private long _IngestDateFrom = long.MinValue;
		private long _IngestDateTo = long.MinValue;
		private int _FailureCount = Int32.MinValue;
		private int _SuccessCount = Int32.MinValue;
		private int _ExternalFailureCount = Int32.MinValue;
		private int _SuccessWithWarningCount = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IngestDateFromAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestDateFrom
		{
			get { return _IngestDateFrom; }
			set 
			{ 
				_IngestDateFrom = value;
				OnPropertyChanged("IngestDateFrom");
			}
		}
		/// <summary>
		/// Use IngestDateToAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestDateTo
		{
			get { return _IngestDateTo; }
			set 
			{ 
				_IngestDateTo = value;
				OnPropertyChanged("IngestDateTo");
			}
		}
		/// <summary>
		/// Use FailureCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FailureCount
		{
			get { return _FailureCount; }
			set 
			{ 
				_FailureCount = value;
				OnPropertyChanged("FailureCount");
			}
		}
		/// <summary>
		/// Use SuccessCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SuccessCount
		{
			get { return _SuccessCount; }
			set 
			{ 
				_SuccessCount = value;
				OnPropertyChanged("SuccessCount");
			}
		}
		/// <summary>
		/// Use ExternalFailureCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ExternalFailureCount
		{
			get { return _ExternalFailureCount; }
			set 
			{ 
				_ExternalFailureCount = value;
				OnPropertyChanged("ExternalFailureCount");
			}
		}
		/// <summary>
		/// Use SuccessWithWarningCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SuccessWithWarningCount
		{
			get { return _SuccessWithWarningCount; }
			set 
			{ 
				_SuccessWithWarningCount = value;
				OnPropertyChanged("SuccessWithWarningCount");
			}
		}
		#endregion

		#region CTor
		public VodIngestAssetResultAggregation()
		{
		}

		public VodIngestAssetResultAggregation(JToken node) : base(node)
		{
			if(node["ingestDateFrom"] != null)
			{
				this._IngestDateFrom = ParseLong(node["ingestDateFrom"].Value<string>());
			}
			if(node["ingestDateTo"] != null)
			{
				this._IngestDateTo = ParseLong(node["ingestDateTo"].Value<string>());
			}
			if(node["failureCount"] != null)
			{
				this._FailureCount = ParseInt(node["failureCount"].Value<string>());
			}
			if(node["successCount"] != null)
			{
				this._SuccessCount = ParseInt(node["successCount"].Value<string>());
			}
			if(node["externalFailureCount"] != null)
			{
				this._ExternalFailureCount = ParseInt(node["externalFailureCount"].Value<string>());
			}
			if(node["successWithWarningCount"] != null)
			{
				this._SuccessWithWarningCount = ParseInt(node["successWithWarningCount"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVodIngestAssetResultAggregation");
			kparams.AddIfNotNull("ingestDateFrom", this._IngestDateFrom);
			kparams.AddIfNotNull("ingestDateTo", this._IngestDateTo);
			kparams.AddIfNotNull("failureCount", this._FailureCount);
			kparams.AddIfNotNull("successCount", this._SuccessCount);
			kparams.AddIfNotNull("externalFailureCount", this._ExternalFailureCount);
			kparams.AddIfNotNull("successWithWarningCount", this._SuccessWithWarningCount);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INGEST_DATE_FROM:
					return "IngestDateFrom";
				case INGEST_DATE_TO:
					return "IngestDateTo";
				case FAILURE_COUNT:
					return "FailureCount";
				case SUCCESS_COUNT:
					return "SuccessCount";
				case EXTERNAL_FAILURE_COUNT:
					return "ExternalFailureCount";
				case SUCCESS_WITH_WARNING_COUNT:
					return "SuccessWithWarningCount";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

