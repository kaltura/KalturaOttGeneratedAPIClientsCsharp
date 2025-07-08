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
	public class GetPlaybackContextParams : ObjectBase
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string ASSET_TYPE = "assetType";
		public const string CONTEXT_DATA_PARAMS = "contextDataParams";
		public const string SOURCE_TYPE = "sourceType";
		#endregion

		#region Private Fields
		private string _AssetId = null;
		private AssetType _AssetType = null;
		private PlaybackContextOptions _ContextDataParams;
		private string _SourceType = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		/// <summary>
		/// Use AssetTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetType AssetType
		{
			get { return _AssetType; }
			set 
			{ 
				_AssetType = value;
				OnPropertyChanged("AssetType");
			}
		}
		/// <summary>
		/// Use ContextDataParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlaybackContextOptions ContextDataParams
		{
			get { return _ContextDataParams; }
			set 
			{ 
				_ContextDataParams = value;
				OnPropertyChanged("ContextDataParams");
			}
		}
		/// <summary>
		/// Use SourceTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SourceType
		{
			get { return _SourceType; }
			set 
			{ 
				_SourceType = value;
				OnPropertyChanged("SourceType");
			}
		}
		#endregion

		#region CTor
		public GetPlaybackContextParams()
		{
		}

		public GetPlaybackContextParams(JToken node) : base(node)
		{
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
			if(node["assetType"] != null)
			{
				this._AssetType = (AssetType)StringEnum.Parse(typeof(AssetType), node["assetType"].Value<string>());
			}
			if(node["contextDataParams"] != null)
			{
				this._ContextDataParams = ObjectFactory.Create<PlaybackContextOptions>(node["contextDataParams"]);
			}
			if(node["sourceType"] != null)
			{
				this._SourceType = node["sourceType"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGetPlaybackContextParams");
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("assetType", this._AssetType);
			kparams.AddIfNotNull("contextDataParams", this._ContextDataParams);
			kparams.AddIfNotNull("sourceType", this._SourceType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_ID:
					return "AssetId";
				case ASSET_TYPE:
					return "AssetType";
				case CONTEXT_DATA_PARAMS:
					return "ContextDataParams";
				case SOURCE_TYPE:
					return "SourceType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

