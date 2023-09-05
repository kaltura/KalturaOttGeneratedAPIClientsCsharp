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
	public class VodIngestAssetResultFilter : Filter
	{
		#region Constants
		public const string FILE_NAME_CONTAINS = "fileNameContains";
		public const string ASSET_NAME_CONTAINS = "assetNameContains";
		public const string INGEST_STATUS_IN = "ingestStatusIn";
		public const string INGEST_DATE_GREATER_THAN = "ingestDateGreaterThan";
		public const string INGEST_DATE_SMALLER_THAN = "ingestDateSmallerThan";
		public const string VOD_TYPE_SYSTEM_NAME_IN = "vodTypeSystemNameIn";
		public const string SHOP_ASSET_USER_RULE_ID_IN = "shopAssetUserRuleIdIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _FileNameContains = null;
		private string _AssetNameContains = null;
		private string _IngestStatusIn = null;
		private long _IngestDateGreaterThan = long.MinValue;
		private long _IngestDateSmallerThan = long.MinValue;
		private string _VodTypeSystemNameIn = null;
		private string _ShopAssetUserRuleIdIn = null;
		private VodIngestAssetResultOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FileNameContainsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileNameContains
		{
			get { return _FileNameContains; }
			set 
			{ 
				_FileNameContains = value;
				OnPropertyChanged("FileNameContains");
			}
		}
		/// <summary>
		/// Use AssetNameContainsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetNameContains
		{
			get { return _AssetNameContains; }
			set 
			{ 
				_AssetNameContains = value;
				OnPropertyChanged("AssetNameContains");
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
		/// Use IngestDateGreaterThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestDateGreaterThan
		{
			get { return _IngestDateGreaterThan; }
			set 
			{ 
				_IngestDateGreaterThan = value;
				OnPropertyChanged("IngestDateGreaterThan");
			}
		}
		/// <summary>
		/// Use IngestDateSmallerThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IngestDateSmallerThan
		{
			get { return _IngestDateSmallerThan; }
			set 
			{ 
				_IngestDateSmallerThan = value;
				OnPropertyChanged("IngestDateSmallerThan");
			}
		}
		/// <summary>
		/// Use VodTypeSystemNameInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VodTypeSystemNameIn
		{
			get { return _VodTypeSystemNameIn; }
			set 
			{ 
				_VodTypeSystemNameIn = value;
				OnPropertyChanged("VodTypeSystemNameIn");
			}
		}
		/// <summary>
		/// Use ShopAssetUserRuleIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ShopAssetUserRuleIdIn
		{
			get { return _ShopAssetUserRuleIdIn; }
			set 
			{ 
				_ShopAssetUserRuleIdIn = value;
				OnPropertyChanged("ShopAssetUserRuleIdIn");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new VodIngestAssetResultOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public VodIngestAssetResultFilter()
		{
		}

		public VodIngestAssetResultFilter(JToken node) : base(node)
		{
			if(node["fileNameContains"] != null)
			{
				this._FileNameContains = node["fileNameContains"].Value<string>();
			}
			if(node["assetNameContains"] != null)
			{
				this._AssetNameContains = node["assetNameContains"].Value<string>();
			}
			if(node["ingestStatusIn"] != null)
			{
				this._IngestStatusIn = node["ingestStatusIn"].Value<string>();
			}
			if(node["ingestDateGreaterThan"] != null)
			{
				this._IngestDateGreaterThan = ParseLong(node["ingestDateGreaterThan"].Value<string>());
			}
			if(node["ingestDateSmallerThan"] != null)
			{
				this._IngestDateSmallerThan = ParseLong(node["ingestDateSmallerThan"].Value<string>());
			}
			if(node["vodTypeSystemNameIn"] != null)
			{
				this._VodTypeSystemNameIn = node["vodTypeSystemNameIn"].Value<string>();
			}
			if(node["shopAssetUserRuleIdIn"] != null)
			{
				this._ShopAssetUserRuleIdIn = node["shopAssetUserRuleIdIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (VodIngestAssetResultOrderBy)StringEnum.Parse(typeof(VodIngestAssetResultOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVodIngestAssetResultFilter");
			kparams.AddIfNotNull("fileNameContains", this._FileNameContains);
			kparams.AddIfNotNull("assetNameContains", this._AssetNameContains);
			kparams.AddIfNotNull("ingestStatusIn", this._IngestStatusIn);
			kparams.AddIfNotNull("ingestDateGreaterThan", this._IngestDateGreaterThan);
			kparams.AddIfNotNull("ingestDateSmallerThan", this._IngestDateSmallerThan);
			kparams.AddIfNotNull("vodTypeSystemNameIn", this._VodTypeSystemNameIn);
			kparams.AddIfNotNull("shopAssetUserRuleIdIn", this._ShopAssetUserRuleIdIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILE_NAME_CONTAINS:
					return "FileNameContains";
				case ASSET_NAME_CONTAINS:
					return "AssetNameContains";
				case INGEST_STATUS_IN:
					return "IngestStatusIn";
				case INGEST_DATE_GREATER_THAN:
					return "IngestDateGreaterThan";
				case INGEST_DATE_SMALLER_THAN:
					return "IngestDateSmallerThan";
				case VOD_TYPE_SYSTEM_NAME_IN:
					return "VodTypeSystemNameIn";
				case SHOP_ASSET_USER_RULE_ID_IN:
					return "ShopAssetUserRuleIdIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

