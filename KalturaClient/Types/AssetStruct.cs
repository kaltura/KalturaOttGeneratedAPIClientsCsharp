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
	public class AssetStruct : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string MULTILINGUAL_NAME = "multilingualName";
		public const string SYSTEM_NAME = "systemName";
		public const string IS_PROTECTED = "isProtected";
		public const string META_IDS = "metaIds";
		public const string CREATE_DATE = "createDate";
		public const string UPDATE_DATE = "updateDate";
		public const string FEATURES = "features";
		public const string PLURAL_NAME = "pluralName";
		public const string PARENT_ID = "parentId";
		public const string CONNECTING_META_ID = "connectingMetaId";
		public const string CONNECTED_PARENT_META_ID = "connectedParentMetaId";
		public const string DYNAMIC_DATA = "dynamicData";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _Name = null;
		private IList<TranslationToken> _MultilingualName;
		private string _SystemName = null;
		private bool? _IsProtected = null;
		private string _MetaIds = null;
		private long _CreateDate = long.MinValue;
		private long _UpdateDate = long.MinValue;
		private string _Features = null;
		private string _PluralName = null;
		private long _ParentId = long.MinValue;
		private long _ConnectingMetaId = long.MinValue;
		private long _ConnectedParentMetaId = long.MinValue;
		private IDictionary<string, StringValue> _DynamicData;
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
			private set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use MultilingualNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<TranslationToken> MultilingualName
		{
			get { return _MultilingualName; }
			set 
			{ 
				_MultilingualName = value;
				OnPropertyChanged("MultilingualName");
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
		/// Use IsProtectedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsProtected
		{
			get { return _IsProtected; }
			set 
			{ 
				_IsProtected = value;
				OnPropertyChanged("IsProtected");
			}
		}
		/// <summary>
		/// Use MetaIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MetaIds
		{
			get { return _MetaIds; }
			set 
			{ 
				_MetaIds = value;
				OnPropertyChanged("MetaIds");
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
		/// Use FeaturesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Features
		{
			get { return _Features; }
			set 
			{ 
				_Features = value;
				OnPropertyChanged("Features");
			}
		}
		/// <summary>
		/// Use PluralNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PluralName
		{
			get { return _PluralName; }
			set 
			{ 
				_PluralName = value;
				OnPropertyChanged("PluralName");
			}
		}
		/// <summary>
		/// Use ParentIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		/// <summary>
		/// Use ConnectingMetaIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ConnectingMetaId
		{
			get { return _ConnectingMetaId; }
			set 
			{ 
				_ConnectingMetaId = value;
				OnPropertyChanged("ConnectingMetaId");
			}
		}
		/// <summary>
		/// Use ConnectedParentMetaIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ConnectedParentMetaId
		{
			get { return _ConnectedParentMetaId; }
			set 
			{ 
				_ConnectedParentMetaId = value;
				OnPropertyChanged("ConnectedParentMetaId");
			}
		}
		/// <summary>
		/// Use DynamicDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IDictionary<string, StringValue> DynamicData
		{
			get { return _DynamicData; }
			set 
			{ 
				_DynamicData = value;
				OnPropertyChanged("DynamicData");
			}
		}
		#endregion

		#region CTor
		public AssetStruct()
		{
		}

		public AssetStruct(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["multilingualName"] != null)
			{
				this._MultilingualName = new List<TranslationToken>();
				foreach(var arrayNode in node["multilingualName"].Children())
				{
					this._MultilingualName.Add(ObjectFactory.Create<TranslationToken>(arrayNode));
				}
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["isProtected"] != null)
			{
				this._IsProtected = ParseBool(node["isProtected"].Value<string>());
			}
			if(node["metaIds"] != null)
			{
				this._MetaIds = node["metaIds"].Value<string>();
			}
			if(node["createDate"] != null)
			{
				this._CreateDate = ParseLong(node["createDate"].Value<string>());
			}
			if(node["updateDate"] != null)
			{
				this._UpdateDate = ParseLong(node["updateDate"].Value<string>());
			}
			if(node["features"] != null)
			{
				this._Features = node["features"].Value<string>();
			}
			if(node["pluralName"] != null)
			{
				this._PluralName = node["pluralName"].Value<string>();
			}
			if(node["parentId"] != null)
			{
				this._ParentId = ParseLong(node["parentId"].Value<string>());
			}
			if(node["connectingMetaId"] != null)
			{
				this._ConnectingMetaId = ParseLong(node["connectingMetaId"].Value<string>());
			}
			if(node["connectedParentMetaId"] != null)
			{
				this._ConnectedParentMetaId = ParseLong(node["connectedParentMetaId"].Value<string>());
			}
			if(node["dynamicData"] != null)
			{
				{
					string key;
					this._DynamicData = new Dictionary<string, StringValue>();
					foreach(var arrayNode in node["dynamicData"].Children<JProperty>())
					{
						key = arrayNode.Name;
						this._DynamicData[key] = ObjectFactory.Create<StringValue>(arrayNode.Value);
					}
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetStruct");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("multilingualName", this._MultilingualName);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("isProtected", this._IsProtected);
			kparams.AddIfNotNull("metaIds", this._MetaIds);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			kparams.AddIfNotNull("features", this._Features);
			kparams.AddIfNotNull("pluralName", this._PluralName);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("connectingMetaId", this._ConnectingMetaId);
			kparams.AddIfNotNull("connectedParentMetaId", this._ConnectedParentMetaId);
			kparams.AddIfNotNull("dynamicData", this._DynamicData);
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
				case MULTILINGUAL_NAME:
					return "MultilingualName";
				case SYSTEM_NAME:
					return "SystemName";
				case IS_PROTECTED:
					return "IsProtected";
				case META_IDS:
					return "MetaIds";
				case CREATE_DATE:
					return "CreateDate";
				case UPDATE_DATE:
					return "UpdateDate";
				case FEATURES:
					return "Features";
				case PLURAL_NAME:
					return "PluralName";
				case PARENT_ID:
					return "ParentId";
				case CONNECTING_META_ID:
					return "ConnectingMetaId";
				case CONNECTED_PARENT_META_ID:
					return "ConnectedParentMetaId";
				case DYNAMIC_DATA:
					return "DynamicData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

