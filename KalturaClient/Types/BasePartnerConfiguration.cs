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
	public class BasePartnerConfiguration : PartnerConfiguration
	{
		#region Constants
		public const string USE_START_DATE = "useStartDate";
		public const string GET_ONLY_ACTIVE_ASSETS = "getOnlyActiveAssets";
		public const string SHOULD_SUPPORT_SINGLE_LOGIN = "shouldSupportSingleLogin";
		public const string KS_EXPIRATION_SECONDS = "ksExpirationSeconds";
		public const string ANONYMOUS_KS_EXPIRATION_SECONDS = "anonymousKSExpirationSeconds";
		public const string REFRESH_TOKEN_EXPIRATION_SECONDS = "refreshTokenExpirationSeconds";
		public const string IS_REFRESH_TOKEN_EXTENDABLE = "isRefreshTokenExtendable";
		public const string REFRESH_EXPIRATION_FOR_PIN_LOGIN_SECONDS = "refreshExpirationForPinLoginSeconds";
		public const string IS_SWITCHING_USERS_ALLOWED = "isSwitchingUsersAllowed";
		public const string TOKEN_KEY_FORMAT = "tokenKeyFormat";
		public const string APP_TOKEN_KEY_FORMAT = "appTokenKeyFormat";
		public const string APP_TOKEN_SESSION_MAX_DURATION_SECONDS = "appTokenSessionMaxDurationSeconds";
		public const string APP_TOKEN_MAX_EXPIRY_SECONDS = "appTokenMaxExpirySeconds";
		public const string USER_SESSIONS_KEY_FORMAT = "userSessionsKeyFormat";
		public const string REVOKED_KS_MAX_TTL_SECONDS = "revokedKsMaxTtlSeconds";
		public const string MEDIA_PREP_ACCOUNT_ID = "mediaPrepAccountId";
		public const string FAIRPLAY_CERTIFICATE = "fairplayCertificate";
		#endregion

		#region Private Fields
		private bool? _UseStartDate = null;
		private bool? _GetOnlyActiveAssets = null;
		private bool? _ShouldSupportSingleLogin = null;
		private long _KsExpirationSeconds = long.MinValue;
		private long _AnonymousKSExpirationSeconds = long.MinValue;
		private long _RefreshTokenExpirationSeconds = long.MinValue;
		private bool? _IsRefreshTokenExtendable = null;
		private long _RefreshExpirationForPinLoginSeconds = long.MinValue;
		private bool? _IsSwitchingUsersAllowed = null;
		private string _TokenKeyFormat = null;
		private string _AppTokenKeyFormat = null;
		private int _AppTokenSessionMaxDurationSeconds = Int32.MinValue;
		private int _AppTokenMaxExpirySeconds = Int32.MinValue;
		private string _UserSessionsKeyFormat = null;
		private int _RevokedKsMaxTtlSeconds = Int32.MinValue;
		private int _MediaPrepAccountId = Int32.MinValue;
		private string _FairplayCertificate = null;
		#endregion

		#region Properties
		[JsonProperty]
		public bool? UseStartDate
		{
			get { return _UseStartDate; }
			set 
			{ 
				_UseStartDate = value;
				OnPropertyChanged("UseStartDate");
			}
		}
		[JsonProperty]
		public bool? GetOnlyActiveAssets
		{
			get { return _GetOnlyActiveAssets; }
			set 
			{ 
				_GetOnlyActiveAssets = value;
				OnPropertyChanged("GetOnlyActiveAssets");
			}
		}
		[JsonProperty]
		public bool? ShouldSupportSingleLogin
		{
			get { return _ShouldSupportSingleLogin; }
			set 
			{ 
				_ShouldSupportSingleLogin = value;
				OnPropertyChanged("ShouldSupportSingleLogin");
			}
		}
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
		[JsonProperty]
		public long RefreshTokenExpirationSeconds
		{
			get { return _RefreshTokenExpirationSeconds; }
			set 
			{ 
				_RefreshTokenExpirationSeconds = value;
				OnPropertyChanged("RefreshTokenExpirationSeconds");
			}
		}
		[JsonProperty]
		public bool? IsRefreshTokenExtendable
		{
			get { return _IsRefreshTokenExtendable; }
			set 
			{ 
				_IsRefreshTokenExtendable = value;
				OnPropertyChanged("IsRefreshTokenExtendable");
			}
		}
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
		[JsonProperty]
		public bool? IsSwitchingUsersAllowed
		{
			get { return _IsSwitchingUsersAllowed; }
			set 
			{ 
				_IsSwitchingUsersAllowed = value;
				OnPropertyChanged("IsSwitchingUsersAllowed");
			}
		}
		[JsonProperty]
		public string TokenKeyFormat
		{
			get { return _TokenKeyFormat; }
			set 
			{ 
				_TokenKeyFormat = value;
				OnPropertyChanged("TokenKeyFormat");
			}
		}
		[JsonProperty]
		public string AppTokenKeyFormat
		{
			get { return _AppTokenKeyFormat; }
			set 
			{ 
				_AppTokenKeyFormat = value;
				OnPropertyChanged("AppTokenKeyFormat");
			}
		}
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
		[JsonProperty]
		public string UserSessionsKeyFormat
		{
			get { return _UserSessionsKeyFormat; }
			set 
			{ 
				_UserSessionsKeyFormat = value;
				OnPropertyChanged("UserSessionsKeyFormat");
			}
		}
		[JsonProperty]
		public int RevokedKsMaxTtlSeconds
		{
			get { return _RevokedKsMaxTtlSeconds; }
			set 
			{ 
				_RevokedKsMaxTtlSeconds = value;
				OnPropertyChanged("RevokedKsMaxTtlSeconds");
			}
		}
		[JsonProperty]
		public int MediaPrepAccountId
		{
			get { return _MediaPrepAccountId; }
			set 
			{ 
				_MediaPrepAccountId = value;
				OnPropertyChanged("MediaPrepAccountId");
			}
		}
		[JsonProperty]
		public string FairplayCertificate
		{
			get { return _FairplayCertificate; }
			set 
			{ 
				_FairplayCertificate = value;
				OnPropertyChanged("FairplayCertificate");
			}
		}
		#endregion

		#region CTor
		public BasePartnerConfiguration()
		{
		}

		public BasePartnerConfiguration(JToken node) : base(node)
		{
			if(node["useStartDate"] != null)
			{
				this._UseStartDate = ParseBool(node["useStartDate"].Value<string>());
			}
			if(node["getOnlyActiveAssets"] != null)
			{
				this._GetOnlyActiveAssets = ParseBool(node["getOnlyActiveAssets"].Value<string>());
			}
			if(node["shouldSupportSingleLogin"] != null)
			{
				this._ShouldSupportSingleLogin = ParseBool(node["shouldSupportSingleLogin"].Value<string>());
			}
			if(node["ksExpirationSeconds"] != null)
			{
				this._KsExpirationSeconds = ParseLong(node["ksExpirationSeconds"].Value<string>());
			}
			if(node["anonymousKSExpirationSeconds"] != null)
			{
				this._AnonymousKSExpirationSeconds = ParseLong(node["anonymousKSExpirationSeconds"].Value<string>());
			}
			if(node["refreshTokenExpirationSeconds"] != null)
			{
				this._RefreshTokenExpirationSeconds = ParseLong(node["refreshTokenExpirationSeconds"].Value<string>());
			}
			if(node["isRefreshTokenExtendable"] != null)
			{
				this._IsRefreshTokenExtendable = ParseBool(node["isRefreshTokenExtendable"].Value<string>());
			}
			if(node["refreshExpirationForPinLoginSeconds"] != null)
			{
				this._RefreshExpirationForPinLoginSeconds = ParseLong(node["refreshExpirationForPinLoginSeconds"].Value<string>());
			}
			if(node["isSwitchingUsersAllowed"] != null)
			{
				this._IsSwitchingUsersAllowed = ParseBool(node["isSwitchingUsersAllowed"].Value<string>());
			}
			if(node["tokenKeyFormat"] != null)
			{
				this._TokenKeyFormat = node["tokenKeyFormat"].Value<string>();
			}
			if(node["appTokenKeyFormat"] != null)
			{
				this._AppTokenKeyFormat = node["appTokenKeyFormat"].Value<string>();
			}
			if(node["appTokenSessionMaxDurationSeconds"] != null)
			{
				this._AppTokenSessionMaxDurationSeconds = ParseInt(node["appTokenSessionMaxDurationSeconds"].Value<string>());
			}
			if(node["appTokenMaxExpirySeconds"] != null)
			{
				this._AppTokenMaxExpirySeconds = ParseInt(node["appTokenMaxExpirySeconds"].Value<string>());
			}
			if(node["userSessionsKeyFormat"] != null)
			{
				this._UserSessionsKeyFormat = node["userSessionsKeyFormat"].Value<string>();
			}
			if(node["revokedKsMaxTtlSeconds"] != null)
			{
				this._RevokedKsMaxTtlSeconds = ParseInt(node["revokedKsMaxTtlSeconds"].Value<string>());
			}
			if(node["mediaPrepAccountId"] != null)
			{
				this._MediaPrepAccountId = ParseInt(node["mediaPrepAccountId"].Value<string>());
			}
			if(node["fairplayCertificate"] != null)
			{
				this._FairplayCertificate = node["fairplayCertificate"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBasePartnerConfiguration");
			kparams.AddIfNotNull("useStartDate", this._UseStartDate);
			kparams.AddIfNotNull("getOnlyActiveAssets", this._GetOnlyActiveAssets);
			kparams.AddIfNotNull("shouldSupportSingleLogin", this._ShouldSupportSingleLogin);
			kparams.AddIfNotNull("ksExpirationSeconds", this._KsExpirationSeconds);
			kparams.AddIfNotNull("anonymousKSExpirationSeconds", this._AnonymousKSExpirationSeconds);
			kparams.AddIfNotNull("refreshTokenExpirationSeconds", this._RefreshTokenExpirationSeconds);
			kparams.AddIfNotNull("isRefreshTokenExtendable", this._IsRefreshTokenExtendable);
			kparams.AddIfNotNull("refreshExpirationForPinLoginSeconds", this._RefreshExpirationForPinLoginSeconds);
			kparams.AddIfNotNull("isSwitchingUsersAllowed", this._IsSwitchingUsersAllowed);
			kparams.AddIfNotNull("tokenKeyFormat", this._TokenKeyFormat);
			kparams.AddIfNotNull("appTokenKeyFormat", this._AppTokenKeyFormat);
			kparams.AddIfNotNull("appTokenSessionMaxDurationSeconds", this._AppTokenSessionMaxDurationSeconds);
			kparams.AddIfNotNull("appTokenMaxExpirySeconds", this._AppTokenMaxExpirySeconds);
			kparams.AddIfNotNull("userSessionsKeyFormat", this._UserSessionsKeyFormat);
			kparams.AddIfNotNull("revokedKsMaxTtlSeconds", this._RevokedKsMaxTtlSeconds);
			kparams.AddIfNotNull("mediaPrepAccountId", this._MediaPrepAccountId);
			kparams.AddIfNotNull("fairplayCertificate", this._FairplayCertificate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USE_START_DATE:
					return "UseStartDate";
				case GET_ONLY_ACTIVE_ASSETS:
					return "GetOnlyActiveAssets";
				case SHOULD_SUPPORT_SINGLE_LOGIN:
					return "ShouldSupportSingleLogin";
				case KS_EXPIRATION_SECONDS:
					return "KsExpirationSeconds";
				case ANONYMOUS_KS_EXPIRATION_SECONDS:
					return "AnonymousKSExpirationSeconds";
				case REFRESH_TOKEN_EXPIRATION_SECONDS:
					return "RefreshTokenExpirationSeconds";
				case IS_REFRESH_TOKEN_EXTENDABLE:
					return "IsRefreshTokenExtendable";
				case REFRESH_EXPIRATION_FOR_PIN_LOGIN_SECONDS:
					return "RefreshExpirationForPinLoginSeconds";
				case IS_SWITCHING_USERS_ALLOWED:
					return "IsSwitchingUsersAllowed";
				case TOKEN_KEY_FORMAT:
					return "TokenKeyFormat";
				case APP_TOKEN_KEY_FORMAT:
					return "AppTokenKeyFormat";
				case APP_TOKEN_SESSION_MAX_DURATION_SECONDS:
					return "AppTokenSessionMaxDurationSeconds";
				case APP_TOKEN_MAX_EXPIRY_SECONDS:
					return "AppTokenMaxExpirySeconds";
				case USER_SESSIONS_KEY_FORMAT:
					return "UserSessionsKeyFormat";
				case REVOKED_KS_MAX_TTL_SECONDS:
					return "RevokedKsMaxTtlSeconds";
				case MEDIA_PREP_ACCOUNT_ID:
					return "MediaPrepAccountId";
				case FAIRPLAY_CERTIFICATE:
					return "FairplayCertificate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

