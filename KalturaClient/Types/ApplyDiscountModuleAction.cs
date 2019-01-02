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
	public class ApplyDiscountModuleAction : RuleAction
	{
		#region Constants
		public const string DISCOUNT_MODULE_ID = "discountModuleId";
		#endregion

		#region Private Fields
		private long _DiscountModuleId = long.MinValue;
		#endregion

		#region Properties
		public long DiscountModuleId
		{
			get { return _DiscountModuleId; }
			set 
			{ 
				_DiscountModuleId = value;
				OnPropertyChanged("DiscountModuleId");
			}
		}
		#endregion

		#region CTor
		public ApplyDiscountModuleAction()
		{
		}

		public ApplyDiscountModuleAction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "discountModuleId":
						this._DiscountModuleId = ParseLong(propertyNode.InnerText);
						continue;
				}
			}
		}

		public ApplyDiscountModuleAction(IDictionary<string,object> data) : base(data)
		{
			    this._DiscountModuleId = data.TryGetValueSafe<long>("discountModuleId");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaApplyDiscountModuleAction");
			kparams.AddIfNotNull("discountModuleId", this._DiscountModuleId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DISCOUNT_MODULE_ID:
					return "DiscountModuleId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

