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
	public class LiveAsset : MediaAsset
	{
		#region Constants
		public const string ENABLE_CDVR_STATE = "enableCdvrState";
		public const string ENABLE_CATCH_UP_STATE = "enableCatchUpState";
		public const string ENABLE_START_OVER_STATE = "enableStartOverState";
		public const string BUFFER_CATCH_UP_SETTING = "bufferCatchUpSetting";
		public const string PADDING_BEFORE_PROGRAM_STARTS = "paddingBeforeProgramStarts";
		public const string PADDING_AFTER_PROGRAM_ENDS = "paddingAfterProgramEnds";
		public const string BUFFER_TRICK_PLAY_SETTING = "bufferTrickPlaySetting";
		public const string ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL_STATE = "enableRecordingPlaybackNonEntitledChannelState";
		public const string ENABLE_TRICK_PLAY_STATE = "enableTrickPlayState";
		public const string EXTERNAL_EPG_INGEST_ID = "externalEpgIngestId";
		public const string EXTERNAL_CDVR_ID = "externalCdvrId";
		public const string ENABLE_CDVR = "enableCdvr";
		public const string ENABLE_CATCH_UP = "enableCatchUp";
		public const string ENABLE_START_OVER = "enableStartOver";
		public const string CATCH_UP_BUFFER = "catchUpBuffer";
		public const string TRICK_PLAY_BUFFER = "trickPlayBuffer";
		public const string ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL = "enableRecordingPlaybackNonEntitledChannel";
		public const string ENABLE_TRICK_PLAY = "enableTrickPlay";
		public const string CHANNEL_TYPE = "channelType";
		#endregion

		#region Private Fields
		private TimeShiftedTvState _EnableCdvrState = null;
		private TimeShiftedTvState _EnableCatchUpState = null;
		private TimeShiftedTvState _EnableStartOverState = null;
		private long _BufferCatchUpSetting = long.MinValue;
		private long _PaddingBeforeProgramStarts = long.MinValue;
		private long _PaddingAfterProgramEnds = long.MinValue;
		private long _BufferTrickPlaySetting = long.MinValue;
		private TimeShiftedTvState _EnableRecordingPlaybackNonEntitledChannelState = null;
		private TimeShiftedTvState _EnableTrickPlayState = null;
		private string _ExternalEpgIngestId = null;
		private string _ExternalCdvrId = null;
		private bool? _EnableCdvr = null;
		private bool? _EnableCatchUp = null;
		private bool? _EnableStartOver = null;
		private long _CatchUpBuffer = long.MinValue;
		private long _TrickPlayBuffer = long.MinValue;
		private bool? _EnableRecordingPlaybackNonEntitledChannel = null;
		private bool? _EnableTrickPlay = null;
		private LinearChannelType _ChannelType = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EnableCdvrStateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TimeShiftedTvState EnableCdvrState
		{
			get { return _EnableCdvrState; }
			set 
			{ 
				_EnableCdvrState = value;
				OnPropertyChanged("EnableCdvrState");
			}
		}
		/// <summary>
		/// Use EnableCatchUpStateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TimeShiftedTvState EnableCatchUpState
		{
			get { return _EnableCatchUpState; }
			set 
			{ 
				_EnableCatchUpState = value;
				OnPropertyChanged("EnableCatchUpState");
			}
		}
		/// <summary>
		/// Use EnableStartOverStateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TimeShiftedTvState EnableStartOverState
		{
			get { return _EnableStartOverState; }
			set 
			{ 
				_EnableStartOverState = value;
				OnPropertyChanged("EnableStartOverState");
			}
		}
		/// <summary>
		/// Use BufferCatchUpSettingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long BufferCatchUpSetting
		{
			get { return _BufferCatchUpSetting; }
			set 
			{ 
				_BufferCatchUpSetting = value;
				OnPropertyChanged("BufferCatchUpSetting");
			}
		}
		/// <summary>
		/// Use PaddingBeforeProgramStartsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PaddingBeforeProgramStarts
		{
			get { return _PaddingBeforeProgramStarts; }
			set 
			{ 
				_PaddingBeforeProgramStarts = value;
				OnPropertyChanged("PaddingBeforeProgramStarts");
			}
		}
		/// <summary>
		/// Use PaddingAfterProgramEndsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long PaddingAfterProgramEnds
		{
			get { return _PaddingAfterProgramEnds; }
			set 
			{ 
				_PaddingAfterProgramEnds = value;
				OnPropertyChanged("PaddingAfterProgramEnds");
			}
		}
		/// <summary>
		/// Use BufferTrickPlaySettingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long BufferTrickPlaySetting
		{
			get { return _BufferTrickPlaySetting; }
			set 
			{ 
				_BufferTrickPlaySetting = value;
				OnPropertyChanged("BufferTrickPlaySetting");
			}
		}
		/// <summary>
		/// Use EnableRecordingPlaybackNonEntitledChannelStateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TimeShiftedTvState EnableRecordingPlaybackNonEntitledChannelState
		{
			get { return _EnableRecordingPlaybackNonEntitledChannelState; }
			set 
			{ 
				_EnableRecordingPlaybackNonEntitledChannelState = value;
				OnPropertyChanged("EnableRecordingPlaybackNonEntitledChannelState");
			}
		}
		/// <summary>
		/// Use EnableTrickPlayStateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TimeShiftedTvState EnableTrickPlayState
		{
			get { return _EnableTrickPlayState; }
			set 
			{ 
				_EnableTrickPlayState = value;
				OnPropertyChanged("EnableTrickPlayState");
			}
		}
		/// <summary>
		/// Use ExternalEpgIngestIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalEpgIngestId
		{
			get { return _ExternalEpgIngestId; }
			set 
			{ 
				_ExternalEpgIngestId = value;
				OnPropertyChanged("ExternalEpgIngestId");
			}
		}
		/// <summary>
		/// Use ExternalCdvrIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalCdvrId
		{
			get { return _ExternalCdvrId; }
			set 
			{ 
				_ExternalCdvrId = value;
				OnPropertyChanged("ExternalCdvrId");
			}
		}
		/// <summary>
		/// Use EnableCdvrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnableCdvr
		{
			get { return _EnableCdvr; }
			private set 
			{ 
				_EnableCdvr = value;
				OnPropertyChanged("EnableCdvr");
			}
		}
		/// <summary>
		/// Use EnableCatchUpAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnableCatchUp
		{
			get { return _EnableCatchUp; }
			private set 
			{ 
				_EnableCatchUp = value;
				OnPropertyChanged("EnableCatchUp");
			}
		}
		/// <summary>
		/// Use EnableStartOverAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnableStartOver
		{
			get { return _EnableStartOver; }
			private set 
			{ 
				_EnableStartOver = value;
				OnPropertyChanged("EnableStartOver");
			}
		}
		/// <summary>
		/// Use CatchUpBufferAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CatchUpBuffer
		{
			get { return _CatchUpBuffer; }
			private set 
			{ 
				_CatchUpBuffer = value;
				OnPropertyChanged("CatchUpBuffer");
			}
		}
		/// <summary>
		/// Use TrickPlayBufferAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long TrickPlayBuffer
		{
			get { return _TrickPlayBuffer; }
			private set 
			{ 
				_TrickPlayBuffer = value;
				OnPropertyChanged("TrickPlayBuffer");
			}
		}
		/// <summary>
		/// Use EnableRecordingPlaybackNonEntitledChannelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnableRecordingPlaybackNonEntitledChannel
		{
			get { return _EnableRecordingPlaybackNonEntitledChannel; }
			private set 
			{ 
				_EnableRecordingPlaybackNonEntitledChannel = value;
				OnPropertyChanged("EnableRecordingPlaybackNonEntitledChannel");
			}
		}
		/// <summary>
		/// Use EnableTrickPlayAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnableTrickPlay
		{
			get { return _EnableTrickPlay; }
			private set 
			{ 
				_EnableTrickPlay = value;
				OnPropertyChanged("EnableTrickPlay");
			}
		}
		/// <summary>
		/// Use ChannelTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LinearChannelType ChannelType
		{
			get { return _ChannelType; }
			set 
			{ 
				_ChannelType = value;
				OnPropertyChanged("ChannelType");
			}
		}
		#endregion

		#region CTor
		public LiveAsset()
		{
		}

		public LiveAsset(JToken node) : base(node)
		{
			if(node["enableCdvrState"] != null)
			{
				this._EnableCdvrState = (TimeShiftedTvState)StringEnum.Parse(typeof(TimeShiftedTvState), node["enableCdvrState"].Value<string>());
			}
			if(node["enableCatchUpState"] != null)
			{
				this._EnableCatchUpState = (TimeShiftedTvState)StringEnum.Parse(typeof(TimeShiftedTvState), node["enableCatchUpState"].Value<string>());
			}
			if(node["enableStartOverState"] != null)
			{
				this._EnableStartOverState = (TimeShiftedTvState)StringEnum.Parse(typeof(TimeShiftedTvState), node["enableStartOverState"].Value<string>());
			}
			if(node["bufferCatchUpSetting"] != null)
			{
				this._BufferCatchUpSetting = ParseLong(node["bufferCatchUpSetting"].Value<string>());
			}
			if(node["paddingBeforeProgramStarts"] != null)
			{
				this._PaddingBeforeProgramStarts = ParseLong(node["paddingBeforeProgramStarts"].Value<string>());
			}
			if(node["paddingAfterProgramEnds"] != null)
			{
				this._PaddingAfterProgramEnds = ParseLong(node["paddingAfterProgramEnds"].Value<string>());
			}
			if(node["bufferTrickPlaySetting"] != null)
			{
				this._BufferTrickPlaySetting = ParseLong(node["bufferTrickPlaySetting"].Value<string>());
			}
			if(node["enableRecordingPlaybackNonEntitledChannelState"] != null)
			{
				this._EnableRecordingPlaybackNonEntitledChannelState = (TimeShiftedTvState)StringEnum.Parse(typeof(TimeShiftedTvState), node["enableRecordingPlaybackNonEntitledChannelState"].Value<string>());
			}
			if(node["enableTrickPlayState"] != null)
			{
				this._EnableTrickPlayState = (TimeShiftedTvState)StringEnum.Parse(typeof(TimeShiftedTvState), node["enableTrickPlayState"].Value<string>());
			}
			if(node["externalEpgIngestId"] != null)
			{
				this._ExternalEpgIngestId = node["externalEpgIngestId"].Value<string>();
			}
			if(node["externalCdvrId"] != null)
			{
				this._ExternalCdvrId = node["externalCdvrId"].Value<string>();
			}
			if(node["enableCdvr"] != null)
			{
				this._EnableCdvr = ParseBool(node["enableCdvr"].Value<string>());
			}
			if(node["enableCatchUp"] != null)
			{
				this._EnableCatchUp = ParseBool(node["enableCatchUp"].Value<string>());
			}
			if(node["enableStartOver"] != null)
			{
				this._EnableStartOver = ParseBool(node["enableStartOver"].Value<string>());
			}
			if(node["catchUpBuffer"] != null)
			{
				this._CatchUpBuffer = ParseLong(node["catchUpBuffer"].Value<string>());
			}
			if(node["trickPlayBuffer"] != null)
			{
				this._TrickPlayBuffer = ParseLong(node["trickPlayBuffer"].Value<string>());
			}
			if(node["enableRecordingPlaybackNonEntitledChannel"] != null)
			{
				this._EnableRecordingPlaybackNonEntitledChannel = ParseBool(node["enableRecordingPlaybackNonEntitledChannel"].Value<string>());
			}
			if(node["enableTrickPlay"] != null)
			{
				this._EnableTrickPlay = ParseBool(node["enableTrickPlay"].Value<string>());
			}
			if(node["channelType"] != null)
			{
				this._ChannelType = (LinearChannelType)StringEnum.Parse(typeof(LinearChannelType), node["channelType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveAsset");
			kparams.AddIfNotNull("enableCdvrState", this._EnableCdvrState);
			kparams.AddIfNotNull("enableCatchUpState", this._EnableCatchUpState);
			kparams.AddIfNotNull("enableStartOverState", this._EnableStartOverState);
			kparams.AddIfNotNull("bufferCatchUpSetting", this._BufferCatchUpSetting);
			kparams.AddIfNotNull("paddingBeforeProgramStarts", this._PaddingBeforeProgramStarts);
			kparams.AddIfNotNull("paddingAfterProgramEnds", this._PaddingAfterProgramEnds);
			kparams.AddIfNotNull("bufferTrickPlaySetting", this._BufferTrickPlaySetting);
			kparams.AddIfNotNull("enableRecordingPlaybackNonEntitledChannelState", this._EnableRecordingPlaybackNonEntitledChannelState);
			kparams.AddIfNotNull("enableTrickPlayState", this._EnableTrickPlayState);
			kparams.AddIfNotNull("externalEpgIngestId", this._ExternalEpgIngestId);
			kparams.AddIfNotNull("externalCdvrId", this._ExternalCdvrId);
			kparams.AddIfNotNull("enableCdvr", this._EnableCdvr);
			kparams.AddIfNotNull("enableCatchUp", this._EnableCatchUp);
			kparams.AddIfNotNull("enableStartOver", this._EnableStartOver);
			kparams.AddIfNotNull("catchUpBuffer", this._CatchUpBuffer);
			kparams.AddIfNotNull("trickPlayBuffer", this._TrickPlayBuffer);
			kparams.AddIfNotNull("enableRecordingPlaybackNonEntitledChannel", this._EnableRecordingPlaybackNonEntitledChannel);
			kparams.AddIfNotNull("enableTrickPlay", this._EnableTrickPlay);
			kparams.AddIfNotNull("channelType", this._ChannelType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENABLE_CDVR_STATE:
					return "EnableCdvrState";
				case ENABLE_CATCH_UP_STATE:
					return "EnableCatchUpState";
				case ENABLE_START_OVER_STATE:
					return "EnableStartOverState";
				case BUFFER_CATCH_UP_SETTING:
					return "BufferCatchUpSetting";
				case PADDING_BEFORE_PROGRAM_STARTS:
					return "PaddingBeforeProgramStarts";
				case PADDING_AFTER_PROGRAM_ENDS:
					return "PaddingAfterProgramEnds";
				case BUFFER_TRICK_PLAY_SETTING:
					return "BufferTrickPlaySetting";
				case ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL_STATE:
					return "EnableRecordingPlaybackNonEntitledChannelState";
				case ENABLE_TRICK_PLAY_STATE:
					return "EnableTrickPlayState";
				case EXTERNAL_EPG_INGEST_ID:
					return "ExternalEpgIngestId";
				case EXTERNAL_CDVR_ID:
					return "ExternalCdvrId";
				case ENABLE_CDVR:
					return "EnableCdvr";
				case ENABLE_CATCH_UP:
					return "EnableCatchUp";
				case ENABLE_START_OVER:
					return "EnableStartOver";
				case CATCH_UP_BUFFER:
					return "CatchUpBuffer";
				case TRICK_PLAY_BUFFER:
					return "TrickPlayBuffer";
				case ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL:
					return "EnableRecordingPlaybackNonEntitledChannel";
				case ENABLE_TRICK_PLAY:
					return "EnableTrickPlay";
				case CHANNEL_TYPE:
					return "ChannelType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

