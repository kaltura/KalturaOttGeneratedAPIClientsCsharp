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
	public class IngestEpg : ObjectBase
	{
		#region Constants
		public const string INGEST_ID = "ingestId";
		public const string INGEST_NAME = "ingestName";
		public const string INGEST_FILENAME_EXTENSION = "ingestFilenameExtension";
		public const string CREATED_DATE = "createdDate";
		public const string INGESTED_BY_USER_ID = "ingestedByUserId";
		public const string COMPLETED_DATE = "completedDate";
		public const string INGEST_PROFILE_ID = "ingestProfileId";
		public const string STATUS = "status";
		#endregion

		#region Private Fields
		private long _IngestId = long.MinValue;
		private string _IngestName = null;
		private string _IngestFilenameExtension = null;
		private long _CreatedDate = long.MinValue;
		private long _IngestedByUserId = long.MinValue;
		private long _CompletedDate = long.MinValue;
		private long _IngestProfileId = long.MinValue;
		private IngestStatus _Status = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IngestIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestId
		{
			get { return _IngestId; }
			private set 
			{ 
				_IngestId = value;
				OnPropertyChanged("IngestId");
			}
		}
		/// <summary>
		/// Use IngestNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IngestName
		{
			get { return _IngestName; }
			set 
			{ 
				_IngestName = value;
				OnPropertyChanged("IngestName");
			}
		}
		/// <summary>
		/// Use IngestFilenameExtensionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IngestFilenameExtension
		{
			get { return _IngestFilenameExtension; }
			set 
			{ 
				_IngestFilenameExtension = value;
				OnPropertyChanged("IngestFilenameExtension");
			}
		}
		/// <summary>
		/// Use CreatedDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CreatedDate
		{
			get { return _CreatedDate; }
			set 
			{ 
				_CreatedDate = value;
				OnPropertyChanged("CreatedDate");
			}
		}
		/// <summary>
		/// Use IngestedByUserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestedByUserId
		{
			get { return _IngestedByUserId; }
			set 
			{ 
				_IngestedByUserId = value;
				OnPropertyChanged("IngestedByUserId");
			}
		}
		/// <summary>
		/// Use CompletedDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CompletedDate
		{
			get { return _CompletedDate; }
			set 
			{ 
				_CompletedDate = value;
				OnPropertyChanged("CompletedDate");
			}
		}
		/// <summary>
		/// Use IngestProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestProfileId
		{
			get { return _IngestProfileId; }
			set 
			{ 
				_IngestProfileId = value;
				OnPropertyChanged("IngestProfileId");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IngestStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public IngestEpg()
		{
		}

		public IngestEpg(JToken node) : base(node)
		{
			if(node["ingestId"] != null)
			{
				this._IngestId = ParseLong(node["ingestId"].Value<string>());
			}
			if(node["ingestName"] != null)
			{
				this._IngestName = node["ingestName"].Value<string>();
			}
			if(node["ingestFilenameExtension"] != null)
			{
				this._IngestFilenameExtension = node["ingestFilenameExtension"].Value<string>();
			}
			if(node["createdDate"] != null)
			{
				this._CreatedDate = ParseLong(node["createdDate"].Value<string>());
			}
			if(node["ingestedByUserId"] != null)
			{
				this._IngestedByUserId = ParseLong(node["ingestedByUserId"].Value<string>());
			}
			if(node["completedDate"] != null)
			{
				this._CompletedDate = ParseLong(node["completedDate"].Value<string>());
			}
			if(node["ingestProfileId"] != null)
			{
				this._IngestProfileId = ParseLong(node["ingestProfileId"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (IngestStatus)StringEnum.Parse(typeof(IngestStatus), node["status"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIngestEpg");
			kparams.AddIfNotNull("ingestId", this._IngestId);
			kparams.AddIfNotNull("ingestName", this._IngestName);
			kparams.AddIfNotNull("ingestFilenameExtension", this._IngestFilenameExtension);
			kparams.AddIfNotNull("createdDate", this._CreatedDate);
			kparams.AddIfNotNull("ingestedByUserId", this._IngestedByUserId);
			kparams.AddIfNotNull("completedDate", this._CompletedDate);
			kparams.AddIfNotNull("ingestProfileId", this._IngestProfileId);
			kparams.AddIfNotNull("status", this._Status);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INGEST_ID:
					return "IngestId";
				case INGEST_NAME:
					return "IngestName";
				case INGEST_FILENAME_EXTENSION:
					return "IngestFilenameExtension";
				case CREATED_DATE:
					return "CreatedDate";
				case INGESTED_BY_USER_ID:
					return "IngestedByUserId";
				case COMPLETED_DATE:
					return "CompletedDate";
				case INGEST_PROFILE_ID:
					return "IngestProfileId";
				case STATUS:
					return "Status";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

