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
	public class VodIngestAssetResult : ObjectBase
	{
		#region Constants
		public const string ASSET_NAME = "assetName";
		public const string SHOP_ASSET_USER_RULE_ID = "shopAssetUserRuleId";
		public const string FILE_NAME = "fileName";
		public const string INGEST_DATE = "ingestDate";
		public const string STATUS = "status";
		public const string VOD_TYPE_SYSTEM_NAME = "vodTypeSystemName";
		public const string ERRORS = "errors";
		public const string WARNINGS = "warnings";
		public const string FILE_UPLOAD_DATE = "fileUploadDate";
		public const string PROCESSING_START_DATE = "processingStartDate";
		public const string PROCESSING_COMPLETION_DATE = "processingCompletionDate";
		#endregion

		#region Private Fields
		private string _AssetName = null;
		private long _ShopAssetUserRuleId = long.MinValue;
		private string _FileName = null;
		private long _IngestDate = long.MinValue;
		private VodIngestAssetResultStatus _Status = null;
		private string _VodTypeSystemName = null;
		private IList<VodIngestAssetResultErrorMessage> _Errors;
		private IList<VodIngestAssetResultErrorMessage> _Warnings;
		private long _FileUploadDate = long.MinValue;
		private long _ProcessingStartDate = long.MinValue;
		private long _ProcessingCompletionDate = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetName
		{
			get { return _AssetName; }
			set 
			{ 
				_AssetName = value;
				OnPropertyChanged("AssetName");
			}
		}
		/// <summary>
		/// Use ShopAssetUserRuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ShopAssetUserRuleId
		{
			get { return _ShopAssetUserRuleId; }
			set 
			{ 
				_ShopAssetUserRuleId = value;
				OnPropertyChanged("ShopAssetUserRuleId");
			}
		}
		/// <summary>
		/// Use FileNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		/// <summary>
		/// Use IngestDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestDate
		{
			get { return _IngestDate; }
			set 
			{ 
				_IngestDate = value;
				OnPropertyChanged("IngestDate");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VodIngestAssetResultStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use VodTypeSystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VodTypeSystemName
		{
			get { return _VodTypeSystemName; }
			set 
			{ 
				_VodTypeSystemName = value;
				OnPropertyChanged("VodTypeSystemName");
			}
		}
		/// <summary>
		/// Use ErrorsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<VodIngestAssetResultErrorMessage> Errors
		{
			get { return _Errors; }
			set 
			{ 
				_Errors = value;
				OnPropertyChanged("Errors");
			}
		}
		/// <summary>
		/// Use WarningsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<VodIngestAssetResultErrorMessage> Warnings
		{
			get { return _Warnings; }
			set 
			{ 
				_Warnings = value;
				OnPropertyChanged("Warnings");
			}
		}
		/// <summary>
		/// Use FileUploadDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long FileUploadDate
		{
			get { return _FileUploadDate; }
			set 
			{ 
				_FileUploadDate = value;
				OnPropertyChanged("FileUploadDate");
			}
		}
		/// <summary>
		/// Use ProcessingStartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ProcessingStartDate
		{
			get { return _ProcessingStartDate; }
			set 
			{ 
				_ProcessingStartDate = value;
				OnPropertyChanged("ProcessingStartDate");
			}
		}
		/// <summary>
		/// Use ProcessingCompletionDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ProcessingCompletionDate
		{
			get { return _ProcessingCompletionDate; }
			set 
			{ 
				_ProcessingCompletionDate = value;
				OnPropertyChanged("ProcessingCompletionDate");
			}
		}
		#endregion

		#region CTor
		public VodIngestAssetResult()
		{
		}

		public VodIngestAssetResult(JToken node) : base(node)
		{
			if(node["assetName"] != null)
			{
				this._AssetName = node["assetName"].Value<string>();
			}
			if(node["shopAssetUserRuleId"] != null)
			{
				this._ShopAssetUserRuleId = ParseLong(node["shopAssetUserRuleId"].Value<string>());
			}
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["ingestDate"] != null)
			{
				this._IngestDate = ParseLong(node["ingestDate"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (VodIngestAssetResultStatus)StringEnum.Parse(typeof(VodIngestAssetResultStatus), node["status"].Value<string>());
			}
			if(node["vodTypeSystemName"] != null)
			{
				this._VodTypeSystemName = node["vodTypeSystemName"].Value<string>();
			}
			if(node["errors"] != null)
			{
				this._Errors = new List<VodIngestAssetResultErrorMessage>();
				foreach(var arrayNode in node["errors"].Children())
				{
					this._Errors.Add(ObjectFactory.Create<VodIngestAssetResultErrorMessage>(arrayNode));
				}
			}
			if(node["warnings"] != null)
			{
				this._Warnings = new List<VodIngestAssetResultErrorMessage>();
				foreach(var arrayNode in node["warnings"].Children())
				{
					this._Warnings.Add(ObjectFactory.Create<VodIngestAssetResultErrorMessage>(arrayNode));
				}
			}
			if(node["fileUploadDate"] != null)
			{
				this._FileUploadDate = ParseLong(node["fileUploadDate"].Value<string>());
			}
			if(node["processingStartDate"] != null)
			{
				this._ProcessingStartDate = ParseLong(node["processingStartDate"].Value<string>());
			}
			if(node["processingCompletionDate"] != null)
			{
				this._ProcessingCompletionDate = ParseLong(node["processingCompletionDate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVodIngestAssetResult");
			kparams.AddIfNotNull("assetName", this._AssetName);
			kparams.AddIfNotNull("shopAssetUserRuleId", this._ShopAssetUserRuleId);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("ingestDate", this._IngestDate);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("vodTypeSystemName", this._VodTypeSystemName);
			kparams.AddIfNotNull("errors", this._Errors);
			kparams.AddIfNotNull("warnings", this._Warnings);
			kparams.AddIfNotNull("fileUploadDate", this._FileUploadDate);
			kparams.AddIfNotNull("processingStartDate", this._ProcessingStartDate);
			kparams.AddIfNotNull("processingCompletionDate", this._ProcessingCompletionDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_NAME:
					return "AssetName";
				case SHOP_ASSET_USER_RULE_ID:
					return "ShopAssetUserRuleId";
				case FILE_NAME:
					return "FileName";
				case INGEST_DATE:
					return "IngestDate";
				case STATUS:
					return "Status";
				case VOD_TYPE_SYSTEM_NAME:
					return "VodTypeSystemName";
				case ERRORS:
					return "Errors";
				case WARNINGS:
					return "Warnings";
				case FILE_UPLOAD_DATE:
					return "FileUploadDate";
				case PROCESSING_START_DATE:
					return "ProcessingStartDate";
				case PROCESSING_COMPLETION_DATE:
					return "ProcessingCompletionDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

