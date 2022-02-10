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
	public class Collection : OTTObjectSupportNullable
	{
		#region Constants
		public const string ID = "id";
		public const string CHANNELS = "channels";
		public const string CHANNELS_IDS = "channelsIds";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string DISCOUNT_MODULE = "discountModule";
		public const string DISCOUNT_MODULE_ID = "discountModuleId";
		public const string NAME = "name";
		public const string MULTILINGUAL_NAME = "multilingualName";
		public const string DESCRIPTION = "description";
		public const string MULTILINGUAL_DESCRIPTION = "multilingualDescription";
		public const string USAGE_MODULE = "usageModule";
		public const string USAGE_MODULE_ID = "usageModuleId";
		public const string COUPONS_GROUPS = "couponsGroups";
		public const string COLLECTION_COUPON_GROUP = "collectionCouponGroup";
		public const string EXTERNAL_ID = "externalId";
		public const string PRODUCT_CODES = "productCodes";
		public const string PRICE_DETAILS_ID = "priceDetailsId";
		public const string IS_ACTIVE = "isActive";
		public const string CREATE_DATE = "createDate";
		public const string UPDATE_DATE = "updateDate";
		public const string VIRTUAL_ASSET_ID = "virtualAssetId";
		#endregion

		#region Private Fields
		private string _Id = null;
		private IList<BaseChannel> _Channels;
		private string _ChannelsIds = null;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private DiscountModule _DiscountModule;
		private long _DiscountModuleId = long.MinValue;
		private string _Name = null;
		private IList<TranslationToken> _MultilingualName;
		private string _Description = null;
		private IList<TranslationToken> _MultilingualDescription;
		private UsageModule _UsageModule;
		private long _UsageModuleId = long.MinValue;
		private IList<CouponsGroup> _CouponsGroups;
		private IList<CollectionCouponGroup> _CollectionCouponGroup;
		private string _ExternalId = null;
		private IList<ProductCode> _ProductCodes;
		private long _PriceDetailsId = long.MinValue;
		private bool? _IsActive = null;
		private long _CreateDate = long.MinValue;
		private long _UpdateDate = long.MinValue;
		private long _VirtualAssetId = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use ChannelsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<BaseChannel> Channels
		{
			get { return _Channels; }
			private set 
			{ 
				_Channels = value;
				OnPropertyChanged("Channels");
			}
		}
		/// <summary>
		/// Use ChannelsIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ChannelsIds
		{
			get { return _ChannelsIds; }
			set 
			{ 
				_ChannelsIds = value;
				OnPropertyChanged("ChannelsIds");
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
		/// Use DiscountModuleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DiscountModule DiscountModule
		{
			get { return _DiscountModule; }
			private set 
			{ 
				_DiscountModule = value;
				OnPropertyChanged("DiscountModule");
			}
		}
		/// <summary>
		/// Use DiscountModuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long DiscountModuleId
		{
			get { return _DiscountModuleId; }
			set 
			{ 
				_DiscountModuleId = value;
				OnPropertyChanged("DiscountModuleId");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			private set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use MultilingualNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<TranslationToken> MultilingualName
		{
			get { return _MultilingualName; }
			set 
			{ 
				_MultilingualName = value;
				OnPropertyChanged("MultilingualName");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			private set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use MultilingualDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<TranslationToken> MultilingualDescription
		{
			get { return _MultilingualDescription; }
			set 
			{ 
				_MultilingualDescription = value;
				OnPropertyChanged("MultilingualDescription");
			}
		}
		/// <summary>
		/// Use UsageModuleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UsageModule UsageModule
		{
			get { return _UsageModule; }
			private set 
			{ 
				_UsageModule = value;
				OnPropertyChanged("UsageModule");
			}
		}
		/// <summary>
		/// Use UsageModuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long UsageModuleId
		{
			get { return _UsageModuleId; }
			set 
			{ 
				_UsageModuleId = value;
				OnPropertyChanged("UsageModuleId");
			}
		}
		/// <summary>
		/// Use CouponsGroupsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<CouponsGroup> CouponsGroups
		{
			get { return _CouponsGroups; }
			private set 
			{ 
				_CouponsGroups = value;
				OnPropertyChanged("CouponsGroups");
			}
		}
		/// <summary>
		/// Use CollectionCouponGroupAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<CollectionCouponGroup> CollectionCouponGroup
		{
			get { return _CollectionCouponGroup; }
			set 
			{ 
				_CollectionCouponGroup = value;
				OnPropertyChanged("CollectionCouponGroup");
			}
		}
		/// <summary>
		/// Use ExternalIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ProductCodesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ProductCode> ProductCodes
		{
			get { return _ProductCodes; }
			set 
			{ 
				_ProductCodes = value;
				OnPropertyChanged("ProductCodes");
			}
		}
		/// <summary>
		/// Use PriceDetailsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PriceDetailsId
		{
			get { return _PriceDetailsId; }
			set 
			{ 
				_PriceDetailsId = value;
				OnPropertyChanged("PriceDetailsId");
			}
		}
		/// <summary>
		/// Use IsActiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsActive
		{
			get { return _IsActive; }
			set 
			{ 
				_IsActive = value;
				OnPropertyChanged("IsActive");
			}
		}
		/// <summary>
		/// Use CreateDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CreateDate
		{
			get { return _CreateDate; }
			private set 
			{ 
				_CreateDate = value;
				OnPropertyChanged("CreateDate");
			}
		}
		/// <summary>
		/// Use UpdateDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long UpdateDate
		{
			get { return _UpdateDate; }
			private set 
			{ 
				_UpdateDate = value;
				OnPropertyChanged("UpdateDate");
			}
		}
		/// <summary>
		/// Use VirtualAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long VirtualAssetId
		{
			get { return _VirtualAssetId; }
			private set 
			{ 
				_VirtualAssetId = value;
				OnPropertyChanged("VirtualAssetId");
			}
		}
		#endregion

		#region CTor
		public Collection()
		{
		}

		public Collection(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["channels"] != null)
			{
				this._Channels = new List<BaseChannel>();
				foreach(var arrayNode in node["channels"].Children())
				{
					this._Channels.Add(ObjectFactory.Create<BaseChannel>(arrayNode));
				}
			}
			if(node["channelsIds"] != null)
			{
				this._ChannelsIds = node["channelsIds"].Value<string>();
			}
			if(node["startDate"] != null)
			{
				this._StartDate = ParseLong(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseLong(node["endDate"].Value<string>());
			}
			if(node["discountModule"] != null)
			{
				this._DiscountModule = ObjectFactory.Create<DiscountModule>(node["discountModule"]);
			}
			if(node["discountModuleId"] != null)
			{
				this._DiscountModuleId = ParseLong(node["discountModuleId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["multilingualName"] != null)
			{
				this._MultilingualName = new List<TranslationToken>();
				foreach(var arrayNode in node["multilingualName"].Children())
				{
					this._MultilingualName.Add(ObjectFactory.Create<TranslationToken>(arrayNode));
				}
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["multilingualDescription"] != null)
			{
				this._MultilingualDescription = new List<TranslationToken>();
				foreach(var arrayNode in node["multilingualDescription"].Children())
				{
					this._MultilingualDescription.Add(ObjectFactory.Create<TranslationToken>(arrayNode));
				}
			}
			if(node["usageModule"] != null)
			{
				this._UsageModule = ObjectFactory.Create<UsageModule>(node["usageModule"]);
			}
			if(node["usageModuleId"] != null)
			{
				this._UsageModuleId = ParseLong(node["usageModuleId"].Value<string>());
			}
			if(node["couponsGroups"] != null)
			{
				this._CouponsGroups = new List<CouponsGroup>();
				foreach(var arrayNode in node["couponsGroups"].Children())
				{
					this._CouponsGroups.Add(ObjectFactory.Create<CouponsGroup>(arrayNode));
				}
			}
			if(node["collectionCouponGroup"] != null)
			{
				this._CollectionCouponGroup = new List<CollectionCouponGroup>();
				foreach(var arrayNode in node["collectionCouponGroup"].Children())
				{
					this._CollectionCouponGroup.Add(ObjectFactory.Create<CollectionCouponGroup>(arrayNode));
				}
			}
			if(node["externalId"] != null)
			{
				this._ExternalId = node["externalId"].Value<string>();
			}
			if(node["productCodes"] != null)
			{
				this._ProductCodes = new List<ProductCode>();
				foreach(var arrayNode in node["productCodes"].Children())
				{
					this._ProductCodes.Add(ObjectFactory.Create<ProductCode>(arrayNode));
				}
			}
			if(node["priceDetailsId"] != null)
			{
				this._PriceDetailsId = ParseLong(node["priceDetailsId"].Value<string>());
			}
			if(node["isActive"] != null)
			{
				this._IsActive = ParseBool(node["isActive"].Value<string>());
			}
			if(node["createDate"] != null)
			{
				this._CreateDate = ParseLong(node["createDate"].Value<string>());
			}
			if(node["updateDate"] != null)
			{
				this._UpdateDate = ParseLong(node["updateDate"].Value<string>());
			}
			if(node["virtualAssetId"] != null)
			{
				this._VirtualAssetId = ParseLong(node["virtualAssetId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCollection");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("channels", this._Channels);
			kparams.AddIfNotNull("channelsIds", this._ChannelsIds);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("discountModule", this._DiscountModule);
			kparams.AddIfNotNull("discountModuleId", this._DiscountModuleId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("multilingualName", this._MultilingualName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("multilingualDescription", this._MultilingualDescription);
			kparams.AddIfNotNull("usageModule", this._UsageModule);
			kparams.AddIfNotNull("usageModuleId", this._UsageModuleId);
			kparams.AddIfNotNull("couponsGroups", this._CouponsGroups);
			kparams.AddIfNotNull("collectionCouponGroup", this._CollectionCouponGroup);
			kparams.AddIfNotNull("externalId", this._ExternalId);
			kparams.AddIfNotNull("productCodes", this._ProductCodes);
			kparams.AddIfNotNull("priceDetailsId", this._PriceDetailsId);
			kparams.AddIfNotNull("isActive", this._IsActive);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			kparams.AddIfNotNull("virtualAssetId", this._VirtualAssetId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CHANNELS:
					return "Channels";
				case CHANNELS_IDS:
					return "ChannelsIds";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case DISCOUNT_MODULE:
					return "DiscountModule";
				case DISCOUNT_MODULE_ID:
					return "DiscountModuleId";
				case NAME:
					return "Name";
				case MULTILINGUAL_NAME:
					return "MultilingualName";
				case DESCRIPTION:
					return "Description";
				case MULTILINGUAL_DESCRIPTION:
					return "MultilingualDescription";
				case USAGE_MODULE:
					return "UsageModule";
				case USAGE_MODULE_ID:
					return "UsageModuleId";
				case COUPONS_GROUPS:
					return "CouponsGroups";
				case COLLECTION_COUPON_GROUP:
					return "CollectionCouponGroup";
				case EXTERNAL_ID:
					return "ExternalId";
				case PRODUCT_CODES:
					return "ProductCodes";
				case PRICE_DETAILS_ID:
					return "PriceDetailsId";
				case IS_ACTIVE:
					return "IsActive";
				case CREATE_DATE:
					return "CreateDate";
				case UPDATE_DATE:
					return "UpdateDate";
				case VIRTUAL_ASSET_ID:
					return "VirtualAssetId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

