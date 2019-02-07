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
	public class MetaFilter : Filter
	{
		#region Constants
		public const string FIELD_NAME_EQUAL = "fieldNameEqual";
		public const string FIELD_NAME_NOT_EQUAL = "fieldNameNotEqual";
		public const string TYPE_EQUAL = "typeEqual";
		public const string ASSET_TYPE_EQUAL = "assetTypeEqual";
		public const string FEATURES_IN = "featuresIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private MetaFieldName _FieldNameEqual = null;
		private MetaFieldName _FieldNameNotEqual = null;
		private MetaType _TypeEqual = null;
		private AssetType _AssetTypeEqual = null;
		private string _FeaturesIn = null;
		private MetaOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public MetaFieldName FieldNameEqual
		{
			get { return _FieldNameEqual; }
			set 
			{ 
				_FieldNameEqual = value;
				OnPropertyChanged("FieldNameEqual");
			}
		}
		[JsonProperty]
		public MetaFieldName FieldNameNotEqual
		{
			get { return _FieldNameNotEqual; }
			set 
			{ 
				_FieldNameNotEqual = value;
				OnPropertyChanged("FieldNameNotEqual");
			}
		}
		[JsonProperty]
		public MetaType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		[JsonProperty]
		public AssetType AssetTypeEqual
		{
			get { return _AssetTypeEqual; }
			set 
			{ 
				_AssetTypeEqual = value;
				OnPropertyChanged("AssetTypeEqual");
			}
		}
		[JsonProperty]
		public string FeaturesIn
		{
			get { return _FeaturesIn; }
			set 
			{ 
				_FeaturesIn = value;
				OnPropertyChanged("FeaturesIn");
			}
		}
		[JsonProperty]
		public new MetaOrderBy OrderBy
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
		public MetaFilter()
		{
		}

		public MetaFilter(JToken node) : base(node)
		{
			if(node["fieldNameEqual"] != null)
			{
				this._FieldNameEqual = (MetaFieldName)StringEnum.Parse(typeof(MetaFieldName), node["fieldNameEqual"].Value<string>());
			}
			if(node["fieldNameNotEqual"] != null)
			{
				this._FieldNameNotEqual = (MetaFieldName)StringEnum.Parse(typeof(MetaFieldName), node["fieldNameNotEqual"].Value<string>());
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (MetaType)StringEnum.Parse(typeof(MetaType), node["typeEqual"].Value<string>());
			}
			if(node["assetTypeEqual"] != null)
			{
				this._AssetTypeEqual = (AssetType)StringEnum.Parse(typeof(AssetType), node["assetTypeEqual"].Value<string>());
			}
			if(node["featuresIn"] != null)
			{
				this._FeaturesIn = node["featuresIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (MetaOrderBy)StringEnum.Parse(typeof(MetaOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetaFilter");
			kparams.AddIfNotNull("fieldNameEqual", this._FieldNameEqual);
			kparams.AddIfNotNull("fieldNameNotEqual", this._FieldNameNotEqual);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("assetTypeEqual", this._AssetTypeEqual);
			kparams.AddIfNotNull("featuresIn", this._FeaturesIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_NAME_EQUAL:
					return "FieldNameEqual";
				case FIELD_NAME_NOT_EQUAL:
					return "FieldNameNotEqual";
				case TYPE_EQUAL:
					return "TypeEqual";
				case ASSET_TYPE_EQUAL:
					return "AssetTypeEqual";
				case FEATURES_IN:
					return "FeaturesIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

