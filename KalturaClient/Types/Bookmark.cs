// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2018  Kaltura Inc.
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

namespace Kaltura.Types
{
	public class Bookmark : SlimAsset
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string POSITION = "position";
		public const string POSITION_OWNER = "positionOwner";
		public const string FINISHED_WATCHING = "finishedWatching";
		public const string PLAYER_DATA = "playerData";
		public const string PROGRAM_ID = "programId";
		public const string IS_REPORTING_MODE = "isReportingMode";
		#endregion

		#region Private Fields
		private string _UserId = null;
		private int _Position = Int32.MinValue;
		private PositionOwner _PositionOwner = null;
		private bool? _FinishedWatching = null;
		private BookmarkPlayerData _PlayerData;
		private long _ProgramId = long.MinValue;
		private bool? _IsReportingMode = null;
		#endregion

		#region Properties
		public string UserId
		{
			get { return _UserId; }
		}
		public int Position
		{
			get { return _Position; }
			set 
			{ 
				_Position = value;
				OnPropertyChanged("Position");
			}
		}
		public PositionOwner PositionOwner
		{
			get { return _PositionOwner; }
		}
		public bool? FinishedWatching
		{
			get { return _FinishedWatching; }
		}
		public BookmarkPlayerData PlayerData
		{
			get { return _PlayerData; }
			set 
			{ 
				_PlayerData = value;
				OnPropertyChanged("PlayerData");
			}
		}
		public long ProgramId
		{
			get { return _ProgramId; }
			set 
			{ 
				_ProgramId = value;
				OnPropertyChanged("ProgramId");
			}
		}
		public bool? IsReportingMode
		{
			get { return _IsReportingMode; }
			set 
			{ 
				_IsReportingMode = value;
				OnPropertyChanged("IsReportingMode");
			}
		}
		#endregion

		#region CTor
		public Bookmark()
		{
		}

		public Bookmark(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "position":
						this._Position = ParseInt(propertyNode.InnerText);
						continue;
					case "positionOwner":
						this._PositionOwner = (PositionOwner)StringEnum.Parse(typeof(PositionOwner), propertyNode.InnerText);
						continue;
					case "finishedWatching":
						this._FinishedWatching = ParseBool(propertyNode.InnerText);
						continue;
					case "playerData":
						this._PlayerData = ObjectFactory.Create<BookmarkPlayerData>(propertyNode);
						continue;
					case "programId":
						this._ProgramId = ParseLong(propertyNode.InnerText);
						continue;
					case "isReportingMode":
						this._IsReportingMode = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public Bookmark(IDictionary<string,object> data) : base(data)
		{
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._Position = data.TryGetValueSafe<int>("position");
			    this._PositionOwner = (PositionOwner)StringEnum.Parse(typeof(PositionOwner), data.TryGetValueSafe<string>("positionOwner"));
			    this._FinishedWatching = data.TryGetValueSafe<bool>("finishedWatching");
			    this._PlayerData = ObjectFactory.Create<BookmarkPlayerData>(data.TryGetValueSafe<IDictionary<string,object>>("playerData"));
			    this._ProgramId = data.TryGetValueSafe<long>("programId");
			    this._IsReportingMode = data.TryGetValueSafe<bool>("isReportingMode");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBookmark");
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("position", this._Position);
			kparams.AddIfNotNull("positionOwner", this._PositionOwner);
			kparams.AddIfNotNull("finishedWatching", this._FinishedWatching);
			kparams.AddIfNotNull("playerData", this._PlayerData);
			kparams.AddIfNotNull("programId", this._ProgramId);
			kparams.AddIfNotNull("isReportingMode", this._IsReportingMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID:
					return "UserId";
				case POSITION:
					return "Position";
				case POSITION_OWNER:
					return "PositionOwner";
				case FINISHED_WATCHING:
					return "FinishedWatching";
				case PLAYER_DATA:
					return "PlayerData";
				case PROGRAM_ID:
					return "ProgramId";
				case IS_REPORTING_MODE:
					return "IsReportingMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

