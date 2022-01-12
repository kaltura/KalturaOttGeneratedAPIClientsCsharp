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
	public class DefaultParentalSettingsPartnerConfig : PartnerConfiguration
	{
		#region Constants
		public const string DEFAULT_MOVIES_PARENTAL_RULE_ID = "defaultMoviesParentalRuleId";
		public const string DEFAULT_TV_SERIES_PARENTAL_RULE_ID = "defaultTvSeriesParentalRuleId";
		public const string DEFAULT_PARENTAL_PIN = "defaultParentalPin";
		public const string DEFAULT_PURCHASE_PIN = "defaultPurchasePin";
		public const string DEFAULT_PURCHASE_SETTINGS = "defaultPurchaseSettings";
		#endregion

		#region Private Fields
		private long _DefaultMoviesParentalRuleId = long.MinValue;
		private long _DefaultTvSeriesParentalRuleId = long.MinValue;
		private string _DefaultParentalPin = null;
		private string _DefaultPurchasePin = null;
		private long _DefaultPurchaseSettings = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use DefaultMoviesParentalRuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long DefaultMoviesParentalRuleId
		{
			get { return _DefaultMoviesParentalRuleId; }
			set 
			{ 
				_DefaultMoviesParentalRuleId = value;
				OnPropertyChanged("DefaultMoviesParentalRuleId");
			}
		}
		/// <summary>
		/// Use DefaultTvSeriesParentalRuleIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long DefaultTvSeriesParentalRuleId
		{
			get { return _DefaultTvSeriesParentalRuleId; }
			set 
			{ 
				_DefaultTvSeriesParentalRuleId = value;
				OnPropertyChanged("DefaultTvSeriesParentalRuleId");
			}
		}
		/// <summary>
		/// Use DefaultParentalPinAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultParentalPin
		{
			get { return _DefaultParentalPin; }
			set 
			{ 
				_DefaultParentalPin = value;
				OnPropertyChanged("DefaultParentalPin");
			}
		}
		/// <summary>
		/// Use DefaultPurchasePinAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultPurchasePin
		{
			get { return _DefaultPurchasePin; }
			set 
			{ 
				_DefaultPurchasePin = value;
				OnPropertyChanged("DefaultPurchasePin");
			}
		}
		/// <summary>
		/// Use DefaultPurchaseSettingsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long DefaultPurchaseSettings
		{
			get { return _DefaultPurchaseSettings; }
			set 
			{ 
				_DefaultPurchaseSettings = value;
				OnPropertyChanged("DefaultPurchaseSettings");
			}
		}
		#endregion

		#region CTor
		public DefaultParentalSettingsPartnerConfig()
		{
		}

		public DefaultParentalSettingsPartnerConfig(JToken node) : base(node)
		{
			if(node["defaultMoviesParentalRuleId"] != null)
			{
				this._DefaultMoviesParentalRuleId = ParseLong(node["defaultMoviesParentalRuleId"].Value<string>());
			}
			if(node["defaultTvSeriesParentalRuleId"] != null)
			{
				this._DefaultTvSeriesParentalRuleId = ParseLong(node["defaultTvSeriesParentalRuleId"].Value<string>());
			}
			if(node["defaultParentalPin"] != null)
			{
				this._DefaultParentalPin = node["defaultParentalPin"].Value<string>();
			}
			if(node["defaultPurchasePin"] != null)
			{
				this._DefaultPurchasePin = node["defaultPurchasePin"].Value<string>();
			}
			if(node["defaultPurchaseSettings"] != null)
			{
				this._DefaultPurchaseSettings = ParseLong(node["defaultPurchaseSettings"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDefaultParentalSettingsPartnerConfig");
			kparams.AddIfNotNull("defaultMoviesParentalRuleId", this._DefaultMoviesParentalRuleId);
			kparams.AddIfNotNull("defaultTvSeriesParentalRuleId", this._DefaultTvSeriesParentalRuleId);
			kparams.AddIfNotNull("defaultParentalPin", this._DefaultParentalPin);
			kparams.AddIfNotNull("defaultPurchasePin", this._DefaultPurchasePin);
			kparams.AddIfNotNull("defaultPurchaseSettings", this._DefaultPurchaseSettings);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DEFAULT_MOVIES_PARENTAL_RULE_ID:
					return "DefaultMoviesParentalRuleId";
				case DEFAULT_TV_SERIES_PARENTAL_RULE_ID:
					return "DefaultTvSeriesParentalRuleId";
				case DEFAULT_PARENTAL_PIN:
					return "DefaultParentalPin";
				case DEFAULT_PURCHASE_PIN:
					return "DefaultPurchasePin";
				case DEFAULT_PURCHASE_SETTINGS:
					return "DefaultPurchaseSettings";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

