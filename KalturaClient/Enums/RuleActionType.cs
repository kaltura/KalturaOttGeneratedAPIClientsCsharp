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
namespace Kaltura.Enums
{
	public sealed class RuleActionType : StringEnum
	{
		public static readonly RuleActionType BLOCK = new RuleActionType("BLOCK");
		public static readonly RuleActionType START_DATE_OFFSET = new RuleActionType("START_DATE_OFFSET");
		public static readonly RuleActionType END_DATE_OFFSET = new RuleActionType("END_DATE_OFFSET");
		public static readonly RuleActionType USER_BLOCK = new RuleActionType("USER_BLOCK");
		public static readonly RuleActionType ALLOW_PLAYBACK = new RuleActionType("ALLOW_PLAYBACK");
		public static readonly RuleActionType BLOCK_PLAYBACK = new RuleActionType("BLOCK_PLAYBACK");
		public static readonly RuleActionType APPLY_DISCOUNT_MODULE = new RuleActionType("APPLY_DISCOUNT_MODULE");
		public static readonly RuleActionType APPLY_PLAYBACK_ADAPTER = new RuleActionType("APPLY_PLAYBACK_ADAPTER");
		public static readonly RuleActionType FILTER = new RuleActionType("FILTER");
		public static readonly RuleActionType ASSET_LIFE_CYCLE_TRANSITION = new RuleActionType("ASSET_LIFE_CYCLE_TRANSITION");
		public static readonly RuleActionType APPLY_FREE_PLAYBACK = new RuleActionType("APPLY_FREE_PLAYBACK");
		public static readonly RuleActionType FILTERASSETBYKSQL = new RuleActionType("FilterAssetByKsql");
		public static readonly RuleActionType FILTERFILEBYQUALITYINDISCOVERY = new RuleActionType("FilterFileByQualityInDiscovery");
		public static readonly RuleActionType FILTERFILEBYQUALITYINPLAYBACK = new RuleActionType("FilterFileByQualityInPlayback");
		public static readonly RuleActionType FILTERFILEBYFILETYPEIDFORASSETTYPEINDISCOVERY = new RuleActionType("FilterFileByFileTypeIdForAssetTypeInDiscovery");
		public static readonly RuleActionType FILTERFILEBYFILETYPEIDFORASSETTYPEINPLAYBACK = new RuleActionType("FilterFileByFileTypeIdForAssetTypeInPlayback");
		public static readonly RuleActionType FILTERFILEBYFILETYPEIDINDISCOVERY = new RuleActionType("FilterFileByFileTypeIdInDiscovery");
		public static readonly RuleActionType FILTERFILEBYFILETYPEIDINPLAYBACK = new RuleActionType("FilterFileByFileTypeIdInPlayback");
		public static readonly RuleActionType FILTERFILEBYAUDIOCODECINDISCOVERY = new RuleActionType("FilterFileByAudioCodecInDiscovery");
		public static readonly RuleActionType FILTERFILEBYAUDIOCODECINPLAYBACK = new RuleActionType("FilterFileByAudioCodecInPlayback");
		public static readonly RuleActionType FILTERFILEBYVIDEOCODECINDISCOVERY = new RuleActionType("FilterFileByVideoCodecInDiscovery");
		public static readonly RuleActionType FILTERFILEBYVIDEOCODECINPLAYBACK = new RuleActionType("FilterFileByVideoCodecInPlayback");
		public static readonly RuleActionType FILTERFILEBYSTREAMERTYPEINDISCOVERY = new RuleActionType("FilterFileByStreamerTypeInDiscovery");
		public static readonly RuleActionType FILTERFILEBYSTREAMERTYPEINPLAYBACK = new RuleActionType("FilterFileByStreamerTypeInPlayback");
		public static readonly RuleActionType FILTERFILEBYLABELINDISCOVERY = new RuleActionType("FilterFileByLabelInDiscovery");
		public static readonly RuleActionType FILTERFILEBYLABELINPLAYBACK = new RuleActionType("FilterFileByLabelInPlayback");
		public static readonly RuleActionType FILTERFILEBYDYNAMICDATAINDISCOVERY = new RuleActionType("FilterFileByDynamicDataInDiscovery");
		public static readonly RuleActionType FILTERFILEBYDYNAMICDATAINPLAYBACK = new RuleActionType("FilterFileByDynamicDataInPlayback");

		private RuleActionType(string name) : base(name) { }
	}
}
