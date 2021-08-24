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
	public class SubscriptionFilter : Filter
	{
		#region Constants
		public const string SUBSCRIPTION_ID_IN = "subscriptionIdIn";
		public const string MEDIA_FILE_ID_EQUAL = "mediaFileIdEqual";
		public const string EXTERNAL_ID_IN = "externalIdIn";
		public const string COUPON_GROUP_ID_EQUAL = "couponGroupIdEqual";
		public const string PREVIEW_MODULE_ID_EQUAL = "previewModuleIdEqual";
		public const string PRICE_PLAN_ID_EQUAL = "pricePlanIdEqual";
		public const string CHANNEL_ID_EQUAL = "channelIdEqual";
		public const string KSQL = "kSql";
		public const string ALSO_INACTIVE = "alsoInactive";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _SubscriptionIdIn = null;
		private int _MediaFileIdEqual = Int32.MinValue;
		private string _ExternalIdIn = null;
		private int _CouponGroupIdEqual = Int32.MinValue;
		private long _PreviewModuleIdEqual = long.MinValue;
		private long _PricePlanIdEqual = long.MinValue;
		private long _ChannelIdEqual = long.MinValue;
		private string _KSql = null;
		private bool? _AlsoInactive = null;
		private SubscriptionOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SubscriptionIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SubscriptionIdIn
		{
			get { return _SubscriptionIdIn; }
			set 
			{ 
				_SubscriptionIdIn = value;
				OnPropertyChanged("SubscriptionIdIn");
			}
		}
		/// <summary>
		/// Use MediaFileIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MediaFileIdEqual
		{
			get { return _MediaFileIdEqual; }
			set 
			{ 
				_MediaFileIdEqual = value;
				OnPropertyChanged("MediaFileIdEqual");
			}
		}
		/// <summary>
		/// Use ExternalIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalIdIn
		{
			get { return _ExternalIdIn; }
			set 
			{ 
				_ExternalIdIn = value;
				OnPropertyChanged("ExternalIdIn");
			}
		}
		/// <summary>
		/// Use CouponGroupIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CouponGroupIdEqual
		{
			get { return _CouponGroupIdEqual; }
			set 
			{ 
				_CouponGroupIdEqual = value;
				OnPropertyChanged("CouponGroupIdEqual");
			}
		}
		/// <summary>
		/// Use PreviewModuleIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PreviewModuleIdEqual
		{
			get { return _PreviewModuleIdEqual; }
			set 
			{ 
				_PreviewModuleIdEqual = value;
				OnPropertyChanged("PreviewModuleIdEqual");
			}
		}
		/// <summary>
		/// Use PricePlanIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PricePlanIdEqual
		{
			get { return _PricePlanIdEqual; }
			set 
			{ 
				_PricePlanIdEqual = value;
				OnPropertyChanged("PricePlanIdEqual");
			}
		}
		/// <summary>
		/// Use ChannelIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ChannelIdEqual
		{
			get { return _ChannelIdEqual; }
			set 
			{ 
				_ChannelIdEqual = value;
				OnPropertyChanged("ChannelIdEqual");
			}
		}
		/// <summary>
		/// Use KSqlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string KSql
		{
			get { return _KSql; }
			set 
			{ 
				_KSql = value;
				OnPropertyChanged("KSql");
			}
		}
		/// <summary>
		/// Use AlsoInactiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AlsoInactive
		{
			get { return _AlsoInactive; }
			set 
			{ 
				_AlsoInactive = value;
				OnPropertyChanged("AlsoInactive");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new SubscriptionOrderBy OrderBy
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
		public SubscriptionFilter()
		{
		}

		public SubscriptionFilter(JToken node) : base(node)
		{
			if(node["subscriptionIdIn"] != null)
			{
				this._SubscriptionIdIn = node["subscriptionIdIn"].Value<string>();
			}
			if(node["mediaFileIdEqual"] != null)
			{
				this._MediaFileIdEqual = ParseInt(node["mediaFileIdEqual"].Value<string>());
			}
			if(node["externalIdIn"] != null)
			{
				this._ExternalIdIn = node["externalIdIn"].Value<string>();
			}
			if(node["couponGroupIdEqual"] != null)
			{
				this._CouponGroupIdEqual = ParseInt(node["couponGroupIdEqual"].Value<string>());
			}
			if(node["previewModuleIdEqual"] != null)
			{
				this._PreviewModuleIdEqual = ParseLong(node["previewModuleIdEqual"].Value<string>());
			}
			if(node["pricePlanIdEqual"] != null)
			{
				this._PricePlanIdEqual = ParseLong(node["pricePlanIdEqual"].Value<string>());
			}
			if(node["channelIdEqual"] != null)
			{
				this._ChannelIdEqual = ParseLong(node["channelIdEqual"].Value<string>());
			}
			if(node["kSql"] != null)
			{
				this._KSql = node["kSql"].Value<string>();
			}
			if(node["alsoInactive"] != null)
			{
				this._AlsoInactive = ParseBool(node["alsoInactive"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (SubscriptionOrderBy)StringEnum.Parse(typeof(SubscriptionOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSubscriptionFilter");
			kparams.AddIfNotNull("subscriptionIdIn", this._SubscriptionIdIn);
			kparams.AddIfNotNull("mediaFileIdEqual", this._MediaFileIdEqual);
			kparams.AddIfNotNull("externalIdIn", this._ExternalIdIn);
			kparams.AddIfNotNull("couponGroupIdEqual", this._CouponGroupIdEqual);
			kparams.AddIfNotNull("previewModuleIdEqual", this._PreviewModuleIdEqual);
			kparams.AddIfNotNull("pricePlanIdEqual", this._PricePlanIdEqual);
			kparams.AddIfNotNull("channelIdEqual", this._ChannelIdEqual);
			kparams.AddIfNotNull("kSql", this._KSql);
			kparams.AddIfNotNull("alsoInactive", this._AlsoInactive);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SUBSCRIPTION_ID_IN:
					return "SubscriptionIdIn";
				case MEDIA_FILE_ID_EQUAL:
					return "MediaFileIdEqual";
				case EXTERNAL_ID_IN:
					return "ExternalIdIn";
				case COUPON_GROUP_ID_EQUAL:
					return "CouponGroupIdEqual";
				case PREVIEW_MODULE_ID_EQUAL:
					return "PreviewModuleIdEqual";
				case PRICE_PLAN_ID_EQUAL:
					return "PricePlanIdEqual";
				case CHANNEL_ID_EQUAL:
					return "ChannelIdEqual";
				case KSQL:
					return "KSql";
				case ALSO_INACTIVE:
					return "AlsoInactive";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

