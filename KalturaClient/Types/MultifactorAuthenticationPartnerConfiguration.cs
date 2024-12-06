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
	public class MultifactorAuthenticationPartnerConfiguration : ObjectBase
	{
		#region Constants
		public const string IS_ENABLED = "isEnabled";
		public const string ROLES = "roles";
		public const string TOKEN_EXPIRATION_IN_SECONDS = "tokenExpirationInSeconds";
		public const string TOKEN_DELIVERY_METHOD = "tokenDeliveryMethod";
		#endregion

		#region Private Fields
		private bool? _IsEnabled = null;
		private string _Roles = null;
		private int _TokenExpirationInSeconds = Int32.MinValue;
		private TokenDeliveryMethod _TokenDeliveryMethod = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IsEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsEnabled
		{
			get { return _IsEnabled; }
			set 
			{ 
				_IsEnabled = value;
				OnPropertyChanged("IsEnabled");
			}
		}
		/// <summary>
		/// Use RolesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Roles
		{
			get { return _Roles; }
			set 
			{ 
				_Roles = value;
				OnPropertyChanged("Roles");
			}
		}
		/// <summary>
		/// Use TokenExpirationInSecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int TokenExpirationInSeconds
		{
			get { return _TokenExpirationInSeconds; }
			set 
			{ 
				_TokenExpirationInSeconds = value;
				OnPropertyChanged("TokenExpirationInSeconds");
			}
		}
		/// <summary>
		/// Use TokenDeliveryMethodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TokenDeliveryMethod TokenDeliveryMethod
		{
			get { return _TokenDeliveryMethod; }
			set 
			{ 
				_TokenDeliveryMethod = value;
				OnPropertyChanged("TokenDeliveryMethod");
			}
		}
		#endregion

		#region CTor
		public MultifactorAuthenticationPartnerConfiguration()
		{
		}

		public MultifactorAuthenticationPartnerConfiguration(JToken node) : base(node)
		{
			if(node["isEnabled"] != null)
			{
				this._IsEnabled = ParseBool(node["isEnabled"].Value<string>());
			}
			if(node["roles"] != null)
			{
				this._Roles = node["roles"].Value<string>();
			}
			if(node["tokenExpirationInSeconds"] != null)
			{
				this._TokenExpirationInSeconds = ParseInt(node["tokenExpirationInSeconds"].Value<string>());
			}
			if(node["tokenDeliveryMethod"] != null)
			{
				this._TokenDeliveryMethod = (TokenDeliveryMethod)StringEnum.Parse(typeof(TokenDeliveryMethod), node["tokenDeliveryMethod"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMultifactorAuthenticationPartnerConfiguration");
			kparams.AddIfNotNull("isEnabled", this._IsEnabled);
			kparams.AddIfNotNull("roles", this._Roles);
			kparams.AddIfNotNull("tokenExpirationInSeconds", this._TokenExpirationInSeconds);
			kparams.AddIfNotNull("tokenDeliveryMethod", this._TokenDeliveryMethod);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IS_ENABLED:
					return "IsEnabled";
				case ROLES:
					return "Roles";
				case TOKEN_EXPIRATION_IN_SECONDS:
					return "TokenExpirationInSeconds";
				case TOKEN_DELIVERY_METHOD:
					return "TokenDeliveryMethod";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

