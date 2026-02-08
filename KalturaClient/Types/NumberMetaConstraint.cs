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
	public class NumberMetaConstraint : BaseAttributeConstraint
	{
		#region Constants
		public const string EQUALS = "equals";
		public const string GREATER_THAN = "greaterThan";
		public const string SMALLER_THAN = "smallerThan";
		#endregion

		#region Private Fields
		private string _Equals = null;
		private string _GreaterThan = null;
		private string _SmallerThan = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EqualsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Equals
		{
			get { return _Equals; }
			set 
			{ 
				_Equals = value;
				OnPropertyChanged("Equals");
			}
		}
		/// <summary>
		/// Use GreaterThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string GreaterThan
		{
			get { return _GreaterThan; }
			set 
			{ 
				_GreaterThan = value;
				OnPropertyChanged("GreaterThan");
			}
		}
		/// <summary>
		/// Use SmallerThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SmallerThan
		{
			get { return _SmallerThan; }
			set 
			{ 
				_SmallerThan = value;
				OnPropertyChanged("SmallerThan");
			}
		}
		#endregion

		#region CTor
		public NumberMetaConstraint()
		{
		}

		public NumberMetaConstraint(JToken node) : base(node)
		{
			if(node["equals"] != null)
			{
				this._Equals = node["equals"].Value<string>();
			}
			if(node["greaterThan"] != null)
			{
				this._GreaterThan = node["greaterThan"].Value<string>();
			}
			if(node["smallerThan"] != null)
			{
				this._SmallerThan = node["smallerThan"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaNumberMetaConstraint");
			kparams.AddIfNotNull("equals", this._Equals);
			kparams.AddIfNotNull("greaterThan", this._GreaterThan);
			kparams.AddIfNotNull("smallerThan", this._SmallerThan);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EQUALS:
					return "Equals";
				case GREATER_THAN:
					return "GreaterThan";
				case SMALLER_THAN:
					return "SmallerThan";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

