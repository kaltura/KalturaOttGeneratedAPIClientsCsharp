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
// Copyright (C) 2006-2018  Kaltura Inc.
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

namespace Kaltura.Types
{
	public class AssetRuleFilter : Filter
	{
		#region Constants
		public const string CONDITIONS_CONTAIN_TYPE = "conditionsContainType";
		public const string ASSET_APPLIED = "assetApplied";
		public const string ACTIONS_CONTAIN_TYPE = "actionsContainType";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private RuleConditionType _ConditionsContainType = null;
		private SlimAsset _AssetApplied;
		private RuleActionType _ActionsContainType = null;
		private AssetRuleOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public RuleConditionType ConditionsContainType
		{
			get { return _ConditionsContainType; }
			set 
			{ 
				_ConditionsContainType = value;
				OnPropertyChanged("ConditionsContainType");
			}
		}
		public SlimAsset AssetApplied
		{
			get { return _AssetApplied; }
			set 
			{ 
				_AssetApplied = value;
				OnPropertyChanged("AssetApplied");
			}
		}
		public RuleActionType ActionsContainType
		{
			get { return _ActionsContainType; }
			set 
			{ 
				_ActionsContainType = value;
				OnPropertyChanged("ActionsContainType");
			}
		}
		public new AssetRuleOrderBy OrderBy
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
		public AssetRuleFilter()
		{
		}

		public AssetRuleFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "conditionsContainType":
						this._ConditionsContainType = (RuleConditionType)StringEnum.Parse(typeof(RuleConditionType), propertyNode.InnerText);
						continue;
					case "assetApplied":
						this._AssetApplied = ObjectFactory.Create<SlimAsset>(propertyNode);
						continue;
					case "actionsContainType":
						this._ActionsContainType = (RuleActionType)StringEnum.Parse(typeof(RuleActionType), propertyNode.InnerText);
						continue;
					case "orderBy":
						this._OrderBy = (AssetRuleOrderBy)StringEnum.Parse(typeof(AssetRuleOrderBy), propertyNode.InnerText);
						continue;
				}
			}
		}

		public AssetRuleFilter(IDictionary<string,object> data) : base(data)
		{
			    this._ConditionsContainType = (RuleConditionType)StringEnum.Parse(typeof(RuleConditionType), data.TryGetValueSafe<string>("conditionsContainType"));
			    this._AssetApplied = ObjectFactory.Create<SlimAsset>(data.TryGetValueSafe<IDictionary<string,object>>("assetApplied"));
			    this._ActionsContainType = (RuleActionType)StringEnum.Parse(typeof(RuleActionType), data.TryGetValueSafe<string>("actionsContainType"));
			    this._OrderBy = (AssetRuleOrderBy)StringEnum.Parse(typeof(AssetRuleOrderBy), data.TryGetValueSafe<string>("orderBy"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetRuleFilter");
			kparams.AddIfNotNull("conditionsContainType", this._ConditionsContainType);
			kparams.AddIfNotNull("assetApplied", this._AssetApplied);
			kparams.AddIfNotNull("actionsContainType", this._ActionsContainType);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONDITIONS_CONTAIN_TYPE:
					return "ConditionsContainType";
				case ASSET_APPLIED:
					return "AssetApplied";
				case ACTIONS_CONTAIN_TYPE:
					return "ActionsContainType";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

