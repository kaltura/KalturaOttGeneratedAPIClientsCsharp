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
	public class IngestStatusGetEpgDetailsRequestBuilder : RequestBuilder<IngestEpgDetails>
	{
		#region Constants
		public const string INGEST_ID = "ingestId";
		#endregion

		public long IngestId { get; set; }

		public IngestStatusGetEpgDetailsRequestBuilder()
			: base("ingeststatus", "getEpgDetails")
		{
		}

		public IngestStatusGetEpgDetailsRequestBuilder(long ingestId)
			: this()
		{
			this.IngestId = ingestId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("ingestId"))
				kparams.AddIfNotNull("ingestId", IngestId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<IngestEpgDetails>(result);
		}
	}

	public class IngestStatusGetEpgListRequestBuilder : RequestBuilder<ListResponse<IngestEpg>>
	{
		#region Constants
		public const string IDS_FILTER = "idsFilter";
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public IngestByIdsFilter IdsFilter { get; set; }
		public IngestByCompoundFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public IngestStatusGetEpgListRequestBuilder()
			: base("ingeststatus", "getEpgList")
		{
		}

		public IngestStatusGetEpgListRequestBuilder(IngestByIdsFilter idsFilter, IngestByCompoundFilter filter, FilterPager pager)
			: this()
		{
			this.IdsFilter = idsFilter;
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("idsFilter"))
				kparams.AddIfNotNull("idsFilter", IdsFilter);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<IngestEpg>>(result);
		}
	}

	public class IngestStatusGetEpgProgramResultListRequestBuilder : RequestBuilder<ListResponse<IngestEpgProgramResult>>
	{
		#region Constants
		public const string INGEST_ID = "ingestId";
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public long IngestId { get; set; }
		public IngestEpgProgramResultFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public IngestStatusGetEpgProgramResultListRequestBuilder()
			: base("ingeststatus", "getEpgProgramResultList")
		{
		}

		public IngestStatusGetEpgProgramResultListRequestBuilder(long ingestId, IngestEpgProgramResultFilter filter, FilterPager pager)
			: this()
		{
			this.IngestId = ingestId;
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("ingestId"))
				kparams.AddIfNotNull("ingestId", IngestId);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<IngestEpgProgramResult>>(result);
		}
	}

	public class IngestStatusGetPartnerConfigurationRequestBuilder : RequestBuilder<IngestStatusPartnerConfiguration>
	{
		#region Constants
		#endregion


		public IngestStatusGetPartnerConfigurationRequestBuilder()
			: base("ingeststatus", "getPartnerConfiguration")
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
			return ObjectFactory.Create<IngestStatusPartnerConfiguration>(result);
		}
	}

	public class IngestStatusUpdatePartnerConfigurationRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string CONFIG = "config";
		#endregion

		public IngestStatusPartnerConfiguration Config { get; set; }

		public IngestStatusUpdatePartnerConfigurationRequestBuilder()
			: base("ingeststatus", "updatePartnerConfiguration")
		{
		}

		public IngestStatusUpdatePartnerConfigurationRequestBuilder(IngestStatusPartnerConfiguration config)
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


	public class IngestStatusService
	{
		private IngestStatusService()
		{
		}

		public static IngestStatusGetEpgDetailsRequestBuilder GetEpgDetails(long ingestId)
		{
			return new IngestStatusGetEpgDetailsRequestBuilder(ingestId);
		}

		public static IngestStatusGetEpgListRequestBuilder GetEpgList(IngestByIdsFilter idsFilter = null, IngestByCompoundFilter filter = null, FilterPager pager = null)
		{
			return new IngestStatusGetEpgListRequestBuilder(idsFilter, filter, pager);
		}

		public static IngestStatusGetEpgProgramResultListRequestBuilder GetEpgProgramResultList(long ingestId, IngestEpgProgramResultFilter filter = null, FilterPager pager = null)
		{
			return new IngestStatusGetEpgProgramResultListRequestBuilder(ingestId, filter, pager);
		}

		public static IngestStatusGetPartnerConfigurationRequestBuilder GetPartnerConfiguration()
		{
			return new IngestStatusGetPartnerConfigurationRequestBuilder();
		}

		public static IngestStatusUpdatePartnerConfigurationRequestBuilder UpdatePartnerConfiguration(IngestStatusPartnerConfiguration config)
		{
			return new IngestStatusUpdatePartnerConfigurationRequestBuilder(config);
		}
	}
}
