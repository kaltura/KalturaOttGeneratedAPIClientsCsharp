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
	public class BulkUploadStatistics : ObjectBase
	{
		#region Constants
		public const string PENDING = "pending";
		public const string UPLOADED = "uploaded";
		public const string QUEUED = "queued";
		public const string PARSING = "parsing";
		public const string PROCESSING = "processing";
		public const string PROCESSED = "processed";
		public const string SUCCESS = "success";
		public const string PARTIAL = "partial";
		public const string FAILED = "failed";
		public const string FATAL = "fatal";
		#endregion

		#region Private Fields
		private long _Pending = long.MinValue;
		private long _Uploaded = long.MinValue;
		private long _Queued = long.MinValue;
		private long _Parsing = long.MinValue;
		private long _Processing = long.MinValue;
		private long _Processed = long.MinValue;
		private long _Success = long.MinValue;
		private long _Partial = long.MinValue;
		private long _Failed = long.MinValue;
		private long _Fatal = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use PendingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Pending
		{
			get { return _Pending; }
			set 
			{ 
				_Pending = value;
				OnPropertyChanged("Pending");
			}
		}
		/// <summary>
		/// Use UploadedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Uploaded
		{
			get { return _Uploaded; }
			set 
			{ 
				_Uploaded = value;
				OnPropertyChanged("Uploaded");
			}
		}
		/// <summary>
		/// Use QueuedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Queued
		{
			get { return _Queued; }
			set 
			{ 
				_Queued = value;
				OnPropertyChanged("Queued");
			}
		}
		/// <summary>
		/// Use ParsingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Parsing
		{
			get { return _Parsing; }
			set 
			{ 
				_Parsing = value;
				OnPropertyChanged("Parsing");
			}
		}
		/// <summary>
		/// Use ProcessingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Processing
		{
			get { return _Processing; }
			set 
			{ 
				_Processing = value;
				OnPropertyChanged("Processing");
			}
		}
		/// <summary>
		/// Use ProcessedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Processed
		{
			get { return _Processed; }
			set 
			{ 
				_Processed = value;
				OnPropertyChanged("Processed");
			}
		}
		/// <summary>
		/// Use SuccessAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Success
		{
			get { return _Success; }
			set 
			{ 
				_Success = value;
				OnPropertyChanged("Success");
			}
		}
		/// <summary>
		/// Use PartialAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Partial
		{
			get { return _Partial; }
			set 
			{ 
				_Partial = value;
				OnPropertyChanged("Partial");
			}
		}
		/// <summary>
		/// Use FailedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Failed
		{
			get { return _Failed; }
			set 
			{ 
				_Failed = value;
				OnPropertyChanged("Failed");
			}
		}
		/// <summary>
		/// Use FatalAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Fatal
		{
			get { return _Fatal; }
			set 
			{ 
				_Fatal = value;
				OnPropertyChanged("Fatal");
			}
		}
		#endregion

		#region CTor
		public BulkUploadStatistics()
		{
		}

		public BulkUploadStatistics(JToken node) : base(node)
		{
			if(node["pending"] != null)
			{
				this._Pending = ParseLong(node["pending"].Value<string>());
			}
			if(node["uploaded"] != null)
			{
				this._Uploaded = ParseLong(node["uploaded"].Value<string>());
			}
			if(node["queued"] != null)
			{
				this._Queued = ParseLong(node["queued"].Value<string>());
			}
			if(node["parsing"] != null)
			{
				this._Parsing = ParseLong(node["parsing"].Value<string>());
			}
			if(node["processing"] != null)
			{
				this._Processing = ParseLong(node["processing"].Value<string>());
			}
			if(node["processed"] != null)
			{
				this._Processed = ParseLong(node["processed"].Value<string>());
			}
			if(node["success"] != null)
			{
				this._Success = ParseLong(node["success"].Value<string>());
			}
			if(node["partial"] != null)
			{
				this._Partial = ParseLong(node["partial"].Value<string>());
			}
			if(node["failed"] != null)
			{
				this._Failed = ParseLong(node["failed"].Value<string>());
			}
			if(node["fatal"] != null)
			{
				this._Fatal = ParseLong(node["fatal"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadStatistics");
			kparams.AddIfNotNull("pending", this._Pending);
			kparams.AddIfNotNull("uploaded", this._Uploaded);
			kparams.AddIfNotNull("queued", this._Queued);
			kparams.AddIfNotNull("parsing", this._Parsing);
			kparams.AddIfNotNull("processing", this._Processing);
			kparams.AddIfNotNull("processed", this._Processed);
			kparams.AddIfNotNull("success", this._Success);
			kparams.AddIfNotNull("partial", this._Partial);
			kparams.AddIfNotNull("failed", this._Failed);
			kparams.AddIfNotNull("fatal", this._Fatal);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PENDING:
					return "Pending";
				case UPLOADED:
					return "Uploaded";
				case QUEUED:
					return "Queued";
				case PARSING:
					return "Parsing";
				case PROCESSING:
					return "Processing";
				case PROCESSED:
					return "Processed";
				case SUCCESS:
					return "Success";
				case PARTIAL:
					return "Partial";
				case FAILED:
					return "Failed";
				case FATAL:
					return "Fatal";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

