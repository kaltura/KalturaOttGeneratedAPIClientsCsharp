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
	public class DiscountDetailsFilter : Filter
	{
		#region Constants
		public const string ID_IN = "idIn";
		public const string ASSOCIATED_SHOP_ENTITIES = "associatedShopEntities";
		#endregion

		#region Private Fields
		private string _IdIn = null;
		private AssociatedShopEntities _AssociatedShopEntities;
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
		/// Use AssociatedShopEntitiesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssociatedShopEntities AssociatedShopEntities
		{
			get { return _AssociatedShopEntities; }
			set 
			{ 
				_AssociatedShopEntities = value;
				OnPropertyChanged("AssociatedShopEntities");
			}
		}
		#endregion

		#region CTor
		public DiscountDetailsFilter()
		{
		}

		public DiscountDetailsFilter(JToken node) : base(node)
		{
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["associatedShopEntities"] != null)
			{
				this._AssociatedShopEntities = ObjectFactory.Create<AssociatedShopEntities>(node["associatedShopEntities"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDiscountDetailsFilter");
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("associatedShopEntities", this._AssociatedShopEntities);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_IN:
					return "IdIn";
				case ASSOCIATED_SHOP_ENTITIES:
					return "AssociatedShopEntities";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

