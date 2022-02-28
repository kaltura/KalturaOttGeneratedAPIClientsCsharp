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
	public class ProgramAssetGroupOffer : OTTObjectSupportNullable
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string MULTILINGUAL_NAME = "multilingualName";
		public const string PRICE_DETAILS_ID = "priceDetailsId";
		public const string FILE_TYPES_IDS = "fileTypesIds";
		public const string DISCOUNT_MODULE_ID = "discountModuleId";
		public const string COUPONS_GROUP_ID = "couponsGroupId";
		public const string DESCRIPTION = "description";
		public const string MULTILINGUAL_DESCRIPTION = "multilingualDescription";
		public const string VIRTUAL_ASSET_ID = "virtualAssetId";
		public const string IS_ACTIVE = "isActive";
		public const string CREATE_DATE = "createDate";
		public const string UPDATE_DATE = "updateDate";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string EXPIRY_DATE = "expiryDate";
		public const string EXTERNAL_ID = "externalId";
		public const string EXTERNAL_OFFER_ID = "externalOfferId";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _Name = null;
		private IList<TranslationToken> _MultilingualName;
		private long _PriceDetailsId = long.MinValue;
		private string _FileTypesIds = null;
		private long _DiscountModuleId = long.MinValue;
		private long _CouponsGroupId = long.MinValue;
		private string _Description = null;
		private IList<TranslationToken> _MultilingualDescription;
		private long _VirtualAssetId = long.MinValue;
		private bool? _IsActive = null;
		private long _CreateDate = long.MinValue;
		private long _UpdateDate = long.MinValue;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private long _ExpiryDate = long.MinValue;
		private string _ExternalId = null;
		private string _ExternalOfferId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		/// Use CouponsGroupIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CouponsGroupId
		{
			get { return _CouponsGroupId; }
			set 
			{ 
				_CouponsGroupId = value;
				OnPropertyChanged("CouponsGroupId");
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
		/// Use ExpiryDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ExpiryDate
		{
			get { return _ExpiryDate; }
			set 
			{ 
				_ExpiryDate = value;
				OnPropertyChanged("ExpiryDate");
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
		/// Use ExternalOfferIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalOfferId
		{
			get { return _ExternalOfferId; }
			set 
			{ 
				_ExternalOfferId = value;
				OnPropertyChanged("ExternalOfferId");
			}
		}
		#endregion

		#region CTor
		public ProgramAssetGroupOffer()
		{
		}

		public ProgramAssetGroupOffer(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
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
			if(node["priceDetailsId"] != null)
			{
				this._PriceDetailsId = ParseLong(node["priceDetailsId"].Value<string>());
			}
			if(node["fileTypesIds"] != null)
			{
				this._FileTypesIds = node["fileTypesIds"].Value<string>();
			}
			if(node["discountModuleId"] != null)
			{
				this._DiscountModuleId = ParseLong(node["discountModuleId"].Value<string>());
			}
			if(node["couponsGroupId"] != null)
			{
				this._CouponsGroupId = ParseLong(node["couponsGroupId"].Value<string>());
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
			if(node["virtualAssetId"] != null)
			{
				this._VirtualAssetId = ParseLong(node["virtualAssetId"].Value<string>());
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
			if(node["startDate"] != null)
			{
				this._StartDate = ParseLong(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseLong(node["endDate"].Value<string>());
			}
			if(node["expiryDate"] != null)
			{
				this._ExpiryDate = ParseLong(node["expiryDate"].Value<string>());
			}
			if(node["externalId"] != null)
			{
				this._ExternalId = node["externalId"].Value<string>();
			}
			if(node["externalOfferId"] != null)
			{
				this._ExternalOfferId = node["externalOfferId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaProgramAssetGroupOffer");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("multilingualName", this._MultilingualName);
			kparams.AddIfNotNull("priceDetailsId", this._PriceDetailsId);
			kparams.AddIfNotNull("fileTypesIds", this._FileTypesIds);
			kparams.AddIfNotNull("discountModuleId", this._DiscountModuleId);
			kparams.AddIfNotNull("couponsGroupId", this._CouponsGroupId);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("multilingualDescription", this._MultilingualDescription);
			kparams.AddIfNotNull("virtualAssetId", this._VirtualAssetId);
			kparams.AddIfNotNull("isActive", this._IsActive);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("expiryDate", this._ExpiryDate);
			kparams.AddIfNotNull("externalId", this._ExternalId);
			kparams.AddIfNotNull("externalOfferId", this._ExternalOfferId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case MULTILINGUAL_NAME:
					return "MultilingualName";
				case PRICE_DETAILS_ID:
					return "PriceDetailsId";
				case FILE_TYPES_IDS:
					return "FileTypesIds";
				case DISCOUNT_MODULE_ID:
					return "DiscountModuleId";
				case COUPONS_GROUP_ID:
					return "CouponsGroupId";
				case DESCRIPTION:
					return "Description";
				case MULTILINGUAL_DESCRIPTION:
					return "MultilingualDescription";
				case VIRTUAL_ASSET_ID:
					return "VirtualAssetId";
				case IS_ACTIVE:
					return "IsActive";
				case CREATE_DATE:
					return "CreateDate";
				case UPDATE_DATE:
					return "UpdateDate";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case EXPIRY_DATE:
					return "ExpiryDate";
				case EXTERNAL_ID:
					return "ExternalId";
				case EXTERNAL_OFFER_ID:
					return "ExternalOfferId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

