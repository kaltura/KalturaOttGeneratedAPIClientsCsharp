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
	public class MediaFileDynamicData : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string MEDIA_FILE_TYPE_ID = "mediaFileTypeId";
		public const string MEDIA_FILE_TYPE_KEY_NAME = "mediaFileTypeKeyName";
		public const string VALUE = "value";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private long _MediaFileTypeId = long.MinValue;
		private string _MediaFileTypeKeyName = null;
		private string _Value = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use MediaFileTypeIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long MediaFileTypeId
		{
			get { return _MediaFileTypeId; }
			set 
			{ 
				_MediaFileTypeId = value;
				OnPropertyChanged("MediaFileTypeId");
			}
		}
		/// <summary>
		/// Use MediaFileTypeKeyNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaFileTypeKeyName
		{
			get { return _MediaFileTypeKeyName; }
			set 
			{ 
				_MediaFileTypeKeyName = value;
				OnPropertyChanged("MediaFileTypeKeyName");
			}
		}
		/// <summary>
		/// Use ValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		#endregion

		#region CTor
		public MediaFileDynamicData()
		{
		}

		public MediaFileDynamicData(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["mediaFileTypeId"] != null)
			{
				this._MediaFileTypeId = ParseLong(node["mediaFileTypeId"].Value<string>());
			}
			if(node["mediaFileTypeKeyName"] != null)
			{
				this._MediaFileTypeKeyName = node["mediaFileTypeKeyName"].Value<string>();
			}
			if(node["value"] != null)
			{
				this._Value = node["value"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaFileDynamicData");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("mediaFileTypeId", this._MediaFileTypeId);
			kparams.AddIfNotNull("mediaFileTypeKeyName", this._MediaFileTypeKeyName);
			kparams.AddIfNotNull("value", this._Value);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case MEDIA_FILE_TYPE_ID:
					return "MediaFileTypeId";
				case MEDIA_FILE_TYPE_KEY_NAME:
					return "MediaFileTypeKeyName";
				case VALUE:
					return "Value";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

