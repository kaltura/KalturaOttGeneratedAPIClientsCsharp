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
	public class AiRecommendationTreeGetNextNodeAndRecommendationRequestBuilder : RequestBuilder<TreeNextNodeResponse>
	{
		#region Constants
		public const string TREE_ID = "treeId";
		public const string PREVIOUS_QUESTION_ID = "previousQuestionId";
		public const string ANSWER_ID = "answerId";
		public const string TOP_QUESTION_ID = "topQuestionId";
		#endregion

		public string TreeId { get; set; }
		public string PreviousQuestionId { get; set; }
		public string AnswerId { get; set; }
		public string TopQuestionId { get; set; }

		public AiRecommendationTreeGetNextNodeAndRecommendationRequestBuilder()
			: base("airecommendationtree", "getNextNodeAndRecommendation")
		{
		}

		public AiRecommendationTreeGetNextNodeAndRecommendationRequestBuilder(string treeId, string previousQuestionId, string answerId, string topQuestionId)
			: this()
		{
			this.TreeId = treeId;
			this.PreviousQuestionId = previousQuestionId;
			this.AnswerId = answerId;
			this.TopQuestionId = topQuestionId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("treeId"))
				kparams.AddIfNotNull("treeId", TreeId);
			if (!isMapped("previousQuestionId"))
				kparams.AddIfNotNull("previousQuestionId", PreviousQuestionId);
			if (!isMapped("answerId"))
				kparams.AddIfNotNull("answerId", AnswerId);
			if (!isMapped("topQuestionId"))
				kparams.AddIfNotNull("topQuestionId", TopQuestionId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<TreeNextNodeResponse>(result);
		}
	}

	public class AiRecommendationTreeGetPartnerConfigRequestBuilder : RequestBuilder<AiRecommendationTreePartnerConfiguration>
	{
		#region Constants
		#endregion


		public AiRecommendationTreeGetPartnerConfigRequestBuilder()
			: base("airecommendationtree", "getPartnerConfig")
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
			return ObjectFactory.Create<AiRecommendationTreePartnerConfiguration>(result);
		}
	}

	public class AiRecommendationTreeGetRecommendationWithNaturalTextRequestBuilder : RequestBuilder<TreeNaturalTextResponse>
	{
		#region Constants
		public const string NATURAL_TEXT_QUERY = "naturalTextQuery";
		public const string PREVIOUS_QUESTION_ID = "previousQuestionId";
		public const string TREE_ID = "treeId";
		#endregion

		public string NaturalTextQuery { get; set; }
		public string PreviousQuestionId { get; set; }
		public string TreeId { get; set; }

		public AiRecommendationTreeGetRecommendationWithNaturalTextRequestBuilder()
			: base("airecommendationtree", "getRecommendationWithNaturalText")
		{
		}

		public AiRecommendationTreeGetRecommendationWithNaturalTextRequestBuilder(string naturalTextQuery, string previousQuestionId, string treeId)
			: this()
		{
			this.NaturalTextQuery = naturalTextQuery;
			this.PreviousQuestionId = previousQuestionId;
			this.TreeId = treeId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("naturalTextQuery"))
				kparams.AddIfNotNull("naturalTextQuery", NaturalTextQuery);
			if (!isMapped("previousQuestionId"))
				kparams.AddIfNotNull("previousQuestionId", PreviousQuestionId);
			if (!isMapped("treeId"))
				kparams.AddIfNotNull("treeId", TreeId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<TreeNaturalTextResponse>(result);
		}
	}

	public class AiRecommendationTreeUpsertPartnerConfigRequestBuilder : RequestBuilder<AiRecommendationTreePartnerConfiguration>
	{
		#region Constants
		public const string CONFIGURATION = "configuration";
		#endregion

		public AiRecommendationTreePartnerConfiguration Configuration { get; set; }

		public AiRecommendationTreeUpsertPartnerConfigRequestBuilder()
			: base("airecommendationtree", "upsertPartnerConfig")
		{
		}

		public AiRecommendationTreeUpsertPartnerConfigRequestBuilder(AiRecommendationTreePartnerConfiguration configuration)
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
			return ObjectFactory.Create<AiRecommendationTreePartnerConfiguration>(result);
		}
	}


	public class AiRecommendationTreeService
	{
		private AiRecommendationTreeService()
		{
		}

		public static AiRecommendationTreeGetNextNodeAndRecommendationRequestBuilder GetNextNodeAndRecommendation(string treeId = null, string previousQuestionId = null, string answerId = null, string topQuestionId = null)
		{
			return new AiRecommendationTreeGetNextNodeAndRecommendationRequestBuilder(treeId, previousQuestionId, answerId, topQuestionId);
		}

		public static AiRecommendationTreeGetPartnerConfigRequestBuilder GetPartnerConfig()
		{
			return new AiRecommendationTreeGetPartnerConfigRequestBuilder();
		}

		public static AiRecommendationTreeGetRecommendationWithNaturalTextRequestBuilder GetRecommendationWithNaturalText(string naturalTextQuery, string previousQuestionId = null, string treeId = null)
		{
			return new AiRecommendationTreeGetRecommendationWithNaturalTextRequestBuilder(naturalTextQuery, previousQuestionId, treeId);
		}

		public static AiRecommendationTreeUpsertPartnerConfigRequestBuilder UpsertPartnerConfig(AiRecommendationTreePartnerConfiguration configuration)
		{
			return new AiRecommendationTreeUpsertPartnerConfigRequestBuilder(configuration);
		}
	}
}
