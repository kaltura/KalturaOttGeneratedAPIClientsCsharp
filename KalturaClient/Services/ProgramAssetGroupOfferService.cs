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
	public class ProgramAssetGroupOfferAddRequestBuilder : RequestBuilder<ProgramAssetGroupOffer>
	{
		#region Constants
		public const string PROGRAM_ASSET_GROUP_OFFER = "programAssetGroupOffer";
		#endregion

		public ProgramAssetGroupOffer ProgramAssetGroupOffer { get; set; }

		public ProgramAssetGroupOfferAddRequestBuilder()
			: base("programassetgroupoffer", "add")
		{
		}

		public ProgramAssetGroupOfferAddRequestBuilder(ProgramAssetGroupOffer programAssetGroupOffer)
			: this()
		{
			this.ProgramAssetGroupOffer = programAssetGroupOffer;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("programAssetGroupOffer"))
				kparams.AddIfNotNull("programAssetGroupOffer", ProgramAssetGroupOffer);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ProgramAssetGroupOffer>(result);
		}
	}

	public class ProgramAssetGroupOfferDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public ProgramAssetGroupOfferDeleteRequestBuilder()
			: base("programassetgroupoffer", "delete")
		{
		}

		public ProgramAssetGroupOfferDeleteRequestBuilder(long id)
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

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class ProgramAssetGroupOfferListRequestBuilder : RequestBuilder<ListResponse<ProgramAssetGroupOffer>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ProgramAssetGroupOfferFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public ProgramAssetGroupOfferListRequestBuilder()
			: base("programassetgroupoffer", "list")
		{
		}

		public ProgramAssetGroupOfferListRequestBuilder(ProgramAssetGroupOfferFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
			return ObjectFactory.Create<ListResponse<ProgramAssetGroupOffer>>(result);
		}
	}

	public class ProgramAssetGroupOfferUpdateRequestBuilder : RequestBuilder<ProgramAssetGroupOffer>
	{
		#region Constants
		public const string ID = "id";
		public const string PROGRAM_ASSET_GROUP_OFFER = "programAssetGroupOffer";
		#endregion

		public long Id { get; set; }
		public ProgramAssetGroupOffer ProgramAssetGroupOffer { get; set; }

		public ProgramAssetGroupOfferUpdateRequestBuilder()
			: base("programassetgroupoffer", "update")
		{
		}

		public ProgramAssetGroupOfferUpdateRequestBuilder(long id, ProgramAssetGroupOffer programAssetGroupOffer)
			: this()
		{
			this.Id = id;
			this.ProgramAssetGroupOffer = programAssetGroupOffer;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("programAssetGroupOffer"))
				kparams.AddIfNotNull("programAssetGroupOffer", ProgramAssetGroupOffer);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ProgramAssetGroupOffer>(result);
		}
	}


	public class ProgramAssetGroupOfferService
	{
		private ProgramAssetGroupOfferService()
		{
		}

		public static ProgramAssetGroupOfferAddRequestBuilder Add(ProgramAssetGroupOffer programAssetGroupOffer)
		{
			return new ProgramAssetGroupOfferAddRequestBuilder(programAssetGroupOffer);
		}

		public static ProgramAssetGroupOfferDeleteRequestBuilder Delete(long id)
		{
			return new ProgramAssetGroupOfferDeleteRequestBuilder(id);
		}

		public static ProgramAssetGroupOfferListRequestBuilder List(ProgramAssetGroupOfferFilter filter = null, FilterPager pager = null)
		{
			return new ProgramAssetGroupOfferListRequestBuilder(filter, pager);
		}

		public static ProgramAssetGroupOfferUpdateRequestBuilder Update(long id, ProgramAssetGroupOffer programAssetGroupOffer)
		{
			return new ProgramAssetGroupOfferUpdateRequestBuilder(id, programAssetGroupOffer);
		}
	}
}
