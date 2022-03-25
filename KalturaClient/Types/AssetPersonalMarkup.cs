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
	public class AssetPersonalMarkup : ObjectBase
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string ASSET_TYPE = "assetType";
		public const string PRODUCTS = "products";
		#endregion

		#region Private Fields
		private long _AssetId = long.MinValue;
		private AssetType _AssetType = null;
		private IList<ProductMarkup> _Products;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long AssetId
		{
			get { return _AssetId; }
			private set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		/// <summary>
		/// Use AssetTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetType AssetType
		{
			get { return _AssetType; }
			private set 
			{ 
				_AssetType = value;
				OnPropertyChanged("AssetType");
			}
		}
		/// <summary>
		/// Use ProductsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ProductMarkup> Products
		{
			get { return _Products; }
			set 
			{ 
				_Products = value;
				OnPropertyChanged("Products");
			}
		}
		#endregion

		#region CTor
		public AssetPersonalMarkup()
		{
		}

		public AssetPersonalMarkup(JToken node) : base(node)
		{
			if(node["assetId"] != null)
			{
				this._AssetId = ParseLong(node["assetId"].Value<string>());
			}
			if(node["assetType"] != null)
			{
				this._AssetType = (AssetType)StringEnum.Parse(typeof(AssetType), node["assetType"].Value<string>());
			}
			if(node["products"] != null)
			{
				this._Products = new List<ProductMarkup>();
				foreach(var arrayNode in node["products"].Children())
				{
					this._Products.Add(ObjectFactory.Create<ProductMarkup>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetPersonalMarkup");
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("assetType", this._AssetType);
			kparams.AddIfNotNull("products", this._Products);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_ID:
					return "AssetId";
				case ASSET_TYPE:
					return "AssetType";
				case PRODUCTS:
					return "Products";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

