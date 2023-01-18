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
	public class TriggerCampaignEvent : EventObject
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string CAMPAIGN_ID = "campaignId";
		public const string UDID = "udid";
		public const string HOUSEHOLD_ID = "householdId";
		#endregion

		#region Private Fields
		private long _UserId = long.MinValue;
		private long _CampaignId = long.MinValue;
		private string _Udid = null;
		private long _HouseholdId = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use UserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long UserId
		{
			get { return _UserId; }
			private set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		/// <summary>
		/// Use CampaignIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CampaignId
		{
			get { return _CampaignId; }
			private set 
			{ 
				_CampaignId = value;
				OnPropertyChanged("CampaignId");
			}
		}
		/// <summary>
		/// Use UdidAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Udid
		{
			get { return _Udid; }
			private set 
			{ 
				_Udid = value;
				OnPropertyChanged("Udid");
			}
		}
		/// <summary>
		/// Use HouseholdIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long HouseholdId
		{
			get { return _HouseholdId; }
			private set 
			{ 
				_HouseholdId = value;
				OnPropertyChanged("HouseholdId");
			}
		}
		#endregion

		#region CTor
		public TriggerCampaignEvent()
		{
		}

		public TriggerCampaignEvent(JToken node) : base(node)
		{
			if(node["userId"] != null)
			{
				this._UserId = ParseLong(node["userId"].Value<string>());
			}
			if(node["campaignId"] != null)
			{
				this._CampaignId = ParseLong(node["campaignId"].Value<string>());
			}
			if(node["udid"] != null)
			{
				this._Udid = node["udid"].Value<string>();
			}
			if(node["householdId"] != null)
			{
				this._HouseholdId = ParseLong(node["householdId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTriggerCampaignEvent");
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("campaignId", this._CampaignId);
			kparams.AddIfNotNull("udid", this._Udid);
			kparams.AddIfNotNull("householdId", this._HouseholdId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID:
					return "UserId";
				case CAMPAIGN_ID:
					return "CampaignId";
				case UDID:
					return "Udid";
				case HOUSEHOLD_ID:
					return "HouseholdId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

