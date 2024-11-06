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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class WatchBasedRecommendationsProfileAddRequestBuilder : RequestBuilder<WatchBasedRecommendationsProfile>
	{
		#region Constants
		public const string PROFILE = "profile";
		#endregion

		public WatchBasedRecommendationsProfile Profile { get; set; }

		public WatchBasedRecommendationsProfileAddRequestBuilder()
			: base("watchbasedrecommendationsprofile", "add")
		{
		}

		public WatchBasedRecommendationsProfileAddRequestBuilder(WatchBasedRecommendationsProfile profile)
			: this()
		{
			this.Profile = profile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("profile"))
				kparams.AddIfNotNull("profile", Profile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<WatchBasedRecommendationsProfile>(result);
		}
	}

	public class WatchBasedRecommendationsProfileDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public WatchBasedRecommendationsProfileDeleteRequestBuilder()
			: base("watchbasedrecommendationsprofile", "delete")
		{
		}

		public WatchBasedRecommendationsProfileDeleteRequestBuilder(long id)
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

	public class WatchBasedRecommendationsProfileListRequestBuilder : RequestBuilder<ListResponse<WatchBasedRecommendationsProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public WatchBasedRecommendationsProfileFilter Filter { get; set; }

		public WatchBasedRecommendationsProfileListRequestBuilder()
			: base("watchbasedrecommendationsprofile", "list")
		{
		}

		public WatchBasedRecommendationsProfileListRequestBuilder(WatchBasedRecommendationsProfileFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<WatchBasedRecommendationsProfile>>(result);
		}
	}

	public class WatchBasedRecommendationsProfileUpdateRequestBuilder : RequestBuilder<WatchBasedRecommendationsProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string PROFILE = "profile";
		#endregion

		public long Id { get; set; }
		public WatchBasedRecommendationsProfile Profile { get; set; }

		public WatchBasedRecommendationsProfileUpdateRequestBuilder()
			: base("watchbasedrecommendationsprofile", "update")
		{
		}

		public WatchBasedRecommendationsProfileUpdateRequestBuilder(long id, WatchBasedRecommendationsProfile profile)
			: this()
		{
			this.Id = id;
			this.Profile = profile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("profile"))
				kparams.AddIfNotNull("profile", Profile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<WatchBasedRecommendationsProfile>(result);
		}
	}


	public class WatchBasedRecommendationsProfileService
	{
		private WatchBasedRecommendationsProfileService()
		{
		}

		public static WatchBasedRecommendationsProfileAddRequestBuilder Add(WatchBasedRecommendationsProfile profile)
		{
			return new WatchBasedRecommendationsProfileAddRequestBuilder(profile);
		}

		public static WatchBasedRecommendationsProfileDeleteRequestBuilder Delete(long id)
		{
			return new WatchBasedRecommendationsProfileDeleteRequestBuilder(id);
		}

		public static WatchBasedRecommendationsProfileListRequestBuilder List(WatchBasedRecommendationsProfileFilter filter = null)
		{
			return new WatchBasedRecommendationsProfileListRequestBuilder(filter);
		}

		public static WatchBasedRecommendationsProfileUpdateRequestBuilder Update(long id, WatchBasedRecommendationsProfile profile)
		{
			return new WatchBasedRecommendationsProfileUpdateRequestBuilder(id, profile);
		}
	}
}
