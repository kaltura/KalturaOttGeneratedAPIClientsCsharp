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
	public class SubtitlesFilter : Filter
	{
		#region Constants
		public const string ID_IN = "idIn";
		public const string FILE_NAME_CONTAINS = "fileNameContains";
		#endregion

		#region Private Fields
		private string _IdIn = null;
		private string _FileNameContains = null;
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
		/// Use FileNameContainsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileNameContains
		{
			get { return _FileNameContains; }
			set 
			{ 
				_FileNameContains = value;
				OnPropertyChanged("FileNameContains");
			}
		}
		#endregion

		#region CTor
		public SubtitlesFilter()
		{
		}

		public SubtitlesFilter(JToken node) : base(node)
		{
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["fileNameContains"] != null)
			{
				this._FileNameContains = node["fileNameContains"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSubtitlesFilter");
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("fileNameContains", this._FileNameContains);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_IN:
					return "IdIn";
				case FILE_NAME_CONTAINS:
					return "FileNameContains";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

