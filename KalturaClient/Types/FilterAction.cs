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
	public class FilterAction : AssetRuleAction
	{
		#region Constants
		public const string PRE_ACTION_CONDITION = "preActionCondition";
		#endregion

		#region Private Fields
		private BasePreActionCondition _PreActionCondition;
		#endregion

		#region Properties
		/// <summary>
		/// Use PreActionConditionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BasePreActionCondition PreActionCondition
		{
			get { return _PreActionCondition; }
			set 
			{ 
				_PreActionCondition = value;
				OnPropertyChanged("PreActionCondition");
			}
		}
		#endregion

		#region CTor
		public FilterAction()
		{
		}

		public FilterAction(JToken node) : base(node)
		{
			if(node["preActionCondition"] != null)
			{
				this._PreActionCondition = ObjectFactory.Create<BasePreActionCondition>(node["preActionCondition"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFilterAction");
			kparams.AddIfNotNull("preActionCondition", this._PreActionCondition);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PRE_ACTION_CONDITION:
					return "PreActionCondition";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

