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
	public class CouponPromotion : BasePromotion
	{
		#region Constants
		public const string COUPON_GROUP_ID = "couponGroupId";
		#endregion

		#region Private Fields
		private long _CouponGroupId = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use CouponGroupIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CouponGroupId
		{
			get { return _CouponGroupId; }
			set 
			{ 
				_CouponGroupId = value;
				OnPropertyChanged("CouponGroupId");
			}
		}
		#endregion

		#region CTor
		public CouponPromotion()
		{
		}

		public CouponPromotion(JToken node) : base(node)
		{
			if(node["couponGroupId"] != null)
			{
				this._CouponGroupId = ParseLong(node["couponGroupId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCouponPromotion");
			kparams.AddIfNotNull("couponGroupId", this._CouponGroupId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case COUPON_GROUP_ID:
					return "CouponGroupId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

