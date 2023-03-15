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
	public class PaddedRecording : Recording
	{
		#region Constants
		public const string START_PADDING = "startPadding";
		public const string END_PADDING = "endPadding";
		#endregion

		#region Private Fields
		private int _StartPadding = Int32.MinValue;
		private int _EndPadding = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use StartPaddingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StartPadding
		{
			get { return _StartPadding; }
			set 
			{ 
				_StartPadding = value;
				OnPropertyChanged("StartPadding");
			}
		}
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
		#endregion

		#region CTor
		public PaddedRecording()
		{
		}

		public PaddedRecording(JToken node) : base(node)
		{
			if(node["startPadding"] != null)
			{
				this._StartPadding = ParseInt(node["startPadding"].Value<string>());
			}
			if(node["endPadding"] != null)
			{
				this._EndPadding = ParseInt(node["endPadding"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPaddedRecording");
			kparams.AddIfNotNull("startPadding", this._StartPadding);
			kparams.AddIfNotNull("endPadding", this._EndPadding);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case START_PADDING:
					return "StartPadding";
				case END_PADDING:
					return "EndPadding";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

