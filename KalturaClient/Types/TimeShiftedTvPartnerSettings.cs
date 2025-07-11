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
	public class TimeShiftedTvPartnerSettings : ObjectBase
	{
		#region Constants
		public const string CATCH_UP_ENABLED = "catchUpEnabled";
		public const string CDVR_ENABLED = "cdvrEnabled";
		public const string START_OVER_ENABLED = "startOverEnabled";
		public const string TRICK_PLAY_ENABLED = "trickPlayEnabled";
		public const string RECORDING_SCHEDULE_WINDOW_ENABLED = "recordingScheduleWindowEnabled";
		public const string PROTECTION_ENABLED = "protectionEnabled";
		public const string CATCH_UP_BUFFER_LENGTH = "catchUpBufferLength";
		public const string TRICK_PLAY_BUFFER_LENGTH = "trickPlayBufferLength";
		public const string RECORDING_SCHEDULE_WINDOW = "recordingScheduleWindow";
		public const string PADDING_BEFORE_PROGRAM_STARTS = "paddingBeforeProgramStarts";
		public const string PADDING_AFTER_PROGRAM_ENDS = "paddingAfterProgramEnds";
		public const string PROTECTION_PERIOD = "protectionPeriod";
		public const string PROTECTION_QUOTA_PERCENTAGE = "protectionQuotaPercentage";
		public const string RECORDING_LIFETIME_PERIOD = "recordingLifetimePeriod";
		public const string CLEANUP_NOTICE_PERIOD = "cleanupNoticePeriod";
		public const string SERIES_RECORDING_ENABLED = "seriesRecordingEnabled";
		public const string NON_ENTITLED_CHANNEL_PLAYBACK_ENABLED = "nonEntitledChannelPlaybackEnabled";
		public const string NON_EXISTING_CHANNEL_PLAYBACK_ENABLED = "nonExistingChannelPlaybackEnabled";
		public const string QUOTA_OVERAGE_POLICY = "quotaOveragePolicy";
		public const string PROTECTION_POLICY = "protectionPolicy";
		public const string RECOVERY_GRACE_PERIOD = "recoveryGracePeriod";
		public const string PRIVATE_COPY_ENABLED = "privateCopyEnabled";
		public const string DEFAULT_QUOTA = "defaultQuota";
		public const string PERSONALIZED_RECORDING = "personalizedRecording";
		public const string MAX_RECORDING_CONCURRENCY = "maxRecordingConcurrency";
		public const string MAX_CONCURRENCY_MARGIN = "maxConcurrencyMargin";
		public const string SHOULD_ROUND_STOP_RECORDINGS_BY_SECONDS = "shouldRoundStopRecordingsBySeconds";
		#endregion

		#region Private Fields
		private bool? _CatchUpEnabled = null;
		private bool? _CdvrEnabled = null;
		private bool? _StartOverEnabled = null;
		private bool? _TrickPlayEnabled = null;
		private bool? _RecordingScheduleWindowEnabled = null;
		private bool? _ProtectionEnabled = null;
		private long _CatchUpBufferLength = long.MinValue;
		private long _TrickPlayBufferLength = long.MinValue;
		private long _RecordingScheduleWindow = long.MinValue;
		private long _PaddingBeforeProgramStarts = long.MinValue;
		private long _PaddingAfterProgramEnds = long.MinValue;
		private int _ProtectionPeriod = Int32.MinValue;
		private int _ProtectionQuotaPercentage = Int32.MinValue;
		private int _RecordingLifetimePeriod = Int32.MinValue;
		private int _CleanupNoticePeriod = Int32.MinValue;
		private bool? _SeriesRecordingEnabled = null;
		private bool? _NonEntitledChannelPlaybackEnabled = null;
		private bool? _NonExistingChannelPlaybackEnabled = null;
		private QuotaOveragePolicy _QuotaOveragePolicy = null;
		private ProtectionPolicy _ProtectionPolicy = null;
		private int _RecoveryGracePeriod = Int32.MinValue;
		private bool? _PrivateCopyEnabled = null;
		private int _DefaultQuota = Int32.MinValue;
		private bool? _PersonalizedRecording = null;
		private int _MaxRecordingConcurrency = Int32.MinValue;
		private int _MaxConcurrencyMargin = Int32.MinValue;
		private bool? _ShouldRoundStopRecordingsBySeconds = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use CatchUpEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? CatchUpEnabled
		{
			get { return _CatchUpEnabled; }
			set 
			{ 
				_CatchUpEnabled = value;
				OnPropertyChanged("CatchUpEnabled");
			}
		}
		/// <summary>
		/// Use CdvrEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? CdvrEnabled
		{
			get { return _CdvrEnabled; }
			set 
			{ 
				_CdvrEnabled = value;
				OnPropertyChanged("CdvrEnabled");
			}
		}
		/// <summary>
		/// Use StartOverEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? StartOverEnabled
		{
			get { return _StartOverEnabled; }
			set 
			{ 
				_StartOverEnabled = value;
				OnPropertyChanged("StartOverEnabled");
			}
		}
		/// <summary>
		/// Use TrickPlayEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? TrickPlayEnabled
		{
			get { return _TrickPlayEnabled; }
			set 
			{ 
				_TrickPlayEnabled = value;
				OnPropertyChanged("TrickPlayEnabled");
			}
		}
		/// <summary>
		/// Use RecordingScheduleWindowEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? RecordingScheduleWindowEnabled
		{
			get { return _RecordingScheduleWindowEnabled; }
			set 
			{ 
				_RecordingScheduleWindowEnabled = value;
				OnPropertyChanged("RecordingScheduleWindowEnabled");
			}
		}
		/// <summary>
		/// Use ProtectionEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ProtectionEnabled
		{
			get { return _ProtectionEnabled; }
			set 
			{ 
				_ProtectionEnabled = value;
				OnPropertyChanged("ProtectionEnabled");
			}
		}
		/// <summary>
		/// Use CatchUpBufferLengthAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CatchUpBufferLength
		{
			get { return _CatchUpBufferLength; }
			set 
			{ 
				_CatchUpBufferLength = value;
				OnPropertyChanged("CatchUpBufferLength");
			}
		}
		/// <summary>
		/// Use TrickPlayBufferLengthAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long TrickPlayBufferLength
		{
			get { return _TrickPlayBufferLength; }
			set 
			{ 
				_TrickPlayBufferLength = value;
				OnPropertyChanged("TrickPlayBufferLength");
			}
		}
		/// <summary>
		/// Use RecordingScheduleWindowAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long RecordingScheduleWindow
		{
			get { return _RecordingScheduleWindow; }
			set 
			{ 
				_RecordingScheduleWindow = value;
				OnPropertyChanged("RecordingScheduleWindow");
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
		/// Use ProtectionPeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ProtectionPeriod
		{
			get { return _ProtectionPeriod; }
			set 
			{ 
				_ProtectionPeriod = value;
				OnPropertyChanged("ProtectionPeriod");
			}
		}
		/// <summary>
		/// Use ProtectionQuotaPercentageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ProtectionQuotaPercentage
		{
			get { return _ProtectionQuotaPercentage; }
			set 
			{ 
				_ProtectionQuotaPercentage = value;
				OnPropertyChanged("ProtectionQuotaPercentage");
			}
		}
		/// <summary>
		/// Use RecordingLifetimePeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RecordingLifetimePeriod
		{
			get { return _RecordingLifetimePeriod; }
			set 
			{ 
				_RecordingLifetimePeriod = value;
				OnPropertyChanged("RecordingLifetimePeriod");
			}
		}
		/// <summary>
		/// Use CleanupNoticePeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CleanupNoticePeriod
		{
			get { return _CleanupNoticePeriod; }
			set 
			{ 
				_CleanupNoticePeriod = value;
				OnPropertyChanged("CleanupNoticePeriod");
			}
		}
		/// <summary>
		/// Use SeriesRecordingEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? SeriesRecordingEnabled
		{
			get { return _SeriesRecordingEnabled; }
			set 
			{ 
				_SeriesRecordingEnabled = value;
				OnPropertyChanged("SeriesRecordingEnabled");
			}
		}
		/// <summary>
		/// Use NonEntitledChannelPlaybackEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? NonEntitledChannelPlaybackEnabled
		{
			get { return _NonEntitledChannelPlaybackEnabled; }
			set 
			{ 
				_NonEntitledChannelPlaybackEnabled = value;
				OnPropertyChanged("NonEntitledChannelPlaybackEnabled");
			}
		}
		/// <summary>
		/// Use NonExistingChannelPlaybackEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? NonExistingChannelPlaybackEnabled
		{
			get { return _NonExistingChannelPlaybackEnabled; }
			set 
			{ 
				_NonExistingChannelPlaybackEnabled = value;
				OnPropertyChanged("NonExistingChannelPlaybackEnabled");
			}
		}
		/// <summary>
		/// Use QuotaOveragePolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public QuotaOveragePolicy QuotaOveragePolicy
		{
			get { return _QuotaOveragePolicy; }
			set 
			{ 
				_QuotaOveragePolicy = value;
				OnPropertyChanged("QuotaOveragePolicy");
			}
		}
		/// <summary>
		/// Use ProtectionPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ProtectionPolicy ProtectionPolicy
		{
			get { return _ProtectionPolicy; }
			set 
			{ 
				_ProtectionPolicy = value;
				OnPropertyChanged("ProtectionPolicy");
			}
		}
		/// <summary>
		/// Use RecoveryGracePeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RecoveryGracePeriod
		{
			get { return _RecoveryGracePeriod; }
			set 
			{ 
				_RecoveryGracePeriod = value;
				OnPropertyChanged("RecoveryGracePeriod");
			}
		}
		/// <summary>
		/// Use PrivateCopyEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? PrivateCopyEnabled
		{
			get { return _PrivateCopyEnabled; }
			set 
			{ 
				_PrivateCopyEnabled = value;
				OnPropertyChanged("PrivateCopyEnabled");
			}
		}
		/// <summary>
		/// Use DefaultQuotaAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DefaultQuota
		{
			get { return _DefaultQuota; }
			set 
			{ 
				_DefaultQuota = value;
				OnPropertyChanged("DefaultQuota");
			}
		}
		/// <summary>
		/// Use PersonalizedRecordingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? PersonalizedRecording
		{
			get { return _PersonalizedRecording; }
			set 
			{ 
				_PersonalizedRecording = value;
				OnPropertyChanged("PersonalizedRecording");
			}
		}
		/// <summary>
		/// Use MaxRecordingConcurrencyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxRecordingConcurrency
		{
			get { return _MaxRecordingConcurrency; }
			set 
			{ 
				_MaxRecordingConcurrency = value;
				OnPropertyChanged("MaxRecordingConcurrency");
			}
		}
		/// <summary>
		/// Use MaxConcurrencyMarginAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxConcurrencyMargin
		{
			get { return _MaxConcurrencyMargin; }
			set 
			{ 
				_MaxConcurrencyMargin = value;
				OnPropertyChanged("MaxConcurrencyMargin");
			}
		}
		/// <summary>
		/// Use ShouldRoundStopRecordingsBySecondsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ShouldRoundStopRecordingsBySeconds
		{
			get { return _ShouldRoundStopRecordingsBySeconds; }
			set 
			{ 
				_ShouldRoundStopRecordingsBySeconds = value;
				OnPropertyChanged("ShouldRoundStopRecordingsBySeconds");
			}
		}
		#endregion

		#region CTor
		public TimeShiftedTvPartnerSettings()
		{
		}

		public TimeShiftedTvPartnerSettings(JToken node) : base(node)
		{
			if(node["catchUpEnabled"] != null)
			{
				this._CatchUpEnabled = ParseBool(node["catchUpEnabled"].Value<string>());
			}
			if(node["cdvrEnabled"] != null)
			{
				this._CdvrEnabled = ParseBool(node["cdvrEnabled"].Value<string>());
			}
			if(node["startOverEnabled"] != null)
			{
				this._StartOverEnabled = ParseBool(node["startOverEnabled"].Value<string>());
			}
			if(node["trickPlayEnabled"] != null)
			{
				this._TrickPlayEnabled = ParseBool(node["trickPlayEnabled"].Value<string>());
			}
			if(node["recordingScheduleWindowEnabled"] != null)
			{
				this._RecordingScheduleWindowEnabled = ParseBool(node["recordingScheduleWindowEnabled"].Value<string>());
			}
			if(node["protectionEnabled"] != null)
			{
				this._ProtectionEnabled = ParseBool(node["protectionEnabled"].Value<string>());
			}
			if(node["catchUpBufferLength"] != null)
			{
				this._CatchUpBufferLength = ParseLong(node["catchUpBufferLength"].Value<string>());
			}
			if(node["trickPlayBufferLength"] != null)
			{
				this._TrickPlayBufferLength = ParseLong(node["trickPlayBufferLength"].Value<string>());
			}
			if(node["recordingScheduleWindow"] != null)
			{
				this._RecordingScheduleWindow = ParseLong(node["recordingScheduleWindow"].Value<string>());
			}
			if(node["paddingBeforeProgramStarts"] != null)
			{
				this._PaddingBeforeProgramStarts = ParseLong(node["paddingBeforeProgramStarts"].Value<string>());
			}
			if(node["paddingAfterProgramEnds"] != null)
			{
				this._PaddingAfterProgramEnds = ParseLong(node["paddingAfterProgramEnds"].Value<string>());
			}
			if(node["protectionPeriod"] != null)
			{
				this._ProtectionPeriod = ParseInt(node["protectionPeriod"].Value<string>());
			}
			if(node["protectionQuotaPercentage"] != null)
			{
				this._ProtectionQuotaPercentage = ParseInt(node["protectionQuotaPercentage"].Value<string>());
			}
			if(node["recordingLifetimePeriod"] != null)
			{
				this._RecordingLifetimePeriod = ParseInt(node["recordingLifetimePeriod"].Value<string>());
			}
			if(node["cleanupNoticePeriod"] != null)
			{
				this._CleanupNoticePeriod = ParseInt(node["cleanupNoticePeriod"].Value<string>());
			}
			if(node["seriesRecordingEnabled"] != null)
			{
				this._SeriesRecordingEnabled = ParseBool(node["seriesRecordingEnabled"].Value<string>());
			}
			if(node["nonEntitledChannelPlaybackEnabled"] != null)
			{
				this._NonEntitledChannelPlaybackEnabled = ParseBool(node["nonEntitledChannelPlaybackEnabled"].Value<string>());
			}
			if(node["nonExistingChannelPlaybackEnabled"] != null)
			{
				this._NonExistingChannelPlaybackEnabled = ParseBool(node["nonExistingChannelPlaybackEnabled"].Value<string>());
			}
			if(node["quotaOveragePolicy"] != null)
			{
				this._QuotaOveragePolicy = (QuotaOveragePolicy)StringEnum.Parse(typeof(QuotaOveragePolicy), node["quotaOveragePolicy"].Value<string>());
			}
			if(node["protectionPolicy"] != null)
			{
				this._ProtectionPolicy = (ProtectionPolicy)StringEnum.Parse(typeof(ProtectionPolicy), node["protectionPolicy"].Value<string>());
			}
			if(node["recoveryGracePeriod"] != null)
			{
				this._RecoveryGracePeriod = ParseInt(node["recoveryGracePeriod"].Value<string>());
			}
			if(node["privateCopyEnabled"] != null)
			{
				this._PrivateCopyEnabled = ParseBool(node["privateCopyEnabled"].Value<string>());
			}
			if(node["defaultQuota"] != null)
			{
				this._DefaultQuota = ParseInt(node["defaultQuota"].Value<string>());
			}
			if(node["personalizedRecording"] != null)
			{
				this._PersonalizedRecording = ParseBool(node["personalizedRecording"].Value<string>());
			}
			if(node["maxRecordingConcurrency"] != null)
			{
				this._MaxRecordingConcurrency = ParseInt(node["maxRecordingConcurrency"].Value<string>());
			}
			if(node["maxConcurrencyMargin"] != null)
			{
				this._MaxConcurrencyMargin = ParseInt(node["maxConcurrencyMargin"].Value<string>());
			}
			if(node["shouldRoundStopRecordingsBySeconds"] != null)
			{
				this._ShouldRoundStopRecordingsBySeconds = ParseBool(node["shouldRoundStopRecordingsBySeconds"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTimeShiftedTvPartnerSettings");
			kparams.AddIfNotNull("catchUpEnabled", this._CatchUpEnabled);
			kparams.AddIfNotNull("cdvrEnabled", this._CdvrEnabled);
			kparams.AddIfNotNull("startOverEnabled", this._StartOverEnabled);
			kparams.AddIfNotNull("trickPlayEnabled", this._TrickPlayEnabled);
			kparams.AddIfNotNull("recordingScheduleWindowEnabled", this._RecordingScheduleWindowEnabled);
			kparams.AddIfNotNull("protectionEnabled", this._ProtectionEnabled);
			kparams.AddIfNotNull("catchUpBufferLength", this._CatchUpBufferLength);
			kparams.AddIfNotNull("trickPlayBufferLength", this._TrickPlayBufferLength);
			kparams.AddIfNotNull("recordingScheduleWindow", this._RecordingScheduleWindow);
			kparams.AddIfNotNull("paddingBeforeProgramStarts", this._PaddingBeforeProgramStarts);
			kparams.AddIfNotNull("paddingAfterProgramEnds", this._PaddingAfterProgramEnds);
			kparams.AddIfNotNull("protectionPeriod", this._ProtectionPeriod);
			kparams.AddIfNotNull("protectionQuotaPercentage", this._ProtectionQuotaPercentage);
			kparams.AddIfNotNull("recordingLifetimePeriod", this._RecordingLifetimePeriod);
			kparams.AddIfNotNull("cleanupNoticePeriod", this._CleanupNoticePeriod);
			kparams.AddIfNotNull("seriesRecordingEnabled", this._SeriesRecordingEnabled);
			kparams.AddIfNotNull("nonEntitledChannelPlaybackEnabled", this._NonEntitledChannelPlaybackEnabled);
			kparams.AddIfNotNull("nonExistingChannelPlaybackEnabled", this._NonExistingChannelPlaybackEnabled);
			kparams.AddIfNotNull("quotaOveragePolicy", this._QuotaOveragePolicy);
			kparams.AddIfNotNull("protectionPolicy", this._ProtectionPolicy);
			kparams.AddIfNotNull("recoveryGracePeriod", this._RecoveryGracePeriod);
			kparams.AddIfNotNull("privateCopyEnabled", this._PrivateCopyEnabled);
			kparams.AddIfNotNull("defaultQuota", this._DefaultQuota);
			kparams.AddIfNotNull("personalizedRecording", this._PersonalizedRecording);
			kparams.AddIfNotNull("maxRecordingConcurrency", this._MaxRecordingConcurrency);
			kparams.AddIfNotNull("maxConcurrencyMargin", this._MaxConcurrencyMargin);
			kparams.AddIfNotNull("shouldRoundStopRecordingsBySeconds", this._ShouldRoundStopRecordingsBySeconds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATCH_UP_ENABLED:
					return "CatchUpEnabled";
				case CDVR_ENABLED:
					return "CdvrEnabled";
				case START_OVER_ENABLED:
					return "StartOverEnabled";
				case TRICK_PLAY_ENABLED:
					return "TrickPlayEnabled";
				case RECORDING_SCHEDULE_WINDOW_ENABLED:
					return "RecordingScheduleWindowEnabled";
				case PROTECTION_ENABLED:
					return "ProtectionEnabled";
				case CATCH_UP_BUFFER_LENGTH:
					return "CatchUpBufferLength";
				case TRICK_PLAY_BUFFER_LENGTH:
					return "TrickPlayBufferLength";
				case RECORDING_SCHEDULE_WINDOW:
					return "RecordingScheduleWindow";
				case PADDING_BEFORE_PROGRAM_STARTS:
					return "PaddingBeforeProgramStarts";
				case PADDING_AFTER_PROGRAM_ENDS:
					return "PaddingAfterProgramEnds";
				case PROTECTION_PERIOD:
					return "ProtectionPeriod";
				case PROTECTION_QUOTA_PERCENTAGE:
					return "ProtectionQuotaPercentage";
				case RECORDING_LIFETIME_PERIOD:
					return "RecordingLifetimePeriod";
				case CLEANUP_NOTICE_PERIOD:
					return "CleanupNoticePeriod";
				case SERIES_RECORDING_ENABLED:
					return "SeriesRecordingEnabled";
				case NON_ENTITLED_CHANNEL_PLAYBACK_ENABLED:
					return "NonEntitledChannelPlaybackEnabled";
				case NON_EXISTING_CHANNEL_PLAYBACK_ENABLED:
					return "NonExistingChannelPlaybackEnabled";
				case QUOTA_OVERAGE_POLICY:
					return "QuotaOveragePolicy";
				case PROTECTION_POLICY:
					return "ProtectionPolicy";
				case RECOVERY_GRACE_PERIOD:
					return "RecoveryGracePeriod";
				case PRIVATE_COPY_ENABLED:
					return "PrivateCopyEnabled";
				case DEFAULT_QUOTA:
					return "DefaultQuota";
				case PERSONALIZED_RECORDING:
					return "PersonalizedRecording";
				case MAX_RECORDING_CONCURRENCY:
					return "MaxRecordingConcurrency";
				case MAX_CONCURRENCY_MARGIN:
					return "MaxConcurrencyMargin";
				case SHOULD_ROUND_STOP_RECORDINGS_BY_SECONDS:
					return "ShouldRoundStopRecordingsBySeconds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

