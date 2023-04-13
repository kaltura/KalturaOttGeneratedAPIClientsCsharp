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
	public class IngestEpgDetailsAggregation : ObjectBase
	{
		#region Constants
		public const string LINEAR_CHANNELS = "linearChannels";
		public const string DATES = "dates";
		public const string ALL = "all";
		#endregion

		#region Private Fields
		private IList<ChannelAggregatedIngestInfo> _LinearChannels;
		private IList<DateAggregatedIngestInfo> _Dates;
		private AggregatedIngestInfo _All;
		#endregion

		#region Properties
		/// <summary>
		/// Use LinearChannelsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ChannelAggregatedIngestInfo> LinearChannels
		{
			get { return _LinearChannels; }
			set 
			{ 
				_LinearChannels = value;
				OnPropertyChanged("LinearChannels");
			}
		}
		/// <summary>
		/// Use DatesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<DateAggregatedIngestInfo> Dates
		{
			get { return _Dates; }
			set 
			{ 
				_Dates = value;
				OnPropertyChanged("Dates");
			}
		}
		/// <summary>
		/// Use AllAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AggregatedIngestInfo All
		{
			get { return _All; }
			set 
			{ 
				_All = value;
				OnPropertyChanged("All");
			}
		}
		#endregion

		#region CTor
		public IngestEpgDetailsAggregation()
		{
		}

		public IngestEpgDetailsAggregation(JToken node) : base(node)
		{
			if(node["linearChannels"] != null)
			{
				this._LinearChannels = new List<ChannelAggregatedIngestInfo>();
				foreach(var arrayNode in node["linearChannels"].Children())
				{
					this._LinearChannels.Add(ObjectFactory.Create<ChannelAggregatedIngestInfo>(arrayNode));
				}
			}
			if(node["dates"] != null)
			{
				this._Dates = new List<DateAggregatedIngestInfo>();
				foreach(var arrayNode in node["dates"].Children())
				{
					this._Dates.Add(ObjectFactory.Create<DateAggregatedIngestInfo>(arrayNode));
				}
			}
			if(node["all"] != null)
			{
				this._All = ObjectFactory.Create<AggregatedIngestInfo>(node["all"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIngestEpgDetailsAggregation");
			kparams.AddIfNotNull("linearChannels", this._LinearChannels);
			kparams.AddIfNotNull("dates", this._Dates);
			kparams.AddIfNotNull("all", this._All);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LINEAR_CHANNELS:
					return "LinearChannels";
				case DATES:
					return "Dates";
				case ALL:
					return "All";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

