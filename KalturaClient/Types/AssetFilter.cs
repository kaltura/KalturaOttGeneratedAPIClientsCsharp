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
	public class AssetFilter : PersistedFilter
	{
		#region Constants
		public const string DYNAMIC_ORDER_BY = "dynamicOrderBy";
		public const string ORDERING_PARAMETERS = "orderingParameters";
		public const string TRENDING_DAYS_EQUAL = "trendingDaysEqual";
		public const string SHOULD_APPLY_PRIORITY_GROUPS_EQUAL = "shouldApplyPriorityGroupsEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private DynamicOrderBy _DynamicOrderBy;
		private IList<BaseAssetOrder> _OrderingParameters;
		private int _TrendingDaysEqual = Int32.MinValue;
		private bool? _ShouldApplyPriorityGroupsEqual = null;
		private AssetOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use DynamicOrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DynamicOrderBy DynamicOrderBy
		{
			get { return _DynamicOrderBy; }
			set 
			{ 
				_DynamicOrderBy = value;
				OnPropertyChanged("DynamicOrderBy");
			}
		}
		/// <summary>
		/// Use OrderingParametersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<BaseAssetOrder> OrderingParameters
		{
			get { return _OrderingParameters; }
			set 
			{ 
				_OrderingParameters = value;
				OnPropertyChanged("OrderingParameters");
			}
		}
		/// <summary>
		/// Use TrendingDaysEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int TrendingDaysEqual
		{
			get { return _TrendingDaysEqual; }
			set 
			{ 
				_TrendingDaysEqual = value;
				OnPropertyChanged("TrendingDaysEqual");
			}
		}
		/// <summary>
		/// Use ShouldApplyPriorityGroupsEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ShouldApplyPriorityGroupsEqual
		{
			get { return _ShouldApplyPriorityGroupsEqual; }
			set 
			{ 
				_ShouldApplyPriorityGroupsEqual = value;
				OnPropertyChanged("ShouldApplyPriorityGroupsEqual");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new AssetOrderBy OrderBy
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
		public AssetFilter()
		{
		}

		public AssetFilter(JToken node) : base(node)
		{
			if(node["dynamicOrderBy"] != null)
			{
				this._DynamicOrderBy = ObjectFactory.Create<DynamicOrderBy>(node["dynamicOrderBy"]);
			}
			if(node["orderingParameters"] != null)
			{
				this._OrderingParameters = new List<BaseAssetOrder>();
				foreach(var arrayNode in node["orderingParameters"].Children())
				{
					this._OrderingParameters.Add(ObjectFactory.Create<BaseAssetOrder>(arrayNode));
				}
			}
			if(node["trendingDaysEqual"] != null)
			{
				this._TrendingDaysEqual = ParseInt(node["trendingDaysEqual"].Value<string>());
			}
			if(node["shouldApplyPriorityGroupsEqual"] != null)
			{
				this._ShouldApplyPriorityGroupsEqual = ParseBool(node["shouldApplyPriorityGroupsEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (AssetOrderBy)StringEnum.Parse(typeof(AssetOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetFilter");
			kparams.AddIfNotNull("dynamicOrderBy", this._DynamicOrderBy);
			kparams.AddIfNotNull("orderingParameters", this._OrderingParameters);
			kparams.AddIfNotNull("trendingDaysEqual", this._TrendingDaysEqual);
			kparams.AddIfNotNull("shouldApplyPriorityGroupsEqual", this._ShouldApplyPriorityGroupsEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DYNAMIC_ORDER_BY:
					return "DynamicOrderBy";
				case ORDERING_PARAMETERS:
					return "OrderingParameters";
				case TRENDING_DAYS_EQUAL:
					return "TrendingDaysEqual";
				case SHOULD_APPLY_PRIORITY_GROUPS_EQUAL:
					return "ShouldApplyPriorityGroupsEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

