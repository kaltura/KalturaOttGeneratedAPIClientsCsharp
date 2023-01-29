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
	public class LiveToVodGetConfigurationRequestBuilder : RequestBuilder<LiveToVodFullConfiguration>
	{
		#region Constants
		#endregion


		public LiveToVodGetConfigurationRequestBuilder()
			: base("livetovod", "getConfiguration")
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
			return ObjectFactory.Create<LiveToVodFullConfiguration>(result);
		}
	}

	public class LiveToVodGetLinearAssetConfigurationRequestBuilder : RequestBuilder<LiveToVodLinearAssetConfiguration>
	{
		#region Constants
		public const string LINEAR_ASSET_ID = "linearAssetId";
		#endregion

		public long LinearAssetId { get; set; }

		public LiveToVodGetLinearAssetConfigurationRequestBuilder()
			: base("livetovod", "getLinearAssetConfiguration")
		{
		}

		public LiveToVodGetLinearAssetConfigurationRequestBuilder(long linearAssetId)
			: this()
		{
			this.LinearAssetId = linearAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("linearAssetId"))
				kparams.AddIfNotNull("linearAssetId", LinearAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveToVodLinearAssetConfiguration>(result);
		}
	}

	public class LiveToVodGetPartnerConfigurationRequestBuilder : RequestBuilder<LiveToVodPartnerConfiguration>
	{
		#region Constants
		#endregion


		public LiveToVodGetPartnerConfigurationRequestBuilder()
			: base("livetovod", "getPartnerConfiguration")
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
			return ObjectFactory.Create<LiveToVodPartnerConfiguration>(result);
		}
	}

	public class LiveToVodUpdateLinearAssetConfigurationRequestBuilder : RequestBuilder<LiveToVodLinearAssetConfiguration>
	{
		#region Constants
		public const string CONFIGURATION = "configuration";
		#endregion

		public LiveToVodLinearAssetConfiguration Configuration { get; set; }

		public LiveToVodUpdateLinearAssetConfigurationRequestBuilder()
			: base("livetovod", "updateLinearAssetConfiguration")
		{
		}

		public LiveToVodUpdateLinearAssetConfigurationRequestBuilder(LiveToVodLinearAssetConfiguration configuration)
			: this()
		{
			this.Configuration = configuration;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("configuration"))
				kparams.AddIfNotNull("configuration", Configuration);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveToVodLinearAssetConfiguration>(result);
		}
	}

	public class LiveToVodUpdatePartnerConfigurationRequestBuilder : RequestBuilder<LiveToVodPartnerConfiguration>
	{
		#region Constants
		public const string CONFIGURATION = "configuration";
		#endregion

		public LiveToVodPartnerConfiguration Configuration { get; set; }

		public LiveToVodUpdatePartnerConfigurationRequestBuilder()
			: base("livetovod", "updatePartnerConfiguration")
		{
		}

		public LiveToVodUpdatePartnerConfigurationRequestBuilder(LiveToVodPartnerConfiguration configuration)
			: this()
		{
			this.Configuration = configuration;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("configuration"))
				kparams.AddIfNotNull("configuration", Configuration);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveToVodPartnerConfiguration>(result);
		}
	}


	public class LiveToVodService
	{
		private LiveToVodService()
		{
		}

		public static LiveToVodGetConfigurationRequestBuilder GetConfiguration()
		{
			return new LiveToVodGetConfigurationRequestBuilder();
		}

		public static LiveToVodGetLinearAssetConfigurationRequestBuilder GetLinearAssetConfiguration(long linearAssetId)
		{
			return new LiveToVodGetLinearAssetConfigurationRequestBuilder(linearAssetId);
		}

		public static LiveToVodGetPartnerConfigurationRequestBuilder GetPartnerConfiguration()
		{
			return new LiveToVodGetPartnerConfigurationRequestBuilder();
		}

		public static LiveToVodUpdateLinearAssetConfigurationRequestBuilder UpdateLinearAssetConfiguration(LiveToVodLinearAssetConfiguration configuration)
		{
			return new LiveToVodUpdateLinearAssetConfigurationRequestBuilder(configuration);
		}

		public static LiveToVodUpdatePartnerConfigurationRequestBuilder UpdatePartnerConfiguration(LiveToVodPartnerConfiguration configuration)
		{
			return new LiveToVodUpdatePartnerConfigurationRequestBuilder(configuration);
		}
	}
}
