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
	public class MetaFieldNameMap : ObjectBase
	{
		#region Constants
		public const string GENRE = "genre";
		public const string SENTIMENT = "sentiment";
		public const string SHORT_DESCRIPTION = "shortDescription";
		public const string LONG_DESCRIPTION = "longDescription";
		public const string ONE_LINER = "oneLiner";
		public const string KEYWORDS = "keywords";
		#endregion

		#region Private Fields
		private string _Genre = null;
		private string _Sentiment = null;
		private string _ShortDescription = null;
		private string _LongDescription = null;
		private string _OneLiner = null;
		private string _Keywords = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use GenreAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Genre
		{
			get { return _Genre; }
			set 
			{ 
				_Genre = value;
				OnPropertyChanged("Genre");
			}
		}
		/// <summary>
		/// Use SentimentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Sentiment
		{
			get { return _Sentiment; }
			set 
			{ 
				_Sentiment = value;
				OnPropertyChanged("Sentiment");
			}
		}
		/// <summary>
		/// Use ShortDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ShortDescription
		{
			get { return _ShortDescription; }
			set 
			{ 
				_ShortDescription = value;
				OnPropertyChanged("ShortDescription");
			}
		}
		/// <summary>
		/// Use LongDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LongDescription
		{
			get { return _LongDescription; }
			set 
			{ 
				_LongDescription = value;
				OnPropertyChanged("LongDescription");
			}
		}
		/// <summary>
		/// Use OneLinerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OneLiner
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
		public string Keywords
		{
			get { return _Keywords; }
			set 
			{ 
				_Keywords = value;
				OnPropertyChanged("Keywords");
			}
		}
		#endregion

		#region CTor
		public MetaFieldNameMap()
		{
		}

		public MetaFieldNameMap(JToken node) : base(node)
		{
			if(node["genre"] != null)
			{
				this._Genre = node["genre"].Value<string>();
			}
			if(node["sentiment"] != null)
			{
				this._Sentiment = node["sentiment"].Value<string>();
			}
			if(node["shortDescription"] != null)
			{
				this._ShortDescription = node["shortDescription"].Value<string>();
			}
			if(node["longDescription"] != null)
			{
				this._LongDescription = node["longDescription"].Value<string>();
			}
			if(node["oneLiner"] != null)
			{
				this._OneLiner = node["oneLiner"].Value<string>();
			}
			if(node["keywords"] != null)
			{
				this._Keywords = node["keywords"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetaFieldNameMap");
			kparams.AddIfNotNull("genre", this._Genre);
			kparams.AddIfNotNull("sentiment", this._Sentiment);
			kparams.AddIfNotNull("shortDescription", this._ShortDescription);
			kparams.AddIfNotNull("longDescription", this._LongDescription);
			kparams.AddIfNotNull("oneLiner", this._OneLiner);
			kparams.AddIfNotNull("keywords", this._Keywords);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case GENRE:
					return "Genre";
				case SENTIMENT:
					return "Sentiment";
				case SHORT_DESCRIPTION:
					return "ShortDescription";
				case LONG_DESCRIPTION:
					return "LongDescription";
				case ONE_LINER:
					return "OneLiner";
				case KEYWORDS:
					return "Keywords";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

