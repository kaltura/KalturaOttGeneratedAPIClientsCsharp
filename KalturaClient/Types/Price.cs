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
	public class Price : ObjectBase
	{
		#region Constants
		public const string CURRENCY_ID = "currencyId";
		public const string AMOUNT = "amount";
		public const string CURRENCY = "currency";
		public const string CURRENCY_SIGN = "currencySign";
		public const string COUNTRY_ID = "countryId";
		#endregion

		#region Private Fields
		private long _CurrencyId = long.MinValue;
		private double _Amount = Double.MinValue;
		private string _Currency = null;
		private string _CurrencySign = null;
		private long _CountryId = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use CurrencyIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CurrencyId
		{
			get { return _CurrencyId; }
			private set 
			{ 
				_CurrencyId = value;
				OnPropertyChanged("CurrencyId");
			}
		}
		/// <summary>
		/// Use AmountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Amount
		{
			get { return _Amount; }
			set 
			{ 
				_Amount = value;
				OnPropertyChanged("Amount");
			}
		}
		/// <summary>
		/// Use CurrencyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Currency
		{
			get { return _Currency; }
			set 
			{ 
				_Currency = value;
				OnPropertyChanged("Currency");
			}
		}
		/// <summary>
		/// Use CurrencySignAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CurrencySign
		{
			get { return _CurrencySign; }
			set 
			{ 
				_CurrencySign = value;
				OnPropertyChanged("CurrencySign");
			}
		}
		/// <summary>
		/// Use CountryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CountryId
		{
			get { return _CountryId; }
			set 
			{ 
				_CountryId = value;
				OnPropertyChanged("CountryId");
			}
		}
		#endregion

		#region CTor
		public Price()
		{
		}

		public Price(JToken node) : base(node)
		{
			if(node["currencyId"] != null)
			{
				this._CurrencyId = ParseLong(node["currencyId"].Value<string>());
			}
			if(node["amount"] != null)
			{
				this._Amount = ParseDouble(node["amount"].Value<string>());
			}
			if(node["currency"] != null)
			{
				this._Currency = node["currency"].Value<string>();
			}
			if(node["currencySign"] != null)
			{
				this._CurrencySign = node["currencySign"].Value<string>();
			}
			if(node["countryId"] != null)
			{
				this._CountryId = ParseLong(node["countryId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPrice");
			kparams.AddIfNotNull("currencyId", this._CurrencyId);
			kparams.AddIfNotNull("amount", this._Amount);
			kparams.AddIfNotNull("currency", this._Currency);
			kparams.AddIfNotNull("currencySign", this._CurrencySign);
			kparams.AddIfNotNull("countryId", this._CountryId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CURRENCY_ID:
					return "CurrencyId";
				case AMOUNT:
					return "Amount";
				case CURRENCY:
					return "Currency";
				case CURRENCY_SIGN:
					return "CurrencySign";
				case COUNTRY_ID:
					return "CountryId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

