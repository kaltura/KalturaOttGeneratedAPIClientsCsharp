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
	public class CollectionFilter : Filter
	{
		#region Constants
		public const string COLLECTION_ID_IN = "collectionIdIn";
		public const string MEDIA_FILE_ID_EQUAL = "mediaFileIdEqual";
		public const string COUPON_GROUP_ID_EQUAL = "couponGroupIdEqual";
		public const string ALSO_INACTIVE = "alsoInactive";
		public const string ASSET_USER_RULE_ID_IN = "assetUserRuleIdIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _CollectionIdIn = null;
		private int _MediaFileIdEqual = Int32.MinValue;
		private int _CouponGroupIdEqual = Int32.MinValue;
		private bool? _AlsoInactive = null;
		private string _AssetUserRuleIdIn = null;
		private CollectionOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use CollectionIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CollectionIdIn
		{
			get { return _CollectionIdIn; }
			set 
			{ 
				_CollectionIdIn = value;
				OnPropertyChanged("CollectionIdIn");
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
		/// Use AssetUserRuleIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetUserRuleIdIn
		{
			get { return _AssetUserRuleIdIn; }
			set 
			{ 
				_AssetUserRuleIdIn = value;
				OnPropertyChanged("AssetUserRuleIdIn");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new CollectionOrderBy OrderBy
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
		public CollectionFilter()
		{
		}

		public CollectionFilter(JToken node) : base(node)
		{
			if(node["collectionIdIn"] != null)
			{
				this._CollectionIdIn = node["collectionIdIn"].Value<string>();
			}
			if(node["mediaFileIdEqual"] != null)
			{
				this._MediaFileIdEqual = ParseInt(node["mediaFileIdEqual"].Value<string>());
			}
			if(node["couponGroupIdEqual"] != null)
			{
				this._CouponGroupIdEqual = ParseInt(node["couponGroupIdEqual"].Value<string>());
			}
			if(node["alsoInactive"] != null)
			{
				this._AlsoInactive = ParseBool(node["alsoInactive"].Value<string>());
			}
			if(node["assetUserRuleIdIn"] != null)
			{
				this._AssetUserRuleIdIn = node["assetUserRuleIdIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (CollectionOrderBy)StringEnum.Parse(typeof(CollectionOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCollectionFilter");
			kparams.AddIfNotNull("collectionIdIn", this._CollectionIdIn);
			kparams.AddIfNotNull("mediaFileIdEqual", this._MediaFileIdEqual);
			kparams.AddIfNotNull("couponGroupIdEqual", this._CouponGroupIdEqual);
			kparams.AddIfNotNull("alsoInactive", this._AlsoInactive);
			kparams.AddIfNotNull("assetUserRuleIdIn", this._AssetUserRuleIdIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case COLLECTION_ID_IN:
					return "CollectionIdIn";
				case MEDIA_FILE_ID_EQUAL:
					return "MediaFileIdEqual";
				case COUPON_GROUP_ID_EQUAL:
					return "CouponGroupIdEqual";
				case ALSO_INACTIVE:
					return "AlsoInactive";
				case ASSET_USER_RULE_ID_IN:
					return "AssetUserRuleIdIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

