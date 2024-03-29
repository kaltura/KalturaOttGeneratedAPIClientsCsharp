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
	public class PasswordPolicyFilter : Filter
	{
		#region Constants
		public const string USER_ROLE_ID_IN = "userRoleIdIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _UserRoleIdIn = null;
		private PasswordPolicyOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use UserRoleIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserRoleIdIn
		{
			get { return _UserRoleIdIn; }
			set 
			{ 
				_UserRoleIdIn = value;
				OnPropertyChanged("UserRoleIdIn");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new PasswordPolicyOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public PasswordPolicyFilter()
		{
		}

		public PasswordPolicyFilter(JToken node) : base(node)
		{
			if(node["userRoleIdIn"] != null)
			{
				this._UserRoleIdIn = node["userRoleIdIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (PasswordPolicyOrderBy)StringEnum.Parse(typeof(PasswordPolicyOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPasswordPolicyFilter");
			kparams.AddIfNotNull("userRoleIdIn", this._UserRoleIdIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ROLE_ID_IN:
					return "UserRoleIdIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

