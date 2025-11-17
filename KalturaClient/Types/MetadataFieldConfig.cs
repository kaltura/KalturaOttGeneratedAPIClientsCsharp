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
	public class MetadataFieldConfig : ObjectBase
	{
		#region Constants
		public const string SYSTEM_NAME = "systemName";
		public const string OPERATION = "operation";
		#endregion

		#region Private Fields
		private string _SystemName = null;
		private MetadataUpdateOperation _Operation = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		/// <summary>
		/// Use OperationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataUpdateOperation Operation
		{
			get { return _Operation; }
			set 
			{ 
				_Operation = value;
				OnPropertyChanged("Operation");
			}
		}
		#endregion

		#region CTor
		public MetadataFieldConfig()
		{
		}

		public MetadataFieldConfig(JToken node) : base(node)
		{
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["operation"] != null)
			{
				this._Operation = (MetadataUpdateOperation)StringEnum.Parse(typeof(MetadataUpdateOperation), node["operation"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetadataFieldConfig");
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("operation", this._Operation);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SYSTEM_NAME:
					return "SystemName";
				case OPERATION:
					return "Operation";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

