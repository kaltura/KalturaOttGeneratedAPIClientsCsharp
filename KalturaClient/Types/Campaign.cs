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
	public class Campaign : OTTObjectSupportNullable
	{
		#region Constants
		public const string ID = "id";
		public const string CREATE_DATE = "createDate";
		public const string UPDATE_DATE = "updateDate";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string STATE = "state";
		public const string PROMOTION = "promotion";
		public const string MESSAGE = "message";
		public const string COLLECTION_ID_IN = "collectionIdIn";
		public const string ASSET_USER_RULE_ID = "assetUserRuleId";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private long _CreateDate = long.MinValue;
		private long _UpdateDate = long.MinValue;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private ObjectState _State = null;
		private BasePromotion _Promotion;
		private string _Message = null;
		private string _CollectionIdIn = null;
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
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		/// Use StartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		/// <summary>
		/// Use EndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
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
		/// Use SystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use StateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ObjectState State
		{
			get { return _State; }
			private set 
			{ 
				_State = value;
				OnPropertyChanged("State");
			}
		}
		/// <summary>
		/// Use PromotionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BasePromotion Promotion
		{
			get { return _Promotion; }
			set 
			{ 
				_Promotion = value;
				OnPropertyChanged("Promotion");
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
		/// <summary>
		/// Use CollectionIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CollectionIdIn
		{
			get { return _CollectionIdIn; }
			set 
			{ 
				_CollectionIdIn = value;
				OnPropertyChanged("CollectionIdIn");
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
		public Campaign()
		{
		}

		public Campaign(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["createDate"] != null)
			{
				this._CreateDate = ParseLong(node["createDate"].Value<string>());
			}
			if(node["updateDate"] != null)
			{
				this._UpdateDate = ParseLong(node["updateDate"].Value<string>());
			}
			if(node["startDate"] != null)
			{
				this._StartDate = ParseLong(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseLong(node["endDate"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["state"] != null)
			{
				this._State = (ObjectState)StringEnum.Parse(typeof(ObjectState), node["state"].Value<string>());
			}
			if(node["promotion"] != null)
			{
				this._Promotion = ObjectFactory.Create<BasePromotion>(node["promotion"]);
			}
			if(node["message"] != null)
			{
				this._Message = node["message"].Value<string>();
			}
			if(node["collectionIdIn"] != null)
			{
				this._CollectionIdIn = node["collectionIdIn"].Value<string>();
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
				kparams.AddReplace("objectType", "KalturaCampaign");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("state", this._State);
			kparams.AddIfNotNull("promotion", this._Promotion);
			kparams.AddIfNotNull("message", this._Message);
			kparams.AddIfNotNull("collectionIdIn", this._CollectionIdIn);
			kparams.AddIfNotNull("assetUserRuleId", this._AssetUserRuleId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATE_DATE:
					return "CreateDate";
				case UPDATE_DATE:
					return "UpdateDate";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case STATE:
					return "State";
				case PROMOTION:
					return "Promotion";
				case MESSAGE:
					return "Message";
				case COLLECTION_ID_IN:
					return "CollectionIdIn";
				case ASSET_USER_RULE_ID:
					return "AssetUserRuleId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

