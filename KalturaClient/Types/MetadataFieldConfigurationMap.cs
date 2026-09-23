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
	public class MetadataFieldConfigurationMap : ObjectBase
	{
		#region Constants
		public const string GENRE = "genre";
		public const string SUB_GENRE = "subGenre";
		public const string SENTIMENT = "sentiment";
		public const string SUGGESTED_TITLE = "suggestedTitle";
		public const string DESCRIPTION = "description";
		public const string ONE_LINER = "oneLiner";
		public const string KEYWORDS = "keywords";
		public const string SENSITIVE_CONTENT = "sensitiveContent";
		#endregion

		#region Private Fields
		private MetadataFieldConfig _Genre;
		private MetadataFieldConfig _SubGenre;
		private MetadataFieldConfig _Sentiment;
		private MetadataFieldConfig _SuggestedTitle;
		private MetadataFieldConfig _Description;
		private MetadataFieldConfig _OneLiner;
		private MetadataFieldConfig _Keywords;
		private MetadataFieldConfig _SensitiveContent;
		#endregion

		#region Properties
		/// <summary>
		/// Use GenreAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig Genre
		{
			get { return _Genre; }
			set 
			{ 
				_Genre = value;
				OnPropertyChanged("Genre");
			}
		}
		/// <summary>
		/// Use SubGenreAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig SubGenre
		{
			get { return _SubGenre; }
			set 
			{ 
				_SubGenre = value;
				OnPropertyChanged("SubGenre");
			}
		}
		/// <summary>
		/// Use SentimentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig Sentiment
		{
			get { return _Sentiment; }
			set 
			{ 
				_Sentiment = value;
				OnPropertyChanged("Sentiment");
			}
		}
		/// <summary>
		/// Use SuggestedTitleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig SuggestedTitle
		{
			get { return _SuggestedTitle; }
			set 
			{ 
				_SuggestedTitle = value;
				OnPropertyChanged("SuggestedTitle");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use OneLinerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig OneLiner
		{
			get { return _OneLiner; }
			set 
			{ 
				_OneLiner = value;
				OnPropertyChanged("OneLiner");
			}
		}
		/// <summary>
		/// Use KeywordsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig Keywords
		{
			get { return _Keywords; }
			set 
			{ 
				_Keywords = value;
				OnPropertyChanged("Keywords");
			}
		}
		/// <summary>
		/// Use SensitiveContentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataFieldConfig SensitiveContent
		{
			get { return _SensitiveContent; }
			set 
			{ 
				_SensitiveContent = value;
				OnPropertyChanged("SensitiveContent");
			}
		}
		#endregion

		#region CTor
		public MetadataFieldConfigurationMap()
		{
		}

		public MetadataFieldConfigurationMap(JToken node) : base(node)
		{
			if(node["genre"] != null)
			{
				this._Genre = ObjectFactory.Create<MetadataFieldConfig>(node["genre"]);
			}
			if(node["subGenre"] != null)
			{
				this._SubGenre = ObjectFactory.Create<MetadataFieldConfig>(node["subGenre"]);
			}
			if(node["sentiment"] != null)
			{
				this._Sentiment = ObjectFactory.Create<MetadataFieldConfig>(node["sentiment"]);
			}
			if(node["suggestedTitle"] != null)
			{
				this._SuggestedTitle = ObjectFactory.Create<MetadataFieldConfig>(node["suggestedTitle"]);
			}
			if(node["description"] != null)
			{
				this._Description = ObjectFactory.Create<MetadataFieldConfig>(node["description"]);
			}
			if(node["oneLiner"] != null)
			{
				this._OneLiner = ObjectFactory.Create<MetadataFieldConfig>(node["oneLiner"]);
			}
			if(node["keywords"] != null)
			{
				this._Keywords = ObjectFactory.Create<MetadataFieldConfig>(node["keywords"]);
			}
			if(node["sensitiveContent"] != null)
			{
				this._SensitiveContent = ObjectFactory.Create<MetadataFieldConfig>(node["sensitiveContent"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetadataFieldConfigurationMap");
			kparams.AddIfNotNull("genre", this._Genre);
			kparams.AddIfNotNull("subGenre", this._SubGenre);
			kparams.AddIfNotNull("sentiment", this._Sentiment);
			kparams.AddIfNotNull("suggestedTitle", this._SuggestedTitle);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("oneLiner", this._OneLiner);
			kparams.AddIfNotNull("keywords", this._Keywords);
			kparams.AddIfNotNull("sensitiveContent", this._SensitiveContent);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case GENRE:
					return "Genre";
				case SUB_GENRE:
					return "SubGenre";
				case SENTIMENT:
					return "Sentiment";
				case SUGGESTED_TITLE:
					return "SuggestedTitle";
				case DESCRIPTION:
					return "Description";
				case ONE_LINER:
					return "OneLiner";
				case KEYWORDS:
					return "Keywords";
				case SENSITIVE_CONTENT:
					return "SensitiveContent";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

