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
	public class AssetUserRuleFilter : Filter
	{
		#region Constants
		public const string ATTACHED_USER_ID_EQUAL_CURRENT = "attachedUserIdEqualCurrent";
		public const string ACTIONS_CONTAIN_TYPE = "actionsContainType";
		public const string CONDITIONS_CONTAIN_TYPE = "conditionsContainType";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private bool? _AttachedUserIdEqualCurrent = null;
		private RuleActionType _ActionsContainType = null;
		private RuleConditionType _ConditionsContainType = null;
		private AssetUserRuleOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AttachedUserIdEqualCurrentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AttachedUserIdEqualCurrent
		{
			get { return _AttachedUserIdEqualCurrent; }
			set 
			{ 
				_AttachedUserIdEqualCurrent = value;
				OnPropertyChanged("AttachedUserIdEqualCurrent");
			}
		}
		/// <summary>
		/// Use ActionsContainTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RuleActionType ActionsContainType
		{
			get { return _ActionsContainType; }
			set 
			{ 
				_ActionsContainType = value;
				OnPropertyChanged("ActionsContainType");
			}
		}
		/// <summary>
		/// Use ConditionsContainTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RuleConditionType ConditionsContainType
		{
			get { return _ConditionsContainType; }
			set 
			{ 
				_ConditionsContainType = value;
				OnPropertyChanged("ConditionsContainType");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new AssetUserRuleOrderBy OrderBy
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
		public AssetUserRuleFilter()
		{
		}

		public AssetUserRuleFilter(JToken node) : base(node)
		{
			if(node["attachedUserIdEqualCurrent"] != null)
			{
				this._AttachedUserIdEqualCurrent = ParseBool(node["attachedUserIdEqualCurrent"].Value<string>());
			}
			if(node["actionsContainType"] != null)
			{
				this._ActionsContainType = (RuleActionType)StringEnum.Parse(typeof(RuleActionType), node["actionsContainType"].Value<string>());
			}
			if(node["conditionsContainType"] != null)
			{
				this._ConditionsContainType = (RuleConditionType)StringEnum.Parse(typeof(RuleConditionType), node["conditionsContainType"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (AssetUserRuleOrderBy)StringEnum.Parse(typeof(AssetUserRuleOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetUserRuleFilter");
			kparams.AddIfNotNull("attachedUserIdEqualCurrent", this._AttachedUserIdEqualCurrent);
			kparams.AddIfNotNull("actionsContainType", this._ActionsContainType);
			kparams.AddIfNotNull("conditionsContainType", this._ConditionsContainType);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ATTACHED_USER_ID_EQUAL_CURRENT:
					return "AttachedUserIdEqualCurrent";
				case ACTIONS_CONTAIN_TYPE:
					return "ActionsContainType";
				case CONDITIONS_CONTAIN_TYPE:
					return "ConditionsContainType";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

