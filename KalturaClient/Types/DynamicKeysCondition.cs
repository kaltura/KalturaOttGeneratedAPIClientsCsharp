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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class DynamicKeysCondition : Condition
	{
		#region Constants
		public const string KEY_VALUES = "keyValues";
		#endregion

		#region Private Fields
		private IDictionary<string, StringValueArray> _KeyValues;
		#endregion

		#region Properties
		/// <summary>
		/// Use KeyValuesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IDictionary<string, StringValueArray> KeyValues
		{
			get { return _KeyValues; }
			set 
			{ 
				_KeyValues = value;
				OnPropertyChanged("KeyValues");
			}
		}
		#endregion

		#region CTor
		public DynamicKeysCondition()
		{
		}

		public DynamicKeysCondition(JToken node) : base(node)
		{
			if(node["keyValues"] != null)
			{
				{
					string key;
					this._KeyValues = new Dictionary<string, StringValueArray>();
					foreach(var arrayNode in node["keyValues"].Children<JProperty>())
					{
						key = arrayNode.Name;
						this._KeyValues[key] = ObjectFactory.Create<StringValueArray>(arrayNode.Value);
					}
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDynamicKeysCondition");
			kparams.AddIfNotNull("keyValues", this._KeyValues);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEY_VALUES:
					return "KeyValues";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

