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
	public class SemanticAssetSearchPartnerConfigGetFilteringConditionRequestBuilder : RequestBuilder<FilteringCondition>
	{
		#region Constants
		#endregion


		public SemanticAssetSearchPartnerConfigGetFilteringConditionRequestBuilder()
			: base("semanticassetsearchpartnerconfig", "getFilteringCondition")
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
			return ObjectFactory.Create<FilteringCondition>(result);
		}
	}

	public class SemanticAssetSearchPartnerConfigGetSearchableAttributesRequestBuilder : RequestBuilder<SearchableAttributes>
	{
		#region Constants
		public const string ASSET_STRUCT_ID = "assetStructId";
		#endregion

		public int AssetStructId { get; set; }

		public SemanticAssetSearchPartnerConfigGetSearchableAttributesRequestBuilder()
			: base("semanticassetsearchpartnerconfig", "getSearchableAttributes")
		{
		}

		public SemanticAssetSearchPartnerConfigGetSearchableAttributesRequestBuilder(int assetStructId)
			: this()
		{
			this.AssetStructId = assetStructId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetStructId"))
				kparams.AddIfNotNull("assetStructId", AssetStructId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SearchableAttributes>(result);
		}
	}

	public class SemanticAssetSearchPartnerConfigUpsertFilteringConditionRequestBuilder : RequestBuilder<FilteringCondition>
	{
		#region Constants
		public const string FILTERING_CONDITION = "filteringCondition";
		#endregion

		public FilteringCondition FilteringCondition { get; set; }

		public SemanticAssetSearchPartnerConfigUpsertFilteringConditionRequestBuilder()
			: base("semanticassetsearchpartnerconfig", "upsertFilteringCondition")
		{
		}

		public SemanticAssetSearchPartnerConfigUpsertFilteringConditionRequestBuilder(FilteringCondition filteringCondition)
			: this()
		{
			this.FilteringCondition = filteringCondition;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filteringCondition"))
				kparams.AddIfNotNull("filteringCondition", FilteringCondition);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<FilteringCondition>(result);
		}
	}

	public class SemanticAssetSearchPartnerConfigUpsertSearchableAttributesRequestBuilder : RequestBuilder<SearchableAttributes>
	{
		#region Constants
		public const string ATTRIBUTES = "attributes";
		#endregion

		public SearchableAttributes Attributes { get; set; }

		public SemanticAssetSearchPartnerConfigUpsertSearchableAttributesRequestBuilder()
			: base("semanticassetsearchpartnerconfig", "upsertSearchableAttributes")
		{
		}

		public SemanticAssetSearchPartnerConfigUpsertSearchableAttributesRequestBuilder(SearchableAttributes attributes)
			: this()
		{
			this.Attributes = attributes;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("attributes"))
				kparams.AddIfNotNull("attributes", Attributes);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<SearchableAttributes>(result);
		}
	}


	public class SemanticAssetSearchPartnerConfigService
	{
		private SemanticAssetSearchPartnerConfigService()
		{
		}

		public static SemanticAssetSearchPartnerConfigGetFilteringConditionRequestBuilder GetFilteringCondition()
		{
			return new SemanticAssetSearchPartnerConfigGetFilteringConditionRequestBuilder();
		}

		public static SemanticAssetSearchPartnerConfigGetSearchableAttributesRequestBuilder GetSearchableAttributes(int assetStructId)
		{
			return new SemanticAssetSearchPartnerConfigGetSearchableAttributesRequestBuilder(assetStructId);
		}

		public static SemanticAssetSearchPartnerConfigUpsertFilteringConditionRequestBuilder UpsertFilteringCondition(FilteringCondition filteringCondition)
		{
			return new SemanticAssetSearchPartnerConfigUpsertFilteringConditionRequestBuilder(filteringCondition);
		}

		public static SemanticAssetSearchPartnerConfigUpsertSearchableAttributesRequestBuilder UpsertSearchableAttributes(SearchableAttributes attributes)
		{
			return new SemanticAssetSearchPartnerConfigUpsertSearchableAttributesRequestBuilder(attributes);
		}
	}
}
