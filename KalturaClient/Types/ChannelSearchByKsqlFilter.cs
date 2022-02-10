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
	public class ChannelSearchByKsqlFilter : ChannelsBaseFilter
	{
		#region Constants
		public const string KSQL = "kSql";
		public const string CHANNEL_STRUCT_EQUAL = "channelStructEqual";
		#endregion

		#region Private Fields
		private string _KSql = null;
		private ChannelStruct _ChannelStructEqual = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use KSqlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string KSql
		{
			get { return _KSql; }
			set 
			{ 
				_KSql = value;
				OnPropertyChanged("KSql");
			}
		}
		/// <summary>
		/// Use ChannelStructEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ChannelStruct ChannelStructEqual
		{
			get { return _ChannelStructEqual; }
			set 
			{ 
				_ChannelStructEqual = value;
				OnPropertyChanged("ChannelStructEqual");
			}
		}
		#endregion

		#region CTor
		public ChannelSearchByKsqlFilter()
		{
		}

		public ChannelSearchByKsqlFilter(JToken node) : base(node)
		{
			if(node["kSql"] != null)
			{
				this._KSql = node["kSql"].Value<string>();
			}
			if(node["channelStructEqual"] != null)
			{
				this._ChannelStructEqual = (ChannelStruct)StringEnum.Parse(typeof(ChannelStruct), node["channelStructEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaChannelSearchByKsqlFilter");
			kparams.AddIfNotNull("kSql", this._KSql);
			kparams.AddIfNotNull("channelStructEqual", this._ChannelStructEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KSQL:
					return "KSql";
				case CHANNEL_STRUCT_EQUAL:
					return "ChannelStructEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

