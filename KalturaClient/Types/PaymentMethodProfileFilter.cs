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
	public class PaymentMethodProfileFilter : Filter
	{
		#region Constants
		public const string PAYMENT_GATEWAY_ID_EQUAL = "paymentGatewayIdEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private int _PaymentGatewayIdEqual = Int32.MinValue;
		private PaymentMethodProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PaymentGatewayIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PaymentGatewayIdEqual
		{
			get { return _PaymentGatewayIdEqual; }
			set 
			{ 
				_PaymentGatewayIdEqual = value;
				OnPropertyChanged("PaymentGatewayIdEqual");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new PaymentMethodProfileOrderBy OrderBy
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
		public PaymentMethodProfileFilter()
		{
		}

		public PaymentMethodProfileFilter(JToken node) : base(node)
		{
			if(node["paymentGatewayIdEqual"] != null)
			{
				this._PaymentGatewayIdEqual = ParseInt(node["paymentGatewayIdEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (PaymentMethodProfileOrderBy)StringEnum.Parse(typeof(PaymentMethodProfileOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPaymentMethodProfileFilter");
			kparams.AddIfNotNull("paymentGatewayIdEqual", this._PaymentGatewayIdEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PAYMENT_GATEWAY_ID_EQUAL:
					return "PaymentGatewayIdEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

