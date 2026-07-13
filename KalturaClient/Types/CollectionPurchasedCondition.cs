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
	public class CollectionPurchasedCondition : BaseSegmentCondition
	{
		#region Constants
		public const string COLLECTION_ID_EQUALS = "collectionIdEquals";
		public const string DAYS = "days";
		#endregion

		#region Private Fields
		private long _CollectionIdEquals = long.MinValue;
		private int _Days = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use CollectionIdEqualsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CollectionIdEquals
		{
			get { return _CollectionIdEquals; }
			set 
			{ 
				_CollectionIdEquals = value;
				OnPropertyChanged("CollectionIdEquals");
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
		public CollectionPurchasedCondition()
		{
		}

		public CollectionPurchasedCondition(JToken node) : base(node)
		{
			if(node["collectionIdEquals"] != null)
			{
				this._CollectionIdEquals = ParseLong(node["collectionIdEquals"].Value<string>());
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
				kparams.AddReplace("objectType", "KalturaCollectionPurchasedCondition");
			kparams.AddIfNotNull("collectionIdEquals", this._CollectionIdEquals);
			kparams.AddIfNotNull("days", this._Days);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case COLLECTION_ID_EQUALS:
					return "CollectionIdEquals";
				case DAYS:
					return "Days";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

