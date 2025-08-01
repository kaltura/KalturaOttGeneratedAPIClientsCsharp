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
	public class GeoBlockRule : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string CREATE_DATE = "createDate";
		public const string UPDATE_DATE = "updateDate";
		public const string COUNTRY_IDS = "countryIds";
		public const string MODE = "mode";
		public const string IS_PROXY_RULE_ENABLED = "isProxyRuleEnabled";
		public const string PROXY_RULE_LEVEL = "proxyRuleLevel";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _Name = null;
		private long _CreateDate = long.MinValue;
		private long _UpdateDate = long.MinValue;
		private string _CountryIds = null;
		private GeoBlockMode _Mode = null;
		private bool? _IsProxyRuleEnabled = null;
		private ProxyRuleLevel _ProxyRuleLevel = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
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
		/// Use CreateDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CreateDate
		{
			get { return _CreateDate; }
			private set 
			{ 
				_CreateDate = value;
				OnPropertyChanged("CreateDate");
			}
		}
		/// <summary>
		/// Use UpdateDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long UpdateDate
		{
			get { return _UpdateDate; }
			private set 
			{ 
				_UpdateDate = value;
				OnPropertyChanged("UpdateDate");
			}
		}
		/// <summary>
		/// Use CountryIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CountryIds
		{
			get { return _CountryIds; }
			set 
			{ 
				_CountryIds = value;
				OnPropertyChanged("CountryIds");
			}
		}
		/// <summary>
		/// Use ModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public GeoBlockMode Mode
		{
			get { return _Mode; }
			set 
			{ 
				_Mode = value;
				OnPropertyChanged("Mode");
			}
		}
		/// <summary>
		/// Use IsProxyRuleEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsProxyRuleEnabled
		{
			get { return _IsProxyRuleEnabled; }
			set 
			{ 
				_IsProxyRuleEnabled = value;
				OnPropertyChanged("IsProxyRuleEnabled");
			}
		}
		/// <summary>
		/// Use ProxyRuleLevelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ProxyRuleLevel ProxyRuleLevel
		{
			get { return _ProxyRuleLevel; }
			set 
			{ 
				_ProxyRuleLevel = value;
				OnPropertyChanged("ProxyRuleLevel");
			}
		}
		#endregion

		#region CTor
		public GeoBlockRule()
		{
		}

		public GeoBlockRule(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["createDate"] != null)
			{
				this._CreateDate = ParseLong(node["createDate"].Value<string>());
			}
			if(node["updateDate"] != null)
			{
				this._UpdateDate = ParseLong(node["updateDate"].Value<string>());
			}
			if(node["countryIds"] != null)
			{
				this._CountryIds = node["countryIds"].Value<string>();
			}
			if(node["mode"] != null)
			{
				this._Mode = (GeoBlockMode)StringEnum.Parse(typeof(GeoBlockMode), node["mode"].Value<string>());
			}
			if(node["isProxyRuleEnabled"] != null)
			{
				this._IsProxyRuleEnabled = ParseBool(node["isProxyRuleEnabled"].Value<string>());
			}
			if(node["proxyRuleLevel"] != null)
			{
				this._ProxyRuleLevel = (ProxyRuleLevel)StringEnum.Parse(typeof(ProxyRuleLevel), node["proxyRuleLevel"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGeoBlockRule");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			kparams.AddIfNotNull("countryIds", this._CountryIds);
			kparams.AddIfNotNull("mode", this._Mode);
			kparams.AddIfNotNull("isProxyRuleEnabled", this._IsProxyRuleEnabled);
			kparams.AddIfNotNull("proxyRuleLevel", this._ProxyRuleLevel);
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
				case CREATE_DATE:
					return "CreateDate";
				case UPDATE_DATE:
					return "UpdateDate";
				case COUNTRY_IDS:
					return "CountryIds";
				case MODE:
					return "Mode";
				case IS_PROXY_RULE_ENABLED:
					return "IsProxyRuleEnabled";
				case PROXY_RULE_LEVEL:
					return "ProxyRuleLevel";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

