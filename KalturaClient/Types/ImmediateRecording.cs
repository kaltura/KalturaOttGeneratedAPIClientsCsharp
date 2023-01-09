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
	public class ImmediateRecording : Recording
	{
		#region Constants
		public const string END_PADDING = "endPadding";
		public const string ABSOLUTE_START = "absoluteStart";
		public const string ABSOLUTE_END = "absoluteEnd";
		#endregion

		#region Private Fields
		private int _EndPadding = Int32.MinValue;
		private long _AbsoluteStart = long.MinValue;
		private long _AbsoluteEnd = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use EndPaddingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EndPadding
		{
			get { return _EndPadding; }
			set 
			{ 
				_EndPadding = value;
				OnPropertyChanged("EndPadding");
			}
		}
		/// <summary>
		/// Use AbsoluteStartAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long AbsoluteStart
		{
			get { return _AbsoluteStart; }
			private set 
			{ 
				_AbsoluteStart = value;
				OnPropertyChanged("AbsoluteStart");
			}
		}
		/// <summary>
		/// Use AbsoluteEndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long AbsoluteEnd
		{
			get { return _AbsoluteEnd; }
			private set 
			{ 
				_AbsoluteEnd = value;
				OnPropertyChanged("AbsoluteEnd");
			}
		}
		#endregion

		#region CTor
		public ImmediateRecording()
		{
		}

		public ImmediateRecording(JToken node) : base(node)
		{
			if(node["endPadding"] != null)
			{
				this._EndPadding = ParseInt(node["endPadding"].Value<string>());
			}
			if(node["absoluteStart"] != null)
			{
				this._AbsoluteStart = ParseLong(node["absoluteStart"].Value<string>());
			}
			if(node["absoluteEnd"] != null)
			{
				this._AbsoluteEnd = ParseLong(node["absoluteEnd"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaImmediateRecording");
			kparams.AddIfNotNull("endPadding", this._EndPadding);
			kparams.AddIfNotNull("absoluteStart", this._AbsoluteStart);
			kparams.AddIfNotNull("absoluteEnd", this._AbsoluteEnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case END_PADDING:
					return "EndPadding";
				case ABSOLUTE_START:
					return "AbsoluteStart";
				case ABSOLUTE_END:
					return "AbsoluteEnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

