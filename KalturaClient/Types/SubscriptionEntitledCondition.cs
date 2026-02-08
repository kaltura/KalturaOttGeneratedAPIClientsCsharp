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
	public class SubscriptionEntitledCondition : BaseSegmentCondition
	{
		#region Constants
		public const string LEVEL = "level";
		public const string SUBSCRIPTION_ID_EQUALS = "subscriptionIdEquals";
		#endregion

		#region Private Fields
		private ConditionLevel _Level = null;
		private long _SubscriptionIdEquals = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use LevelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ConditionLevel Level
		{
			get { return _Level; }
			set 
			{ 
				_Level = value;
				OnPropertyChanged("Level");
			}
		}
		/// <summary>
		/// Use SubscriptionIdEqualsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long SubscriptionIdEquals
		{
			get { return _SubscriptionIdEquals; }
			set 
			{ 
				_SubscriptionIdEquals = value;
				OnPropertyChanged("SubscriptionIdEquals");
			}
		}
		#endregion

		#region CTor
		public SubscriptionEntitledCondition()
		{
		}

		public SubscriptionEntitledCondition(JToken node) : base(node)
		{
			if(node["level"] != null)
			{
				this._Level = (ConditionLevel)StringEnum.Parse(typeof(ConditionLevel), node["level"].Value<string>());
			}
			if(node["subscriptionIdEquals"] != null)
			{
				this._SubscriptionIdEquals = ParseLong(node["subscriptionIdEquals"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSubscriptionEntitledCondition");
			kparams.AddIfNotNull("level", this._Level);
			kparams.AddIfNotNull("subscriptionIdEquals", this._SubscriptionIdEquals);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LEVEL:
					return "Level";
				case SUBSCRIPTION_ID_EQUALS:
					return "SubscriptionIdEquals";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

