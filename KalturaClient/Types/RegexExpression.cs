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
	public class RegexExpression : ObjectBase
	{
		#region Constants
		public const string EXPRESSION = "expression";
		public const string DESCRIPTION = "description";
		#endregion

		#region Private Fields
		private string _Expression = null;
		private string _Description = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ExpressionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Expression
		{
			get { return _Expression; }
			set 
			{ 
				_Expression = value;
				OnPropertyChanged("Expression");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		#endregion

		#region CTor
		public RegexExpression()
		{
		}

		public RegexExpression(JToken node) : base(node)
		{
			if(node["expression"] != null)
			{
				this._Expression = node["expression"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRegexExpression");
			kparams.AddIfNotNull("expression", this._Expression);
			kparams.AddIfNotNull("description", this._Description);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXPRESSION:
					return "Expression";
				case DESCRIPTION:
					return "Description";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

