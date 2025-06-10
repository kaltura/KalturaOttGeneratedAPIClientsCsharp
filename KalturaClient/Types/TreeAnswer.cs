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
	public class TreeAnswer : ObjectBase
	{
		#region Constants
		public const string ANSWER_ID = "answerId";
		public const string TEXT = "text";
		public const string HAS_NEXT_QUESTION = "hasNextQuestion";
		public const string IS_SPECIAL = "isSpecial";
		public const string SPECIAL_TYPE = "specialType";
		#endregion

		#region Private Fields
		private string _AnswerId = null;
		private string _Text = null;
		private bool? _HasNextQuestion = null;
		private bool? _IsSpecial = null;
		private string _SpecialType = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AnswerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AnswerId
		{
			get { return _AnswerId; }
			set 
			{ 
				_AnswerId = value;
				OnPropertyChanged("AnswerId");
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
		/// Use HasNextQuestionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? HasNextQuestion
		{
			get { return _HasNextQuestion; }
			set 
			{ 
				_HasNextQuestion = value;
				OnPropertyChanged("HasNextQuestion");
			}
		}
		/// <summary>
		/// Use IsSpecialAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsSpecial
		{
			get { return _IsSpecial; }
			set 
			{ 
				_IsSpecial = value;
				OnPropertyChanged("IsSpecial");
			}
		}
		/// <summary>
		/// Use SpecialTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SpecialType
		{
			get { return _SpecialType; }
			set 
			{ 
				_SpecialType = value;
				OnPropertyChanged("SpecialType");
			}
		}
		#endregion

		#region CTor
		public TreeAnswer()
		{
		}

		public TreeAnswer(JToken node) : base(node)
		{
			if(node["answerId"] != null)
			{
				this._AnswerId = node["answerId"].Value<string>();
			}
			if(node["text"] != null)
			{
				this._Text = node["text"].Value<string>();
			}
			if(node["hasNextQuestion"] != null)
			{
				this._HasNextQuestion = ParseBool(node["hasNextQuestion"].Value<string>());
			}
			if(node["isSpecial"] != null)
			{
				this._IsSpecial = ParseBool(node["isSpecial"].Value<string>());
			}
			if(node["specialType"] != null)
			{
				this._SpecialType = node["specialType"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTreeAnswer");
			kparams.AddIfNotNull("answerId", this._AnswerId);
			kparams.AddIfNotNull("text", this._Text);
			kparams.AddIfNotNull("hasNextQuestion", this._HasNextQuestion);
			kparams.AddIfNotNull("isSpecial", this._IsSpecial);
			kparams.AddIfNotNull("specialType", this._SpecialType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ANSWER_ID:
					return "AnswerId";
				case TEXT:
					return "Text";
				case HAS_NEXT_QUESTION:
					return "HasNextQuestion";
				case IS_SPECIAL:
					return "IsSpecial";
				case SPECIAL_TYPE:
					return "SpecialType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

