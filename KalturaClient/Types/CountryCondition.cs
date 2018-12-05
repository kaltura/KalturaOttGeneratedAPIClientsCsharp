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
	public class CountryCondition : Condition
	{
		#region Constants
		public const string NOT = "not";
		public const string COUNTRIES = "countries";
		#endregion

		#region Private Fields
		private bool? _Not = null;
		private string _Countries = null;
		#endregion

		#region Properties
		public bool? Not
		{
			get { return _Not; }
			set 
			{ 
				_Not = value;
				OnPropertyChanged("Not");
			}
		}
		public string Countries
		{
			get { return _Countries; }
			set 
			{ 
				_Countries = value;
				OnPropertyChanged("Countries");
			}
		}
		#endregion

		#region CTor
		public CountryCondition()
		{
		}

		public CountryCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "not":
						this._Not = ParseBool(propertyNode.InnerText);
						continue;
					case "countries":
						this._Countries = propertyNode.InnerText;
						continue;
				}
			}
		}

		public CountryCondition(IDictionary<string,object> data) : base(data)
		{
			    this._Not = data.TryGetValueSafe<bool>("not");
			    this._Countries = data.TryGetValueSafe<string>("countries");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCountryCondition");
			kparams.AddIfNotNull("not", this._Not);
			kparams.AddIfNotNull("countries", this._Countries);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NOT:
					return "Not";
				case COUNTRIES:
					return "Countries";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

