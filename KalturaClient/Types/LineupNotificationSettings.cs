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
	public class LineupNotificationSettings : ObjectBase
	{
		#region Constants
		public const string ENABLED = "enabled";
		#endregion

		#region Private Fields
		private bool? _Enabled = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? Enabled
		{
			get { return _Enabled; }
			set 
			{ 
				_Enabled = value;
				OnPropertyChanged("Enabled");
			}
		}
		#endregion

		#region CTor
		public LineupNotificationSettings()
		{
		}

		public LineupNotificationSettings(JToken node) : base(node)
		{
			if(node["enabled"] != null)
			{
				this._Enabled = ParseBool(node["enabled"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLineupNotificationSettings");
			kparams.AddIfNotNull("enabled", this._Enabled);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENABLED:
					return "Enabled";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

