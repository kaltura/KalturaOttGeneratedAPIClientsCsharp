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
	public class AssetPersonalSelectionDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string ASSET_TYPE = "assetType";
		public const string SLOT_NUMBER = "slotNumber";
		#endregion

		public long AssetId { get; set; }
		public AssetType AssetType { get; set; }
		public int SlotNumber { get; set; }

		public AssetPersonalSelectionDeleteRequestBuilder()
			: base("assetpersonalselection", "delete")
		{
		}

		public AssetPersonalSelectionDeleteRequestBuilder(long assetId, AssetType assetType, int slotNumber)
			: this()
		{
			this.AssetId = assetId;
			this.AssetType = assetType;
			this.SlotNumber = slotNumber;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("assetType"))
				kparams.AddIfNotNull("assetType", AssetType);
			if (!isMapped("slotNumber"))
				kparams.AddIfNotNull("slotNumber", SlotNumber);
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

	public class AssetPersonalSelectionDeleteAllRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string SLOT_NUMBER = "slotNumber";
		#endregion

		public int SlotNumber { get; set; }

		public AssetPersonalSelectionDeleteAllRequestBuilder()
			: base("assetpersonalselection", "deleteAll")
		{
		}

		public AssetPersonalSelectionDeleteAllRequestBuilder(int slotNumber)
			: this()
		{
			this.SlotNumber = slotNumber;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("slotNumber"))
				kparams.AddIfNotNull("slotNumber", SlotNumber);
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

	public class AssetPersonalSelectionUpsertRequestBuilder : RequestBuilder<AssetPersonalSelection>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string ASSET_TYPE = "assetType";
		public const string SLOT_NUMBER = "slotNumber";
		#endregion

		public long AssetId { get; set; }
		public AssetType AssetType { get; set; }
		public int SlotNumber { get; set; }

		public AssetPersonalSelectionUpsertRequestBuilder()
			: base("assetpersonalselection", "upsert")
		{
		}

		public AssetPersonalSelectionUpsertRequestBuilder(long assetId, AssetType assetType, int slotNumber)
			: this()
		{
			this.AssetId = assetId;
			this.AssetType = assetType;
			this.SlotNumber = slotNumber;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("assetType"))
				kparams.AddIfNotNull("assetType", AssetType);
			if (!isMapped("slotNumber"))
				kparams.AddIfNotNull("slotNumber", SlotNumber);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<AssetPersonalSelection>(result);
		}
	}


	public class AssetPersonalSelectionService
	{
		private AssetPersonalSelectionService()
		{
		}

		public static AssetPersonalSelectionDeleteRequestBuilder Delete(long assetId, AssetType assetType, int slotNumber)
		{
			return new AssetPersonalSelectionDeleteRequestBuilder(assetId, assetType, slotNumber);
		}

		public static AssetPersonalSelectionDeleteAllRequestBuilder DeleteAll(int slotNumber)
		{
			return new AssetPersonalSelectionDeleteAllRequestBuilder(slotNumber);
		}

		public static AssetPersonalSelectionUpsertRequestBuilder Upsert(long assetId, AssetType assetType, int slotNumber)
		{
			return new AssetPersonalSelectionUpsertRequestBuilder(assetId, assetType, slotNumber);
		}
	}
}
