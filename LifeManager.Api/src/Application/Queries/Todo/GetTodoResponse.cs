﻿namespace LifeManage.src.Application.Queries.Todo
{
	public record GetTodoResponse
	{
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public string? Description { get; set; }
		public bool IsCompleted { get; set; }
		public DateTime? DueDate { get; set; }
	}
}
