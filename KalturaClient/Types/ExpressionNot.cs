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
	public class ExpressionNot : UserSessionProfileExpression
	{
		#region Constants
		public const string EXPRESSION = "expression";
		#endregion

		#region Private Fields
		private UserSessionProfileExpression _Expression;
		#endregion

		#region Properties
		/// <summary>
		/// Use ExpressionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UserSessionProfileExpression Expression
		{
			get { return _Expression; }
			set 
			{ 
				_Expression = value;
				OnPropertyChanged("Expression");
			}
		}
		#endregion

		#region CTor
		public ExpressionNot()
		{
		}

		public ExpressionNot(JToken node) : base(node)
		{
			if(node["expression"] != null)
			{
				this._Expression = ObjectFactory.Create<UserSessionProfileExpression>(node["expression"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExpressionNot");
			kparams.AddIfNotNull("expression", this._Expression);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXPRESSION:
					return "Expression";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

