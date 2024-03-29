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
	public class PermissionItemByParameterFilter : PermissionItemFilter
	{
		#region Constants
		public const string PARAMETER_EQUAL = "parameterEqual";
		public const string OBJECT_EQUAL = "objectEqual";
		#endregion

		#region Private Fields
		private string _ParameterEqual = null;
		private string _ObjectEqual = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ParameterEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParameterEqual
		{
			get { return _ParameterEqual; }
			set 
			{ 
				_ParameterEqual = value;
				OnPropertyChanged("ParameterEqual");
			}
		}
		/// <summary>
		/// Use ObjectEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectEqual
		{
			get { return _ObjectEqual; }
			set 
			{ 
				_ObjectEqual = value;
				OnPropertyChanged("ObjectEqual");
			}
		}
		#endregion

		#region CTor
		public PermissionItemByParameterFilter()
		{
		}

		public PermissionItemByParameterFilter(JToken node) : base(node)
		{
			if(node["parameterEqual"] != null)
			{
				this._ParameterEqual = node["parameterEqual"].Value<string>();
			}
			if(node["objectEqual"] != null)
			{
				this._ObjectEqual = node["objectEqual"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPermissionItemByParameterFilter");
			kparams.AddIfNotNull("parameterEqual", this._ParameterEqual);
			kparams.AddIfNotNull("objectEqual", this._ObjectEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARAMETER_EQUAL:
					return "ParameterEqual";
				case OBJECT_EQUAL:
					return "ObjectEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

