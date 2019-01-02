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
	public class IpRangeCondition : Condition
	{
		#region Constants
		public const string FROM_IP = "fromIP";
		public const string TO_IP = "toIP";
		#endregion

		#region Private Fields
		private string _FromIP = null;
		private string _ToIP = null;
		#endregion

		#region Properties
		public string FromIP
		{
			get { return _FromIP; }
			set 
			{ 
				_FromIP = value;
				OnPropertyChanged("FromIP");
			}
		}
		public string ToIP
		{
			get { return _ToIP; }
			set 
			{ 
				_ToIP = value;
				OnPropertyChanged("ToIP");
			}
		}
		#endregion

		#region CTor
		public IpRangeCondition()
		{
		}

		public IpRangeCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fromIP":
						this._FromIP = propertyNode.InnerText;
						continue;
					case "toIP":
						this._ToIP = propertyNode.InnerText;
						continue;
				}
			}
		}

		public IpRangeCondition(IDictionary<string,object> data) : base(data)
		{
			    this._FromIP = data.TryGetValueSafe<string>("fromIP");
			    this._ToIP = data.TryGetValueSafe<string>("toIP");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIpRangeCondition");
			kparams.AddIfNotNull("fromIP", this._FromIP);
			kparams.AddIfNotNull("toIP", this._ToIP);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FROM_IP:
					return "FromIP";
				case TO_IP:
					return "ToIP";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

