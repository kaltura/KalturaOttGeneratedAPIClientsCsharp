// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class MediaFile : AssetFile
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string ID = "id";
		public const string TYPE = "type";
		public const string DURATION = "duration";
		public const string EXTERNAL_ID = "externalId";
		public const string BILLING_TYPE = "billingType";
		public const string QUALITY = "quality";
		public const string HANDLING_TYPE = "handlingType";
		public const string CDN_NAME = "cdnName";
		public const string CDN_CODE = "cdnCode";
		public const string ALT_CDN_CODE = "altCdnCode";
		public const string PPV_MODULES = "ppvModules";
		public const string PRODUCT_CODE = "productCode";
		public const string FILE_SIZE = "fileSize";
		#endregion

		#region Private Fields
		private int _AssetId = Int32.MinValue;
		private int _Id = Int32.MinValue;
		private string _Type = null;
		private long _Duration = long.MinValue;
		private string _ExternalId = null;
		private string _BillingType = null;
		private string _Quality = null;
		private string _HandlingType = null;
		private string _CdnName = null;
		private string _CdnCode = null;
		private string _AltCdnCode = null;
		private StringValueArray _PpvModules;
		private string _ProductCode = null;
		private long _FileSize = long.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public long Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public string ExternalId
		{
			get { return _ExternalId; }
			set 
			{ 
				_ExternalId = value;
				OnPropertyChanged("ExternalId");
			}
		}
		[JsonProperty]
		public string BillingType
		{
			get { return _BillingType; }
			set 
			{ 
				_BillingType = value;
				OnPropertyChanged("BillingType");
			}
		}
		[JsonProperty]
		public string Quality
		{
			get { return _Quality; }
			set 
			{ 
				_Quality = value;
				OnPropertyChanged("Quality");
			}
		}
		[JsonProperty]
		public string HandlingType
		{
			get { return _HandlingType; }
			set 
			{ 
				_HandlingType = value;
				OnPropertyChanged("HandlingType");
			}
		}
		[JsonProperty]
		public string CdnName
		{
			get { return _CdnName; }
			set 
			{ 
				_CdnName = value;
				OnPropertyChanged("CdnName");
			}
		}
		[JsonProperty]
		public string CdnCode
		{
			get { return _CdnCode; }
			set 
			{ 
				_CdnCode = value;
				OnPropertyChanged("CdnCode");
			}
		}
		[JsonProperty]
		public string AltCdnCode
		{
			get { return _AltCdnCode; }
			set 
			{ 
				_AltCdnCode = value;
				OnPropertyChanged("AltCdnCode");
			}
		}
		[JsonProperty]
		public StringValueArray PpvModules
		{
			get { return _PpvModules; }
			set 
			{ 
				_PpvModules = value;
				OnPropertyChanged("PpvModules");
			}
		}
		[JsonProperty]
		public string ProductCode
		{
			get { return _ProductCode; }
			set 
			{ 
				_ProductCode = value;
				OnPropertyChanged("ProductCode");
			}
		}
		[JsonProperty]
		public long FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		#endregion

		#region CTor
		public MediaFile()
		{
		}

		public MediaFile(JToken node) : base(node)
		{
			if(node["assetId"] != null)
			{
				this._AssetId = ParseInt(node["assetId"].Value<string>());
			}
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = node["type"].Value<string>();
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseLong(node["duration"].Value<string>());
			}
			if(node["externalId"] != null)
			{
				this._ExternalId = node["externalId"].Value<string>();
			}
			if(node["billingType"] != null)
			{
				this._BillingType = node["billingType"].Value<string>();
			}
			if(node["quality"] != null)
			{
				this._Quality = node["quality"].Value<string>();
			}
			if(node["handlingType"] != null)
			{
				this._HandlingType = node["handlingType"].Value<string>();
			}
			if(node["cdnName"] != null)
			{
				this._CdnName = node["cdnName"].Value<string>();
			}
			if(node["cdnCode"] != null)
			{
				this._CdnCode = node["cdnCode"].Value<string>();
			}
			if(node["altCdnCode"] != null)
			{
				this._AltCdnCode = node["altCdnCode"].Value<string>();
			}
			if(node["ppvModules"] != null)
			{
				this._PpvModules = ObjectFactory.Create<StringValueArray>(node["ppvModules"]);
			}
			if(node["productCode"] != null)
			{
				this._ProductCode = node["productCode"].Value<string>();
			}
			if(node["fileSize"] != null)
			{
				this._FileSize = ParseLong(node["fileSize"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaFile");
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("externalId", this._ExternalId);
			kparams.AddIfNotNull("billingType", this._BillingType);
			kparams.AddIfNotNull("quality", this._Quality);
			kparams.AddIfNotNull("handlingType", this._HandlingType);
			kparams.AddIfNotNull("cdnName", this._CdnName);
			kparams.AddIfNotNull("cdnCode", this._CdnCode);
			kparams.AddIfNotNull("altCdnCode", this._AltCdnCode);
			kparams.AddIfNotNull("ppvModules", this._PpvModules);
			kparams.AddIfNotNull("productCode", this._ProductCode);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_ID:
					return "AssetId";
				case ID:
					return "Id";
				case TYPE:
					return "Type";
				case DURATION:
					return "Duration";
				case EXTERNAL_ID:
					return "ExternalId";
				case BILLING_TYPE:
					return "BillingType";
				case QUALITY:
					return "Quality";
				case HANDLING_TYPE:
					return "HandlingType";
				case CDN_NAME:
					return "CdnName";
				case CDN_CODE:
					return "CdnCode";
				case ALT_CDN_CODE:
					return "AltCdnCode";
				case PPV_MODULES:
					return "PpvModules";
				case PRODUCT_CODE:
					return "ProductCode";
				case FILE_SIZE:
					return "FileSize";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

