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
	public class MediaFileDynamicDataFilter : Filter
	{
		#region Constants
		public const string ID_IN = "idIn";
		public const string MEDIA_FILE_TYPE_ID = "mediaFileTypeId";
		public const string MEDIA_FILE_TYPE_KEY_NAME = "mediaFileTypeKeyName";
		public const string VALUE_EQUAL = "valueEqual";
		public const string VALUE_STARTS_WITH = "valueStartsWith";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _IdIn = null;
		private long _MediaFileTypeId = long.MinValue;
		private string _MediaFileTypeKeyName = null;
		private string _ValueEqual = null;
		private string _ValueStartsWith = null;
		private MediaFileDynamicDataOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
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
		/// Use ValueEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ValueEqual
		{
			get { return _ValueEqual; }
			set 
			{ 
				_ValueEqual = value;
				OnPropertyChanged("ValueEqual");
			}
		}
		/// <summary>
		/// Use ValueStartsWithAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ValueStartsWith
		{
			get { return _ValueStartsWith; }
			set 
			{ 
				_ValueStartsWith = value;
				OnPropertyChanged("ValueStartsWith");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new MediaFileDynamicDataOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public MediaFileDynamicDataFilter()
		{
		}

		public MediaFileDynamicDataFilter(JToken node) : base(node)
		{
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["mediaFileTypeId"] != null)
			{
				this._MediaFileTypeId = ParseLong(node["mediaFileTypeId"].Value<string>());
			}
			if(node["mediaFileTypeKeyName"] != null)
			{
				this._MediaFileTypeKeyName = node["mediaFileTypeKeyName"].Value<string>();
			}
			if(node["valueEqual"] != null)
			{
				this._ValueEqual = node["valueEqual"].Value<string>();
			}
			if(node["valueStartsWith"] != null)
			{
				this._ValueStartsWith = node["valueStartsWith"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (MediaFileDynamicDataOrderBy)StringEnum.Parse(typeof(MediaFileDynamicDataOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaFileDynamicDataFilter");
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("mediaFileTypeId", this._MediaFileTypeId);
			kparams.AddIfNotNull("mediaFileTypeKeyName", this._MediaFileTypeKeyName);
			kparams.AddIfNotNull("valueEqual", this._ValueEqual);
			kparams.AddIfNotNull("valueStartsWith", this._ValueStartsWith);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_IN:
					return "IdIn";
				case MEDIA_FILE_TYPE_ID:
					return "MediaFileTypeId";
				case MEDIA_FILE_TYPE_KEY_NAME:
					return "MediaFileTypeKeyName";
				case VALUE_EQUAL:
					return "ValueEqual";
				case VALUE_STARTS_WITH:
					return "ValueStartsWith";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

