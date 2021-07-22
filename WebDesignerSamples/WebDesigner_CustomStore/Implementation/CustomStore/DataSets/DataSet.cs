﻿using System.Text;

using LiteDB;


namespace WebDesignerCustomStore.Implementation.CustomStore.DataSets
{
	public class Dataset
	{
		[BsonField("_id")]
		public string Id { get; set; }

		[BsonField("Dataset")]
		public byte[] Content { get; set; }

		public string Data => Encoding.UTF8.GetString(Content);
	}
}
