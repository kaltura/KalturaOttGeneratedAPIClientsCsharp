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
namespace Kaltura.Enums
{
	public sealed class SeriesRecordingOrderBy : StringEnum
	{
		public static readonly SeriesRecordingOrderBy START_DATE_ASC = new SeriesRecordingOrderBy("START_DATE_ASC");
		public static readonly SeriesRecordingOrderBy START_DATE_DESC = new SeriesRecordingOrderBy("START_DATE_DESC");
		public static readonly SeriesRecordingOrderBy ID_ASC = new SeriesRecordingOrderBy("ID_ASC");
		public static readonly SeriesRecordingOrderBy ID_DESC = new SeriesRecordingOrderBy("ID_DESC");
		public static readonly SeriesRecordingOrderBy SERIES_ID_ASC = new SeriesRecordingOrderBy("SERIES_ID_ASC");
		public static readonly SeriesRecordingOrderBy SERIES_ID_DESC = new SeriesRecordingOrderBy("SERIES_ID_DESC");

		private SeriesRecordingOrderBy(string name) : base(name) { }
	}
}
