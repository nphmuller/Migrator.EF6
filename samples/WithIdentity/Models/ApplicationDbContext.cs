﻿using System.Data.Entity;
using MR.AspNet.Identity.EntityFramework6;

namespace WithIdentity.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		// MNOTE: This hard coded string will only be used when calling the migrator tool (so only in development).
		public static string ConnectionString { get; set; } =
			"Server=(localdb)\\mssqllocaldb;Database=Migrator.EF6-WithIdentity;Trusted_Connection=True;MultipleActiveResultSets=true";

		public ApplicationDbContext() : base(ConnectionString)
		{
		}

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
