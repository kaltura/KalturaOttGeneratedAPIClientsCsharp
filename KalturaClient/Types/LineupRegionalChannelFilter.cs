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
	public class LineupRegionalChannelFilter : Filter
	{
		#region Constants
		public const string REGION_ID_EQUAL = "regionIdEqual";
		public const string PARENT_REGION_INCLUDED = "parentRegionIncluded";
		public const string KSQL = "kSql";
		public const string LCN_GREATER_THAN_OR_EQUAL = "lcnGreaterThanOrEqual";
		public const string LCN_LESS_THAN_OR_EQUAL = "lcnLessThanOrEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private long _RegionIdEqual = long.MinValue;
		private bool? _ParentRegionIncluded = null;
		private string _KSql = null;
		private int _LcnGreaterThanOrEqual = Int32.MinValue;
		private int _LcnLessThanOrEqual = Int32.MinValue;
		private LineupRegionalChannelOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use RegionIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long RegionIdEqual
		{
			get { return _RegionIdEqual; }
			set 
			{ 
				_RegionIdEqual = value;
				OnPropertyChanged("RegionIdEqual");
			}
		}
		/// <summary>
		/// Use ParentRegionIncludedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ParentRegionIncluded
		{
			get { return _ParentRegionIncluded; }
			set 
			{ 
				_ParentRegionIncluded = value;
				OnPropertyChanged("ParentRegionIncluded");
			}
		}
		/// <summary>
		/// Use KSqlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string KSql
		{
			get { return _KSql; }
			set 
			{ 
				_KSql = value;
				OnPropertyChanged("KSql");
			}
		}
		/// <summary>
		/// Use LcnGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LcnGreaterThanOrEqual
		{
			get { return _LcnGreaterThanOrEqual; }
			set 
			{ 
				_LcnGreaterThanOrEqual = value;
				OnPropertyChanged("LcnGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use LcnLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LcnLessThanOrEqual
		{
			get { return _LcnLessThanOrEqual; }
			set 
			{ 
				_LcnLessThanOrEqual = value;
				OnPropertyChanged("LcnLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new LineupRegionalChannelOrderBy OrderBy
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
		public LineupRegionalChannelFilter()
		{
		}

		public LineupRegionalChannelFilter(JToken node) : base(node)
		{
			if(node["regionIdEqual"] != null)
			{
				this._RegionIdEqual = ParseLong(node["regionIdEqual"].Value<string>());
			}
			if(node["parentRegionIncluded"] != null)
			{
				this._ParentRegionIncluded = ParseBool(node["parentRegionIncluded"].Value<string>());
			}
			if(node["kSql"] != null)
			{
				this._KSql = node["kSql"].Value<string>();
			}
			if(node["lcnGreaterThanOrEqual"] != null)
			{
				this._LcnGreaterThanOrEqual = ParseInt(node["lcnGreaterThanOrEqual"].Value<string>());
			}
			if(node["lcnLessThanOrEqual"] != null)
			{
				this._LcnLessThanOrEqual = ParseInt(node["lcnLessThanOrEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (LineupRegionalChannelOrderBy)StringEnum.Parse(typeof(LineupRegionalChannelOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLineupRegionalChannelFilter");
			kparams.AddIfNotNull("regionIdEqual", this._RegionIdEqual);
			kparams.AddIfNotNull("parentRegionIncluded", this._ParentRegionIncluded);
			kparams.AddIfNotNull("kSql", this._KSql);
			kparams.AddIfNotNull("lcnGreaterThanOrEqual", this._LcnGreaterThanOrEqual);
			kparams.AddIfNotNull("lcnLessThanOrEqual", this._LcnLessThanOrEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case REGION_ID_EQUAL:
					return "RegionIdEqual";
				case PARENT_REGION_INCLUDED:
					return "ParentRegionIncluded";
				case KSQL:
					return "KSql";
				case LCN_GREATER_THAN_OR_EQUAL:
					return "LcnGreaterThanOrEqual";
				case LCN_LESS_THAN_OR_EQUAL:
					return "LcnLessThanOrEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

