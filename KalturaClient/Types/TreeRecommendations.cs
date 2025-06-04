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
	public class TreeRecommendations : ObjectBase
	{
		#region Constants
		public const string TITLE = "title";
		public const string SEARCH_QUERY = "searchQuery";
		public const string ASSET_IDS = "assetIds";
		#endregion

		#region Private Fields
		private string _Title = null;
		private string _SearchQuery = null;
		private IList<StringValue> _AssetIds;
		#endregion

		#region Properties
		/// <summary>
		/// Use TitleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		/// <summary>
		/// Use SearchQueryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SearchQuery
		{
			get { return _SearchQuery; }
			set 
			{ 
				_SearchQuery = value;
				OnPropertyChanged("SearchQuery");
			}
		}
		/// <summary>
		/// Use AssetIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<StringValue> AssetIds
		{
			get { return _AssetIds; }
			set 
			{ 
				_AssetIds = value;
				OnPropertyChanged("AssetIds");
			}
		}
		#endregion

		#region CTor
		public TreeRecommendations()
		{
		}

		public TreeRecommendations(JToken node) : base(node)
		{
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
			if(node["searchQuery"] != null)
			{
				this._SearchQuery = node["searchQuery"].Value<string>();
			}
			if(node["assetIds"] != null)
			{
				this._AssetIds = new List<StringValue>();
				foreach(var arrayNode in node["assetIds"].Children())
				{
					this._AssetIds.Add(ObjectFactory.Create<StringValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTreeRecommendations");
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("searchQuery", this._SearchQuery);
			kparams.AddIfNotNull("assetIds", this._AssetIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TITLE:
					return "Title";
				case SEARCH_QUERY:
					return "SearchQuery";
				case ASSET_IDS:
					return "AssetIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

