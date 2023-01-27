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
	public class ChannelAggregatedIngestInfo : ObjectBase
	{
		#region Constants
		public const string LINEAR_CHANNEL_ID = "linearChannelId";
		public const string AGGREGATED_ERRORS = "aggregatedErrors";
		#endregion

		#region Private Fields
		private long _LinearChannelId = long.MinValue;
		private AggregatedIngestInfo _AggregatedErrors;
		#endregion

		#region Properties
		/// <summary>
		/// Use LinearChannelIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long LinearChannelId
		{
			get { return _LinearChannelId; }
			set 
			{ 
				_LinearChannelId = value;
				OnPropertyChanged("LinearChannelId");
			}
		}
		/// <summary>
		/// Use AggregatedErrorsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AggregatedIngestInfo AggregatedErrors
		{
			get { return _AggregatedErrors; }
			set 
			{ 
				_AggregatedErrors = value;
				OnPropertyChanged("AggregatedErrors");
			}
		}
		#endregion

		#region CTor
		public ChannelAggregatedIngestInfo()
		{
		}

		public ChannelAggregatedIngestInfo(JToken node) : base(node)
		{
			if(node["linearChannelId"] != null)
			{
				this._LinearChannelId = ParseLong(node["linearChannelId"].Value<string>());
			}
			if(node["aggregatedErrors"] != null)
			{
				this._AggregatedErrors = ObjectFactory.Create<AggregatedIngestInfo>(node["aggregatedErrors"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaChannelAggregatedIngestInfo");
			kparams.AddIfNotNull("linearChannelId", this._LinearChannelId);
			kparams.AddIfNotNull("aggregatedErrors", this._AggregatedErrors);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LINEAR_CHANNEL_ID:
					return "LinearChannelId";
				case AGGREGATED_ERRORS:
					return "AggregatedErrors";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

