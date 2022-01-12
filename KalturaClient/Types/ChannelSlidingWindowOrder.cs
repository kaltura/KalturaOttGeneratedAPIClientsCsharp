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
	public class ChannelSlidingWindowOrder : BaseChannelOrder
	{
		#region Constants
		public const string PERIOD = "period";
		public const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private int _Period = Int32.MinValue;
		private ChannelSlidingWindowOrderByType _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Period
		{
			get { return _Period; }
			set 
			{ 
				_Period = value;
				OnPropertyChanged("Period");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ChannelSlidingWindowOrderByType OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public ChannelSlidingWindowOrder()
		{
		}

		public ChannelSlidingWindowOrder(JToken node) : base(node)
		{
			if(node["period"] != null)
			{
				this._Period = ParseInt(node["period"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (ChannelSlidingWindowOrderByType)StringEnum.Parse(typeof(ChannelSlidingWindowOrderByType), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaChannelSlidingWindowOrder");
			kparams.AddIfNotNull("period", this._Period);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PERIOD:
					return "Period";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

