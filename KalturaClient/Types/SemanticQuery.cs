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
	public class SemanticQuery : ObjectBase
	{
		#region Constants
		public const string SUB_QUERIES = "subQueries";
		public const string TITLE = "title";
		#endregion

		#region Private Fields
		private IList<SemanticSubQuery> _SubQueries;
		private string _Title = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SubQueriesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<SemanticSubQuery> SubQueries
		{
			get { return _SubQueries; }
			set 
			{ 
				_SubQueries = value;
				OnPropertyChanged("SubQueries");
			}
		}
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
		#endregion

		#region CTor
		public SemanticQuery()
		{
		}

		public SemanticQuery(JToken node) : base(node)
		{
			if(node["subQueries"] != null)
			{
				this._SubQueries = new List<SemanticSubQuery>();
				foreach(var arrayNode in node["subQueries"].Children())
				{
					this._SubQueries.Add(ObjectFactory.Create<SemanticSubQuery>(arrayNode));
				}
			}
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSemanticQuery");
			kparams.AddIfNotNull("subQueries", this._SubQueries);
			kparams.AddIfNotNull("title", this._Title);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SUB_QUERIES:
					return "SubQueries";
				case TITLE:
					return "Title";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

