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
	public class ContentTypeSelector : ObjectBase
	{
		#region Constants
		public const string INCLUDE_RECORDINGS = "includeRecordings";
		public const string INCLUDE_PROGRAMS = "includePrograms";
		public const string MEDIA_TYPE_ID_IN = "mediaTypeIdIn";
		#endregion

		#region Private Fields
		private bool? _IncludeRecordings = null;
		private bool? _IncludePrograms = null;
		private string _MediaTypeIdIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IncludeRecordingsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IncludeRecordings
		{
			get { return _IncludeRecordings; }
			set 
			{ 
				_IncludeRecordings = value;
				OnPropertyChanged("IncludeRecordings");
			}
		}
		/// <summary>
		/// Use IncludeProgramsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IncludePrograms
		{
			get { return _IncludePrograms; }
			set 
			{ 
				_IncludePrograms = value;
				OnPropertyChanged("IncludePrograms");
			}
		}
		/// <summary>
		/// Use MediaTypeIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaTypeIdIn
		{
			get { return _MediaTypeIdIn; }
			set 
			{ 
				_MediaTypeIdIn = value;
				OnPropertyChanged("MediaTypeIdIn");
			}
		}
		#endregion

		#region CTor
		public ContentTypeSelector()
		{
		}

		public ContentTypeSelector(JToken node) : base(node)
		{
			if(node["includeRecordings"] != null)
			{
				this._IncludeRecordings = ParseBool(node["includeRecordings"].Value<string>());
			}
			if(node["includePrograms"] != null)
			{
				this._IncludePrograms = ParseBool(node["includePrograms"].Value<string>());
			}
			if(node["mediaTypeIdIn"] != null)
			{
				this._MediaTypeIdIn = node["mediaTypeIdIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaContentTypeSelector");
			kparams.AddIfNotNull("includeRecordings", this._IncludeRecordings);
			kparams.AddIfNotNull("includePrograms", this._IncludePrograms);
			kparams.AddIfNotNull("mediaTypeIdIn", this._MediaTypeIdIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INCLUDE_RECORDINGS:
					return "IncludeRecordings";
				case INCLUDE_PROGRAMS:
					return "IncludePrograms";
				case MEDIA_TYPE_ID_IN:
					return "MediaTypeIdIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

