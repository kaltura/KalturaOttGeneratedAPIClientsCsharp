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
	public class MediaImage : ObjectBase
	{
		#region Constants
		public const string RATIO = "ratio";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string URL = "url";
		public const string VERSION = "version";
		public const string ID = "id";
		public const string IS_DEFAULT = "isDefault";
		public const string IMAGE_TYPE_ID = "imageTypeId";
		public const string IMAGE_TYPE_NAME = "imageTypeName";
		#endregion

		#region Private Fields
		private string _Ratio = null;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private string _Url = null;
		private int _Version = Int32.MinValue;
		private string _Id = null;
		private bool? _IsDefault = null;
		private long _ImageTypeId = long.MinValue;
		private string _ImageTypeName = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use RatioAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Ratio
		{
			get { return _Ratio; }
			set 
			{ 
				_Ratio = value;
				OnPropertyChanged("Ratio");
			}
		}
		/// <summary>
		/// Use WidthAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		/// <summary>
		/// Use HeightAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		/// <summary>
		/// Use UrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		/// <summary>
		/// Use VersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use IsDefaultAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		/// <summary>
		/// Use ImageTypeIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ImageTypeId
		{
			get { return _ImageTypeId; }
			set 
			{ 
				_ImageTypeId = value;
				OnPropertyChanged("ImageTypeId");
			}
		}
		/// <summary>
		/// Use ImageTypeNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ImageTypeName
		{
			get { return _ImageTypeName; }
			set 
			{ 
				_ImageTypeName = value;
				OnPropertyChanged("ImageTypeName");
			}
		}
		#endregion

		#region CTor
		public MediaImage()
		{
		}

		public MediaImage(JToken node) : base(node)
		{
			if(node["ratio"] != null)
			{
				this._Ratio = node["ratio"].Value<string>();
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
			}
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = ParseBool(node["isDefault"].Value<string>());
			}
			if(node["imageTypeId"] != null)
			{
				this._ImageTypeId = ParseLong(node["imageTypeId"].Value<string>());
			}
			if(node["imageTypeName"] != null)
			{
				this._ImageTypeName = node["imageTypeName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaImage");
			kparams.AddIfNotNull("ratio", this._Ratio);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("imageTypeId", this._ImageTypeId);
			kparams.AddIfNotNull("imageTypeName", this._ImageTypeName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RATIO:
					return "Ratio";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case URL:
					return "Url";
				case VERSION:
					return "Version";
				case ID:
					return "Id";
				case IS_DEFAULT:
					return "IsDefault";
				case IMAGE_TYPE_ID:
					return "ImageTypeId";
				case IMAGE_TYPE_NAME:
					return "ImageTypeName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

