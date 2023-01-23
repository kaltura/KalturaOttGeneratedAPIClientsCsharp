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
	public class PermissionItemByApiActionFilter : PermissionItemFilter
	{
		#region Constants
		public const string SERVICE_EQUAL = "serviceEqual";
		public const string ACTION_EQUAL = "actionEqual";
		#endregion

		#region Private Fields
		private string _ServiceEqual = null;
		private string _ActionEqual = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ServiceEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServiceEqual
		{
			get { return _ServiceEqual; }
			set 
			{ 
				_ServiceEqual = value;
				OnPropertyChanged("ServiceEqual");
			}
		}
		/// <summary>
		/// Use ActionEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ActionEqual
		{
			get { return _ActionEqual; }
			set 
			{ 
				_ActionEqual = value;
				OnPropertyChanged("ActionEqual");
			}
		}
		#endregion

		#region CTor
		public PermissionItemByApiActionFilter()
		{
		}

		public PermissionItemByApiActionFilter(JToken node) : base(node)
		{
			if(node["serviceEqual"] != null)
			{
				this._ServiceEqual = node["serviceEqual"].Value<string>();
			}
			if(node["actionEqual"] != null)
			{
				this._ActionEqual = node["actionEqual"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPermissionItemByApiActionFilter");
			kparams.AddIfNotNull("serviceEqual", this._ServiceEqual);
			kparams.AddIfNotNull("actionEqual", this._ActionEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SERVICE_EQUAL:
					return "ServiceEqual";
				case ACTION_EQUAL:
					return "ActionEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

