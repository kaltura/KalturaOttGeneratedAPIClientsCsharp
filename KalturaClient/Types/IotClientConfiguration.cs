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
	public class IotClientConfiguration : ObjectBase
	{
		#region Constants
		public const string IDENTITY_POOL_ID = "identityPoolId";
		public const string USER_POOL_ID = "userPoolId";
		public const string AWS_REGION = "awsRegion";
		public const string APP_CLIENT_ID = "appClientId";
		public const string LEGACY_END_POINT = "legacyEndPoint";
		public const string END_POINT = "endPoint";
		public const string THING_NAME = "thingName";
		public const string THING_ARN = "thingArn";
		public const string THING_ID = "thingId";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string TOPICS = "topics";
		public const string STATUS = "status";
		public const string MESSAGE = "message";
		#endregion

		#region Private Fields
		private string _IdentityPoolId = null;
		private string _UserPoolId = null;
		private string _AwsRegion = null;
		private string _AppClientId = null;
		private string _LegacyEndPoint = null;
		private string _EndPoint = null;
		private string _ThingName = null;
		private string _ThingArn = null;
		private string _ThingId = null;
		private string _Username = null;
		private string _Password = null;
		private string _Topics = null;
		private string _Status = null;
		private string _Message = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdentityPoolIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UserPoolIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use AwsRegionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AwsRegion
		{
			get { return _AwsRegion; }
			set 
			{ 
				_AwsRegion = value;
				OnPropertyChanged("AwsRegion");
			}
		}
		/// <summary>
		/// Use AppClientIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AppClientId
		{
			get { return _AppClientId; }
			set 
			{ 
				_AppClientId = value;
				OnPropertyChanged("AppClientId");
			}
		}
		/// <summary>
		/// Use LegacyEndPointAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LegacyEndPoint
		{
			get { return _LegacyEndPoint; }
			set 
			{ 
				_LegacyEndPoint = value;
				OnPropertyChanged("LegacyEndPoint");
			}
		}
		/// <summary>
		/// Use EndPointAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EndPoint
		{
			get { return _EndPoint; }
			set 
			{ 
				_EndPoint = value;
				OnPropertyChanged("EndPoint");
			}
		}
		/// <summary>
		/// Use ThingNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThingName
		{
			get { return _ThingName; }
			set 
			{ 
				_ThingName = value;
				OnPropertyChanged("ThingName");
			}
		}
		/// <summary>
		/// Use ThingArnAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThingArn
		{
			get { return _ThingArn; }
			set 
			{ 
				_ThingArn = value;
				OnPropertyChanged("ThingArn");
			}
		}
		/// <summary>
		/// Use ThingIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThingId
		{
			get { return _ThingId; }
			set 
			{ 
				_ThingId = value;
				OnPropertyChanged("ThingId");
			}
		}
		/// <summary>
		/// Use UsernameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		/// <summary>
		/// Use PasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		/// <summary>
		/// Use TopicsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Topics
		{
			get { return _Topics; }
			set 
			{ 
				_Topics = value;
				OnPropertyChanged("Topics");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use MessageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		#endregion

		#region CTor
		public IotClientConfiguration()
		{
		}

		public IotClientConfiguration(JToken node) : base(node)
		{
			if(node["identityPoolId"] != null)
			{
				this._IdentityPoolId = node["identityPoolId"].Value<string>();
			}
			if(node["userPoolId"] != null)
			{
				this._UserPoolId = node["userPoolId"].Value<string>();
			}
			if(node["awsRegion"] != null)
			{
				this._AwsRegion = node["awsRegion"].Value<string>();
			}
			if(node["appClientId"] != null)
			{
				this._AppClientId = node["appClientId"].Value<string>();
			}
			if(node["legacyEndPoint"] != null)
			{
				this._LegacyEndPoint = node["legacyEndPoint"].Value<string>();
			}
			if(node["endPoint"] != null)
			{
				this._EndPoint = node["endPoint"].Value<string>();
			}
			if(node["thingName"] != null)
			{
				this._ThingName = node["thingName"].Value<string>();
			}
			if(node["thingArn"] != null)
			{
				this._ThingArn = node["thingArn"].Value<string>();
			}
			if(node["thingId"] != null)
			{
				this._ThingId = node["thingId"].Value<string>();
			}
			if(node["username"] != null)
			{
				this._Username = node["username"].Value<string>();
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
			if(node["topics"] != null)
			{
				this._Topics = node["topics"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = node["status"].Value<string>();
			}
			if(node["message"] != null)
			{
				this._Message = node["message"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIotClientConfiguration");
			kparams.AddIfNotNull("identityPoolId", this._IdentityPoolId);
			kparams.AddIfNotNull("userPoolId", this._UserPoolId);
			kparams.AddIfNotNull("awsRegion", this._AwsRegion);
			kparams.AddIfNotNull("appClientId", this._AppClientId);
			kparams.AddIfNotNull("legacyEndPoint", this._LegacyEndPoint);
			kparams.AddIfNotNull("endPoint", this._EndPoint);
			kparams.AddIfNotNull("thingName", this._ThingName);
			kparams.AddIfNotNull("thingArn", this._ThingArn);
			kparams.AddIfNotNull("thingId", this._ThingId);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("topics", this._Topics);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("message", this._Message);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IDENTITY_POOL_ID:
					return "IdentityPoolId";
				case USER_POOL_ID:
					return "UserPoolId";
				case AWS_REGION:
					return "AwsRegion";
				case APP_CLIENT_ID:
					return "AppClientId";
				case LEGACY_END_POINT:
					return "LegacyEndPoint";
				case END_POINT:
					return "EndPoint";
				case THING_NAME:
					return "ThingName";
				case THING_ARN:
					return "ThingArn";
				case THING_ID:
					return "ThingId";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case TOPICS:
					return "Topics";
				case STATUS:
					return "Status";
				case MESSAGE:
					return "Message";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

