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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class HouseholdLimitationsAddRequestBuilder : RequestBuilder<HouseholdLimitations>
	{
		#region Constants
		public const string HOUSEHOLD_LIMITATIONS = "householdLimitations";
		#endregion

		public HouseholdLimitations HouseholdLimitations { get; set; }

		public HouseholdLimitationsAddRequestBuilder()
			: base("householdlimitations", "add")
		{
		}

		public HouseholdLimitationsAddRequestBuilder(HouseholdLimitations householdLimitations)
			: this()
		{
			this.HouseholdLimitations = householdLimitations;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("householdLimitations"))
				kparams.AddIfNotNull("householdLimitations", HouseholdLimitations);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<HouseholdLimitations>(result);
		}
	}

	public class HouseholdLimitationsDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string HOUSEHOLD_LIMITATIONS_ID = "householdLimitationsId";
		#endregion

		public int HouseholdLimitationsId { get; set; }

		public HouseholdLimitationsDeleteRequestBuilder()
			: base("householdlimitations", "delete")
		{
		}

		public HouseholdLimitationsDeleteRequestBuilder(int householdLimitationsId)
			: this()
		{
			this.HouseholdLimitationsId = householdLimitationsId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("householdLimitationsId"))
				kparams.AddIfNotNull("householdLimitationsId", HouseholdLimitationsId);
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

	public class HouseholdLimitationsGetRequestBuilder : RequestBuilder<HouseholdLimitations>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public HouseholdLimitationsGetRequestBuilder()
			: base("householdlimitations", "get")
		{
		}

		public HouseholdLimitationsGetRequestBuilder(int id)
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
			return ObjectFactory.Create<HouseholdLimitations>(result);
		}
	}

	public class HouseholdLimitationsIsUsedRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string DLM_ID = "dlmId";
		#endregion

		public int DlmId { get; set; }

		public HouseholdLimitationsIsUsedRequestBuilder()
			: base("householdlimitations", "isUsed")
		{
		}

		public HouseholdLimitationsIsUsedRequestBuilder(int dlmId)
			: this()
		{
			this.DlmId = dlmId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dlmId"))
				kparams.AddIfNotNull("dlmId", DlmId);
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

	public class HouseholdLimitationsListRequestBuilder : RequestBuilder<ListResponse<HouseholdLimitations>>
	{
		#region Constants
		#endregion


		public HouseholdLimitationsListRequestBuilder()
			: base("householdlimitations", "list")
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
			return ObjectFactory.Create<ListResponse<HouseholdLimitations>>(result);
		}
	}

	public class HouseholdLimitationsUpdateRequestBuilder : RequestBuilder<HouseholdLimitations>
	{
		#region Constants
		public const string DLM_ID = "dlmId";
		public const string HOUSEHOLD_LIMITATION = "householdLimitation";
		#endregion

		public int DlmId { get; set; }
		public HouseholdLimitations HouseholdLimitation { get; set; }

		public HouseholdLimitationsUpdateRequestBuilder()
			: base("householdlimitations", "update")
		{
		}

		public HouseholdLimitationsUpdateRequestBuilder(int dlmId, HouseholdLimitations householdLimitation)
			: this()
		{
			this.DlmId = dlmId;
			this.HouseholdLimitation = householdLimitation;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dlmId"))
				kparams.AddIfNotNull("dlmId", DlmId);
			if (!isMapped("householdLimitation"))
				kparams.AddIfNotNull("householdLimitation", HouseholdLimitation);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<HouseholdLimitations>(result);
		}
	}


	public class HouseholdLimitationsService
	{
		private HouseholdLimitationsService()
		{
		}

		public static HouseholdLimitationsAddRequestBuilder Add(HouseholdLimitations householdLimitations)
		{
			return new HouseholdLimitationsAddRequestBuilder(householdLimitations);
		}

		public static HouseholdLimitationsDeleteRequestBuilder Delete(int householdLimitationsId)
		{
			return new HouseholdLimitationsDeleteRequestBuilder(householdLimitationsId);
		}

		public static HouseholdLimitationsGetRequestBuilder Get(int id)
		{
			return new HouseholdLimitationsGetRequestBuilder(id);
		}

		public static HouseholdLimitationsIsUsedRequestBuilder IsUsed(int dlmId)
		{
			return new HouseholdLimitationsIsUsedRequestBuilder(dlmId);
		}

		public static HouseholdLimitationsListRequestBuilder List()
		{
			return new HouseholdLimitationsListRequestBuilder();
		}

		public static HouseholdLimitationsUpdateRequestBuilder Update(int dlmId, HouseholdLimitations householdLimitation)
		{
			return new HouseholdLimitationsUpdateRequestBuilder(dlmId, householdLimitation);
		}
	}
}
