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
	public class BulkUploadStatisticsGetRequestBuilder : RequestBuilder<BulkUploadStatistics>
	{
		#region Constants
		public const string BULK_OBJECT_TYPE_EQUAL = "bulkObjectTypeEqual";
		public const string CREATE_DATE_GREATER_THAN_OR_EQUAL = "createDateGreaterThanOrEqual";
		#endregion

		public string BulkObjectTypeEqual { get; set; }
		public long CreateDateGreaterThanOrEqual { get; set; }

		public BulkUploadStatisticsGetRequestBuilder()
			: base("bulkuploadstatistics", "get")
		{
		}

		public BulkUploadStatisticsGetRequestBuilder(string bulkObjectTypeEqual, long createDateGreaterThanOrEqual)
			: this()
		{
			this.BulkObjectTypeEqual = bulkObjectTypeEqual;
			this.CreateDateGreaterThanOrEqual = createDateGreaterThanOrEqual;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkObjectTypeEqual"))
				kparams.AddIfNotNull("bulkObjectTypeEqual", BulkObjectTypeEqual);
			if (!isMapped("createDateGreaterThanOrEqual"))
				kparams.AddIfNotNull("createDateGreaterThanOrEqual", CreateDateGreaterThanOrEqual);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUploadStatistics>(result);
		}
	}


	public class BulkUploadStatisticsService
	{
		private BulkUploadStatisticsService()
		{
		}

		public static BulkUploadStatisticsGetRequestBuilder Get(string bulkObjectTypeEqual, long createDateGreaterThanOrEqual)
		{
			return new BulkUploadStatisticsGetRequestBuilder(bulkObjectTypeEqual, createDateGreaterThanOrEqual);
		}
	}
}
