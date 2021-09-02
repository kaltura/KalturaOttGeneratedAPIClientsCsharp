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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class ExpressionOr : UserSessionProfileExpression
	{
		#region Constants
		public const string EXPRESSIONS = "expressions";
		#endregion

		#region Private Fields
		private IList<UserSessionProfileExpression> _Expressions;
		#endregion

		#region Properties
		[JsonProperty]
		public IList<UserSessionProfileExpression> Expressions
		{
			get { return _Expressions; }
			set 
			{ 
				_Expressions = value;
				OnPropertyChanged("Expressions");
			}
		}
		#endregion

		#region CTor
		public ExpressionOr()
		{
		}

		public ExpressionOr(JToken node) : base(node)
		{
			if(node["expressions"] != null)
			{
				this._Expressions = new List<UserSessionProfileExpression>();
				foreach(var arrayNode in node["expressions"].Children())
				{
					this._Expressions.Add(ObjectFactory.Create<UserSessionProfileExpression>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExpressionOr");
			kparams.AddIfNotNull("expressions", this._Expressions);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXPRESSIONS:
					return "Expressions";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

