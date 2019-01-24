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
	public class Channel : BaseChannel
	{
		#region Constants
		public const string DESCRIPTION = "description";
		public const string IMAGES = "images";
		public const string ASSET_TYPES = "assetTypes";
		public const string FILTER_EXPRESSION = "filterExpression";
		public const string IS_ACTIVE = "isActive";
		public const string ORDER = "order";
		public const string GROUP_BY = "groupBy";
		#endregion

		#region Private Fields
		private string _Description = null;
		private IList<MediaImage> _Images;
		private IList<IntegerValue> _AssetTypes;
		private string _FilterExpression = null;
		private bool? _IsActive = null;
		private AssetOrderBy _Order = null;
		private AssetGroupBy _GroupBy;
		#endregion

		#region Properties
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		[JsonProperty]
		public IList<MediaImage> Images
		{
			get { return _Images; }
			set 
			{ 
				_Images = value;
				OnPropertyChanged("Images");
			}
		}
		[JsonProperty]
		public IList<IntegerValue> AssetTypes
		{
			get { return _AssetTypes; }
			set 
			{ 
				_AssetTypes = value;
				OnPropertyChanged("AssetTypes");
			}
		}
		[JsonProperty]
		public string FilterExpression
		{
			get { return _FilterExpression; }
			set 
			{ 
				_FilterExpression = value;
				OnPropertyChanged("FilterExpression");
			}
		}
		[JsonProperty]
		public bool? IsActive
		{
			get { return _IsActive; }
			set 
			{ 
				_IsActive = value;
				OnPropertyChanged("IsActive");
			}
		}
		[JsonProperty]
		public AssetOrderBy Order
		{
			get { return _Order; }
			set 
			{ 
				_Order = value;
				OnPropertyChanged("Order");
			}
		}
		[JsonProperty]
		public AssetGroupBy GroupBy
		{
			get { return _GroupBy; }
			set 
			{ 
				_GroupBy = value;
				OnPropertyChanged("GroupBy");
			}
		}
		#endregion

		#region CTor
		public Channel()
		{
		}

		public Channel(JToken node) : base(node)
		{
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["images"] != null)
			{
				this._Images = new List<MediaImage>();
				foreach(var arrayNode in node["images"].Children())
				{
					this._Images.Add(ObjectFactory.Create<MediaImage>(arrayNode));
				}
			}
			if(node["assetTypes"] != null)
			{
				this._AssetTypes = new List<IntegerValue>();
				foreach(var arrayNode in node["assetTypes"].Children())
				{
					this._AssetTypes.Add(ObjectFactory.Create<IntegerValue>(arrayNode));
				}
			}
			if(node["filterExpression"] != null)
			{
				this._FilterExpression = node["filterExpression"].Value<string>();
			}
			if(node["isActive"] != null)
			{
				this._IsActive = ParseBool(node["isActive"].Value<string>());
			}
			if(node["order"] != null)
			{
				this._Order = (AssetOrderBy)StringEnum.Parse(typeof(AssetOrderBy), node["order"].Value<string>());
			}
			if(node["groupBy"] != null)
			{
				this._GroupBy = ObjectFactory.Create<AssetGroupBy>(node["groupBy"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaChannel");
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("images", this._Images);
			kparams.AddIfNotNull("assetTypes", this._AssetTypes);
			kparams.AddIfNotNull("filterExpression", this._FilterExpression);
			kparams.AddIfNotNull("isActive", this._IsActive);
			kparams.AddIfNotNull("order", this._Order);
			kparams.AddIfNotNull("groupBy", this._GroupBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DESCRIPTION:
					return "Description";
				case IMAGES:
					return "Images";
				case ASSET_TYPES:
					return "AssetTypes";
				case FILTER_EXPRESSION:
					return "FilterExpression";
				case IS_ACTIVE:
					return "IsActive";
				case ORDER:
					return "Order";
				case GROUP_BY:
					return "GroupBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

