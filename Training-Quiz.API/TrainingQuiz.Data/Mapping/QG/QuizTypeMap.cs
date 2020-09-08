using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TrainingQuiz.Core.Domain.QG;

namespace TrainingQuiz.Data.Mapping.QG
{
	public partial class QuizTypeMap: MaiQDEntityTypeConfiguration<QuizType>
	{
		public override void Configure(EntityTypeBuilder<QuizType> builder)
		{
			builder.ToTable("QG_QuizType");
			builder.HasKey(p => p.ID);
			base.Configure(builder);
		}
	}
}
