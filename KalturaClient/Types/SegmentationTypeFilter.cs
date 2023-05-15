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
	public class SegmentationTypeFilter : BaseSegmentationTypeFilter
	{
		#region Constants
		public const string ID_IN = "idIn";
		public const string KSQL = "kSql";
		public const string NAME_CONTAIN = "nameContain";
		public const string ASSET_USER_RULE_ID_IN = "assetUserRuleIdIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _IdIn = null;
		private string _KSql = null;
		private string _NameContain = null;
		private string _AssetUserRuleIdIn = null;
		private SegmentationTypeOrderBy _OrderBy = null;
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
		/// Use KSqlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string KSql
		{
			get { return _KSql; }
			set 
			{ 
				_KSql = value;
				OnPropertyChanged("KSql");
			}
		}
		/// <summary>
		/// Use NameContainAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NameContain
		{
			get { return _NameContain; }
			set 
			{ 
				_NameContain = value;
				OnPropertyChanged("NameContain");
			}
		}
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
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new SegmentationTypeOrderBy OrderBy
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
		public SegmentationTypeFilter()
		{
		}

		public SegmentationTypeFilter(JToken node) : base(node)
		{
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["kSql"] != null)
			{
				this._KSql = node["kSql"].Value<string>();
			}
			if(node["nameContain"] != null)
			{
				this._NameContain = node["nameContain"].Value<string>();
			}
			if(node["assetUserRuleIdIn"] != null)
			{
				this._AssetUserRuleIdIn = node["assetUserRuleIdIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (SegmentationTypeOrderBy)StringEnum.Parse(typeof(SegmentationTypeOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSegmentationTypeFilter");
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("kSql", this._KSql);
			kparams.AddIfNotNull("nameContain", this._NameContain);
			kparams.AddIfNotNull("assetUserRuleIdIn", this._AssetUserRuleIdIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_IN:
					return "IdIn";
				case KSQL:
					return "KSql";
				case NAME_CONTAIN:
					return "NameContain";
				case ASSET_USER_RULE_ID_IN:
					return "AssetUserRuleIdIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

