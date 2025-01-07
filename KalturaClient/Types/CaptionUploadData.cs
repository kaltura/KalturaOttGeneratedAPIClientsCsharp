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
	public class CaptionUploadData : ObjectBase
	{
		#region Constants
		public const string CAPTION_TYPE = "captionType";
		public const string CAPTION_LANGUAGE = "captionLanguage";
		#endregion

		#region Private Fields
		private AssetEnrichCaptionType _CaptionType = null;
		private string _CaptionLanguage = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use CaptionTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetEnrichCaptionType CaptionType
		{
			get { return _CaptionType; }
			set 
			{ 
				_CaptionType = value;
				OnPropertyChanged("CaptionType");
			}
		}
		/// <summary>
		/// Use CaptionLanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CaptionLanguage
		{
			get { return _CaptionLanguage; }
			private set 
			{ 
				_CaptionLanguage = value;
				OnPropertyChanged("CaptionLanguage");
			}
		}
		#endregion

		#region CTor
		public CaptionUploadData()
		{
		}

		public CaptionUploadData(JToken node) : base(node)
		{
			if(node["captionType"] != null)
			{
				this._CaptionType = (AssetEnrichCaptionType)StringEnum.Parse(typeof(AssetEnrichCaptionType), node["captionType"].Value<string>());
			}
			if(node["captionLanguage"] != null)
			{
				this._CaptionLanguage = node["captionLanguage"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionUploadData");
			kparams.AddIfNotNull("captionType", this._CaptionType);
			kparams.AddIfNotNull("captionLanguage", this._CaptionLanguage);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CAPTION_TYPE:
					return "CaptionType";
				case CAPTION_LANGUAGE:
					return "CaptionLanguage";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

