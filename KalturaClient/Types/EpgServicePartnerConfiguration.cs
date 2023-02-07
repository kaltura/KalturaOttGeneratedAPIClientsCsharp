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
	public class EpgServicePartnerConfiguration : ObjectBase
	{
		#region Constants
		public const string NUMBER_OF_SLOTS = "numberOfSlots";
		public const string FIRST_SLOT_OFFSET = "firstSlotOffset";
		#endregion

		#region Private Fields
		private int _NumberOfSlots = Int32.MinValue;
		private int _FirstSlotOffset = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use NumberOfSlotsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int NumberOfSlots
		{
			get { return _NumberOfSlots; }
			set 
			{ 
				_NumberOfSlots = value;
				OnPropertyChanged("NumberOfSlots");
			}
		}
		/// <summary>
		/// Use FirstSlotOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FirstSlotOffset
		{
			get { return _FirstSlotOffset; }
			set 
			{ 
				_FirstSlotOffset = value;
				OnPropertyChanged("FirstSlotOffset");
			}
		}
		#endregion

		#region CTor
		public EpgServicePartnerConfiguration()
		{
		}

		public EpgServicePartnerConfiguration(JToken node) : base(node)
		{
			if(node["numberOfSlots"] != null)
			{
				this._NumberOfSlots = ParseInt(node["numberOfSlots"].Value<string>());
			}
			if(node["firstSlotOffset"] != null)
			{
				this._FirstSlotOffset = ParseInt(node["firstSlotOffset"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEpgServicePartnerConfiguration");
			kparams.AddIfNotNull("numberOfSlots", this._NumberOfSlots);
			kparams.AddIfNotNull("firstSlotOffset", this._FirstSlotOffset);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NUMBER_OF_SLOTS:
					return "NumberOfSlots";
				case FIRST_SLOT_OFFSET:
					return "FirstSlotOffset";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

