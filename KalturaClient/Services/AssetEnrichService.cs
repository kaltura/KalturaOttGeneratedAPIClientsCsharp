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
	public class AssetEnrichGenerateMetadataRequestBuilder : RequestBuilder<CaptionUploadJob>
	{
		#region Constants
		public const string CAPTION_UPLOAD_JOB_ID = "captionUploadJobId";
		public const string EXTERNAL_ASSET_IDS = "externalAssetIds";
		public const string TARGET_DISPLAY_LANGUAGE = "targetDisplayLanguage";
		#endregion

		public long CaptionUploadJobId { get; set; }
		public IList<StringValue> ExternalAssetIds { get; set; }
		public string TargetDisplayLanguage { get; set; }

		public AssetEnrichGenerateMetadataRequestBuilder()
			: base("assetenrich", "generateMetadata")
		{
		}

		public AssetEnrichGenerateMetadataRequestBuilder(long captionUploadJobId, IList<StringValue> externalAssetIds, string targetDisplayLanguage)
			: this()
		{
			this.CaptionUploadJobId = captionUploadJobId;
			this.ExternalAssetIds = externalAssetIds;
			this.TargetDisplayLanguage = targetDisplayLanguage;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionUploadJobId"))
				kparams.AddIfNotNull("captionUploadJobId", CaptionUploadJobId);
			if (!isMapped("externalAssetIds"))
				kparams.AddIfNotNull("externalAssetIds", ExternalAssetIds);
			if (!isMapped("targetDisplayLanguage"))
				kparams.AddIfNotNull("targetDisplayLanguage", TargetDisplayLanguage);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionUploadJob>(result);
		}
	}

	public class AssetEnrichGetCaptionUploadJobRequestBuilder : RequestBuilder<CaptionUploadJob>
	{
		#region Constants
		public const string CAPTION_UPLOAD_JOB_ID = "captionUploadJobId";
		#endregion

		public long CaptionUploadJobId { get; set; }

		public AssetEnrichGetCaptionUploadJobRequestBuilder()
			: base("assetenrich", "getCaptionUploadJob")
		{
		}

		public AssetEnrichGetCaptionUploadJobRequestBuilder(long captionUploadJobId)
			: this()
		{
			this.CaptionUploadJobId = captionUploadJobId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionUploadJobId"))
				kparams.AddIfNotNull("captionUploadJobId", CaptionUploadJobId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionUploadJob>(result);
		}
	}

	public class AssetEnrichGetGeneratedMetadataRequestBuilder : RequestBuilder<EnrichedMetadataResult>
	{
		#region Constants
		public const string CAPTION_UPLOAD_JOB_ID = "captionUploadJobId";
		#endregion

		public long CaptionUploadJobId { get; set; }

		public AssetEnrichGetGeneratedMetadataRequestBuilder()
			: base("assetenrich", "getGeneratedMetadata")
		{
		}

		public AssetEnrichGetGeneratedMetadataRequestBuilder(long captionUploadJobId)
			: this()
		{
			this.CaptionUploadJobId = captionUploadJobId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionUploadJobId"))
				kparams.AddIfNotNull("captionUploadJobId", CaptionUploadJobId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EnrichedMetadataResult>(result);
		}
	}

	public class AssetEnrichGetPartnerConfigurationRequestBuilder : RequestBuilder<MetaEnrichConfiguration>
	{
		#region Constants
		#endregion


		public AssetEnrichGetPartnerConfigurationRequestBuilder()
			: base("assetenrich", "getPartnerConfiguration")
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
			return ObjectFactory.Create<MetaEnrichConfiguration>(result);
		}
	}

	public class AssetEnrichUpdatePartnerConfigurationRequestBuilder : RequestBuilder<MetaEnrichConfiguration>
	{
		#region Constants
		public const string CONFIGURATION = "configuration";
		#endregion

		public MetaEnrichConfiguration Configuration { get; set; }

		public AssetEnrichUpdatePartnerConfigurationRequestBuilder()
			: base("assetenrich", "updatePartnerConfiguration")
		{
		}

		public AssetEnrichUpdatePartnerConfigurationRequestBuilder(MetaEnrichConfiguration configuration)
			: this()
		{
			this.Configuration = configuration;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("configuration"))
				kparams.AddIfNotNull("configuration", Configuration);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<MetaEnrichConfiguration>(result);
		}
	}

	public class AssetEnrichUploadCaptionFileRequestBuilder : RequestBuilder<CaptionUploadJob>
	{
		#region Constants
		public const string JSON = "json";
		public const string FILE_NAME = "fileName";
		#endregion

		public CaptionUploadData Json { get; set; }
		public Stream FileName { get; set; }
		public string FileName_FileName { get; set; }

		public AssetEnrichUploadCaptionFileRequestBuilder()
			: base("assetenrich", "uploadCaptionFile")
		{
		}

		public AssetEnrichUploadCaptionFileRequestBuilder(CaptionUploadData json, Stream fileName)
			: this()
		{
			this.Json = json;
			this.FileName = fileName;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("json"))
				kparams.AddIfNotNull("json", Json);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileName", new FileData(FileName, FileName_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionUploadJob>(result);
		}
	}


	public class AssetEnrichService
	{
		private AssetEnrichService()
		{
		}

		public static AssetEnrichGenerateMetadataRequestBuilder GenerateMetadata(long captionUploadJobId, IList<StringValue> externalAssetIds, string targetDisplayLanguage)
		{
			return new AssetEnrichGenerateMetadataRequestBuilder(captionUploadJobId, externalAssetIds, targetDisplayLanguage);
		}

		public static AssetEnrichGetCaptionUploadJobRequestBuilder GetCaptionUploadJob(long captionUploadJobId)
		{
			return new AssetEnrichGetCaptionUploadJobRequestBuilder(captionUploadJobId);
		}

		public static AssetEnrichGetGeneratedMetadataRequestBuilder GetGeneratedMetadata(long captionUploadJobId)
		{
			return new AssetEnrichGetGeneratedMetadataRequestBuilder(captionUploadJobId);
		}

		public static AssetEnrichGetPartnerConfigurationRequestBuilder GetPartnerConfiguration()
		{
			return new AssetEnrichGetPartnerConfigurationRequestBuilder();
		}

		public static AssetEnrichUpdatePartnerConfigurationRequestBuilder UpdatePartnerConfiguration(MetaEnrichConfiguration configuration)
		{
			return new AssetEnrichUpdatePartnerConfigurationRequestBuilder(configuration);
		}

		public static AssetEnrichUploadCaptionFileRequestBuilder UploadCaptionFile(CaptionUploadData json, Stream fileName)
		{
			return new AssetEnrichUploadCaptionFileRequestBuilder(json, fileName);
		}
	}
}
