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
	public class IngestStatusEpgConfiguration : ObjectBase
	{
		#region Constants
		public const string IS_SUPPORTED = "isSupported";
		public const string RETAINING_PERIOD = "retainingPeriod";
		#endregion

		#region Private Fields
		private bool? _IsSupported = null;
		private int _RetainingPeriod = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IsSupportedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsSupported
		{
			get { return _IsSupported; }
			set 
			{ 
				_IsSupported = value;
				OnPropertyChanged("IsSupported");
			}
		}
		/// <summary>
		/// Use RetainingPeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RetainingPeriod
		{
			get { return _RetainingPeriod; }
			set 
			{ 
				_RetainingPeriod = value;
				OnPropertyChanged("RetainingPeriod");
			}
		}
		#endregion

		#region CTor
		public IngestStatusEpgConfiguration()
		{
		}

		public IngestStatusEpgConfiguration(JToken node) : base(node)
		{
			if(node["isSupported"] != null)
			{
				this._IsSupported = ParseBool(node["isSupported"].Value<string>());
			}
			if(node["retainingPeriod"] != null)
			{
				this._RetainingPeriod = ParseInt(node["retainingPeriod"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIngestStatusEpgConfiguration");
			kparams.AddIfNotNull("isSupported", this._IsSupported);
			kparams.AddIfNotNull("retainingPeriod", this._RetainingPeriod);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IS_SUPPORTED:
					return "IsSupported";
				case RETAINING_PERIOD:
					return "RetainingPeriod";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

