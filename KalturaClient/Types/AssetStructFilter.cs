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
	public class AssetStructFilter : BaseAssetStructFilter
	{
		#region Constants
		public const string ID_IN = "idIn";
		public const string META_ID_EQUAL = "metaIdEqual";
		public const string IS_PROTECTED_EQUAL = "isProtectedEqual";
		public const string OBJECT_VIRTUAL_ASSET_INFO_TYPE_EQUAL = "objectVirtualAssetInfoTypeEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _IdIn = null;
		private long _MetaIdEqual = long.MinValue;
		private bool? _IsProtectedEqual = null;
		private ObjectVirtualAssetInfoType _ObjectVirtualAssetInfoTypeEqual = null;
		private AssetStructOrderBy _OrderBy = null;
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
		/// Use MetaIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long MetaIdEqual
		{
			get { return _MetaIdEqual; }
			set 
			{ 
				_MetaIdEqual = value;
				OnPropertyChanged("MetaIdEqual");
			}
		}
		/// <summary>
		/// Use IsProtectedEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsProtectedEqual
		{
			get { return _IsProtectedEqual; }
			set 
			{ 
				_IsProtectedEqual = value;
				OnPropertyChanged("IsProtectedEqual");
			}
		}
		/// <summary>
		/// Use ObjectVirtualAssetInfoTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ObjectVirtualAssetInfoType ObjectVirtualAssetInfoTypeEqual
		{
			get { return _ObjectVirtualAssetInfoTypeEqual; }
			set 
			{ 
				_ObjectVirtualAssetInfoTypeEqual = value;
				OnPropertyChanged("ObjectVirtualAssetInfoTypeEqual");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new AssetStructOrderBy OrderBy
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
		public AssetStructFilter()
		{
		}

		public AssetStructFilter(JToken node) : base(node)
		{
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["metaIdEqual"] != null)
			{
				this._MetaIdEqual = ParseLong(node["metaIdEqual"].Value<string>());
			}
			if(node["isProtectedEqual"] != null)
			{
				this._IsProtectedEqual = ParseBool(node["isProtectedEqual"].Value<string>());
			}
			if(node["objectVirtualAssetInfoTypeEqual"] != null)
			{
				this._ObjectVirtualAssetInfoTypeEqual = (ObjectVirtualAssetInfoType)StringEnum.Parse(typeof(ObjectVirtualAssetInfoType), node["objectVirtualAssetInfoTypeEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (AssetStructOrderBy)StringEnum.Parse(typeof(AssetStructOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetStructFilter");
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("metaIdEqual", this._MetaIdEqual);
			kparams.AddIfNotNull("isProtectedEqual", this._IsProtectedEqual);
			kparams.AddIfNotNull("objectVirtualAssetInfoTypeEqual", this._ObjectVirtualAssetInfoTypeEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_IN:
					return "IdIn";
				case META_ID_EQUAL:
					return "MetaIdEqual";
				case IS_PROTECTED_EQUAL:
					return "IsProtectedEqual";
				case OBJECT_VIRTUAL_ASSET_INFO_TYPE_EQUAL:
					return "ObjectVirtualAssetInfoTypeEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

