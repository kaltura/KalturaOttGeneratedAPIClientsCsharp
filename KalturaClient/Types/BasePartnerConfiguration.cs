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
	public class BasePartnerConfiguration : PartnerConfiguration
	{
		#region Constants
		public const string KS_EXPIRATION_SECONDS = "ksExpirationSeconds";
		public const string APP_TOKEN_SESSION_MAX_DURATION_SECONDS = "appTokenSessionMaxDurationSeconds";
		public const string ANONYMOUS_KS_EXPIRATION_SECONDS = "anonymousKSExpirationSeconds";
		public const string REFRESH_EXPIRATION_FOR_PIN_LOGIN_SECONDS = "refreshExpirationForPinLoginSeconds";
		public const string APP_TOKEN_MAX_EXPIRY_SECONDS = "appTokenMaxExpirySeconds";
		public const string AUTO_REFRESH_APP_TOKEN = "autoRefreshAppToken";
		public const string UPLOAD_TOKEN_EXPIRY_SECONDS = "uploadTokenExpirySeconds";
		public const string APPTOKEN_USER_VALIDATION_DISABLED = "apptokenUserValidationDisabled";
		public const string EPG_FEATURE_VERSION = "epgFeatureVersion";
		#endregion

		#region Private Fields
		private long _KsExpirationSeconds = long.MinValue;
		private int _AppTokenSessionMaxDurationSeconds = Int32.MinValue;
		private long _AnonymousKSExpirationSeconds = long.MinValue;
		private long _RefreshExpirationForPinLoginSeconds = long.MinValue;
		private int _AppTokenMaxExpirySeconds = Int32.MinValue;
		private bool? _AutoRefreshAppToken = null;
		private int _UploadTokenExpirySeconds = Int32.MinValue;
		private bool? _ApptokenUserValidationDisabled = null;
		private int _EpgFeatureVersion = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use KsExpirationSecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long KsExpirationSeconds
		{
			get { return _KsExpirationSeconds; }
			set 
			{ 
				_KsExpirationSeconds = value;
				OnPropertyChanged("KsExpirationSeconds");
			}
		}
		/// <summary>
		/// Use AppTokenSessionMaxDurationSecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AppTokenSessionMaxDurationSeconds
		{
			get { return _AppTokenSessionMaxDurationSeconds; }
			set 
			{ 
				_AppTokenSessionMaxDurationSeconds = value;
				OnPropertyChanged("AppTokenSessionMaxDurationSeconds");
			}
		}
		/// <summary>
		/// Use AnonymousKSExpirationSecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long AnonymousKSExpirationSeconds
		{
			get { return _AnonymousKSExpirationSeconds; }
			set 
			{ 
				_AnonymousKSExpirationSeconds = value;
				OnPropertyChanged("AnonymousKSExpirationSeconds");
			}
		}
		/// <summary>
		/// Use RefreshExpirationForPinLoginSecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long RefreshExpirationForPinLoginSeconds
		{
			get { return _RefreshExpirationForPinLoginSeconds; }
			set 
			{ 
				_RefreshExpirationForPinLoginSeconds = value;
				OnPropertyChanged("RefreshExpirationForPinLoginSeconds");
			}
		}
		/// <summary>
		/// Use AppTokenMaxExpirySecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AppTokenMaxExpirySeconds
		{
			get { return _AppTokenMaxExpirySeconds; }
			set 
			{ 
				_AppTokenMaxExpirySeconds = value;
				OnPropertyChanged("AppTokenMaxExpirySeconds");
			}
		}
		/// <summary>
		/// Use AutoRefreshAppTokenAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AutoRefreshAppToken
		{
			get { return _AutoRefreshAppToken; }
			set 
			{ 
				_AutoRefreshAppToken = value;
				OnPropertyChanged("AutoRefreshAppToken");
			}
		}
		/// <summary>
		/// Use UploadTokenExpirySecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UploadTokenExpirySeconds
		{
			get { return _UploadTokenExpirySeconds; }
			set 
			{ 
				_UploadTokenExpirySeconds = value;
				OnPropertyChanged("UploadTokenExpirySeconds");
			}
		}
		/// <summary>
		/// Use ApptokenUserValidationDisabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ApptokenUserValidationDisabled
		{
			get { return _ApptokenUserValidationDisabled; }
			set 
			{ 
				_ApptokenUserValidationDisabled = value;
				OnPropertyChanged("ApptokenUserValidationDisabled");
			}
		}
		/// <summary>
		/// Use EpgFeatureVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EpgFeatureVersion
		{
			get { return _EpgFeatureVersion; }
			set 
			{ 
				_EpgFeatureVersion = value;
				OnPropertyChanged("EpgFeatureVersion");
			}
		}
		#endregion

		#region CTor
		public BasePartnerConfiguration()
		{
		}

		public BasePartnerConfiguration(JToken node) : base(node)
		{
			if(node["ksExpirationSeconds"] != null)
			{
				this._KsExpirationSeconds = ParseLong(node["ksExpirationSeconds"].Value<string>());
			}
			if(node["appTokenSessionMaxDurationSeconds"] != null)
			{
				this._AppTokenSessionMaxDurationSeconds = ParseInt(node["appTokenSessionMaxDurationSeconds"].Value<string>());
			}
			if(node["anonymousKSExpirationSeconds"] != null)
			{
				this._AnonymousKSExpirationSeconds = ParseLong(node["anonymousKSExpirationSeconds"].Value<string>());
			}
			if(node["refreshExpirationForPinLoginSeconds"] != null)
			{
				this._RefreshExpirationForPinLoginSeconds = ParseLong(node["refreshExpirationForPinLoginSeconds"].Value<string>());
			}
			if(node["appTokenMaxExpirySeconds"] != null)
			{
				this._AppTokenMaxExpirySeconds = ParseInt(node["appTokenMaxExpirySeconds"].Value<string>());
			}
			if(node["autoRefreshAppToken"] != null)
			{
				this._AutoRefreshAppToken = ParseBool(node["autoRefreshAppToken"].Value<string>());
			}
			if(node["uploadTokenExpirySeconds"] != null)
			{
				this._UploadTokenExpirySeconds = ParseInt(node["uploadTokenExpirySeconds"].Value<string>());
			}
			if(node["apptokenUserValidationDisabled"] != null)
			{
				this._ApptokenUserValidationDisabled = ParseBool(node["apptokenUserValidationDisabled"].Value<string>());
			}
			if(node["epgFeatureVersion"] != null)
			{
				this._EpgFeatureVersion = ParseInt(node["epgFeatureVersion"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBasePartnerConfiguration");
			kparams.AddIfNotNull("ksExpirationSeconds", this._KsExpirationSeconds);
			kparams.AddIfNotNull("appTokenSessionMaxDurationSeconds", this._AppTokenSessionMaxDurationSeconds);
			kparams.AddIfNotNull("anonymousKSExpirationSeconds", this._AnonymousKSExpirationSeconds);
			kparams.AddIfNotNull("refreshExpirationForPinLoginSeconds", this._RefreshExpirationForPinLoginSeconds);
			kparams.AddIfNotNull("appTokenMaxExpirySeconds", this._AppTokenMaxExpirySeconds);
			kparams.AddIfNotNull("autoRefreshAppToken", this._AutoRefreshAppToken);
			kparams.AddIfNotNull("uploadTokenExpirySeconds", this._UploadTokenExpirySeconds);
			kparams.AddIfNotNull("apptokenUserValidationDisabled", this._ApptokenUserValidationDisabled);
			kparams.AddIfNotNull("epgFeatureVersion", this._EpgFeatureVersion);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KS_EXPIRATION_SECONDS:
					return "KsExpirationSeconds";
				case APP_TOKEN_SESSION_MAX_DURATION_SECONDS:
					return "AppTokenSessionMaxDurationSeconds";
				case ANONYMOUS_KS_EXPIRATION_SECONDS:
					return "AnonymousKSExpirationSeconds";
				case REFRESH_EXPIRATION_FOR_PIN_LOGIN_SECONDS:
					return "RefreshExpirationForPinLoginSeconds";
				case APP_TOKEN_MAX_EXPIRY_SECONDS:
					return "AppTokenMaxExpirySeconds";
				case AUTO_REFRESH_APP_TOKEN:
					return "AutoRefreshAppToken";
				case UPLOAD_TOKEN_EXPIRY_SECONDS:
					return "UploadTokenExpirySeconds";
				case APPTOKEN_USER_VALIDATION_DISABLED:
					return "ApptokenUserValidationDisabled";
				case EPG_FEATURE_VERSION:
					return "EpgFeatureVersion";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

