using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingQuiz.Core.Domain.QG
{
	public class QuizType:BaseEntity
	{
		public string QuizTypeName { get; set; }
		public int? Order { get; set; }
	}
}
