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
	public class BusinessModuleRuleAddRequestBuilder : RequestBuilder<BusinessModuleRule>
	{
		#region Constants
		public const string BUSINESS_MODULE_RULE = "businessModuleRule";
		#endregion

		public BusinessModuleRule BusinessModuleRule
		{
			set;
			get;
		}

		public BusinessModuleRuleAddRequestBuilder()
			: base("businessmodulerule", "add")
		{
		}

		public BusinessModuleRuleAddRequestBuilder(BusinessModuleRule businessModuleRule)
			: this()
		{
			this.BusinessModuleRule = businessModuleRule;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("businessModuleRule"))
				kparams.AddIfNotNull("businessModuleRule", BusinessModuleRule);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BusinessModuleRule>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<BusinessModuleRule>((IDictionary<string,object>)result);
		}
	}

	public class BusinessModuleRuleDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id
		{
			set;
			get;
		}

		public BusinessModuleRuleDeleteRequestBuilder()
			: base("businessmodulerule", "delete")
		{
		}

		public BusinessModuleRuleDeleteRequestBuilder(long id)
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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
		public override object DeserializeObject(object result)
		{
			return null;
		}
	}

	public class BusinessModuleRuleGetRequestBuilder : RequestBuilder<BusinessModuleRule>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id
		{
			set;
			get;
		}

		public BusinessModuleRuleGetRequestBuilder()
			: base("businessmodulerule", "get")
		{
		}

		public BusinessModuleRuleGetRequestBuilder(long id)
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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BusinessModuleRule>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<BusinessModuleRule>((IDictionary<string,object>)result);
		}
	}

	public class BusinessModuleRuleListRequestBuilder : RequestBuilder<ListResponse<BusinessModuleRule>>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public BusinessModuleRuleFilter Filter
		{
			set;
			get;
		}

		public BusinessModuleRuleListRequestBuilder()
			: base("businessmodulerule", "list")
		{
		}

		public BusinessModuleRuleListRequestBuilder(BusinessModuleRuleFilter filter)
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
			return ObjectFactory.Create<ListResponse<BusinessModuleRule>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<BusinessModuleRule>>((IDictionary<string,object>)result);
		}
	}

	public class BusinessModuleRuleUpdateRequestBuilder : RequestBuilder<BusinessModuleRule>
	{
		#region Constants
		public const string ID = "id";
		public const string BUSINESS_MODULE_RULE = "businessModuleRule";
		#endregion

		public long Id
		{
			set;
			get;
		}
		public BusinessModuleRule BusinessModuleRule
		{
			set;
			get;
		}

		public BusinessModuleRuleUpdateRequestBuilder()
			: base("businessmodulerule", "update")
		{
		}

		public BusinessModuleRuleUpdateRequestBuilder(long id, BusinessModuleRule businessModuleRule)
			: this()
		{
			this.Id = id;
			this.BusinessModuleRule = businessModuleRule;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("businessModuleRule"))
				kparams.AddIfNotNull("businessModuleRule", BusinessModuleRule);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BusinessModuleRule>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<BusinessModuleRule>((IDictionary<string,object>)result);
		}
	}


	public class BusinessModuleRuleService
	{
		private BusinessModuleRuleService()
		{
		}

		public static BusinessModuleRuleAddRequestBuilder Add(BusinessModuleRule businessModuleRule)
		{
			return new BusinessModuleRuleAddRequestBuilder(businessModuleRule);
		}

		public static BusinessModuleRuleDeleteRequestBuilder Delete(long id)
		{
			return new BusinessModuleRuleDeleteRequestBuilder(id);
		}

		public static BusinessModuleRuleGetRequestBuilder Get(long id)
		{
			return new BusinessModuleRuleGetRequestBuilder(id);
		}

		public static BusinessModuleRuleListRequestBuilder List(BusinessModuleRuleFilter filter = null)
		{
			return new BusinessModuleRuleListRequestBuilder(filter);
		}

		public static BusinessModuleRuleUpdateRequestBuilder Update(long id, BusinessModuleRule businessModuleRule)
		{
			return new BusinessModuleRuleUpdateRequestBuilder(id, businessModuleRule);
		}
	}
}
