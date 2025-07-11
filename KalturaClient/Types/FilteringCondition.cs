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
	public class FilteringCondition : ObjectBase
	{
		#region Constants
		public const string META_NAME = "metaName";
		public const string OPERATOR = "operator";
		public const string VALUE = "value";
		#endregion

		#region Private Fields
		private string _MetaName = null;
		private ConditionOperator _Operator = null;
		private string _Value = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use MetaNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MetaName
		{
			get { return _MetaName; }
			set 
			{ 
				_MetaName = value;
				OnPropertyChanged("MetaName");
			}
		}
		/// <summary>
		/// Use OperatorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ConditionOperator Operator
		{
			get { return _Operator; }
			set 
			{ 
				_Operator = value;
				OnPropertyChanged("Operator");
			}
		}
		/// <summary>
		/// Use ValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Value
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
		public FilteringCondition()
		{
		}

		public FilteringCondition(JToken node) : base(node)
		{
			if(node["metaName"] != null)
			{
				this._MetaName = node["metaName"].Value<string>();
			}
			if(node["operator"] != null)
			{
				this._Operator = (ConditionOperator)StringEnum.Parse(typeof(ConditionOperator), node["operator"].Value<string>());
			}
			if(node["value"] != null)
			{
				this._Value = node["value"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFilteringCondition");
			kparams.AddIfNotNull("metaName", this._MetaName);
			kparams.AddIfNotNull("operator", this._Operator);
			kparams.AddIfNotNull("value", this._Value);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case META_NAME:
					return "MetaName";
				case OPERATOR:
					return "Operator";
				case VALUE:
					return "Value";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

