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
	public class ManualChannel : Channel
	{
		#region Constants
		public const string MEDIA_IDS = "mediaIds";
		public const string ASSETS = "assets";
		#endregion

		#region Private Fields
		private string _MediaIds = null;
		private IList<ManualCollectionAsset> _Assets;
		#endregion

		#region Properties
		/// <summary>
		/// Use MediaIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaIds
		{
			get { return _MediaIds; }
			set 
			{ 
				_MediaIds = value;
				OnPropertyChanged("MediaIds");
			}
		}
		/// <summary>
		/// Use AssetsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ManualCollectionAsset> Assets
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
		public ManualChannel()
		{
		}

		public ManualChannel(JToken node) : base(node)
		{
			if(node["mediaIds"] != null)
			{
				this._MediaIds = node["mediaIds"].Value<string>();
			}
			if(node["assets"] != null)
			{
				this._Assets = new List<ManualCollectionAsset>();
				foreach(var arrayNode in node["assets"].Children())
				{
					this._Assets.Add(ObjectFactory.Create<ManualCollectionAsset>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaManualChannel");
			kparams.AddIfNotNull("mediaIds", this._MediaIds);
			kparams.AddIfNotNull("assets", this._Assets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MEDIA_IDS:
					return "MediaIds";
				case ASSETS:
					return "Assets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

