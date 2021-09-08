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
	public class Duration : ObjectBase
	{
		#region Constants
		public const string UNIT = "unit";
		public const string VALUE = "value";
		public const string CODE = "code";
		#endregion

		#region Private Fields
		private DurationUnit _Unit = null;
		private int _Value = Int32.MinValue;
		private long _Code = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use UnitAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DurationUnit Unit
		{
			get { return _Unit; }
			set 
			{ 
				_Unit = value;
				OnPropertyChanged("Unit");
			}
		}
		/// <summary>
		/// Use ValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		/// <summary>
		/// Use CodeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Code
		{
			get { return _Code; }
			private set 
			{ 
				_Code = value;
				OnPropertyChanged("Code");
			}
		}
		#endregion

		#region CTor
		public Duration()
		{
		}

		public Duration(JToken node) : base(node)
		{
			if(node["unit"] != null)
			{
				this._Unit = (DurationUnit)StringEnum.Parse(typeof(DurationUnit), node["unit"].Value<string>());
			}
			if(node["value"] != null)
			{
				this._Value = ParseInt(node["value"].Value<string>());
			}
			if(node["code"] != null)
			{
				this._Code = ParseLong(node["code"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDuration");
			kparams.AddIfNotNull("unit", this._Unit);
			kparams.AddIfNotNull("value", this._Value);
			kparams.AddIfNotNull("code", this._Code);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case UNIT:
					return "Unit";
				case VALUE:
					return "Value";
				case CODE:
					return "Code";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

