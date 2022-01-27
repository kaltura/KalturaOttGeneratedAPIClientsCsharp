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
	public class IngestByCompoundFilter : Filter
	{
		#region Constants
		public const string INGEST_NAME_CONTAINS = "ingestNameContains";
		public const string INGESTED_BY_USER_ID_IN = "ingestedByUserIdIn";
		public const string INGEST_STATUS_IN = "ingestStatusIn";
		public const string CREATED_DATE_GREATER_THAN = "createdDateGreaterThan";
		public const string CREATED_DATE_SMALLER_THAN = "createdDateSmallerThan";
		#endregion

		#region Private Fields
		private string _IngestNameContains = null;
		private string _IngestedByUserIdIn = null;
		private string _IngestStatusIn = null;
		private long _CreatedDateGreaterThan = long.MinValue;
		private long _CreatedDateSmallerThan = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IngestNameContainsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IngestNameContains
		{
			get { return _IngestNameContains; }
			set 
			{ 
				_IngestNameContains = value;
				OnPropertyChanged("IngestNameContains");
			}
		}
		/// <summary>
		/// Use IngestedByUserIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IngestedByUserIdIn
		{
			get { return _IngestedByUserIdIn; }
			set 
			{ 
				_IngestedByUserIdIn = value;
				OnPropertyChanged("IngestedByUserIdIn");
			}
		}
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
		/// Use CreatedDateGreaterThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CreatedDateGreaterThan
		{
			get { return _CreatedDateGreaterThan; }
			set 
			{ 
				_CreatedDateGreaterThan = value;
				OnPropertyChanged("CreatedDateGreaterThan");
			}
		}
		/// <summary>
		/// Use CreatedDateSmallerThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CreatedDateSmallerThan
		{
			get { return _CreatedDateSmallerThan; }
			set 
			{ 
				_CreatedDateSmallerThan = value;
				OnPropertyChanged("CreatedDateSmallerThan");
			}
		}
		#endregion

		#region CTor
		public IngestByCompoundFilter()
		{
		}

		public IngestByCompoundFilter(JToken node) : base(node)
		{
			if(node["ingestNameContains"] != null)
			{
				this._IngestNameContains = node["ingestNameContains"].Value<string>();
			}
			if(node["ingestedByUserIdIn"] != null)
			{
				this._IngestedByUserIdIn = node["ingestedByUserIdIn"].Value<string>();
			}
			if(node["ingestStatusIn"] != null)
			{
				this._IngestStatusIn = node["ingestStatusIn"].Value<string>();
			}
			if(node["createdDateGreaterThan"] != null)
			{
				this._CreatedDateGreaterThan = ParseLong(node["createdDateGreaterThan"].Value<string>());
			}
			if(node["createdDateSmallerThan"] != null)
			{
				this._CreatedDateSmallerThan = ParseLong(node["createdDateSmallerThan"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIngestByCompoundFilter");
			kparams.AddIfNotNull("ingestNameContains", this._IngestNameContains);
			kparams.AddIfNotNull("ingestedByUserIdIn", this._IngestedByUserIdIn);
			kparams.AddIfNotNull("ingestStatusIn", this._IngestStatusIn);
			kparams.AddIfNotNull("createdDateGreaterThan", this._CreatedDateGreaterThan);
			kparams.AddIfNotNull("createdDateSmallerThan", this._CreatedDateSmallerThan);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INGEST_NAME_CONTAINS:
					return "IngestNameContains";
				case INGESTED_BY_USER_ID_IN:
					return "IngestedByUserIdIn";
				case INGEST_STATUS_IN:
					return "IngestStatusIn";
				case CREATED_DATE_GREATER_THAN:
					return "CreatedDateGreaterThan";
				case CREATED_DATE_SMALLER_THAN:
					return "CreatedDateSmallerThan";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

