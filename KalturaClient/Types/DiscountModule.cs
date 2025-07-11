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
	public class DiscountModule : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PERCENT = "percent";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string ASSET_USER_RULE_ID = "assetUserRuleId";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private double _Percent = Double.MinValue;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private long _AssetUserRuleId = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use PercentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Percent
		{
			get { return _Percent; }
			set 
			{ 
				_Percent = value;
				OnPropertyChanged("Percent");
			}
		}
		/// <summary>
		/// Use StartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		/// <summary>
		/// Use EndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		/// <summary>
		/// Use AssetUserRuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long AssetUserRuleId
		{
			get { return _AssetUserRuleId; }
			set 
			{ 
				_AssetUserRuleId = value;
				OnPropertyChanged("AssetUserRuleId");
			}
		}
		#endregion

		#region CTor
		public DiscountModule()
		{
		}

		public DiscountModule(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["percent"] != null)
			{
				this._Percent = ParseDouble(node["percent"].Value<string>());
			}
			if(node["startDate"] != null)
			{
				this._StartDate = ParseLong(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseLong(node["endDate"].Value<string>());
			}
			if(node["assetUserRuleId"] != null)
			{
				this._AssetUserRuleId = ParseLong(node["assetUserRuleId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDiscountModule");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("percent", this._Percent);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("assetUserRuleId", this._AssetUserRuleId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PERCENT:
					return "Percent";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case ASSET_USER_RULE_ID:
					return "AssetUserRuleId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

