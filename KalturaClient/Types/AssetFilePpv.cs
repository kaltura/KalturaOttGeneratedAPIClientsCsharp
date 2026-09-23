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
	public class AssetFilePpv : OTTObjectSupportNullable
	{
		#region Constants
		public const string ASSET_FILE_ID = "assetFileId";
		public const string PPV_MODULE_ID = "ppvModuleId";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string PURCHASE_START_DATE = "purchaseStartDate";
		public const string PURCHASE_END_DATE = "purchaseEndDate";
		#endregion

		#region Private Fields
		private long _AssetFileId = long.MinValue;
		private long _PpvModuleId = long.MinValue;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private long _PurchaseStartDate = long.MinValue;
		private long _PurchaseEndDate = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetFileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long AssetFileId
		{
			get { return _AssetFileId; }
			set 
			{ 
				_AssetFileId = value;
				OnPropertyChanged("AssetFileId");
			}
		}
		/// <summary>
		/// Use PpvModuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PpvModuleId
		{
			get { return _PpvModuleId; }
			set 
			{ 
				_PpvModuleId = value;
				OnPropertyChanged("PpvModuleId");
			}
		}
		/// <summary>
		/// Use StartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		/// <summary>
		/// Use EndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		/// <summary>
		/// Use PurchaseStartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PurchaseStartDate
		{
			get { return _PurchaseStartDate; }
			set 
			{ 
				_PurchaseStartDate = value;
				OnPropertyChanged("PurchaseStartDate");
			}
		}
		/// <summary>
		/// Use PurchaseEndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PurchaseEndDate
		{
			get { return _PurchaseEndDate; }
			set 
			{ 
				_PurchaseEndDate = value;
				OnPropertyChanged("PurchaseEndDate");
			}
		}
		#endregion

		#region CTor
		public AssetFilePpv()
		{
		}

		public AssetFilePpv(JToken node) : base(node)
		{
			if(node["assetFileId"] != null)
			{
				this._AssetFileId = ParseLong(node["assetFileId"].Value<string>());
			}
			if(node["ppvModuleId"] != null)
			{
				this._PpvModuleId = ParseLong(node["ppvModuleId"].Value<string>());
			}
			if(node["startDate"] != null)
			{
				this._StartDate = ParseLong(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseLong(node["endDate"].Value<string>());
			}
			if(node["purchaseStartDate"] != null)
			{
				this._PurchaseStartDate = ParseLong(node["purchaseStartDate"].Value<string>());
			}
			if(node["purchaseEndDate"] != null)
			{
				this._PurchaseEndDate = ParseLong(node["purchaseEndDate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetFilePpv");
			kparams.AddIfNotNull("assetFileId", this._AssetFileId);
			kparams.AddIfNotNull("ppvModuleId", this._PpvModuleId);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("purchaseStartDate", this._PurchaseStartDate);
			kparams.AddIfNotNull("purchaseEndDate", this._PurchaseEndDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_FILE_ID:
					return "AssetFileId";
				case PPV_MODULE_ID:
					return "PpvModuleId";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case PURCHASE_START_DATE:
					return "PurchaseStartDate";
				case PURCHASE_END_DATE:
					return "PurchaseEndDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

