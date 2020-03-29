// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class IotProfileAws : CrudObject
	{
		#region Constants
		public const string IOT_END_POINT = "iotEndPoint";
		public const string PFX_PATH = "pfxPath";
		public const string PFX_PASSWORD = "pfxPassword";
		public const string CERTIFICATE_PATH = "certificatePath";
		public const string BROKER_PORT = "brokerPort";
		public const string ACCESS_KEY_ID = "accessKeyId";
		public const string SECRET_ACCESS_KEY = "secretAccessKey";
		public const string TTL = "tTL";
		public const string IOT_POLICY_NAME = "iotPolicyName";
		public const string USER_POOL_ID = "userPoolId";
		public const string CLIENT_ID = "clientId";
		public const string IDENTITY_POOL_ID = "identityPoolId";
		public const string REGION = "region";
		public const string UPDATE_DATE = "updateDate";
		#endregion

		#region Private Fields
		private string _IotEndPoint = null;
		private string _PfxPath = null;
		private string _PfxPassword = null;
		private string _CertificatePath = null;
		private int _BrokerPort = Int32.MinValue;
		private string _AccessKeyId = null;
		private string _SecretAccessKey = null;
		private string _TTL = null;
		private string _IotPolicyName = null;
		private string _UserPoolId = null;
		private string _ClientId = null;
		private string _IdentityPoolId = null;
		private string _Region = null;
		private long _UpdateDate = long.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string IotEndPoint
		{
			get { return _IotEndPoint; }
			set 
			{ 
				_IotEndPoint = value;
				OnPropertyChanged("IotEndPoint");
			}
		}
		[JsonProperty]
		public string PfxPath
		{
			get { return _PfxPath; }
			set 
			{ 
				_PfxPath = value;
				OnPropertyChanged("PfxPath");
			}
		}
		[JsonProperty]
		public string PfxPassword
		{
			get { return _PfxPassword; }
			set 
			{ 
				_PfxPassword = value;
				OnPropertyChanged("PfxPassword");
			}
		}
		[JsonProperty]
		public string CertificatePath
		{
			get { return _CertificatePath; }
			set 
			{ 
				_CertificatePath = value;
				OnPropertyChanged("CertificatePath");
			}
		}
		[JsonProperty]
		public int BrokerPort
		{
			get { return _BrokerPort; }
			set 
			{ 
				_BrokerPort = value;
				OnPropertyChanged("BrokerPort");
			}
		}
		[JsonProperty]
		public string AccessKeyId
		{
			get { return _AccessKeyId; }
			set 
			{ 
				_AccessKeyId = value;
				OnPropertyChanged("AccessKeyId");
			}
		}
		[JsonProperty]
		public string SecretAccessKey
		{
			get { return _SecretAccessKey; }
			set 
			{ 
				_SecretAccessKey = value;
				OnPropertyChanged("SecretAccessKey");
			}
		}
		[JsonProperty]
		public string TTL
		{
			get { return _TTL; }
			set 
			{ 
				_TTL = value;
				OnPropertyChanged("TTL");
			}
		}
		[JsonProperty]
		public string IotPolicyName
		{
			get { return _IotPolicyName; }
			set 
			{ 
				_IotPolicyName = value;
				OnPropertyChanged("IotPolicyName");
			}
		}
		[JsonProperty]
		public string UserPoolId
		{
			get { return _UserPoolId; }
			set 
			{ 
				_UserPoolId = value;
				OnPropertyChanged("UserPoolId");
			}
		}
		[JsonProperty]
		public string ClientId
		{
			get { return _ClientId; }
			set 
			{ 
				_ClientId = value;
				OnPropertyChanged("ClientId");
			}
		}
		[JsonProperty]
		public string IdentityPoolId
		{
			get { return _IdentityPoolId; }
			set 
			{ 
				_IdentityPoolId = value;
				OnPropertyChanged("IdentityPoolId");
			}
		}
		[JsonProperty]
		public string Region
		{
			get { return _Region; }
			set 
			{ 
				_Region = value;
				OnPropertyChanged("Region");
			}
		}
		[JsonProperty]
		public long UpdateDate
		{
			get { return _UpdateDate; }
			set 
			{ 
				_UpdateDate = value;
				OnPropertyChanged("UpdateDate");
			}
		}
		#endregion

		#region CTor
		public IotProfileAws()
		{
		}

		public IotProfileAws(JToken node) : base(node)
		{
			if(node["iotEndPoint"] != null)
			{
				this._IotEndPoint = node["iotEndPoint"].Value<string>();
			}
			if(node["pfxPath"] != null)
			{
				this._PfxPath = node["pfxPath"].Value<string>();
			}
			if(node["pfxPassword"] != null)
			{
				this._PfxPassword = node["pfxPassword"].Value<string>();
			}
			if(node["certificatePath"] != null)
			{
				this._CertificatePath = node["certificatePath"].Value<string>();
			}
			if(node["brokerPort"] != null)
			{
				this._BrokerPort = ParseInt(node["brokerPort"].Value<string>());
			}
			if(node["accessKeyId"] != null)
			{
				this._AccessKeyId = node["accessKeyId"].Value<string>();
			}
			if(node["secretAccessKey"] != null)
			{
				this._SecretAccessKey = node["secretAccessKey"].Value<string>();
			}
			if(node["tTL"] != null)
			{
				this._TTL = node["tTL"].Value<string>();
			}
			if(node["iotPolicyName"] != null)
			{
				this._IotPolicyName = node["iotPolicyName"].Value<string>();
			}
			if(node["userPoolId"] != null)
			{
				this._UserPoolId = node["userPoolId"].Value<string>();
			}
			if(node["clientId"] != null)
			{
				this._ClientId = node["clientId"].Value<string>();
			}
			if(node["identityPoolId"] != null)
			{
				this._IdentityPoolId = node["identityPoolId"].Value<string>();
			}
			if(node["region"] != null)
			{
				this._Region = node["region"].Value<string>();
			}
			if(node["updateDate"] != null)
			{
				this._UpdateDate = ParseLong(node["updateDate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIotProfileAws");
			kparams.AddIfNotNull("iotEndPoint", this._IotEndPoint);
			kparams.AddIfNotNull("pfxPath", this._PfxPath);
			kparams.AddIfNotNull("pfxPassword", this._PfxPassword);
			kparams.AddIfNotNull("certificatePath", this._CertificatePath);
			kparams.AddIfNotNull("brokerPort", this._BrokerPort);
			kparams.AddIfNotNull("accessKeyId", this._AccessKeyId);
			kparams.AddIfNotNull("secretAccessKey", this._SecretAccessKey);
			kparams.AddIfNotNull("tTL", this._TTL);
			kparams.AddIfNotNull("iotPolicyName", this._IotPolicyName);
			kparams.AddIfNotNull("userPoolId", this._UserPoolId);
			kparams.AddIfNotNull("clientId", this._ClientId);
			kparams.AddIfNotNull("identityPoolId", this._IdentityPoolId);
			kparams.AddIfNotNull("region", this._Region);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IOT_END_POINT:
					return "IotEndPoint";
				case PFX_PATH:
					return "PfxPath";
				case PFX_PASSWORD:
					return "PfxPassword";
				case CERTIFICATE_PATH:
					return "CertificatePath";
				case BROKER_PORT:
					return "BrokerPort";
				case ACCESS_KEY_ID:
					return "AccessKeyId";
				case SECRET_ACCESS_KEY:
					return "SecretAccessKey";
				case TTL:
					return "TTL";
				case IOT_POLICY_NAME:
					return "IotPolicyName";
				case USER_POOL_ID:
					return "UserPoolId";
				case CLIENT_ID:
					return "ClientId";
				case IDENTITY_POOL_ID:
					return "IdentityPoolId";
				case REGION:
					return "Region";
				case UPDATE_DATE:
					return "UpdateDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

