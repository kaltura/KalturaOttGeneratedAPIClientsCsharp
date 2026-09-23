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
	public class TvodPurchasedCondition : BaseSegmentCondition
	{
		#region Constants
		public const string PPV_ID_EQUALS = "ppvIdEquals";
		public const string MEDIA_ID_EQUALS = "mediaIdEquals";
		public const string DAYS = "days";
		#endregion

		#region Private Fields
		private long _PpvIdEquals = long.MinValue;
		private long _MediaIdEquals = long.MinValue;
		private int _Days = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use PpvIdEqualsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PpvIdEquals
		{
			get { return _PpvIdEquals; }
			set 
			{ 
				_PpvIdEquals = value;
				OnPropertyChanged("PpvIdEquals");
			}
		}
		/// <summary>
		/// Use MediaIdEqualsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long MediaIdEquals
		{
			get { return _MediaIdEquals; }
			set 
			{ 
				_MediaIdEquals = value;
				OnPropertyChanged("MediaIdEquals");
			}
		}
		/// <summary>
		/// Use DaysAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Days
		{
			get { return _Days; }
			set 
			{ 
				_Days = value;
				OnPropertyChanged("Days");
			}
		}
		#endregion

		#region CTor
		public TvodPurchasedCondition()
		{
		}

		public TvodPurchasedCondition(JToken node) : base(node)
		{
			if(node["ppvIdEquals"] != null)
			{
				this._PpvIdEquals = ParseLong(node["ppvIdEquals"].Value<string>());
			}
			if(node["mediaIdEquals"] != null)
			{
				this._MediaIdEquals = ParseLong(node["mediaIdEquals"].Value<string>());
			}
			if(node["days"] != null)
			{
				this._Days = ParseInt(node["days"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTvodPurchasedCondition");
			kparams.AddIfNotNull("ppvIdEquals", this._PpvIdEquals);
			kparams.AddIfNotNull("mediaIdEquals", this._MediaIdEquals);
			kparams.AddIfNotNull("days", this._Days);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PPV_ID_EQUALS:
					return "PpvIdEquals";
				case MEDIA_ID_EQUALS:
					return "MediaIdEquals";
				case DAYS:
					return "Days";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

