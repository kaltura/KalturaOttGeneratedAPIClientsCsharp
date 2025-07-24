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
	public class BulkPlaybackContextRequest : ObjectBase
	{
		#region Constants
		public const string PLAYBACK_CONTEXT_PARAM_SETS = "playbackContextParamSets";
		#endregion

		#region Private Fields
		private IList<GetPlaybackContextParams> _PlaybackContextParamSets;
		#endregion

		#region Properties
		/// <summary>
		/// Use PlaybackContextParamSetsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<GetPlaybackContextParams> PlaybackContextParamSets
		{
			get { return _PlaybackContextParamSets; }
			set 
			{ 
				_PlaybackContextParamSets = value;
				OnPropertyChanged("PlaybackContextParamSets");
			}
		}
		#endregion

		#region CTor
		public BulkPlaybackContextRequest()
		{
		}

		public BulkPlaybackContextRequest(JToken node) : base(node)
		{
			if(node["playbackContextParamSets"] != null)
			{
				this._PlaybackContextParamSets = new List<GetPlaybackContextParams>();
				foreach(var arrayNode in node["playbackContextParamSets"].Children())
				{
					this._PlaybackContextParamSets.Add(ObjectFactory.Create<GetPlaybackContextParams>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkPlaybackContextRequest");
			kparams.AddIfNotNull("playbackContextParamSets", this._PlaybackContextParamSets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PLAYBACK_CONTEXT_PARAM_SETS:
					return "PlaybackContextParamSets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

