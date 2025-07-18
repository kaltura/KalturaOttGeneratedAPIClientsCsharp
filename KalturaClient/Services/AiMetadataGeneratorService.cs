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
	public class AiMetadataGeneratorGenerateMetadataBySubtitlesRequestBuilder : RequestBuilder<GenerateMetadataBySubtitlesJob>
	{
		#region Constants
		public const string SUBTITLES_FILE_ID = "subtitlesFileId";
		public const string EXTERNAL_ASSET_IDS = "externalAssetIds";
		#endregion

		public long SubtitlesFileId { get; set; }
		public IList<StringValue> ExternalAssetIds { get; set; }

		public AiMetadataGeneratorGenerateMetadataBySubtitlesRequestBuilder()
			: base("aimetadatagenerator", "generateMetadataBySubtitles")
		{
		}

		public AiMetadataGeneratorGenerateMetadataBySubtitlesRequestBuilder(long subtitlesFileId, IList<StringValue> externalAssetIds)
			: this()
		{
			this.SubtitlesFileId = subtitlesFileId;
			this.ExternalAssetIds = externalAssetIds;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("subtitlesFileId"))
				kparams.AddIfNotNull("subtitlesFileId", SubtitlesFileId);
			if (!isMapped("externalAssetIds"))
				kparams.AddIfNotNull("externalAssetIds", ExternalAssetIds);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenerateMetadataBySubtitlesJob>(result);
		}
	}

	public class AiMetadataGeneratorGetGeneratedMetadataRequestBuilder : RequestBuilder<GenerateMetadataResult>
	{
		#region Constants
		public const string JOB_ID = "jobId";
		#endregion

		public long JobId { get; set; }

		public AiMetadataGeneratorGetGeneratedMetadataRequestBuilder()
			: base("aimetadatagenerator", "getGeneratedMetadata")
		{
		}

		public AiMetadataGeneratorGetGeneratedMetadataRequestBuilder(long jobId)
			: this()
		{
			this.JobId = jobId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("jobId"))
				kparams.AddIfNotNull("jobId", JobId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenerateMetadataResult>(result);
		}
	}

	public class AiMetadataGeneratorGetGenerateMetadataJobRequestBuilder : RequestBuilder<GenerateMetadataBySubtitlesJob>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public AiMetadataGeneratorGetGenerateMetadataJobRequestBuilder()
			: base("aimetadatagenerator", "getGenerateMetadataJob")
		{
		}

		public AiMetadataGeneratorGetGenerateMetadataJobRequestBuilder(long id)
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
			return ObjectFactory.Create<GenerateMetadataBySubtitlesJob>(result);
		}
	}

	public class AiMetadataGeneratorGetMetadataFieldDefinitionsRequestBuilder : RequestBuilder<MetaFieldNameMap>
	{
		#region Constants
		#endregion


		public AiMetadataGeneratorGetMetadataFieldDefinitionsRequestBuilder()
			: base("aimetadatagenerator", "getMetadataFieldDefinitions")
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
			return ObjectFactory.Create<MetaFieldNameMap>(result);
		}
	}

	public class AiMetadataGeneratorGetPartnerConfigurationRequestBuilder : RequestBuilder<AiMetadataGeneratorConfiguration>
	{
		#region Constants
		#endregion


		public AiMetadataGeneratorGetPartnerConfigurationRequestBuilder()
			: base("aimetadatagenerator", "getPartnerConfiguration")
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
			return ObjectFactory.Create<AiMetadataGeneratorConfiguration>(result);
		}
	}

	public class AiMetadataGeneratorUpdatePartnerConfigurationRequestBuilder : RequestBuilder<AiMetadataGeneratorConfiguration>
	{
		#region Constants
		public const string CONFIGURATION = "configuration";
		#endregion

		public AiMetadataGeneratorConfiguration Configuration { get; set; }

		public AiMetadataGeneratorUpdatePartnerConfigurationRequestBuilder()
			: base("aimetadatagenerator", "updatePartnerConfiguration")
		{
		}

		public AiMetadataGeneratorUpdatePartnerConfigurationRequestBuilder(AiMetadataGeneratorConfiguration configuration)
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
			return ObjectFactory.Create<AiMetadataGeneratorConfiguration>(result);
		}
	}


	public class AiMetadataGeneratorService
	{
		private AiMetadataGeneratorService()
		{
		}

		public static AiMetadataGeneratorGenerateMetadataBySubtitlesRequestBuilder GenerateMetadataBySubtitles(long subtitlesFileId, IList<StringValue> externalAssetIds = null)
		{
			return new AiMetadataGeneratorGenerateMetadataBySubtitlesRequestBuilder(subtitlesFileId, externalAssetIds);
		}

		public static AiMetadataGeneratorGetGeneratedMetadataRequestBuilder GetGeneratedMetadata(long jobId)
		{
			return new AiMetadataGeneratorGetGeneratedMetadataRequestBuilder(jobId);
		}

		public static AiMetadataGeneratorGetGenerateMetadataJobRequestBuilder GetGenerateMetadataJob(long id)
		{
			return new AiMetadataGeneratorGetGenerateMetadataJobRequestBuilder(id);
		}

		public static AiMetadataGeneratorGetMetadataFieldDefinitionsRequestBuilder GetMetadataFieldDefinitions()
		{
			return new AiMetadataGeneratorGetMetadataFieldDefinitionsRequestBuilder();
		}

		public static AiMetadataGeneratorGetPartnerConfigurationRequestBuilder GetPartnerConfiguration()
		{
			return new AiMetadataGeneratorGetPartnerConfigurationRequestBuilder();
		}

		public static AiMetadataGeneratorUpdatePartnerConfigurationRequestBuilder UpdatePartnerConfiguration(AiMetadataGeneratorConfiguration configuration)
		{
			return new AiMetadataGeneratorUpdatePartnerConfigurationRequestBuilder(configuration);
		}
	}
}
