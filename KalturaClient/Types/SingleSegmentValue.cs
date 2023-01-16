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
	public class SingleSegmentValue : BaseSegmentValue
	{
		#region Constants
		public const string ID = "id";
		public const string AFFECTED_USERS = "affectedUsers";
		public const string AFFECTED_HOUSEHOLDS = "affectedHouseholds";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private int _AffectedUsers = Int32.MinValue;
		private int _AffectedHouseholds = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use AffectedUsersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AffectedUsers
		{
			get { return _AffectedUsers; }
			private set 
			{ 
				_AffectedUsers = value;
				OnPropertyChanged("AffectedUsers");
			}
		}
		/// <summary>
		/// Use AffectedHouseholdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AffectedHouseholds
		{
			get { return _AffectedHouseholds; }
			private set 
			{ 
				_AffectedHouseholds = value;
				OnPropertyChanged("AffectedHouseholds");
			}
		}
		#endregion

		#region CTor
		public SingleSegmentValue()
		{
		}

		public SingleSegmentValue(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["affectedUsers"] != null)
			{
				this._AffectedUsers = ParseInt(node["affectedUsers"].Value<string>());
			}
			if(node["affectedHouseholds"] != null)
			{
				this._AffectedHouseholds = ParseInt(node["affectedHouseholds"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSingleSegmentValue");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("affectedUsers", this._AffectedUsers);
			kparams.AddIfNotNull("affectedHouseholds", this._AffectedHouseholds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case AFFECTED_USERS:
					return "AffectedUsers";
				case AFFECTED_HOUSEHOLDS:
					return "AffectedHouseholds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

