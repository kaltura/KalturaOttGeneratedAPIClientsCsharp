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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class GeneralPartnerConfig : PartnerConfiguration
	{
		#region Constants
		public const string PARTNER_NAME = "partnerName";
		public const string MAIN_LANGUAGE = "mainLanguage";
		public const string SECONDARY_LANGUAGES = "secondaryLanguages";
		public const string DELETE_MEDIA_POLICY = "deleteMediaPolicy";
		public const string MAIN_CURRENCY = "mainCurrency";
		public const string SECONDARY_CURRENCIES = "secondaryCurrencies";
		public const string DOWNGRADE_POLICY = "downgradePolicy";
		public const string MAIL_SETTINGS = "mailSettings";
		public const string DATE_FORMAT = "dateFormat";
		public const string HOUSEHOLD_LIMITATION_MODULE = "householdLimitationModule";
		public const string ENABLE_REGION_FILTERING = "enableRegionFiltering";
		public const string DEFAULT_REGION = "defaultRegion";
		public const string ROLLING_DEVICE_DATA = "rollingDeviceData";
		public const string LINEAR_WATCH_HISTORY_THRESHOLD = "linearWatchHistoryThreshold";
		public const string FINISHED_PERCENT_THRESHOLD = "finishedPercentThreshold";
		public const string SUSPENSION_PROFILE_INHERITANCE_TYPE = "suspensionProfileInheritanceType";
		public const string ALLOW_DEVICE_MOBILITY = "allowDeviceMobility";
		#endregion

		#region Private Fields
		private string _PartnerName = null;
		private int _MainLanguage = Int32.MinValue;
		private string _SecondaryLanguages = null;
		private DeleteMediaPolicy _DeleteMediaPolicy = null;
		private int _MainCurrency = Int32.MinValue;
		private string _SecondaryCurrencies = null;
		private DowngradePolicy _DowngradePolicy = null;
		private string _MailSettings = null;
		private string _DateFormat = null;
		private int _HouseholdLimitationModule = Int32.MinValue;
		private bool? _EnableRegionFiltering = null;
		private int _DefaultRegion = Int32.MinValue;
		private RollingDeviceRemovalData _RollingDeviceData;
		private int _LinearWatchHistoryThreshold = Int32.MinValue;
		private int _FinishedPercentThreshold = Int32.MinValue;
		private SuspensionProfileInheritanceType _SuspensionProfileInheritanceType = null;
		private bool? _AllowDeviceMobility = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PartnerNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerName
		{
			get { return _PartnerName; }
			set 
			{ 
				_PartnerName = value;
				OnPropertyChanged("PartnerName");
			}
		}
		/// <summary>
		/// Use MainLanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MainLanguage
		{
			get { return _MainLanguage; }
			set 
			{ 
				_MainLanguage = value;
				OnPropertyChanged("MainLanguage");
			}
		}
		/// <summary>
		/// Use SecondaryLanguagesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondaryLanguages
		{
			get { return _SecondaryLanguages; }
			set 
			{ 
				_SecondaryLanguages = value;
				OnPropertyChanged("SecondaryLanguages");
			}
		}
		/// <summary>
		/// Use DeleteMediaPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DeleteMediaPolicy DeleteMediaPolicy
		{
			get { return _DeleteMediaPolicy; }
			set 
			{ 
				_DeleteMediaPolicy = value;
				OnPropertyChanged("DeleteMediaPolicy");
			}
		}
		/// <summary>
		/// Use MainCurrencyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MainCurrency
		{
			get { return _MainCurrency; }
			set 
			{ 
				_MainCurrency = value;
				OnPropertyChanged("MainCurrency");
			}
		}
		/// <summary>
		/// Use SecondaryCurrenciesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondaryCurrencies
		{
			get { return _SecondaryCurrencies; }
			set 
			{ 
				_SecondaryCurrencies = value;
				OnPropertyChanged("SecondaryCurrencies");
			}
		}
		/// <summary>
		/// Use DowngradePolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DowngradePolicy DowngradePolicy
		{
			get { return _DowngradePolicy; }
			set 
			{ 
				_DowngradePolicy = value;
				OnPropertyChanged("DowngradePolicy");
			}
		}
		/// <summary>
		/// Use MailSettingsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MailSettings
		{
			get { return _MailSettings; }
			set 
			{ 
				_MailSettings = value;
				OnPropertyChanged("MailSettings");
			}
		}
		/// <summary>
		/// Use DateFormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DateFormat
		{
			get { return _DateFormat; }
			set 
			{ 
				_DateFormat = value;
				OnPropertyChanged("DateFormat");
			}
		}
		/// <summary>
		/// Use HouseholdLimitationModuleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int HouseholdLimitationModule
		{
			get { return _HouseholdLimitationModule; }
			set 
			{ 
				_HouseholdLimitationModule = value;
				OnPropertyChanged("HouseholdLimitationModule");
			}
		}
		/// <summary>
		/// Use EnableRegionFilteringAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnableRegionFiltering
		{
			get { return _EnableRegionFiltering; }
			set 
			{ 
				_EnableRegionFiltering = value;
				OnPropertyChanged("EnableRegionFiltering");
			}
		}
		/// <summary>
		/// Use DefaultRegionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DefaultRegion
		{
			get { return _DefaultRegion; }
			set 
			{ 
				_DefaultRegion = value;
				OnPropertyChanged("DefaultRegion");
			}
		}
		/// <summary>
		/// Use RollingDeviceDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RollingDeviceRemovalData RollingDeviceData
		{
			get { return _RollingDeviceData; }
			set 
			{ 
				_RollingDeviceData = value;
				OnPropertyChanged("RollingDeviceData");
			}
		}
		/// <summary>
		/// Use LinearWatchHistoryThresholdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LinearWatchHistoryThreshold
		{
			get { return _LinearWatchHistoryThreshold; }
			set 
			{ 
				_LinearWatchHistoryThreshold = value;
				OnPropertyChanged("LinearWatchHistoryThreshold");
			}
		}
		/// <summary>
		/// Use FinishedPercentThresholdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FinishedPercentThreshold
		{
			get { return _FinishedPercentThreshold; }
			set 
			{ 
				_FinishedPercentThreshold = value;
				OnPropertyChanged("FinishedPercentThreshold");
			}
		}
		/// <summary>
		/// Use SuspensionProfileInheritanceTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SuspensionProfileInheritanceType SuspensionProfileInheritanceType
		{
			get { return _SuspensionProfileInheritanceType; }
			set 
			{ 
				_SuspensionProfileInheritanceType = value;
				OnPropertyChanged("SuspensionProfileInheritanceType");
			}
		}
		/// <summary>
		/// Use AllowDeviceMobilityAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AllowDeviceMobility
		{
			get { return _AllowDeviceMobility; }
			set 
			{ 
				_AllowDeviceMobility = value;
				OnPropertyChanged("AllowDeviceMobility");
			}
		}
		#endregion

		#region CTor
		public GeneralPartnerConfig()
		{
		}

		public GeneralPartnerConfig(JToken node) : base(node)
		{
			if(node["partnerName"] != null)
			{
				this._PartnerName = node["partnerName"].Value<string>();
			}
			if(node["mainLanguage"] != null)
			{
				this._MainLanguage = ParseInt(node["mainLanguage"].Value<string>());
			}
			if(node["secondaryLanguages"] != null)
			{
				this._SecondaryLanguages = node["secondaryLanguages"].Value<string>();
			}
			if(node["deleteMediaPolicy"] != null)
			{
				this._DeleteMediaPolicy = (DeleteMediaPolicy)StringEnum.Parse(typeof(DeleteMediaPolicy), node["deleteMediaPolicy"].Value<string>());
			}
			if(node["mainCurrency"] != null)
			{
				this._MainCurrency = ParseInt(node["mainCurrency"].Value<string>());
			}
			if(node["secondaryCurrencies"] != null)
			{
				this._SecondaryCurrencies = node["secondaryCurrencies"].Value<string>();
			}
			if(node["downgradePolicy"] != null)
			{
				this._DowngradePolicy = (DowngradePolicy)StringEnum.Parse(typeof(DowngradePolicy), node["downgradePolicy"].Value<string>());
			}
			if(node["mailSettings"] != null)
			{
				this._MailSettings = node["mailSettings"].Value<string>();
			}
			if(node["dateFormat"] != null)
			{
				this._DateFormat = node["dateFormat"].Value<string>();
			}
			if(node["householdLimitationModule"] != null)
			{
				this._HouseholdLimitationModule = ParseInt(node["householdLimitationModule"].Value<string>());
			}
			if(node["enableRegionFiltering"] != null)
			{
				this._EnableRegionFiltering = ParseBool(node["enableRegionFiltering"].Value<string>());
			}
			if(node["defaultRegion"] != null)
			{
				this._DefaultRegion = ParseInt(node["defaultRegion"].Value<string>());
			}
			if(node["rollingDeviceData"] != null)
			{
				this._RollingDeviceData = ObjectFactory.Create<RollingDeviceRemovalData>(node["rollingDeviceData"]);
			}
			if(node["linearWatchHistoryThreshold"] != null)
			{
				this._LinearWatchHistoryThreshold = ParseInt(node["linearWatchHistoryThreshold"].Value<string>());
			}
			if(node["finishedPercentThreshold"] != null)
			{
				this._FinishedPercentThreshold = ParseInt(node["finishedPercentThreshold"].Value<string>());
			}
			if(node["suspensionProfileInheritanceType"] != null)
			{
				this._SuspensionProfileInheritanceType = (SuspensionProfileInheritanceType)StringEnum.Parse(typeof(SuspensionProfileInheritanceType), node["suspensionProfileInheritanceType"].Value<string>());
			}
			if(node["allowDeviceMobility"] != null)
			{
				this._AllowDeviceMobility = ParseBool(node["allowDeviceMobility"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGeneralPartnerConfig");
			kparams.AddIfNotNull("partnerName", this._PartnerName);
			kparams.AddIfNotNull("mainLanguage", this._MainLanguage);
			kparams.AddIfNotNull("secondaryLanguages", this._SecondaryLanguages);
			kparams.AddIfNotNull("deleteMediaPolicy", this._DeleteMediaPolicy);
			kparams.AddIfNotNull("mainCurrency", this._MainCurrency);
			kparams.AddIfNotNull("secondaryCurrencies", this._SecondaryCurrencies);
			kparams.AddIfNotNull("downgradePolicy", this._DowngradePolicy);
			kparams.AddIfNotNull("mailSettings", this._MailSettings);
			kparams.AddIfNotNull("dateFormat", this._DateFormat);
			kparams.AddIfNotNull("householdLimitationModule", this._HouseholdLimitationModule);
			kparams.AddIfNotNull("enableRegionFiltering", this._EnableRegionFiltering);
			kparams.AddIfNotNull("defaultRegion", this._DefaultRegion);
			kparams.AddIfNotNull("rollingDeviceData", this._RollingDeviceData);
			kparams.AddIfNotNull("linearWatchHistoryThreshold", this._LinearWatchHistoryThreshold);
			kparams.AddIfNotNull("finishedPercentThreshold", this._FinishedPercentThreshold);
			kparams.AddIfNotNull("suspensionProfileInheritanceType", this._SuspensionProfileInheritanceType);
			kparams.AddIfNotNull("allowDeviceMobility", this._AllowDeviceMobility);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_NAME:
					return "PartnerName";
				case MAIN_LANGUAGE:
					return "MainLanguage";
				case SECONDARY_LANGUAGES:
					return "SecondaryLanguages";
				case DELETE_MEDIA_POLICY:
					return "DeleteMediaPolicy";
				case MAIN_CURRENCY:
					return "MainCurrency";
				case SECONDARY_CURRENCIES:
					return "SecondaryCurrencies";
				case DOWNGRADE_POLICY:
					return "DowngradePolicy";
				case MAIL_SETTINGS:
					return "MailSettings";
				case DATE_FORMAT:
					return "DateFormat";
				case HOUSEHOLD_LIMITATION_MODULE:
					return "HouseholdLimitationModule";
				case ENABLE_REGION_FILTERING:
					return "EnableRegionFiltering";
				case DEFAULT_REGION:
					return "DefaultRegion";
				case ROLLING_DEVICE_DATA:
					return "RollingDeviceData";
				case LINEAR_WATCH_HISTORY_THRESHOLD:
					return "LinearWatchHistoryThreshold";
				case FINISHED_PERCENT_THRESHOLD:
					return "FinishedPercentThreshold";
				case SUSPENSION_PROFILE_INHERITANCE_TYPE:
					return "SuspensionProfileInheritanceType";
				case ALLOW_DEVICE_MOBILITY:
					return "AllowDeviceMobility";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

