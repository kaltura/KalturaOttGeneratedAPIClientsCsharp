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
	public class CustomFieldsPartnerConfiguration : PartnerConfiguration
	{
		#region Constants
		public const string META_SYSTEM_NAME_INSTEAD_OF_ALIAS_LIST = "metaSystemNameInsteadOfAliasList";
		#endregion

		#region Private Fields
		private string _MetaSystemNameInsteadOfAliasList = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use MetaSystemNameInsteadOfAliasListAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MetaSystemNameInsteadOfAliasList
		{
			get { return _MetaSystemNameInsteadOfAliasList; }
			set 
			{ 
				_MetaSystemNameInsteadOfAliasList = value;
				OnPropertyChanged("MetaSystemNameInsteadOfAliasList");
			}
		}
		#endregion

		#region CTor
		public CustomFieldsPartnerConfiguration()
		{
		}

		public CustomFieldsPartnerConfiguration(JToken node) : base(node)
		{
			if(node["metaSystemNameInsteadOfAliasList"] != null)
			{
				this._MetaSystemNameInsteadOfAliasList = node["metaSystemNameInsteadOfAliasList"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCustomFieldsPartnerConfiguration");
			kparams.AddIfNotNull("metaSystemNameInsteadOfAliasList", this._MetaSystemNameInsteadOfAliasList);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case META_SYSTEM_NAME_INSTEAD_OF_ALIAS_LIST:
					return "MetaSystemNameInsteadOfAliasList";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

