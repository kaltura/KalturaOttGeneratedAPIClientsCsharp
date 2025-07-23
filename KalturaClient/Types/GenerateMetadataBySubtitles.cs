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
	public class GenerateMetadataBySubtitles : ObjectBase
	{
		#region Constants
		public const string SUBTITLES_FILE_ID = "subtitlesFileId";
		public const string EXTERNAL_ASSET_IDS = "externalAssetIds";
		#endregion

		#region Private Fields
		private long _SubtitlesFileId = long.MinValue;
		private IList<StringValue> _ExternalAssetIds;
		#endregion

		#region Properties
		/// <summary>
		/// Use SubtitlesFileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long SubtitlesFileId
		{
			get { return _SubtitlesFileId; }
			set 
			{ 
				_SubtitlesFileId = value;
				OnPropertyChanged("SubtitlesFileId");
			}
		}
		/// <summary>
		/// Use ExternalAssetIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<StringValue> ExternalAssetIds
		{
			get { return _ExternalAssetIds; }
			set 
			{ 
				_ExternalAssetIds = value;
				OnPropertyChanged("ExternalAssetIds");
			}
		}
		#endregion

		#region CTor
		public GenerateMetadataBySubtitles()
		{
		}

		public GenerateMetadataBySubtitles(JToken node) : base(node)
		{
			if(node["subtitlesFileId"] != null)
			{
				this._SubtitlesFileId = ParseLong(node["subtitlesFileId"].Value<string>());
			}
			if(node["externalAssetIds"] != null)
			{
				this._ExternalAssetIds = new List<StringValue>();
				foreach(var arrayNode in node["externalAssetIds"].Children())
				{
					this._ExternalAssetIds.Add(ObjectFactory.Create<StringValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenerateMetadataBySubtitles");
			kparams.AddIfNotNull("subtitlesFileId", this._SubtitlesFileId);
			kparams.AddIfNotNull("externalAssetIds", this._ExternalAssetIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SUBTITLES_FILE_ID:
					return "SubtitlesFileId";
				case EXTERNAL_ASSET_IDS:
					return "ExternalAssetIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

