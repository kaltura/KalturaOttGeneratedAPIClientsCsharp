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
	public class SemanticQueryPartnerConfiguration : ObjectBase
	{
		#region Constants
		public const string SUB_QUERIES_COUNT = "subQueriesCount";
		public const string DEFAULT_QUERIES_COUNT = "defaultQueriesCount";
		public const string ASSETS_PER_COLLECTION_COUNT = "assetsPerCollectionCount";
		#endregion

		#region Private Fields
		private int _SubQueriesCount = Int32.MinValue;
		private int _DefaultQueriesCount = Int32.MinValue;
		private int _AssetsPerCollectionCount = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use SubQueriesCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SubQueriesCount
		{
			get { return _SubQueriesCount; }
			set 
			{ 
				_SubQueriesCount = value;
				OnPropertyChanged("SubQueriesCount");
			}
		}
		/// <summary>
		/// Use DefaultQueriesCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DefaultQueriesCount
		{
			get { return _DefaultQueriesCount; }
			set 
			{ 
				_DefaultQueriesCount = value;
				OnPropertyChanged("DefaultQueriesCount");
			}
		}
		/// <summary>
		/// Use AssetsPerCollectionCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AssetsPerCollectionCount
		{
			get { return _AssetsPerCollectionCount; }
			set 
			{ 
				_AssetsPerCollectionCount = value;
				OnPropertyChanged("AssetsPerCollectionCount");
			}
		}
		#endregion

		#region CTor
		public SemanticQueryPartnerConfiguration()
		{
		}

		public SemanticQueryPartnerConfiguration(JToken node) : base(node)
		{
			if(node["subQueriesCount"] != null)
			{
				this._SubQueriesCount = ParseInt(node["subQueriesCount"].Value<string>());
			}
			if(node["defaultQueriesCount"] != null)
			{
				this._DefaultQueriesCount = ParseInt(node["defaultQueriesCount"].Value<string>());
			}
			if(node["assetsPerCollectionCount"] != null)
			{
				this._AssetsPerCollectionCount = ParseInt(node["assetsPerCollectionCount"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSemanticQueryPartnerConfiguration");
			kparams.AddIfNotNull("subQueriesCount", this._SubQueriesCount);
			kparams.AddIfNotNull("defaultQueriesCount", this._DefaultQueriesCount);
			kparams.AddIfNotNull("assetsPerCollectionCount", this._AssetsPerCollectionCount);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SUB_QUERIES_COUNT:
					return "SubQueriesCount";
				case DEFAULT_QUERIES_COUNT:
					return "DefaultQueriesCount";
				case ASSETS_PER_COLLECTION_COUNT:
					return "AssetsPerCollectionCount";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

