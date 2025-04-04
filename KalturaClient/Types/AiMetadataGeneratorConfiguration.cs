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
	public class AiMetadataGeneratorConfiguration : ObjectBase
	{
		#region Constants
		public const string IS_ENABLED = "isEnabled";
		public const string ASSET_STRUCT_META_NAME_MAP = "assetStructMetaNameMap";
		public const string SUPPORTED_LANGUAGES = "supportedLanguages";
		#endregion

		#region Private Fields
		private bool? _IsEnabled = null;
		private IDictionary<string, MetaFieldNameMap> _AssetStructMetaNameMap;
		private IList<StringValue> _SupportedLanguages;
		#endregion

		#region Properties
		/// <summary>
		/// Use IsEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsEnabled
		{
			get { return _IsEnabled; }
			set 
			{ 
				_IsEnabled = value;
				OnPropertyChanged("IsEnabled");
			}
		}
		/// <summary>
		/// Use AssetStructMetaNameMapAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IDictionary<string, MetaFieldNameMap> AssetStructMetaNameMap
		{
			get { return _AssetStructMetaNameMap; }
			set 
			{ 
				_AssetStructMetaNameMap = value;
				OnPropertyChanged("AssetStructMetaNameMap");
			}
		}
		/// <summary>
		/// Use SupportedLanguagesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<StringValue> SupportedLanguages
		{
			get { return _SupportedLanguages; }
			private set 
			{ 
				_SupportedLanguages = value;
				OnPropertyChanged("SupportedLanguages");
			}
		}
		#endregion

		#region CTor
		public AiMetadataGeneratorConfiguration()
		{
		}

		public AiMetadataGeneratorConfiguration(JToken node) : base(node)
		{
			if(node["isEnabled"] != null)
			{
				this._IsEnabled = ParseBool(node["isEnabled"].Value<string>());
			}
			if(node["assetStructMetaNameMap"] != null)
			{
				{
					string key;
					this._AssetStructMetaNameMap = new Dictionary<string, MetaFieldNameMap>();
					foreach(var arrayNode in node["assetStructMetaNameMap"].Children<JProperty>())
					{
						key = arrayNode.Name;
						this._AssetStructMetaNameMap[key] = ObjectFactory.Create<MetaFieldNameMap>(arrayNode.Value);
					}
				}
			}
			if(node["supportedLanguages"] != null)
			{
				this._SupportedLanguages = new List<StringValue>();
				foreach(var arrayNode in node["supportedLanguages"].Children())
				{
					this._SupportedLanguages.Add(ObjectFactory.Create<StringValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAiMetadataGeneratorConfiguration");
			kparams.AddIfNotNull("isEnabled", this._IsEnabled);
			kparams.AddIfNotNull("assetStructMetaNameMap", this._AssetStructMetaNameMap);
			kparams.AddIfNotNull("supportedLanguages", this._SupportedLanguages);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IS_ENABLED:
					return "IsEnabled";
				case ASSET_STRUCT_META_NAME_MAP:
					return "AssetStructMetaNameMap";
				case SUPPORTED_LANGUAGES:
					return "SupportedLanguages";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

