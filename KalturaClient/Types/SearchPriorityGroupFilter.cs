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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class SearchPriorityGroupFilter : Filter
	{
		#region Constants
		public const string ACTIVE_ONLY_EQUAL = "activeOnlyEqual";
		public const string ID_EQUAL = "idEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private bool? _ActiveOnlyEqual = null;
		private long _IdEqual = long.MinValue;
		private SearchPriorityGroupOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ActiveOnlyEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ActiveOnlyEqual
		{
			get { return _ActiveOnlyEqual; }
			set 
			{ 
				_ActiveOnlyEqual = value;
				OnPropertyChanged("ActiveOnlyEqual");
			}
		}
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new SearchPriorityGroupOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public SearchPriorityGroupFilter()
		{
		}

		public SearchPriorityGroupFilter(JToken node) : base(node)
		{
			if(node["activeOnlyEqual"] != null)
			{
				this._ActiveOnlyEqual = ParseBool(node["activeOnlyEqual"].Value<string>());
			}
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseLong(node["idEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (SearchPriorityGroupOrderBy)StringEnum.Parse(typeof(SearchPriorityGroupOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSearchPriorityGroupFilter");
			kparams.AddIfNotNull("activeOnlyEqual", this._ActiveOnlyEqual);
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ACTIVE_ONLY_EQUAL:
					return "ActiveOnlyEqual";
				case ID_EQUAL:
					return "IdEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

