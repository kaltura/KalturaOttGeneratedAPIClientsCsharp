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
	public class FacebookIdpAttachRequestBuilder : RequestBuilder<SocialAttachStatus>
	{
		#region Constants
		public const string ACCESS_TOKEN = "accessToken";
		#endregion

		public string AccessToken { get; set; }

		public FacebookIdpAttachRequestBuilder()
			: base("facebookidp", "attach")
		{
		}

		public FacebookIdpAttachRequestBuilder(string accessToken)
			: this()
		{
			this.AccessToken = accessToken;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("accessToken"))
				kparams.AddIfNotNull("accessToken", AccessToken);
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

	public class FacebookIdpDetachRequestBuilder : RequestBuilder<SocialAttachStatus>
	{
		#region Constants
		#endregion


		public FacebookIdpDetachRequestBuilder()
			: base("facebookidp", "detach")
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

	public class FacebookIdpGetServiceIdRequestBuilder : RequestBuilder<SocialServiceId>
	{
		#region Constants
		#endregion


		public FacebookIdpGetServiceIdRequestBuilder()
			: base("facebookidp", "getServiceId")
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

	public class FacebookIdpIsAttachedRequestBuilder : RequestBuilder<SocialAttachStatus>
	{
		#region Constants
		#endregion


		public FacebookIdpIsAttachedRequestBuilder()
			: base("facebookidp", "isAttached")
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

	public class FacebookIdpLoginRequestBuilder : RequestBuilder<LoginResponse>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string ACCESS_TOKEN = "accessToken";
		public const string EXTRA_PARAMS = "extraParams";
		public const string UDID = "udid";
		#endregion

		public new int PartnerId { get; set; }
		public string AccessToken { get; set; }
		public IDictionary<string, StringValue> ExtraParams { get; set; }
		public string Udid { get; set; }

		public FacebookIdpLoginRequestBuilder()
			: base("facebookidp", "login")
		{
		}

		public FacebookIdpLoginRequestBuilder(int partnerId, string accessToken, IDictionary<string, StringValue> extraParams, string udid)
			: this()
		{
			this.PartnerId = partnerId;
			this.AccessToken = accessToken;
			this.ExtraParams = extraParams;
			this.Udid = udid;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("accessToken"))
				kparams.AddIfNotNull("accessToken", AccessToken);
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

	public class FacebookIdpSetSecretRequestBuilder : RequestBuilder<SocialSetSecretResponse>
	{
		#region Constants
		public const string SECRET = "secret";
		#endregion

		public string Secret { get; set; }

		public FacebookIdpSetSecretRequestBuilder()
			: base("facebookidp", "setSecret")
		{
		}

		public FacebookIdpSetSecretRequestBuilder(string secret)
			: this()
		{
			this.Secret = secret;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("secret"))
				kparams.AddIfNotNull("secret", Secret);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SocialSetSecretResponse>(result);
		}
	}

	public class FacebookIdpSetServiceIdRequestBuilder : RequestBuilder<SocialServiceId>
	{
		#region Constants
		public const string SERVICE_ID = "serviceId";
		#endregion

		public string ServiceId { get; set; }

		public FacebookIdpSetServiceIdRequestBuilder()
			: base("facebookidp", "setServiceId")
		{
		}

		public FacebookIdpSetServiceIdRequestBuilder(string serviceId)
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


	public class FacebookIdpService
	{
		private FacebookIdpService()
		{
		}

		public static FacebookIdpAttachRequestBuilder Attach(string accessToken)
		{
			return new FacebookIdpAttachRequestBuilder(accessToken);
		}

		public static FacebookIdpDetachRequestBuilder Detach()
		{
			return new FacebookIdpDetachRequestBuilder();
		}

		public static FacebookIdpGetServiceIdRequestBuilder GetServiceId()
		{
			return new FacebookIdpGetServiceIdRequestBuilder();
		}

		public static FacebookIdpIsAttachedRequestBuilder IsAttached()
		{
			return new FacebookIdpIsAttachedRequestBuilder();
		}

		public static FacebookIdpLoginRequestBuilder Login(int partnerId, string accessToken, IDictionary<string, StringValue> extraParams = null, string udid = null)
		{
			return new FacebookIdpLoginRequestBuilder(partnerId, accessToken, extraParams, udid);
		}

		public static FacebookIdpSetSecretRequestBuilder SetSecret(string secret)
		{
			return new FacebookIdpSetSecretRequestBuilder(secret);
		}

		public static FacebookIdpSetServiceIdRequestBuilder SetServiceId(string serviceId)
		{
			return new FacebookIdpSetServiceIdRequestBuilder(serviceId);
		}
	}
}
