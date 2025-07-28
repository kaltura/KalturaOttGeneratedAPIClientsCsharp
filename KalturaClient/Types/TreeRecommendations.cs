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
	public class TreeRecommendations : ObjectBase
	{
		#region Constants
		public const string TITLE = "title";
		public const string ASSETS = "assets";
		#endregion

		#region Private Fields
		private string _Title = null;
		private IList<Asset> _Assets;
		#endregion

		#region Properties
		/// <summary>
		/// Use TitleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		/// <summary>
		/// Use AssetsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<Asset> Assets
		{
			get { return _Assets; }
			set 
			{ 
				_Assets = value;
				OnPropertyChanged("Assets");
			}
		}
		#endregion

		#region CTor
		public TreeRecommendations()
		{
		}

		public TreeRecommendations(JToken node) : base(node)
		{
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
			if(node["assets"] != null)
			{
				this._Assets = new List<Asset>();
				foreach(var arrayNode in node["assets"].Children())
				{
					this._Assets.Add(ObjectFactory.Create<Asset>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTreeRecommendations");
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("assets", this._Assets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TITLE:
					return "Title";
				case ASSETS:
					return "Assets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

