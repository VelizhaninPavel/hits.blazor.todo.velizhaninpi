﻿using Microsoft.VisualBasic;
using System.Data;

namespace TodoServerApp.Data
{
	public class TaskItem
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public DateTime? CreateDate { get; set; }
		public DateTime? FinishDate { get; set; }
	}
}