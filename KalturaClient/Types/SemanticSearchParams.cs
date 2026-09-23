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
	public class SemanticSearchParams : ObjectBase
	{
		#region Constants
		public const string QUERY = "query";
		public const string REFINE_QUERY = "refineQuery";
		public const string SIZE = "size";
		public const string PROGRAM_PARAMS = "programParams";
		public const string MEDIA_PARAMS = "mediaParams";
		#endregion

		#region Private Fields
		private string _Query = null;
		private bool? _RefineQuery = null;
		private int _Size = Int32.MinValue;
		private ProgramSemanticSearchParams _ProgramParams;
		private MediaSemanticSearchParams _MediaParams;
		#endregion

		#region Properties
		/// <summary>
		/// Use QueryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Query
		{
			get { return _Query; }
			set 
			{ 
				_Query = value;
				OnPropertyChanged("Query");
			}
		}
		/// <summary>
		/// Use RefineQueryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? RefineQuery
		{
			get { return _RefineQuery; }
			set 
			{ 
				_RefineQuery = value;
				OnPropertyChanged("RefineQuery");
			}
		}
		/// <summary>
		/// Use SizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Size
		{
			get { return _Size; }
			set 
			{ 
				_Size = value;
				OnPropertyChanged("Size");
			}
		}
		/// <summary>
		/// Use ProgramParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ProgramSemanticSearchParams ProgramParams
		{
			get { return _ProgramParams; }
			set 
			{ 
				_ProgramParams = value;
				OnPropertyChanged("ProgramParams");
			}
		}
		/// <summary>
		/// Use MediaParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MediaSemanticSearchParams MediaParams
		{
			get { return _MediaParams; }
			set 
			{ 
				_MediaParams = value;
				OnPropertyChanged("MediaParams");
			}
		}
		#endregion

		#region CTor
		public SemanticSearchParams()
		{
		}

		public SemanticSearchParams(JToken node) : base(node)
		{
			if(node["query"] != null)
			{
				this._Query = node["query"].Value<string>();
			}
			if(node["refineQuery"] != null)
			{
				this._RefineQuery = ParseBool(node["refineQuery"].Value<string>());
			}
			if(node["size"] != null)
			{
				this._Size = ParseInt(node["size"].Value<string>());
			}
			if(node["programParams"] != null)
			{
				this._ProgramParams = ObjectFactory.Create<ProgramSemanticSearchParams>(node["programParams"]);
			}
			if(node["mediaParams"] != null)
			{
				this._MediaParams = ObjectFactory.Create<MediaSemanticSearchParams>(node["mediaParams"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSemanticSearchParams");
			kparams.AddIfNotNull("query", this._Query);
			kparams.AddIfNotNull("refineQuery", this._RefineQuery);
			kparams.AddIfNotNull("size", this._Size);
			kparams.AddIfNotNull("programParams", this._ProgramParams);
			kparams.AddIfNotNull("mediaParams", this._MediaParams);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case QUERY:
					return "Query";
				case REFINE_QUERY:
					return "RefineQuery";
				case SIZE:
					return "Size";
				case PROGRAM_PARAMS:
					return "ProgramParams";
				case MEDIA_PARAMS:
					return "MediaParams";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

