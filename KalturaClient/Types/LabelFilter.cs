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
	public class LabelFilter : Filter
	{
		#region Constants
		public const string ID_IN = "idIn";
		public const string LABEL_EQUAL = "labelEqual";
		public const string LABEL_STARTS_WITH = "labelStartsWith";
		public const string ENTITY_ATTRIBUTE_EQUAL = "entityAttributeEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _IdIn = null;
		private string _LabelEqual = null;
		private string _LabelStartsWith = null;
		private EntityAttribute _EntityAttributeEqual = null;
		private LabelOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		/// <summary>
		/// Use LabelEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LabelEqual
		{
			get { return _LabelEqual; }
			set 
			{ 
				_LabelEqual = value;
				OnPropertyChanged("LabelEqual");
			}
		}
		/// <summary>
		/// Use LabelStartsWithAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LabelStartsWith
		{
			get { return _LabelStartsWith; }
			set 
			{ 
				_LabelStartsWith = value;
				OnPropertyChanged("LabelStartsWith");
			}
		}
		/// <summary>
		/// Use EntityAttributeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntityAttribute EntityAttributeEqual
		{
			get { return _EntityAttributeEqual; }
			set 
			{ 
				_EntityAttributeEqual = value;
				OnPropertyChanged("EntityAttributeEqual");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new LabelOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public LabelFilter()
		{
		}

		public LabelFilter(JToken node) : base(node)
		{
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["labelEqual"] != null)
			{
				this._LabelEqual = node["labelEqual"].Value<string>();
			}
			if(node["labelStartsWith"] != null)
			{
				this._LabelStartsWith = node["labelStartsWith"].Value<string>();
			}
			if(node["entityAttributeEqual"] != null)
			{
				this._EntityAttributeEqual = (EntityAttribute)StringEnum.Parse(typeof(EntityAttribute), node["entityAttributeEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (LabelOrderBy)StringEnum.Parse(typeof(LabelOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLabelFilter");
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("labelEqual", this._LabelEqual);
			kparams.AddIfNotNull("labelStartsWith", this._LabelStartsWith);
			kparams.AddIfNotNull("entityAttributeEqual", this._EntityAttributeEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_IN:
					return "IdIn";
				case LABEL_EQUAL:
					return "LabelEqual";
				case LABEL_STARTS_WITH:
					return "LabelStartsWith";
				case ENTITY_ATTRIBUTE_EQUAL:
					return "EntityAttributeEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

