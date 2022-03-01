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
	public class ProgramAssetGroupOfferFilter : Filter
	{
		#region Constants
		public const string ALSO_INACTIVE = "alsoInactive";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private bool? _AlsoInactive = null;
		private ProgramAssetGroupOfferOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AlsoInactiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AlsoInactive
		{
			get { return _AlsoInactive; }
			set 
			{ 
				_AlsoInactive = value;
				OnPropertyChanged("AlsoInactive");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new ProgramAssetGroupOfferOrderBy OrderBy
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
		public ProgramAssetGroupOfferFilter()
		{
		}

		public ProgramAssetGroupOfferFilter(JToken node) : base(node)
		{
			if(node["alsoInactive"] != null)
			{
				this._AlsoInactive = ParseBool(node["alsoInactive"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (ProgramAssetGroupOfferOrderBy)StringEnum.Parse(typeof(ProgramAssetGroupOfferOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaProgramAssetGroupOfferFilter");
			kparams.AddIfNotNull("alsoInactive", this._AlsoInactive);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ALSO_INACTIVE:
					return "AlsoInactive";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

