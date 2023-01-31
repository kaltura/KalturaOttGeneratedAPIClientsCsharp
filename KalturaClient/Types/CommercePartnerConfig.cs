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
	public class CommercePartnerConfig : PartnerConfiguration
	{
		#region Constants
		public const string BOOKMARK_EVENT_THRESHOLDS = "bookmarkEventThresholds";
		public const string KEEP_SUBSCRIPTION_ADD_ONS = "keepSubscriptionAddOns";
		public const string PROGRAM_ASSET_ENTITLEMENT_PADDING_START = "programAssetEntitlementPaddingStart";
		public const string PROGRAM_ASSET_ENTITLEMENT_PADDING_END = "programAssetEntitlementPaddingEnd";
		#endregion

		#region Private Fields
		private IList<BookmarkEventThreshold> _BookmarkEventThresholds;
		private bool? _KeepSubscriptionAddOns = null;
		private int _ProgramAssetEntitlementPaddingStart = Int32.MinValue;
		private int _ProgramAssetEntitlementPaddingEnd = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use BookmarkEventThresholdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<BookmarkEventThreshold> BookmarkEventThresholds
		{
			get { return _BookmarkEventThresholds; }
			set 
			{ 
				_BookmarkEventThresholds = value;
				OnPropertyChanged("BookmarkEventThresholds");
			}
		}
		/// <summary>
		/// Use KeepSubscriptionAddOnsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? KeepSubscriptionAddOns
		{
			get { return _KeepSubscriptionAddOns; }
			set 
			{ 
				_KeepSubscriptionAddOns = value;
				OnPropertyChanged("KeepSubscriptionAddOns");
			}
		}
		/// <summary>
		/// Use ProgramAssetEntitlementPaddingStartAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ProgramAssetEntitlementPaddingStart
		{
			get { return _ProgramAssetEntitlementPaddingStart; }
			set 
			{ 
				_ProgramAssetEntitlementPaddingStart = value;
				OnPropertyChanged("ProgramAssetEntitlementPaddingStart");
			}
		}
		/// <summary>
		/// Use ProgramAssetEntitlementPaddingEndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ProgramAssetEntitlementPaddingEnd
		{
			get { return _ProgramAssetEntitlementPaddingEnd; }
			set 
			{ 
				_ProgramAssetEntitlementPaddingEnd = value;
				OnPropertyChanged("ProgramAssetEntitlementPaddingEnd");
			}
		}
		#endregion

		#region CTor
		public CommercePartnerConfig()
		{
		}

		public CommercePartnerConfig(JToken node) : base(node)
		{
			if(node["bookmarkEventThresholds"] != null)
			{
				this._BookmarkEventThresholds = new List<BookmarkEventThreshold>();
				foreach(var arrayNode in node["bookmarkEventThresholds"].Children())
				{
					this._BookmarkEventThresholds.Add(ObjectFactory.Create<BookmarkEventThreshold>(arrayNode));
				}
			}
			if(node["keepSubscriptionAddOns"] != null)
			{
				this._KeepSubscriptionAddOns = ParseBool(node["keepSubscriptionAddOns"].Value<string>());
			}
			if(node["programAssetEntitlementPaddingStart"] != null)
			{
				this._ProgramAssetEntitlementPaddingStart = ParseInt(node["programAssetEntitlementPaddingStart"].Value<string>());
			}
			if(node["programAssetEntitlementPaddingEnd"] != null)
			{
				this._ProgramAssetEntitlementPaddingEnd = ParseInt(node["programAssetEntitlementPaddingEnd"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCommercePartnerConfig");
			kparams.AddIfNotNull("bookmarkEventThresholds", this._BookmarkEventThresholds);
			kparams.AddIfNotNull("keepSubscriptionAddOns", this._KeepSubscriptionAddOns);
			kparams.AddIfNotNull("programAssetEntitlementPaddingStart", this._ProgramAssetEntitlementPaddingStart);
			kparams.AddIfNotNull("programAssetEntitlementPaddingEnd", this._ProgramAssetEntitlementPaddingEnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case BOOKMARK_EVENT_THRESHOLDS:
					return "BookmarkEventThresholds";
				case KEEP_SUBSCRIPTION_ADD_ONS:
					return "KeepSubscriptionAddOns";
				case PROGRAM_ASSET_ENTITLEMENT_PADDING_START:
					return "ProgramAssetEntitlementPaddingStart";
				case PROGRAM_ASSET_ENTITLEMENT_PADDING_END:
					return "ProgramAssetEntitlementPaddingEnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

