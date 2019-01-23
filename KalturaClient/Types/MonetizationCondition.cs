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
	public class MonetizationCondition : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string MINIMUM_PRICE = "minimumPrice";
		public const string MULTIPLIER = "multiplier";
		#endregion

		#region Private Fields
		private MonetizationType _Type = null;
		private int _MinimumPrice = Int32.MinValue;
		private int _Multiplier = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public MonetizationType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public int MinimumPrice
		{
			get { return _MinimumPrice; }
			set 
			{ 
				_MinimumPrice = value;
				OnPropertyChanged("MinimumPrice");
			}
		}
		[JsonProperty]
		public int Multiplier
		{
			get { return _Multiplier; }
			set 
			{ 
				_Multiplier = value;
				OnPropertyChanged("Multiplier");
			}
		}
		#endregion

		#region CTor
		public MonetizationCondition()
		{
		}

		public MonetizationCondition(JToken node) : base(node)
		{
			if(node["type"] != null)
			{
				this._Type = (MonetizationType)StringEnum.Parse(typeof(MonetizationType), node["type"].Value<string>());
			}
			if(node["minimumPrice"] != null)
			{
				this._MinimumPrice = ParseInt(node["minimumPrice"].Value<string>());
			}
			if(node["multiplier"] != null)
			{
				this._Multiplier = ParseInt(node["multiplier"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMonetizationCondition");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("minimumPrice", this._MinimumPrice);
			kparams.AddIfNotNull("multiplier", this._Multiplier);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case MINIMUM_PRICE:
					return "MinimumPrice";
				case MULTIPLIER:
					return "Multiplier";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

