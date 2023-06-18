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
	public sealed class LineupRegionalChannelOrderBy : StringEnum
	{
		public static readonly LineupRegionalChannelOrderBy LCN_ASC = new LineupRegionalChannelOrderBy("LCN_ASC");
		public static readonly LineupRegionalChannelOrderBy LCN_DESC = new LineupRegionalChannelOrderBy("LCN_DESC");
		public static readonly LineupRegionalChannelOrderBy NAME_ASC = new LineupRegionalChannelOrderBy("NAME_ASC");
		public static readonly LineupRegionalChannelOrderBy NAME_DESC = new LineupRegionalChannelOrderBy("NAME_DESC");

		private LineupRegionalChannelOrderBy(string name) : base(name) { }
	}
}