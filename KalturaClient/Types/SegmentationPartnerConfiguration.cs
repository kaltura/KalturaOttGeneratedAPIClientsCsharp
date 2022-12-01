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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class SegmentationPartnerConfiguration : ObjectBase
	{
		#region Constants
		public const string MAX_CALCULATED_PERIOD = "maxCalculatedPeriod";
		public const string MAX_DYNAMIC_SEGMENTS = "maxDynamicSegments";
		#endregion

		#region Private Fields
		private int _MaxCalculatedPeriod = Int32.MinValue;
		private int _MaxDynamicSegments = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use MaxCalculatedPeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxCalculatedPeriod
		{
			get { return _MaxCalculatedPeriod; }
			set 
			{ 
				_MaxCalculatedPeriod = value;
				OnPropertyChanged("MaxCalculatedPeriod");
			}
		}
		/// <summary>
		/// Use MaxDynamicSegmentsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxDynamicSegments
		{
			get { return _MaxDynamicSegments; }
			set 
			{ 
				_MaxDynamicSegments = value;
				OnPropertyChanged("MaxDynamicSegments");
			}
		}
		#endregion

		#region CTor
		public SegmentationPartnerConfiguration()
		{
		}

		public SegmentationPartnerConfiguration(JToken node) : base(node)
		{
			if(node["maxCalculatedPeriod"] != null)
			{
				this._MaxCalculatedPeriod = ParseInt(node["maxCalculatedPeriod"].Value<string>());
			}
			if(node["maxDynamicSegments"] != null)
			{
				this._MaxDynamicSegments = ParseInt(node["maxDynamicSegments"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSegmentationPartnerConfiguration");
			kparams.AddIfNotNull("maxCalculatedPeriod", this._MaxCalculatedPeriod);
			kparams.AddIfNotNull("maxDynamicSegments", this._MaxDynamicSegments);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MAX_CALCULATED_PERIOD:
					return "MaxCalculatedPeriod";
				case MAX_DYNAMIC_SEGMENTS:
					return "MaxDynamicSegments";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

