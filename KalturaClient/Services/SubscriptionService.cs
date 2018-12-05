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
// Copyright (C) 2006-2018  Kaltura Inc.
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

namespace Kaltura.Services
{
	public class SubscriptionListRequestBuilder : RequestBuilder<ListResponse<Subscription>>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public SubscriptionFilter Filter
		{
			set;
			get;
		}

		public SubscriptionListRequestBuilder()
			: base("subscription", "list")
		{
		}

		public SubscriptionListRequestBuilder(SubscriptionFilter filter)
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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<Subscription>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<Subscription>>((IDictionary<string,object>)result);
		}
	}

	public class SubscriptionValidateCouponRequestBuilder : RequestBuilder<Coupon>
	{
		#region Constants
		public const string ID = "id";
		public const string CODE = "code";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public string Code
		{
			set;
			get;
		}

		public SubscriptionValidateCouponRequestBuilder()
			: base("subscription", "validateCoupon")
		{
		}

		public SubscriptionValidateCouponRequestBuilder(int id, string code)
			: this()
		{
			this.Id = id;
			this.Code = code;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("code"))
				kparams.AddIfNotNull("code", Code);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Coupon>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<Coupon>((IDictionary<string,object>)result);
		}
	}


	public class SubscriptionService
	{
		private SubscriptionService()
		{
		}

		public static SubscriptionListRequestBuilder List(SubscriptionFilter filter)
		{
			return new SubscriptionListRequestBuilder(filter);
		}

		public static SubscriptionValidateCouponRequestBuilder ValidateCoupon(int id, string code)
		{
			return new SubscriptionValidateCouponRequestBuilder(id, code);
		}
	}
}
