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
	public class CloudUploadSettingsConfiguration : PartnerConfiguration
	{
		#region Constants
		public const string DEFAULT_ALLOWED_FILE_EXTENSIONS = "defaultAllowedFileExtensions";
		public const string CUSTOM_ALLOWED_FILE_EXTENSIONS = "customAllowedFileExtensions";
		#endregion

		#region Private Fields
		private string _DefaultAllowedFileExtensions = null;
		private string _CustomAllowedFileExtensions = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use DefaultAllowedFileExtensionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultAllowedFileExtensions
		{
			get { return _DefaultAllowedFileExtensions; }
			private set 
			{ 
				_DefaultAllowedFileExtensions = value;
				OnPropertyChanged("DefaultAllowedFileExtensions");
			}
		}
		/// <summary>
		/// Use CustomAllowedFileExtensionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CustomAllowedFileExtensions
		{
			get { return _CustomAllowedFileExtensions; }
			set 
			{ 
				_CustomAllowedFileExtensions = value;
				OnPropertyChanged("CustomAllowedFileExtensions");
			}
		}
		#endregion

		#region CTor
		public CloudUploadSettingsConfiguration()
		{
		}

		public CloudUploadSettingsConfiguration(JToken node) : base(node)
		{
			if(node["defaultAllowedFileExtensions"] != null)
			{
				this._DefaultAllowedFileExtensions = node["defaultAllowedFileExtensions"].Value<string>();
			}
			if(node["customAllowedFileExtensions"] != null)
			{
				this._CustomAllowedFileExtensions = node["customAllowedFileExtensions"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCloudUploadSettingsConfiguration");
			kparams.AddIfNotNull("defaultAllowedFileExtensions", this._DefaultAllowedFileExtensions);
			kparams.AddIfNotNull("customAllowedFileExtensions", this._CustomAllowedFileExtensions);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DEFAULT_ALLOWED_FILE_EXTENSIONS:
					return "DefaultAllowedFileExtensions";
				case CUSTOM_ALLOWED_FILE_EXTENSIONS:
					return "CustomAllowedFileExtensions";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

