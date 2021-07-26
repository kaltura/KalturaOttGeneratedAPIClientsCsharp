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
	public class DynamicData : ObjectBase
	{
		#region Constants
		public const string KEY = "key";
		public const string VALUE = "value";
		#endregion

		#region Private Fields
		private string _Key = null;
		private Value _Value;
		#endregion

		#region Properties
		[JsonProperty]
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		[JsonProperty]
		public Value Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		#endregion

		#region CTor
		public DynamicData()
		{
		}

		public DynamicData(JToken node) : base(node)
		{
			if(node["key"] != null)
			{
				this._Key = node["key"].Value<string>();
			}
			if(node["value"] != null)
			{
				this._Value = ObjectFactory.Create<Value>(node["value"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDynamicData");
			kparams.AddIfNotNull("key", this._Key);
			kparams.AddIfNotNull("value", this._Value);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEY:
					return "Key";
				case VALUE:
					return "Value";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

