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
	public class Subtitles : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATE_DATE = "createDate";
		public const string FILE_NAME = "fileName";
		public const string SUBTITLES_TYPE = "subtitlesType";
		public const string SUBTITLES_LANGUAGE = "subtitlesLanguage";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private long _CreateDate = long.MinValue;
		private string _FileName = null;
		private SubtitlesType _SubtitlesType = null;
		private string _SubtitlesLanguage = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use CreateDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CreateDate
		{
			get { return _CreateDate; }
			private set 
			{ 
				_CreateDate = value;
				OnPropertyChanged("CreateDate");
			}
		}
		/// <summary>
		/// Use FileNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		/// <summary>
		/// Use SubtitlesTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SubtitlesType SubtitlesType
		{
			get { return _SubtitlesType; }
			set 
			{ 
				_SubtitlesType = value;
				OnPropertyChanged("SubtitlesType");
			}
		}
		/// <summary>
		/// Use SubtitlesLanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SubtitlesLanguage
		{
			get { return _SubtitlesLanguage; }
			set 
			{ 
				_SubtitlesLanguage = value;
				OnPropertyChanged("SubtitlesLanguage");
			}
		}
		#endregion

		#region CTor
		public Subtitles()
		{
		}

		public Subtitles(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["createDate"] != null)
			{
				this._CreateDate = ParseLong(node["createDate"].Value<string>());
			}
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["subtitlesType"] != null)
			{
				this._SubtitlesType = (SubtitlesType)StringEnum.Parse(typeof(SubtitlesType), node["subtitlesType"].Value<string>());
			}
			if(node["subtitlesLanguage"] != null)
			{
				this._SubtitlesLanguage = node["subtitlesLanguage"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSubtitles");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("subtitlesType", this._SubtitlesType);
			kparams.AddIfNotNull("subtitlesLanguage", this._SubtitlesLanguage);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATE_DATE:
					return "CreateDate";
				case FILE_NAME:
					return "FileName";
				case SUBTITLES_TYPE:
					return "SubtitlesType";
				case SUBTITLES_LANGUAGE:
					return "SubtitlesLanguage";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

