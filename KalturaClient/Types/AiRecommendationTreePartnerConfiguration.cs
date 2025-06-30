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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class AiRecommendationTreePartnerConfiguration : ObjectBase
	{
		#region Constants
		public const string ACTIVE_METADATA_TYPES = "activeMetadataTypes";
		public const string TOP_LEVEL_QUESTIONS = "topLevelQuestions";
		public const string ANSWERS_PER_QUESTION = "answersPerQuestion";
		public const string LEVELS = "levels";
		public const string SPECIAL_ANSWERS = "specialAnswers";
		public const string NUM_OF_RECOMMENDED_ASSETS = "numOfRecommendedAssets";
		public const string TREE_GENERATION_FREQUENCY = "treeGenerationFrequency";
		public const string ACTIVE_TREE_ID = "activeTreeId";
		#endregion

		#region Private Fields
		private IDictionary<string, IntegerValue> _ActiveMetadataTypes;
		private int _TopLevelQuestions = Int32.MinValue;
		private int _AnswersPerQuestion = Int32.MinValue;
		private int _Levels = Int32.MinValue;
		private bool? _SpecialAnswers = null;
		private int _NumOfRecommendedAssets = Int32.MinValue;
		private string _TreeGenerationFrequency = null;
		private string _ActiveTreeId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ActiveMetadataTypesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IDictionary<string, IntegerValue> ActiveMetadataTypes
		{
			get { return _ActiveMetadataTypes; }
			set 
			{ 
				_ActiveMetadataTypes = value;
				OnPropertyChanged("ActiveMetadataTypes");
			}
		}
		/// <summary>
		/// Use TopLevelQuestionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int TopLevelQuestions
		{
			get { return _TopLevelQuestions; }
			set 
			{ 
				_TopLevelQuestions = value;
				OnPropertyChanged("TopLevelQuestions");
			}
		}
		/// <summary>
		/// Use AnswersPerQuestionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AnswersPerQuestion
		{
			get { return _AnswersPerQuestion; }
			set 
			{ 
				_AnswersPerQuestion = value;
				OnPropertyChanged("AnswersPerQuestion");
			}
		}
		/// <summary>
		/// Use LevelsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Levels
		{
			get { return _Levels; }
			set 
			{ 
				_Levels = value;
				OnPropertyChanged("Levels");
			}
		}
		/// <summary>
		/// Use SpecialAnswersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? SpecialAnswers
		{
			get { return _SpecialAnswers; }
			set 
			{ 
				_SpecialAnswers = value;
				OnPropertyChanged("SpecialAnswers");
			}
		}
		/// <summary>
		/// Use NumOfRecommendedAssetsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int NumOfRecommendedAssets
		{
			get { return _NumOfRecommendedAssets; }
			set 
			{ 
				_NumOfRecommendedAssets = value;
				OnPropertyChanged("NumOfRecommendedAssets");
			}
		}
		/// <summary>
		/// Use TreeGenerationFrequencyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TreeGenerationFrequency
		{
			get { return _TreeGenerationFrequency; }
			set 
			{ 
				_TreeGenerationFrequency = value;
				OnPropertyChanged("TreeGenerationFrequency");
			}
		}
		/// <summary>
		/// Use ActiveTreeIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ActiveTreeId
		{
			get { return _ActiveTreeId; }
			set 
			{ 
				_ActiveTreeId = value;
				OnPropertyChanged("ActiveTreeId");
			}
		}
		#endregion

		#region CTor
		public AiRecommendationTreePartnerConfiguration()
		{
		}

		public AiRecommendationTreePartnerConfiguration(JToken node) : base(node)
		{
			if(node["activeMetadataTypes"] != null)
			{
				{
					string key;
					this._ActiveMetadataTypes = new Dictionary<string, IntegerValue>();
					foreach(var arrayNode in node["activeMetadataTypes"].Children<JProperty>())
					{
						key = arrayNode.Name;
						this._ActiveMetadataTypes[key] = ObjectFactory.Create<IntegerValue>(arrayNode.Value);
					}
				}
			}
			if(node["topLevelQuestions"] != null)
			{
				this._TopLevelQuestions = ParseInt(node["topLevelQuestions"].Value<string>());
			}
			if(node["answersPerQuestion"] != null)
			{
				this._AnswersPerQuestion = ParseInt(node["answersPerQuestion"].Value<string>());
			}
			if(node["levels"] != null)
			{
				this._Levels = ParseInt(node["levels"].Value<string>());
			}
			if(node["specialAnswers"] != null)
			{
				this._SpecialAnswers = ParseBool(node["specialAnswers"].Value<string>());
			}
			if(node["numOfRecommendedAssets"] != null)
			{
				this._NumOfRecommendedAssets = ParseInt(node["numOfRecommendedAssets"].Value<string>());
			}
			if(node["treeGenerationFrequency"] != null)
			{
				this._TreeGenerationFrequency = node["treeGenerationFrequency"].Value<string>();
			}
			if(node["activeTreeId"] != null)
			{
				this._ActiveTreeId = node["activeTreeId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAiRecommendationTreePartnerConfiguration");
			kparams.AddIfNotNull("activeMetadataTypes", this._ActiveMetadataTypes);
			kparams.AddIfNotNull("topLevelQuestions", this._TopLevelQuestions);
			kparams.AddIfNotNull("answersPerQuestion", this._AnswersPerQuestion);
			kparams.AddIfNotNull("levels", this._Levels);
			kparams.AddIfNotNull("specialAnswers", this._SpecialAnswers);
			kparams.AddIfNotNull("numOfRecommendedAssets", this._NumOfRecommendedAssets);
			kparams.AddIfNotNull("treeGenerationFrequency", this._TreeGenerationFrequency);
			kparams.AddIfNotNull("activeTreeId", this._ActiveTreeId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ACTIVE_METADATA_TYPES:
					return "ActiveMetadataTypes";
				case TOP_LEVEL_QUESTIONS:
					return "TopLevelQuestions";
				case ANSWERS_PER_QUESTION:
					return "AnswersPerQuestion";
				case LEVELS:
					return "Levels";
				case SPECIAL_ANSWERS:
					return "SpecialAnswers";
				case NUM_OF_RECOMMENDED_ASSETS:
					return "NumOfRecommendedAssets";
				case TREE_GENERATION_FREQUENCY:
					return "TreeGenerationFrequency";
				case ACTIVE_TREE_ID:
					return "ActiveTreeId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

