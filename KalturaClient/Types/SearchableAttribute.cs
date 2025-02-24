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
	public class SearchableAttribute : ObjectBase
	{
		#region Constants
		public const string ASSET_STRUCT_ID = "assetStructId";
		public const string ATTRIBUTES = "attributes";
		#endregion

		#region Private Fields
		private string _AssetStructId = null;
		private string _Attributes = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetStructIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetStructId
		{
			get { return _AssetStructId; }
			set 
			{ 
				_AssetStructId = value;
				OnPropertyChanged("AssetStructId");
			}
		}
		/// <summary>
		/// Use AttributesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Attributes
		{
			get { return _Attributes; }
			set 
			{ 
				_Attributes = value;
				OnPropertyChanged("Attributes");
			}
		}
		#endregion

		#region CTor
		public SearchableAttribute()
		{
		}

		public SearchableAttribute(JToken node) : base(node)
		{
			if(node["assetStructId"] != null)
			{
				this._AssetStructId = node["assetStructId"].Value<string>();
			}
			if(node["attributes"] != null)
			{
				this._Attributes = node["attributes"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSearchableAttribute");
			kparams.AddIfNotNull("assetStructId", this._AssetStructId);
			kparams.AddIfNotNull("attributes", this._Attributes);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_STRUCT_ID:
					return "AssetStructId";
				case ATTRIBUTES:
					return "Attributes";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

