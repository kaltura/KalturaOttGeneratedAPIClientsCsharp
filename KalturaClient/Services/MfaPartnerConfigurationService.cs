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
	public class MfaPartnerConfigurationGetRequestBuilder : RequestBuilder<MultifactorAuthenticationPartnerConfiguration>
	{
		#region Constants
		#endregion


		public MfaPartnerConfigurationGetRequestBuilder()
			: base("mfapartnerconfiguration", "get")
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
			return ObjectFactory.Create<MultifactorAuthenticationPartnerConfiguration>(result);
		}
	}

	public class MfaPartnerConfigurationUpdateRequestBuilder : RequestBuilder<MultifactorAuthenticationPartnerConfiguration>
	{
		#region Constants
		public const string CONFIGURATION = "configuration";
		#endregion

		public MultifactorAuthenticationPartnerConfiguration Configuration { get; set; }

		public MfaPartnerConfigurationUpdateRequestBuilder()
			: base("mfapartnerconfiguration", "update")
		{
		}

		public MfaPartnerConfigurationUpdateRequestBuilder(MultifactorAuthenticationPartnerConfiguration configuration)
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
			return ObjectFactory.Create<MultifactorAuthenticationPartnerConfiguration>(result);
		}
	}


	public class MfaPartnerConfigurationService
	{
		private MfaPartnerConfigurationService()
		{
		}

		public static MfaPartnerConfigurationGetRequestBuilder Get()
		{
			return new MfaPartnerConfigurationGetRequestBuilder();
		}

		public static MfaPartnerConfigurationUpdateRequestBuilder Update(MultifactorAuthenticationPartnerConfiguration configuration)
		{
			return new MfaPartnerConfigurationUpdateRequestBuilder(configuration);
		}
	}
}
