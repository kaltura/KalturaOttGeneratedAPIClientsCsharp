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
	public class TreeNextNodeResponse : ObjectBase
	{
		#region Constants
		public const string QUESTION = "question";
		public const string ANSWERS = "answers";
		public const string RECOMMENDATIONS = "recommendations";
		#endregion

		#region Private Fields
		private TreeQuestion _Question;
		private IList<TreeAnswer> _Answers;
		private TreeRecommendations _Recommendations;
		#endregion

		#region Properties
		/// <summary>
		/// Use QuestionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TreeQuestion Question
		{
			get { return _Question; }
			set 
			{ 
				_Question = value;
				OnPropertyChanged("Question");
			}
		}
		/// <summary>
		/// Use AnswersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<TreeAnswer> Answers
		{
			get { return _Answers; }
			set 
			{ 
				_Answers = value;
				OnPropertyChanged("Answers");
			}
		}
		/// <summary>
		/// Use RecommendationsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TreeRecommendations Recommendations
		{
			get { return _Recommendations; }
			set 
			{ 
				_Recommendations = value;
				OnPropertyChanged("Recommendations");
			}
		}
		#endregion

		#region CTor
		public TreeNextNodeResponse()
		{
		}

		public TreeNextNodeResponse(JToken node) : base(node)
		{
			if(node["question"] != null)
			{
				this._Question = ObjectFactory.Create<TreeQuestion>(node["question"]);
			}
			if(node["answers"] != null)
			{
				this._Answers = new List<TreeAnswer>();
				foreach(var arrayNode in node["answers"].Children())
				{
					this._Answers.Add(ObjectFactory.Create<TreeAnswer>(arrayNode));
				}
			}
			if(node["recommendations"] != null)
			{
				this._Recommendations = ObjectFactory.Create<TreeRecommendations>(node["recommendations"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTreeNextNodeResponse");
			kparams.AddIfNotNull("question", this._Question);
			kparams.AddIfNotNull("answers", this._Answers);
			kparams.AddIfNotNull("recommendations", this._Recommendations);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case QUESTION:
					return "Question";
				case ANSWERS:
					return "Answers";
				case RECOMMENDATIONS:
					return "Recommendations";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

