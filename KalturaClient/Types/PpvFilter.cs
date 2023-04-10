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
	public class PpvFilter : Filter
	{
		#region Constants
		public const string ID_IN = "idIn";
		public const string COUPON_GROUP_ID_EQUAL = "couponGroupIdEqual";
		public const string ALSO_INACTIVE = "alsoInactive";
		public const string NAME_CONTAINS = "nameContains";
		public const string ASSET_USER_RULE_ID_IN = "assetUserRuleIdIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _IdIn = null;
		private int _CouponGroupIdEqual = Int32.MinValue;
		private bool? _AlsoInactive = null;
		private string _NameContains = null;
		private string _AssetUserRuleIdIn = null;
		private PpvOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
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
		/// Use NameContainsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NameContains
		{
			get { return _NameContains; }
			set 
			{ 
				_NameContains = value;
				OnPropertyChanged("NameContains");
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
		public new PpvOrderBy OrderBy
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
		public PpvFilter()
		{
		}

		public PpvFilter(JToken node) : base(node)
		{
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["couponGroupIdEqual"] != null)
			{
				this._CouponGroupIdEqual = ParseInt(node["couponGroupIdEqual"].Value<string>());
			}
			if(node["alsoInactive"] != null)
			{
				this._AlsoInactive = ParseBool(node["alsoInactive"].Value<string>());
			}
			if(node["nameContains"] != null)
			{
				this._NameContains = node["nameContains"].Value<string>();
			}
			if(node["assetUserRuleIdIn"] != null)
			{
				this._AssetUserRuleIdIn = node["assetUserRuleIdIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (PpvOrderBy)StringEnum.Parse(typeof(PpvOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPpvFilter");
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("couponGroupIdEqual", this._CouponGroupIdEqual);
			kparams.AddIfNotNull("alsoInactive", this._AlsoInactive);
			kparams.AddIfNotNull("nameContains", this._NameContains);
			kparams.AddIfNotNull("assetUserRuleIdIn", this._AssetUserRuleIdIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_IN:
					return "IdIn";
				case COUPON_GROUP_ID_EQUAL:
					return "CouponGroupIdEqual";
				case ALSO_INACTIVE:
					return "AlsoInactive";
				case NAME_CONTAINS:
					return "NameContains";
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

