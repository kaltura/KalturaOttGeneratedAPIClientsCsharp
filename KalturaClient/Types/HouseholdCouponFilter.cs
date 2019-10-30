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
	public class HouseholdCouponFilter : CrudFilter
	{
		#region Constants
		public const string BUSINESS_MODULE_TYPE_EQUAL = "businessModuleTypeEqual";
		public const string BUSINESS_MODULE_ID_EQUAL = "businessModuleIdEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private TransactionType _BusinessModuleTypeEqual = null;
		private long _BusinessModuleIdEqual = long.MinValue;
		private HouseholdCouponOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public TransactionType BusinessModuleTypeEqual
		{
			get { return _BusinessModuleTypeEqual; }
			set 
			{ 
				_BusinessModuleTypeEqual = value;
				OnPropertyChanged("BusinessModuleTypeEqual");
			}
		}
		[JsonProperty]
		public long BusinessModuleIdEqual
		{
			get { return _BusinessModuleIdEqual; }
			set 
			{ 
				_BusinessModuleIdEqual = value;
				OnPropertyChanged("BusinessModuleIdEqual");
			}
		}
		[JsonProperty]
		public new HouseholdCouponOrderBy OrderBy
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
		public HouseholdCouponFilter()
		{
		}

		public HouseholdCouponFilter(JToken node) : base(node)
		{
			if(node["businessModuleTypeEqual"] != null)
			{
				this._BusinessModuleTypeEqual = (TransactionType)StringEnum.Parse(typeof(TransactionType), node["businessModuleTypeEqual"].Value<string>());
			}
			if(node["businessModuleIdEqual"] != null)
			{
				this._BusinessModuleIdEqual = ParseLong(node["businessModuleIdEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (HouseholdCouponOrderBy)StringEnum.Parse(typeof(HouseholdCouponOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHouseholdCouponFilter");
			kparams.AddIfNotNull("businessModuleTypeEqual", this._BusinessModuleTypeEqual);
			kparams.AddIfNotNull("businessModuleIdEqual", this._BusinessModuleIdEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case BUSINESS_MODULE_TYPE_EQUAL:
					return "BusinessModuleTypeEqual";
				case BUSINESS_MODULE_ID_EQUAL:
					return "BusinessModuleIdEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

