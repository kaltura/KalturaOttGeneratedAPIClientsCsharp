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
// Copyright (C) 2006-2017  Kaltura Inc.
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

namespace Kaltura.Types
{
	public class PricePlan : UsageModule
	{
		#region Constants
		public const string IS_RENEWABLE = "isRenewable";
		public const string RENEWALS_NUMBER = "renewalsNumber";
		public const string PRICE_ID = "priceId";
		public const string DISCOUNT_ID = "discountId";
		#endregion

		#region Private Fields
		private bool? _IsRenewable = null;
		private int _RenewalsNumber = Int32.MinValue;
		private int _PriceId = Int32.MinValue;
		private long _DiscountId = long.MinValue;
		#endregion

		#region Properties
		public bool? IsRenewable
		{
			get { return _IsRenewable; }
			set 
			{ 
				_IsRenewable = value;
				OnPropertyChanged("IsRenewable");
			}
		}
		public int RenewalsNumber
		{
			get { return _RenewalsNumber; }
			set 
			{ 
				_RenewalsNumber = value;
				OnPropertyChanged("RenewalsNumber");
			}
		}
		public int PriceId
		{
			get { return _PriceId; }
			set 
			{ 
				_PriceId = value;
				OnPropertyChanged("PriceId");
			}
		}
		public long DiscountId
		{
			get { return _DiscountId; }
			set 
			{ 
				_DiscountId = value;
				OnPropertyChanged("DiscountId");
			}
		}
		#endregion

		#region CTor
		public PricePlan()
		{
		}

		public PricePlan(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "isRenewable":
						this._IsRenewable = ParseBool(propertyNode.InnerText);
						continue;
					case "renewalsNumber":
						this._RenewalsNumber = ParseInt(propertyNode.InnerText);
						continue;
					case "priceId":
						this._PriceId = ParseInt(propertyNode.InnerText);
						continue;
					case "discountId":
						this._DiscountId = ParseLong(propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPricePlan");
			kparams.AddIfNotNull("isRenewable", this._IsRenewable);
			kparams.AddIfNotNull("renewalsNumber", this._RenewalsNumber);
			kparams.AddIfNotNull("priceId", this._PriceId);
			kparams.AddIfNotNull("discountId", this._DiscountId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IS_RENEWABLE:
					return "IsRenewable";
				case RENEWALS_NUMBER:
					return "RenewalsNumber";
				case PRICE_ID:
					return "PriceId";
				case DISCOUNT_ID:
					return "DiscountId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

