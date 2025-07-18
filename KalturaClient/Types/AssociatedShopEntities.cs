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
	public class AssociatedShopEntities : ObjectBase
	{
		#region Constants
		public const string ASSET_USER_RULE_ID_IN = "assetUserRuleIdIn";
		public const string INCLUDE_NULL_ASSET_USER_RULE_ID = "includeNullAssetUserRuleId";
		#endregion

		#region Private Fields
		private string _AssetUserRuleIdIn = null;
		private bool? _IncludeNullAssetUserRuleId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetUserRuleIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetUserRuleIdIn
		{
			get { return _AssetUserRuleIdIn; }
			set 
			{ 
				_AssetUserRuleIdIn = value;
				OnPropertyChanged("AssetUserRuleIdIn");
			}
		}
		/// <summary>
		/// Use IncludeNullAssetUserRuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IncludeNullAssetUserRuleId
		{
			get { return _IncludeNullAssetUserRuleId; }
			set 
			{ 
				_IncludeNullAssetUserRuleId = value;
				OnPropertyChanged("IncludeNullAssetUserRuleId");
			}
		}
		#endregion

		#region CTor
		public AssociatedShopEntities()
		{
		}

		public AssociatedShopEntities(JToken node) : base(node)
		{
			if(node["assetUserRuleIdIn"] != null)
			{
				this._AssetUserRuleIdIn = node["assetUserRuleIdIn"].Value<string>();
			}
			if(node["includeNullAssetUserRuleId"] != null)
			{
				this._IncludeNullAssetUserRuleId = ParseBool(node["includeNullAssetUserRuleId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssociatedShopEntities");
			kparams.AddIfNotNull("assetUserRuleIdIn", this._AssetUserRuleIdIn);
			kparams.AddIfNotNull("includeNullAssetUserRuleId", this._IncludeNullAssetUserRuleId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_USER_RULE_ID_IN:
					return "AssetUserRuleIdIn";
				case INCLUDE_NULL_ASSET_USER_RULE_ID:
					return "IncludeNullAssetUserRuleId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

