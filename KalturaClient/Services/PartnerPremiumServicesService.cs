// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
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
	public class PartnerPremiumServicesGetRequestBuilder : RequestBuilder<PartnerPremiumServices>
	{
		#region Constants
		#endregion


		public PartnerPremiumServicesGetRequestBuilder()
			: base("partnerpremiumservices", "get")
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
			return ObjectFactory.Create<PartnerPremiumServices>(result);
		}
	}

	public class PartnerPremiumServicesUpdateRequestBuilder : RequestBuilder<PartnerPremiumServices>
	{
		#region Constants
		public const string PARTNER_PREMIUM_SERVICES = "partnerPremiumServices";
		#endregion

		public PartnerPremiumServices PartnerPremiumServices { get; set; }

		public PartnerPremiumServicesUpdateRequestBuilder()
			: base("partnerpremiumservices", "update")
		{
		}

		public PartnerPremiumServicesUpdateRequestBuilder(PartnerPremiumServices partnerPremiumServices)
			: this()
		{
			this.PartnerPremiumServices = partnerPremiumServices;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerPremiumServices"))
				kparams.AddIfNotNull("partnerPremiumServices", PartnerPremiumServices);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PartnerPremiumServices>(result);
		}
	}


	public class PartnerPremiumServicesService
	{
		private PartnerPremiumServicesService()
		{
		}

		public static PartnerPremiumServicesGetRequestBuilder Get()
		{
			return new PartnerPremiumServicesGetRequestBuilder();
		}

		public static PartnerPremiumServicesUpdateRequestBuilder Update(PartnerPremiumServices partnerPremiumServices)
		{
			return new PartnerPremiumServicesUpdateRequestBuilder(partnerPremiumServices);
		}
	}
}
