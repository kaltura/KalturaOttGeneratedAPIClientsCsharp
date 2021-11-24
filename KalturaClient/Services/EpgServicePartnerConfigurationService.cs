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
	public class EpgServicePartnerConfigurationGetRequestBuilder : RequestBuilder<EpgServicePartnerConfiguration>
	{
		#region Constants
		#endregion


		public EpgServicePartnerConfigurationGetRequestBuilder()
			: base("epgservicepartnerconfiguration", "get")
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
			return ObjectFactory.Create<EpgServicePartnerConfiguration>(result);
		}
	}

	public class EpgServicePartnerConfigurationUpdateRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string CONFIG = "config";
		#endregion

		public EpgServicePartnerConfiguration Config { get; set; }

		public EpgServicePartnerConfigurationUpdateRequestBuilder()
			: base("epgservicepartnerconfiguration", "update")
		{
		}

		public EpgServicePartnerConfigurationUpdateRequestBuilder(EpgServicePartnerConfiguration config)
			: this()
		{
			this.Config = config;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("config"))
				kparams.AddIfNotNull("config", Config);
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


	public class EpgServicePartnerConfigurationService
	{
		private EpgServicePartnerConfigurationService()
		{
		}

		public static EpgServicePartnerConfigurationGetRequestBuilder Get()
		{
			return new EpgServicePartnerConfigurationGetRequestBuilder();
		}

		public static EpgServicePartnerConfigurationUpdateRequestBuilder Update(EpgServicePartnerConfiguration config)
		{
			return new EpgServicePartnerConfigurationUpdateRequestBuilder(config);
		}
	}
}