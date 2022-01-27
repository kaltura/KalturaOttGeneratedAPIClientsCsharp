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
	public class SessionCharacteristic : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string REGION_ID = "regionId";
		public const string USER_SEGMENTS_IDS = "userSegmentsIds";
		public const string USER_ROLES_IDS = "userRolesIds";
		public const string USER_SESSION_PROFILES_IDS = "userSessionProfilesIds";
		#endregion

		#region Private Fields
		private string _Id = null;
		private int _RegionId = Int32.MinValue;
		private string _UserSegmentsIds = null;
		private string _UserRolesIds = null;
		private string _UserSessionProfilesIds = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use RegionIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RegionId
		{
			get { return _RegionId; }
			private set 
			{ 
				_RegionId = value;
				OnPropertyChanged("RegionId");
			}
		}
		/// <summary>
		/// Use UserSegmentsIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserSegmentsIds
		{
			get { return _UserSegmentsIds; }
			private set 
			{ 
				_UserSegmentsIds = value;
				OnPropertyChanged("UserSegmentsIds");
			}
		}
		/// <summary>
		/// Use UserRolesIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserRolesIds
		{
			get { return _UserRolesIds; }
			private set 
			{ 
				_UserRolesIds = value;
				OnPropertyChanged("UserRolesIds");
			}
		}
		/// <summary>
		/// Use UserSessionProfilesIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserSessionProfilesIds
		{
			get { return _UserSessionProfilesIds; }
			private set 
			{ 
				_UserSessionProfilesIds = value;
				OnPropertyChanged("UserSessionProfilesIds");
			}
		}
		#endregion

		#region CTor
		public SessionCharacteristic()
		{
		}

		public SessionCharacteristic(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["regionId"] != null)
			{
				this._RegionId = ParseInt(node["regionId"].Value<string>());
			}
			if(node["userSegmentsIds"] != null)
			{
				this._UserSegmentsIds = node["userSegmentsIds"].Value<string>();
			}
			if(node["userRolesIds"] != null)
			{
				this._UserRolesIds = node["userRolesIds"].Value<string>();
			}
			if(node["userSessionProfilesIds"] != null)
			{
				this._UserSessionProfilesIds = node["userSessionProfilesIds"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSessionCharacteristic");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("regionId", this._RegionId);
			kparams.AddIfNotNull("userSegmentsIds", this._UserSegmentsIds);
			kparams.AddIfNotNull("userRolesIds", this._UserRolesIds);
			kparams.AddIfNotNull("userSessionProfilesIds", this._UserSessionProfilesIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case REGION_ID:
					return "RegionId";
				case USER_SEGMENTS_IDS:
					return "UserSegmentsIds";
				case USER_ROLES_IDS:
					return "UserRolesIds";
				case USER_SESSION_PROFILES_IDS:
					return "UserSessionProfilesIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

