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
	public class TreeQuestion : ObjectBase
	{
		#region Constants
		public const string QUESTION_ID = "questionId";
		public const string TEXT = "text";
		public const string LEVEL = "level";
		#endregion

		#region Private Fields
		private string _QuestionId = null;
		private string _Text = null;
		private int _Level = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use QuestionIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string QuestionId
		{
			get { return _QuestionId; }
			set 
			{ 
				_QuestionId = value;
				OnPropertyChanged("QuestionId");
			}
		}
		/// <summary>
		/// Use TextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		/// <summary>
		/// Use LevelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Level
		{
			get { return _Level; }
			set 
			{ 
				_Level = value;
				OnPropertyChanged("Level");
			}
		}
		#endregion

		#region CTor
		public TreeQuestion()
		{
		}

		public TreeQuestion(JToken node) : base(node)
		{
			if(node["questionId"] != null)
			{
				this._QuestionId = node["questionId"].Value<string>();
			}
			if(node["text"] != null)
			{
				this._Text = node["text"].Value<string>();
			}
			if(node["level"] != null)
			{
				this._Level = ParseInt(node["level"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTreeQuestion");
			kparams.AddIfNotNull("questionId", this._QuestionId);
			kparams.AddIfNotNull("text", this._Text);
			kparams.AddIfNotNull("level", this._Level);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case QUESTION_ID:
					return "QuestionId";
				case TEXT:
					return "Text";
				case LEVEL:
					return "Level";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

