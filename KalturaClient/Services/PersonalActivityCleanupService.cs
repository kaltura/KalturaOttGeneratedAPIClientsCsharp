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
	public class PersonalActivityCleanupGetPartnerConfigurationRequestBuilder : RequestBuilder<PersonalActivityCleanupConfiguration>
	{
		#region Constants
		#endregion


		public PersonalActivityCleanupGetPartnerConfigurationRequestBuilder()
			: base("personalactivitycleanup", "getPartnerConfiguration")
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
			return ObjectFactory.Create<PersonalActivityCleanupConfiguration>(result);
		}
	}

	public class PersonalActivityCleanupUpdatePartnerConfigurationRequestBuilder : RequestBuilder<PersonalActivityCleanupConfiguration>
	{
		#region Constants
		public const string PERSONAL_ACTIVITY_CLEANUP_CONFIGURATION = "personalActivityCleanupConfiguration";
		#endregion

		public PersonalActivityCleanupConfiguration PersonalActivityCleanupConfiguration { get; set; }

		public PersonalActivityCleanupUpdatePartnerConfigurationRequestBuilder()
			: base("personalactivitycleanup", "updatePartnerConfiguration")
		{
		}

		public PersonalActivityCleanupUpdatePartnerConfigurationRequestBuilder(PersonalActivityCleanupConfiguration personalActivityCleanupConfiguration)
			: this()
		{
			this.PersonalActivityCleanupConfiguration = personalActivityCleanupConfiguration;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("personalActivityCleanupConfiguration"))
				kparams.AddIfNotNull("personalActivityCleanupConfiguration", PersonalActivityCleanupConfiguration);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PersonalActivityCleanupConfiguration>(result);
		}
	}


	public class PersonalActivityCleanupService
	{
		private PersonalActivityCleanupService()
		{
		}

		public static PersonalActivityCleanupGetPartnerConfigurationRequestBuilder GetPartnerConfiguration()
		{
			return new PersonalActivityCleanupGetPartnerConfigurationRequestBuilder();
		}

		public static PersonalActivityCleanupUpdatePartnerConfigurationRequestBuilder UpdatePartnerConfiguration(PersonalActivityCleanupConfiguration personalActivityCleanupConfiguration)
		{
			return new PersonalActivityCleanupUpdatePartnerConfigurationRequestBuilder(personalActivityCleanupConfiguration);
		}
	}
}
