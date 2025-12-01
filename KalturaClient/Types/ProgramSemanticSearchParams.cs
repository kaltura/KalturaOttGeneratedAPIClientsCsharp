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
	public class ProgramSemanticSearchParams : ObjectBase
	{
		#region Constants
		public const string ENDS_AFTER = "endsAfter";
		public const string EXPIRES_AFTER = "expiresAfter";
		#endregion

		#region Private Fields
		private long _EndsAfter = long.MinValue;
		private long _ExpiresAfter = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use EndsAfterAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EndsAfter
		{
			get { return _EndsAfter; }
			set 
			{ 
				_EndsAfter = value;
				OnPropertyChanged("EndsAfter");
			}
		}
		/// <summary>
		/// Use ExpiresAfterAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ExpiresAfter
		{
			get { return _ExpiresAfter; }
			set 
			{ 
				_ExpiresAfter = value;
				OnPropertyChanged("ExpiresAfter");
			}
		}
		#endregion

		#region CTor
		public ProgramSemanticSearchParams()
		{
		}

		public ProgramSemanticSearchParams(JToken node) : base(node)
		{
			if(node["endsAfter"] != null)
			{
				this._EndsAfter = ParseLong(node["endsAfter"].Value<string>());
			}
			if(node["expiresAfter"] != null)
			{
				this._ExpiresAfter = ParseLong(node["expiresAfter"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaProgramSemanticSearchParams");
			kparams.AddIfNotNull("endsAfter", this._EndsAfter);
			kparams.AddIfNotNull("expiresAfter", this._ExpiresAfter);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENDS_AFTER:
					return "EndsAfter";
				case EXPIRES_AFTER:
					return "ExpiresAfter";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

