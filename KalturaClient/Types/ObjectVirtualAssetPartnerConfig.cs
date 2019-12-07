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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class ObjectVirtualAssetPartnerConfig : PartnerConfiguration
	{
		#region Constants
		public const string OBJECT_VIRTUAL_ASSETS = "objectVirtualAssets";
		#endregion

		#region Private Fields
		private IList<ObjectVirtualAssetInfo> _ObjectVirtualAssets;
		#endregion

		#region Properties
		[JsonProperty]
		public IList<ObjectVirtualAssetInfo> ObjectVirtualAssets
		{
			get { return _ObjectVirtualAssets; }
			set 
			{ 
				_ObjectVirtualAssets = value;
				OnPropertyChanged("ObjectVirtualAssets");
			}
		}
		#endregion

		#region CTor
		public ObjectVirtualAssetPartnerConfig()
		{
		}

		public ObjectVirtualAssetPartnerConfig(JToken node) : base(node)
		{
			if(node["objectVirtualAssets"] != null)
			{
				this._ObjectVirtualAssets = new List<ObjectVirtualAssetInfo>();
				foreach(var arrayNode in node["objectVirtualAssets"].Children())
				{
					this._ObjectVirtualAssets.Add(ObjectFactory.Create<ObjectVirtualAssetInfo>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaObjectVirtualAssetPartnerConfig");
			kparams.AddIfNotNull("objectVirtualAssets", this._ObjectVirtualAssets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT_VIRTUAL_ASSETS:
					return "ObjectVirtualAssets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

