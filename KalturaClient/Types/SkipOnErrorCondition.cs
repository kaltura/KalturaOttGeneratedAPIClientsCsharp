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
	public class SkipOnErrorCondition : SkipCondition
	{
		#region Constants
		public const string CONDITION = "condition";
		#endregion

		#region Private Fields
		private SkipOptions _Condition = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ConditionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SkipOptions Condition
		{
			get { return _Condition; }
			set 
			{ 
				_Condition = value;
				OnPropertyChanged("Condition");
			}
		}
		#endregion

		#region CTor
		public SkipOnErrorCondition()
		{
		}

		public SkipOnErrorCondition(JToken node) : base(node)
		{
			if(node["condition"] != null)
			{
				this._Condition = (SkipOptions)StringEnum.Parse(typeof(SkipOptions), node["condition"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSkipOnErrorCondition");
			kparams.AddIfNotNull("condition", this._Condition);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONDITION:
					return "Condition";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

