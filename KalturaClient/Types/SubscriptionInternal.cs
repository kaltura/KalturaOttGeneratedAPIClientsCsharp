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
	public class SubscriptionInternal : ObjectBase
	{
		#region Constants
		public const string CHANNELS_IDS = "channelsIds";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string FILE_TYPES_IDS = "fileTypesIds";
		public const string INTERNAL_DISCOUNT_MODULE_ID = "internalDiscountModuleId";
		public const string NAME = "name";
		public const string MULTILINGUAL_NAME = "multilingualName";
		public const string DESCRIPTION = "description";
		public const string MULTILINGUAL_DESCRIPTION = "multilingualDescription";
		public const string PRORITY_IN_ORDER = "prorityInOrder";
		public const string PRICE_PLAN_IDS = "pricePlanIds";
		public const string PREVIEW_MODULE_ID = "previewModuleId";
		public const string HOUSEHOLD_LIMITATIONS_ID = "householdLimitationsId";
		public const string GRACE_PERIOD_MINUTES = "gracePeriodMinutes";
		public const string PREMIUM_SERVICES = "premiumServices";
		public const string COUPONS_GROUPS = "couponsGroups";
		public const string PRODUCT_CODES = "productCodes";
		public const string DEPENDENCY_TYPE = "dependencyType";
		public const string EXTERNAL_ID = "externalId";
		public const string IS_CANCELLATION_BLOCKED = "isCancellationBlocked";
		public const string PRE_SALE_DATE = "preSaleDate";
		public const string ADS_POLICY = "adsPolicy";
		public const string ADS_PARAM = "adsParam";
		public const string IS_ACTIVE = "isActive";
		#endregion

		#region Private Fields
		private string _ChannelsIds = null;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private string _FileTypesIds = null;
		private long _InternalDiscountModuleId = long.MinValue;
		private string _Name = null;
		private IList<TranslationToken> _MultilingualName;
		private string _Description = null;
		private IList<TranslationToken> _MultilingualDescription;
		private long _ProrityInOrder = long.MinValue;
		private string _PricePlanIds = null;
		private long _PreviewModuleId = long.MinValue;
		private int _HouseholdLimitationsId = Int32.MinValue;
		private int _GracePeriodMinutes = Int32.MinValue;
		private IList<PremiumService> _PremiumServices;
		private IList<SubscriptionCouponGroup> _CouponsGroups;
		private IList<ProductCode> _ProductCodes;
		private SubscriptionDependencyType _DependencyType = null;
		private string _ExternalId = null;
		private bool? _IsCancellationBlocked = null;
		private long _PreSaleDate = long.MinValue;
		private AdsPolicy _AdsPolicy = null;
		private string _AdsParam = null;
		private bool? _IsActive = null;
		#endregion

		#region Properties
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
		/// Use FileTypesIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileTypesIds
		{
			get { return _FileTypesIds; }
			set 
			{ 
				_FileTypesIds = value;
				OnPropertyChanged("FileTypesIds");
			}
		}
		/// <summary>
		/// Use InternalDiscountModuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long InternalDiscountModuleId
		{
			get { return _InternalDiscountModuleId; }
			set 
			{ 
				_InternalDiscountModuleId = value;
				OnPropertyChanged("InternalDiscountModuleId");
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
		/// Use ProrityInOrderAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ProrityInOrder
		{
			get { return _ProrityInOrder; }
			set 
			{ 
				_ProrityInOrder = value;
				OnPropertyChanged("ProrityInOrder");
			}
		}
		/// <summary>
		/// Use PricePlanIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PricePlanIds
		{
			get { return _PricePlanIds; }
			set 
			{ 
				_PricePlanIds = value;
				OnPropertyChanged("PricePlanIds");
			}
		}
		/// <summary>
		/// Use PreviewModuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PreviewModuleId
		{
			get { return _PreviewModuleId; }
			set 
			{ 
				_PreviewModuleId = value;
				OnPropertyChanged("PreviewModuleId");
			}
		}
		/// <summary>
		/// Use HouseholdLimitationsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int HouseholdLimitationsId
		{
			get { return _HouseholdLimitationsId; }
			set 
			{ 
				_HouseholdLimitationsId = value;
				OnPropertyChanged("HouseholdLimitationsId");
			}
		}
		/// <summary>
		/// Use GracePeriodMinutesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int GracePeriodMinutes
		{
			get { return _GracePeriodMinutes; }
			set 
			{ 
				_GracePeriodMinutes = value;
				OnPropertyChanged("GracePeriodMinutes");
			}
		}
		/// <summary>
		/// Use PremiumServicesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<PremiumService> PremiumServices
		{
			get { return _PremiumServices; }
			set 
			{ 
				_PremiumServices = value;
				OnPropertyChanged("PremiumServices");
			}
		}
		/// <summary>
		/// Use CouponsGroupsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<SubscriptionCouponGroup> CouponsGroups
		{
			get { return _CouponsGroups; }
			set 
			{ 
				_CouponsGroups = value;
				OnPropertyChanged("CouponsGroups");
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
		/// Use DependencyTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SubscriptionDependencyType DependencyType
		{
			get { return _DependencyType; }
			set 
			{ 
				_DependencyType = value;
				OnPropertyChanged("DependencyType");
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
		/// Use IsCancellationBlockedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsCancellationBlocked
		{
			get { return _IsCancellationBlocked; }
			set 
			{ 
				_IsCancellationBlocked = value;
				OnPropertyChanged("IsCancellationBlocked");
			}
		}
		/// <summary>
		/// Use PreSaleDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PreSaleDate
		{
			get { return _PreSaleDate; }
			set 
			{ 
				_PreSaleDate = value;
				OnPropertyChanged("PreSaleDate");
			}
		}
		/// <summary>
		/// Use AdsPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AdsPolicy AdsPolicy
		{
			get { return _AdsPolicy; }
			set 
			{ 
				_AdsPolicy = value;
				OnPropertyChanged("AdsPolicy");
			}
		}
		/// <summary>
		/// Use AdsParamAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdsParam
		{
			get { return _AdsParam; }
			set 
			{ 
				_AdsParam = value;
				OnPropertyChanged("AdsParam");
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
		#endregion

		#region CTor
		public SubscriptionInternal()
		{
		}

		public SubscriptionInternal(JToken node) : base(node)
		{
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
			if(node["fileTypesIds"] != null)
			{
				this._FileTypesIds = node["fileTypesIds"].Value<string>();
			}
			if(node["internalDiscountModuleId"] != null)
			{
				this._InternalDiscountModuleId = ParseLong(node["internalDiscountModuleId"].Value<string>());
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
			if(node["prorityInOrder"] != null)
			{
				this._ProrityInOrder = ParseLong(node["prorityInOrder"].Value<string>());
			}
			if(node["pricePlanIds"] != null)
			{
				this._PricePlanIds = node["pricePlanIds"].Value<string>();
			}
			if(node["previewModuleId"] != null)
			{
				this._PreviewModuleId = ParseLong(node["previewModuleId"].Value<string>());
			}
			if(node["householdLimitationsId"] != null)
			{
				this._HouseholdLimitationsId = ParseInt(node["householdLimitationsId"].Value<string>());
			}
			if(node["gracePeriodMinutes"] != null)
			{
				this._GracePeriodMinutes = ParseInt(node["gracePeriodMinutes"].Value<string>());
			}
			if(node["premiumServices"] != null)
			{
				this._PremiumServices = new List<PremiumService>();
				foreach(var arrayNode in node["premiumServices"].Children())
				{
					this._PremiumServices.Add(ObjectFactory.Create<PremiumService>(arrayNode));
				}
			}
			if(node["couponsGroups"] != null)
			{
				this._CouponsGroups = new List<SubscriptionCouponGroup>();
				foreach(var arrayNode in node["couponsGroups"].Children())
				{
					this._CouponsGroups.Add(ObjectFactory.Create<SubscriptionCouponGroup>(arrayNode));
				}
			}
			if(node["productCodes"] != null)
			{
				this._ProductCodes = new List<ProductCode>();
				foreach(var arrayNode in node["productCodes"].Children())
				{
					this._ProductCodes.Add(ObjectFactory.Create<ProductCode>(arrayNode));
				}
			}
			if(node["dependencyType"] != null)
			{
				this._DependencyType = (SubscriptionDependencyType)StringEnum.Parse(typeof(SubscriptionDependencyType), node["dependencyType"].Value<string>());
			}
			if(node["externalId"] != null)
			{
				this._ExternalId = node["externalId"].Value<string>();
			}
			if(node["isCancellationBlocked"] != null)
			{
				this._IsCancellationBlocked = ParseBool(node["isCancellationBlocked"].Value<string>());
			}
			if(node["preSaleDate"] != null)
			{
				this._PreSaleDate = ParseLong(node["preSaleDate"].Value<string>());
			}
			if(node["adsPolicy"] != null)
			{
				this._AdsPolicy = (AdsPolicy)StringEnum.Parse(typeof(AdsPolicy), node["adsPolicy"].Value<string>());
			}
			if(node["adsParam"] != null)
			{
				this._AdsParam = node["adsParam"].Value<string>();
			}
			if(node["isActive"] != null)
			{
				this._IsActive = ParseBool(node["isActive"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSubscriptionInternal");
			kparams.AddIfNotNull("channelsIds", this._ChannelsIds);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("fileTypesIds", this._FileTypesIds);
			kparams.AddIfNotNull("internalDiscountModuleId", this._InternalDiscountModuleId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("multilingualName", this._MultilingualName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("multilingualDescription", this._MultilingualDescription);
			kparams.AddIfNotNull("prorityInOrder", this._ProrityInOrder);
			kparams.AddIfNotNull("pricePlanIds", this._PricePlanIds);
			kparams.AddIfNotNull("previewModuleId", this._PreviewModuleId);
			kparams.AddIfNotNull("householdLimitationsId", this._HouseholdLimitationsId);
			kparams.AddIfNotNull("gracePeriodMinutes", this._GracePeriodMinutes);
			kparams.AddIfNotNull("premiumServices", this._PremiumServices);
			kparams.AddIfNotNull("couponsGroups", this._CouponsGroups);
			kparams.AddIfNotNull("productCodes", this._ProductCodes);
			kparams.AddIfNotNull("dependencyType", this._DependencyType);
			kparams.AddIfNotNull("externalId", this._ExternalId);
			kparams.AddIfNotNull("isCancellationBlocked", this._IsCancellationBlocked);
			kparams.AddIfNotNull("preSaleDate", this._PreSaleDate);
			kparams.AddIfNotNull("adsPolicy", this._AdsPolicy);
			kparams.AddIfNotNull("adsParam", this._AdsParam);
			kparams.AddIfNotNull("isActive", this._IsActive);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CHANNELS_IDS:
					return "ChannelsIds";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case FILE_TYPES_IDS:
					return "FileTypesIds";
				case INTERNAL_DISCOUNT_MODULE_ID:
					return "InternalDiscountModuleId";
				case NAME:
					return "Name";
				case MULTILINGUAL_NAME:
					return "MultilingualName";
				case DESCRIPTION:
					return "Description";
				case MULTILINGUAL_DESCRIPTION:
					return "MultilingualDescription";
				case PRORITY_IN_ORDER:
					return "ProrityInOrder";
				case PRICE_PLAN_IDS:
					return "PricePlanIds";
				case PREVIEW_MODULE_ID:
					return "PreviewModuleId";
				case HOUSEHOLD_LIMITATIONS_ID:
					return "HouseholdLimitationsId";
				case GRACE_PERIOD_MINUTES:
					return "GracePeriodMinutes";
				case PREMIUM_SERVICES:
					return "PremiumServices";
				case COUPONS_GROUPS:
					return "CouponsGroups";
				case PRODUCT_CODES:
					return "ProductCodes";
				case DEPENDENCY_TYPE:
					return "DependencyType";
				case EXTERNAL_ID:
					return "ExternalId";
				case IS_CANCELLATION_BLOCKED:
					return "IsCancellationBlocked";
				case PRE_SALE_DATE:
					return "PreSaleDate";
				case ADS_POLICY:
					return "AdsPolicy";
				case ADS_PARAM:
					return "AdsParam";
				case IS_ACTIVE:
					return "IsActive";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

