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
	public class SearchScope : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string FILTERS = "filters";
		#endregion

		#region Private Fields
		private SearchType _Type = null;
		private IList<SearchCondition> _Filters;
		#endregion

		#region Properties
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SearchType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use FiltersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<SearchCondition> Filters
		{
			get { return _Filters; }
			set 
			{ 
				_Filters = value;
				OnPropertyChanged("Filters");
			}
		}
		#endregion

		#region CTor
		public SearchScope()
		{
		}

		public SearchScope(JToken node) : base(node)
		{
			if(node["type"] != null)
			{
				this._Type = (SearchType)StringEnum.Parse(typeof(SearchType), node["type"].Value<string>());
			}
			if(node["filters"] != null)
			{
				this._Filters = new List<SearchCondition>();
				foreach(var arrayNode in node["filters"].Children())
				{
					this._Filters.Add(ObjectFactory.Create<SearchCondition>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSearchScope");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("filters", this._Filters);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case FILTERS:
					return "Filters";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

