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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class UserSessionProfileAddRequestBuilder : RequestBuilder<UserSessionProfile>
	{
		#region Constants
		public const string USER_SESSION_PROFILE = "userSessionProfile";
		#endregion

		public UserSessionProfile UserSessionProfile { get; set; }

		public UserSessionProfileAddRequestBuilder()
			: base("usersessionprofile", "add")
		{
		}

		public UserSessionProfileAddRequestBuilder(UserSessionProfile userSessionProfile)
			: this()
		{
			this.UserSessionProfile = userSessionProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userSessionProfile"))
				kparams.AddIfNotNull("userSessionProfile", UserSessionProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<UserSessionProfile>(result);
		}
	}

	public class UserSessionProfileDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public UserSessionProfileDeleteRequestBuilder()
			: base("usersessionprofile", "delete")
		{
		}

		public UserSessionProfileDeleteRequestBuilder(long id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class UserSessionProfileListRequestBuilder : RequestBuilder<ListResponse<UserSessionProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public UserSessionProfileFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public UserSessionProfileListRequestBuilder()
			: base("usersessionprofile", "list")
		{
		}

		public UserSessionProfileListRequestBuilder(UserSessionProfileFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<UserSessionProfile>>(result);
		}
	}

	public class UserSessionProfileUpdateRequestBuilder : RequestBuilder<UserSessionProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string USER_SESSION_PROFILE = "userSessionProfile";
		#endregion

		public long Id { get; set; }
		public UserSessionProfile UserSessionProfile { get; set; }

		public UserSessionProfileUpdateRequestBuilder()
			: base("usersessionprofile", "update")
		{
		}

		public UserSessionProfileUpdateRequestBuilder(long id, UserSessionProfile userSessionProfile)
			: this()
		{
			this.Id = id;
			this.UserSessionProfile = userSessionProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("userSessionProfile"))
				kparams.AddIfNotNull("userSessionProfile", UserSessionProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<UserSessionProfile>(result);
		}
	}


	public class UserSessionProfileService
	{
		private UserSessionProfileService()
		{
		}

		public static UserSessionProfileAddRequestBuilder Add(UserSessionProfile userSessionProfile)
		{
			return new UserSessionProfileAddRequestBuilder(userSessionProfile);
		}

		public static UserSessionProfileDeleteRequestBuilder Delete(long id)
		{
			return new UserSessionProfileDeleteRequestBuilder(id);
		}

		public static UserSessionProfileListRequestBuilder List(UserSessionProfileFilter filter = null, FilterPager pager = null)
		{
			return new UserSessionProfileListRequestBuilder(filter, pager);
		}

		public static UserSessionProfileUpdateRequestBuilder Update(long id, UserSessionProfile userSessionProfile)
		{
			return new UserSessionProfileUpdateRequestBuilder(id, userSessionProfile);
		}
	}
}
