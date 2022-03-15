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
namespace Kaltura.Enums
{
	public sealed class ChannelOrderBy : StringEnum
	{
		public static readonly ChannelOrderBy ORDER_NUM = new ChannelOrderBy("ORDER_NUM");
		public static readonly ChannelOrderBy RELEVANCY_DESC = new ChannelOrderBy("RELEVANCY_DESC");
		public static readonly ChannelOrderBy NAME_ASC = new ChannelOrderBy("NAME_ASC");
		public static readonly ChannelOrderBy NAME_DESC = new ChannelOrderBy("NAME_DESC");
		public static readonly ChannelOrderBy VIEWS_DESC = new ChannelOrderBy("VIEWS_DESC");
		public static readonly ChannelOrderBy RATINGS_DESC = new ChannelOrderBy("RATINGS_DESC");
		public static readonly ChannelOrderBy VOTES_DESC = new ChannelOrderBy("VOTES_DESC");
		public static readonly ChannelOrderBy START_DATE_DESC = new ChannelOrderBy("START_DATE_DESC");
		public static readonly ChannelOrderBy START_DATE_ASC = new ChannelOrderBy("START_DATE_ASC");
		public static readonly ChannelOrderBy LIKES_DESC = new ChannelOrderBy("LIKES_DESC");
		public static readonly ChannelOrderBy CREATE_DATE_ASC = new ChannelOrderBy("CREATE_DATE_ASC");
		public static readonly ChannelOrderBy CREATE_DATE_DESC = new ChannelOrderBy("CREATE_DATE_DESC");

		private ChannelOrderBy(string name) : base(name) { }
	}
}
