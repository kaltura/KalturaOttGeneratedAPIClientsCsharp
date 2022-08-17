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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class SessionCreateSessionCharacteristicRequestBuilder : RequestBuilder<SessionCharacteristic>
	{
		#region Constants
		public new const string USER_ID = "userId";
		public const string HOUSEHOLD_ID = "householdId";
		public const string UDID = "udid";
		public const string EXPIRATION = "expiration";
		public const string REGION_ID = "regionId";
		public const string SESSION_CHARACTERISTIC_PARAMS = "sessionCharacteristicParams";
		#endregion

		public new string UserId { get; set; }
		public long HouseholdId { get; set; }
		public string Udid { get; set; }
		public long Expiration { get; set; }
		public int RegionId { get; set; }
		public IDictionary<string, StringValueArray> SessionCharacteristicParams { get; set; }

		public SessionCreateSessionCharacteristicRequestBuilder()
			: base("session", "createSessionCharacteristic")
		{
		}

		public SessionCreateSessionCharacteristicRequestBuilder(string userId, long householdId, string udid, long expiration, int regionId, IDictionary<string, StringValueArray> sessionCharacteristicParams)
			: this()
		{
			this.UserId = userId;
			this.HouseholdId = householdId;
			this.Udid = udid;
			this.Expiration = expiration;
			this.RegionId = regionId;
			this.SessionCharacteristicParams = sessionCharacteristicParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("householdId"))
				kparams.AddIfNotNull("householdId", HouseholdId);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			if (!isMapped("expiration"))
				kparams.AddIfNotNull("expiration", Expiration);
			if (!isMapped("regionId"))
				kparams.AddIfNotNull("regionId", RegionId);
			if (!isMapped("sessionCharacteristicParams"))
				kparams.AddIfNotNull("sessionCharacteristicParams", SessionCharacteristicParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SessionCharacteristic>(result);
		}
	}

	public class SessionGetRequestBuilder : RequestBuilder<Session>
	{
		#region Constants
		public const string SESSION = "session";
		#endregion

		public string Session { get; set; }

		public SessionGetRequestBuilder()
			: base("session", "get")
		{
		}

		public SessionGetRequestBuilder(string session)
			: this()
		{
			this.Session = session;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("session"))
				kparams.AddIfNotNull("session", Session);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Session>(result);
		}
	}

	public class SessionRevokeRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		#endregion


		public SessionRevokeRequestBuilder()
			: base("session", "revoke")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class SessionSwitchUserRequestBuilder : RequestBuilder<LoginSession>
	{
		#region Constants
		public const string USER_ID_TO_SWITCH = "userIdToSwitch";
		#endregion

		public string UserIdToSwitch { get; set; }

		public SessionSwitchUserRequestBuilder()
			: base("session", "switchUser")
		{
		}

		public SessionSwitchUserRequestBuilder(string userIdToSwitch)
			: this()
		{
			this.UserIdToSwitch = userIdToSwitch;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userIdToSwitch"))
				kparams.AddIfNotNull("userIdToSwitch", UserIdToSwitch);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LoginSession>(result);
		}
	}


	public class SessionService
	{
		private SessionService()
		{
		}

		public static SessionCreateSessionCharacteristicRequestBuilder CreateSessionCharacteristic(string userId, long householdId, string udid, long expiration, int regionId = Int32.MinValue, IDictionary<string, StringValueArray> sessionCharacteristicParams = null)
		{
			return new SessionCreateSessionCharacteristicRequestBuilder(userId, householdId, udid, expiration, regionId, sessionCharacteristicParams);
		}

		public static SessionGetRequestBuilder Get(string session = null)
		{
			return new SessionGetRequestBuilder(session);
		}

		public static SessionRevokeRequestBuilder Revoke()
		{
			return new SessionRevokeRequestBuilder();
		}

		public static SessionSwitchUserRequestBuilder SwitchUser(string userIdToSwitch)
		{
			return new SessionSwitchUserRequestBuilder(userIdToSwitch);
		}
	}
}
