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
	public class AssetLifeCycleTransitionAction : AssetRuleAction
	{
		#region Constants
		public const string ASSET_LIFE_CYCLE_RULE_ACTION_TYPE = "assetLifeCycleRuleActionType";
		public const string ASSET_LIFE_CYCLE_RULE_TRANSITION_TYPE = "assetLifeCycleRuleTransitionType";
		#endregion

		#region Private Fields
		private AssetLifeCycleRuleActionType _AssetLifeCycleRuleActionType = null;
		private AssetLifeCycleRuleTransitionType _AssetLifeCycleRuleTransitionType = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetLifeCycleRuleActionTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetLifeCycleRuleActionType AssetLifeCycleRuleActionType
		{
			get { return _AssetLifeCycleRuleActionType; }
			set 
			{ 
				_AssetLifeCycleRuleActionType = value;
				OnPropertyChanged("AssetLifeCycleRuleActionType");
			}
		}
		/// <summary>
		/// Use AssetLifeCycleRuleTransitionTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetLifeCycleRuleTransitionType AssetLifeCycleRuleTransitionType
		{
			get { return _AssetLifeCycleRuleTransitionType; }
			private set 
			{ 
				_AssetLifeCycleRuleTransitionType = value;
				OnPropertyChanged("AssetLifeCycleRuleTransitionType");
			}
		}
		#endregion

		#region CTor
		public AssetLifeCycleTransitionAction()
		{
		}

		public AssetLifeCycleTransitionAction(JToken node) : base(node)
		{
			if(node["assetLifeCycleRuleActionType"] != null)
			{
				this._AssetLifeCycleRuleActionType = (AssetLifeCycleRuleActionType)StringEnum.Parse(typeof(AssetLifeCycleRuleActionType), node["assetLifeCycleRuleActionType"].Value<string>());
			}
			if(node["assetLifeCycleRuleTransitionType"] != null)
			{
				this._AssetLifeCycleRuleTransitionType = (AssetLifeCycleRuleTransitionType)StringEnum.Parse(typeof(AssetLifeCycleRuleTransitionType), node["assetLifeCycleRuleTransitionType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetLifeCycleTransitionAction");
			kparams.AddIfNotNull("assetLifeCycleRuleActionType", this._AssetLifeCycleRuleActionType);
			kparams.AddIfNotNull("assetLifeCycleRuleTransitionType", this._AssetLifeCycleRuleTransitionType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_LIFE_CYCLE_RULE_ACTION_TYPE:
					return "AssetLifeCycleRuleActionType";
				case ASSET_LIFE_CYCLE_RULE_TRANSITION_TYPE:
					return "AssetLifeCycleRuleTransitionType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

