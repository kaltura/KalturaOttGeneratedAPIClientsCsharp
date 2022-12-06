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
	public class Recording : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		public const string ASSET_ID = "assetId";
		public const string TYPE = "type";
		public const string VIEWABLE_UNTIL_DATE = "viewableUntilDate";
		public const string IS_PROTECTED = "isProtected";
		public const string CREATE_DATE = "createDate";
		public const string UPDATE_DATE = "updateDate";
		public const string HOUSEHOLD_SPECIFIC_START_TIME_OFFSET = "householdSpecificStartTimeOffset";
		public const string HOUSEHOLD_SPECIFIC_END_TIME_OFFSET = "householdSpecificEndTimeOffset";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private RecordingStatus _Status = null;
		private long _AssetId = long.MinValue;
		private RecordingType _Type = null;
		private long _ViewableUntilDate = long.MinValue;
		private bool? _IsProtected = null;
		private long _CreateDate = long.MinValue;
		private long _UpdateDate = long.MinValue;
		private int _HouseholdSpecificStartTimeOffset = Int32.MinValue;
		private int _HouseholdSpecificEndTimeOffset = Int32.MinValue;
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
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RecordingStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use AssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RecordingType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use ViewableUntilDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ViewableUntilDate
		{
			get { return _ViewableUntilDate; }
			set 
			{ 
				_ViewableUntilDate = value;
				OnPropertyChanged("ViewableUntilDate");
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
		/// Use HouseholdSpecificStartTimeOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int HouseholdSpecificStartTimeOffset
		{
			get { return _HouseholdSpecificStartTimeOffset; }
			set 
			{ 
				_HouseholdSpecificStartTimeOffset = value;
				OnPropertyChanged("HouseholdSpecificStartTimeOffset");
			}
		}
		/// <summary>
		/// Use HouseholdSpecificEndTimeOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int HouseholdSpecificEndTimeOffset
		{
			get { return _HouseholdSpecificEndTimeOffset; }
			set 
			{ 
				_HouseholdSpecificEndTimeOffset = value;
				OnPropertyChanged("HouseholdSpecificEndTimeOffset");
			}
		}
		#endregion

		#region CTor
		public Recording()
		{
		}

		public Recording(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (RecordingStatus)StringEnum.Parse(typeof(RecordingStatus), node["status"].Value<string>());
			}
			if(node["assetId"] != null)
			{
				this._AssetId = ParseLong(node["assetId"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (RecordingType)StringEnum.Parse(typeof(RecordingType), node["type"].Value<string>());
			}
			if(node["viewableUntilDate"] != null)
			{
				this._ViewableUntilDate = ParseLong(node["viewableUntilDate"].Value<string>());
			}
			if(node["isProtected"] != null)
			{
				this._IsProtected = ParseBool(node["isProtected"].Value<string>());
			}
			if(node["createDate"] != null)
			{
				this._CreateDate = ParseLong(node["createDate"].Value<string>());
			}
			if(node["updateDate"] != null)
			{
				this._UpdateDate = ParseLong(node["updateDate"].Value<string>());
			}
			if(node["householdSpecificStartTimeOffset"] != null)
			{
				this._HouseholdSpecificStartTimeOffset = ParseInt(node["householdSpecificStartTimeOffset"].Value<string>());
			}
			if(node["householdSpecificEndTimeOffset"] != null)
			{
				this._HouseholdSpecificEndTimeOffset = ParseInt(node["householdSpecificEndTimeOffset"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRecording");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("viewableUntilDate", this._ViewableUntilDate);
			kparams.AddIfNotNull("isProtected", this._IsProtected);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			kparams.AddIfNotNull("householdSpecificStartTimeOffset", this._HouseholdSpecificStartTimeOffset);
			kparams.AddIfNotNull("householdSpecificEndTimeOffset", this._HouseholdSpecificEndTimeOffset);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case STATUS:
					return "Status";
				case ASSET_ID:
					return "AssetId";
				case TYPE:
					return "Type";
				case VIEWABLE_UNTIL_DATE:
					return "ViewableUntilDate";
				case IS_PROTECTED:
					return "IsProtected";
				case CREATE_DATE:
					return "CreateDate";
				case UPDATE_DATE:
					return "UpdateDate";
				case HOUSEHOLD_SPECIFIC_START_TIME_OFFSET:
					return "HouseholdSpecificStartTimeOffset";
				case HOUSEHOLD_SPECIFIC_END_TIME_OFFSET:
					return "HouseholdSpecificEndTimeOffset";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

