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
	public class UsageModule : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string MAX_VIEWS_NUMBER = "maxViewsNumber";
		public const string VIEW_LIFE_CYCLE = "viewLifeCycle";
		public const string FULL_LIFE_CYCLE = "fullLifeCycle";
		public const string COUPON_ID = "couponId";
		public const string WAIVER_PERIOD = "waiverPeriod";
		public const string IS_WAIVER_ENABLED = "isWaiverEnabled";
		public const string IS_OFFLINE_PLAYBACK = "isOfflinePlayback";
		public const string ASSET_USER_RULE_ID = "assetUserRuleId";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _Name = null;
		private int _MaxViewsNumber = Int32.MinValue;
		private int _ViewLifeCycle = Int32.MinValue;
		private int _FullLifeCycle = Int32.MinValue;
		private int _CouponId = Int32.MinValue;
		private int _WaiverPeriod = Int32.MinValue;
		private bool? _IsWaiverEnabled = null;
		private bool? _IsOfflinePlayback = null;
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
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use MaxViewsNumberAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxViewsNumber
		{
			get { return _MaxViewsNumber; }
			set 
			{ 
				_MaxViewsNumber = value;
				OnPropertyChanged("MaxViewsNumber");
			}
		}
		/// <summary>
		/// Use ViewLifeCycleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ViewLifeCycle
		{
			get { return _ViewLifeCycle; }
			set 
			{ 
				_ViewLifeCycle = value;
				OnPropertyChanged("ViewLifeCycle");
			}
		}
		/// <summary>
		/// Use FullLifeCycleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FullLifeCycle
		{
			get { return _FullLifeCycle; }
			set 
			{ 
				_FullLifeCycle = value;
				OnPropertyChanged("FullLifeCycle");
			}
		}
		/// <summary>
		/// Use CouponIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CouponId
		{
			get { return _CouponId; }
			private set 
			{ 
				_CouponId = value;
				OnPropertyChanged("CouponId");
			}
		}
		/// <summary>
		/// Use WaiverPeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int WaiverPeriod
		{
			get { return _WaiverPeriod; }
			set 
			{ 
				_WaiverPeriod = value;
				OnPropertyChanged("WaiverPeriod");
			}
		}
		/// <summary>
		/// Use IsWaiverEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsWaiverEnabled
		{
			get { return _IsWaiverEnabled; }
			set 
			{ 
				_IsWaiverEnabled = value;
				OnPropertyChanged("IsWaiverEnabled");
			}
		}
		/// <summary>
		/// Use IsOfflinePlaybackAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsOfflinePlayback
		{
			get { return _IsOfflinePlayback; }
			set 
			{ 
				_IsOfflinePlayback = value;
				OnPropertyChanged("IsOfflinePlayback");
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
		public UsageModule()
		{
		}

		public UsageModule(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["maxViewsNumber"] != null)
			{
				this._MaxViewsNumber = ParseInt(node["maxViewsNumber"].Value<string>());
			}
			if(node["viewLifeCycle"] != null)
			{
				this._ViewLifeCycle = ParseInt(node["viewLifeCycle"].Value<string>());
			}
			if(node["fullLifeCycle"] != null)
			{
				this._FullLifeCycle = ParseInt(node["fullLifeCycle"].Value<string>());
			}
			if(node["couponId"] != null)
			{
				this._CouponId = ParseInt(node["couponId"].Value<string>());
			}
			if(node["waiverPeriod"] != null)
			{
				this._WaiverPeriod = ParseInt(node["waiverPeriod"].Value<string>());
			}
			if(node["isWaiverEnabled"] != null)
			{
				this._IsWaiverEnabled = ParseBool(node["isWaiverEnabled"].Value<string>());
			}
			if(node["isOfflinePlayback"] != null)
			{
				this._IsOfflinePlayback = ParseBool(node["isOfflinePlayback"].Value<string>());
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
				kparams.AddReplace("objectType", "KalturaUsageModule");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("maxViewsNumber", this._MaxViewsNumber);
			kparams.AddIfNotNull("viewLifeCycle", this._ViewLifeCycle);
			kparams.AddIfNotNull("fullLifeCycle", this._FullLifeCycle);
			kparams.AddIfNotNull("couponId", this._CouponId);
			kparams.AddIfNotNull("waiverPeriod", this._WaiverPeriod);
			kparams.AddIfNotNull("isWaiverEnabled", this._IsWaiverEnabled);
			kparams.AddIfNotNull("isOfflinePlayback", this._IsOfflinePlayback);
			kparams.AddIfNotNull("assetUserRuleId", this._AssetUserRuleId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case MAX_VIEWS_NUMBER:
					return "MaxViewsNumber";
				case VIEW_LIFE_CYCLE:
					return "ViewLifeCycle";
				case FULL_LIFE_CYCLE:
					return "FullLifeCycle";
				case COUPON_ID:
					return "CouponId";
				case WAIVER_PERIOD:
					return "WaiverPeriod";
				case IS_WAIVER_ENABLED:
					return "IsWaiverEnabled";
				case IS_OFFLINE_PLAYBACK:
					return "IsOfflinePlayback";
				case ASSET_USER_RULE_ID:
					return "AssetUserRuleId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

