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
	public class ProductMarkup : ObjectBase
	{
		#region Constants
		public const string PRODUCT_ID = "productId";
		public const string PRODUCT_TYPE = "productType";
		public const string IS_ENTITLED = "isEntitled";
		#endregion

		#region Private Fields
		private long _ProductId = long.MinValue;
		private TransactionType _ProductType = null;
		private bool? _IsEntitled = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ProductIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ProductId
		{
			get { return _ProductId; }
			private set 
			{ 
				_ProductId = value;
				OnPropertyChanged("ProductId");
			}
		}
		/// <summary>
		/// Use ProductTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TransactionType ProductType
		{
			get { return _ProductType; }
			private set 
			{ 
				_ProductType = value;
				OnPropertyChanged("ProductType");
			}
		}
		/// <summary>
		/// Use IsEntitledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsEntitled
		{
			get { return _IsEntitled; }
			private set 
			{ 
				_IsEntitled = value;
				OnPropertyChanged("IsEntitled");
			}
		}
		#endregion

		#region CTor
		public ProductMarkup()
		{
		}

		public ProductMarkup(JToken node) : base(node)
		{
			if(node["productId"] != null)
			{
				this._ProductId = ParseLong(node["productId"].Value<string>());
			}
			if(node["productType"] != null)
			{
				this._ProductType = (TransactionType)StringEnum.Parse(typeof(TransactionType), node["productType"].Value<string>());
			}
			if(node["isEntitled"] != null)
			{
				this._IsEntitled = ParseBool(node["isEntitled"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaProductMarkup");
			kparams.AddIfNotNull("productId", this._ProductId);
			kparams.AddIfNotNull("productType", this._ProductType);
			kparams.AddIfNotNull("isEntitled", this._IsEntitled);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PRODUCT_ID:
					return "ProductId";
				case PRODUCT_TYPE:
					return "ProductType";
				case IS_ENTITLED:
					return "IsEntitled";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

