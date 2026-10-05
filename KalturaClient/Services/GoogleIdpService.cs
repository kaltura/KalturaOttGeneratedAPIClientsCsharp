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
	public class GoogleIdpAttachRequestBuilder : RequestBuilder<SocialAttachStatus>
	{
		#region Constants
		public const string ID_TOKEN = "idToken";
		#endregion

		public string IdToken { get; set; }

		public GoogleIdpAttachRequestBuilder()
			: base("googleidp", "attach")
		{
		}

		public GoogleIdpAttachRequestBuilder(string idToken)
			: this()
		{
			this.IdToken = idToken;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("idToken"))
				kparams.AddIfNotNull("idToken", IdToken);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SocialAttachStatus>(result);
		}
	}

	public class GoogleIdpDetachRequestBuilder : RequestBuilder<SocialAttachStatus>
	{
		#region Constants
		#endregion


		public GoogleIdpDetachRequestBuilder()
			: base("googleidp", "detach")
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
			return ObjectFactory.Create<SocialAttachStatus>(result);
		}
	}

	public class GoogleIdpGetServiceIdRequestBuilder : RequestBuilder<SocialServiceId>
	{
		#region Constants
		#endregion


		public GoogleIdpGetServiceIdRequestBuilder()
			: base("googleidp", "getServiceId")
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
			return ObjectFactory.Create<SocialServiceId>(result);
		}
	}

	public class GoogleIdpIsAttachedRequestBuilder : RequestBuilder<SocialAttachStatus>
	{
		#region Constants
		#endregion


		public GoogleIdpIsAttachedRequestBuilder()
			: base("googleidp", "isAttached")
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
			return ObjectFactory.Create<SocialAttachStatus>(result);
		}
	}

	public class GoogleIdpLoginRequestBuilder : RequestBuilder<LoginResponse>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string ID_TOKEN = "idToken";
		public const string EXTRA_PARAMS = "extraParams";
		public const string UDID = "udid";
		#endregion

		public new int PartnerId { get; set; }
		public string IdToken { get; set; }
		public IDictionary<string, StringValue> ExtraParams { get; set; }
		public string Udid { get; set; }

		public GoogleIdpLoginRequestBuilder()
			: base("googleidp", "login")
		{
		}

		public GoogleIdpLoginRequestBuilder(int partnerId, string idToken, IDictionary<string, StringValue> extraParams, string udid)
			: this()
		{
			this.PartnerId = partnerId;
			this.IdToken = idToken;
			this.ExtraParams = extraParams;
			this.Udid = udid;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("idToken"))
				kparams.AddIfNotNull("idToken", IdToken);
			if (!isMapped("extraParams"))
				kparams.AddIfNotNull("extraParams", ExtraParams);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LoginResponse>(result);
		}
	}

	public class GoogleIdpSetServiceIdRequestBuilder : RequestBuilder<SocialServiceId>
	{
		#region Constants
		public const string SERVICE_ID = "serviceId";
		#endregion

		public string ServiceId { get; set; }

		public GoogleIdpSetServiceIdRequestBuilder()
			: base("googleidp", "setServiceId")
		{
		}

		public GoogleIdpSetServiceIdRequestBuilder(string serviceId)
			: this()
		{
			this.ServiceId = serviceId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serviceId"))
				kparams.AddIfNotNull("serviceId", ServiceId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SocialServiceId>(result);
		}
	}


	public class GoogleIdpService
	{
		private GoogleIdpService()
		{
		}

		public static GoogleIdpAttachRequestBuilder Attach(string idToken)
		{
			return new GoogleIdpAttachRequestBuilder(idToken);
		}

		public static GoogleIdpDetachRequestBuilder Detach()
		{
			return new GoogleIdpDetachRequestBuilder();
		}

		public static GoogleIdpGetServiceIdRequestBuilder GetServiceId()
		{
			return new GoogleIdpGetServiceIdRequestBuilder();
		}

		public static GoogleIdpIsAttachedRequestBuilder IsAttached()
		{
			return new GoogleIdpIsAttachedRequestBuilder();
		}

		public static GoogleIdpLoginRequestBuilder Login(int partnerId, string idToken, IDictionary<string, StringValue> extraParams = null, string udid = null)
		{
			return new GoogleIdpLoginRequestBuilder(partnerId, idToken, extraParams, udid);
		}

		public static GoogleIdpSetServiceIdRequestBuilder SetServiceId(string serviceId)
		{
			return new GoogleIdpSetServiceIdRequestBuilder(serviceId);
		}
	}
}
