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
	public class LiveToVodFullConfiguration : ObjectBase
	{
		#region Constants
		public const string IS_L2V_ENABLED = "isL2vEnabled";
		public const string RETENTION_PERIOD_DAYS = "retentionPeriodDays";
		public const string METADATA_CLASSIFIER = "metadataClassifier";
		public const string LINEAR_ASSETS = "linearAssets";
		#endregion

		#region Private Fields
		private bool? _IsL2vEnabled = null;
		private int _RetentionPeriodDays = Int32.MinValue;
		private string _MetadataClassifier = null;
		private IList<LiveToVodLinearAssetConfiguration> _LinearAssets;
		#endregion

		#region Properties
		/// <summary>
		/// Use IsL2vEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsL2vEnabled
		{
			get { return _IsL2vEnabled; }
			set 
			{ 
				_IsL2vEnabled = value;
				OnPropertyChanged("IsL2vEnabled");
			}
		}
		/// <summary>
		/// Use RetentionPeriodDaysAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RetentionPeriodDays
		{
			get { return _RetentionPeriodDays; }
			set 
			{ 
				_RetentionPeriodDays = value;
				OnPropertyChanged("RetentionPeriodDays");
			}
		}
		/// <summary>
		/// Use MetadataClassifierAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MetadataClassifier
		{
			get { return _MetadataClassifier; }
			set 
			{ 
				_MetadataClassifier = value;
				OnPropertyChanged("MetadataClassifier");
			}
		}
		/// <summary>
		/// Use LinearAssetsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<LiveToVodLinearAssetConfiguration> LinearAssets
		{
			get { return _LinearAssets; }
			set 
			{ 
				_LinearAssets = value;
				OnPropertyChanged("LinearAssets");
			}
		}
		#endregion

		#region CTor
		public LiveToVodFullConfiguration()
		{
		}

		public LiveToVodFullConfiguration(JToken node) : base(node)
		{
			if(node["isL2vEnabled"] != null)
			{
				this._IsL2vEnabled = ParseBool(node["isL2vEnabled"].Value<string>());
			}
			if(node["retentionPeriodDays"] != null)
			{
				this._RetentionPeriodDays = ParseInt(node["retentionPeriodDays"].Value<string>());
			}
			if(node["metadataClassifier"] != null)
			{
				this._MetadataClassifier = node["metadataClassifier"].Value<string>();
			}
			if(node["linearAssets"] != null)
			{
				this._LinearAssets = new List<LiveToVodLinearAssetConfiguration>();
				foreach(var arrayNode in node["linearAssets"].Children())
				{
					this._LinearAssets.Add(ObjectFactory.Create<LiveToVodLinearAssetConfiguration>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveToVodFullConfiguration");
			kparams.AddIfNotNull("isL2vEnabled", this._IsL2vEnabled);
			kparams.AddIfNotNull("retentionPeriodDays", this._RetentionPeriodDays);
			kparams.AddIfNotNull("metadataClassifier", this._MetadataClassifier);
			kparams.AddIfNotNull("linearAssets", this._LinearAssets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IS_L2V_ENABLED:
					return "IsL2vEnabled";
				case RETENTION_PERIOD_DAYS:
					return "RetentionPeriodDays";
				case METADATA_CLASSIFIER:
					return "MetadataClassifier";
				case LINEAR_ASSETS:
					return "LinearAssets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

