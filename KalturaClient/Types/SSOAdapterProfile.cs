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
	public class SSOAdapterProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string IS_ACTIVE = "isActive";
		public const string ADAPTER_URL = "adapterUrl";
		public const string SETTINGS = "settings";
		public const string EXTERNAL_IDENTIFIER = "externalIdentifier";
		public const string SHARED_SECRET = "sharedSecret";
		public const string ADAPTER_GRPC_ADDRESS = "adapterGrpcAddress";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private int _IsActive = Int32.MinValue;
		private string _AdapterUrl = null;
		private IDictionary<string, StringValue> _Settings;
		private string _ExternalIdentifier = null;
		private string _SharedSecret = null;
		private string _AdapterGrpcAddress = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
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
		/// Use IsActiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsActive
		{
			get { return _IsActive; }
			set 
			{ 
				_IsActive = value;
				OnPropertyChanged("IsActive");
			}
		}
		/// <summary>
		/// Use AdapterUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdapterUrl
		{
			get { return _AdapterUrl; }
			set 
			{ 
				_AdapterUrl = value;
				OnPropertyChanged("AdapterUrl");
			}
		}
		/// <summary>
		/// Use SettingsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IDictionary<string, StringValue> Settings
		{
			get { return _Settings; }
			set 
			{ 
				_Settings = value;
				OnPropertyChanged("Settings");
			}
		}
		/// <summary>
		/// Use ExternalIdentifierAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalIdentifier
		{
			get { return _ExternalIdentifier; }
			set 
			{ 
				_ExternalIdentifier = value;
				OnPropertyChanged("ExternalIdentifier");
			}
		}
		/// <summary>
		/// Use SharedSecretAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SharedSecret
		{
			get { return _SharedSecret; }
			set 
			{ 
				_SharedSecret = value;
				OnPropertyChanged("SharedSecret");
			}
		}
		/// <summary>
		/// Use AdapterGrpcAddressAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdapterGrpcAddress
		{
			get { return _AdapterGrpcAddress; }
			set 
			{ 
				_AdapterGrpcAddress = value;
				OnPropertyChanged("AdapterGrpcAddress");
			}
		}
		#endregion

		#region CTor
		public SSOAdapterProfile()
		{
		}

		public SSOAdapterProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["isActive"] != null)
			{
				this._IsActive = ParseInt(node["isActive"].Value<string>());
			}
			if(node["adapterUrl"] != null)
			{
				this._AdapterUrl = node["adapterUrl"].Value<string>();
			}
			if(node["settings"] != null)
			{
				{
					string key;
					this._Settings = new Dictionary<string, StringValue>();
					foreach(var arrayNode in node["settings"].Children<JProperty>())
					{
						key = arrayNode.Name;
						this._Settings[key] = ObjectFactory.Create<StringValue>(arrayNode.Value);
					}
				}
			}
			if(node["externalIdentifier"] != null)
			{
				this._ExternalIdentifier = node["externalIdentifier"].Value<string>();
			}
			if(node["sharedSecret"] != null)
			{
				this._SharedSecret = node["sharedSecret"].Value<string>();
			}
			if(node["adapterGrpcAddress"] != null)
			{
				this._AdapterGrpcAddress = node["adapterGrpcAddress"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSSOAdapterProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("isActive", this._IsActive);
			kparams.AddIfNotNull("adapterUrl", this._AdapterUrl);
			kparams.AddIfNotNull("settings", this._Settings);
			kparams.AddIfNotNull("externalIdentifier", this._ExternalIdentifier);
			kparams.AddIfNotNull("sharedSecret", this._SharedSecret);
			kparams.AddIfNotNull("adapterGrpcAddress", this._AdapterGrpcAddress);
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
				case IS_ACTIVE:
					return "IsActive";
				case ADAPTER_URL:
					return "AdapterUrl";
				case SETTINGS:
					return "Settings";
				case EXTERNAL_IDENTIFIER:
					return "ExternalIdentifier";
				case SHARED_SECRET:
					return "SharedSecret";
				case ADAPTER_GRPC_ADDRESS:
					return "AdapterGrpcAddress";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

