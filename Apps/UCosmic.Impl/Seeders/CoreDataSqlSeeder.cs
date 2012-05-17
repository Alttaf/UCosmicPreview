﻿using System.Collections.Generic;
using System.Linq;
using UCosmic.Impl.Orm;

namespace UCosmic.Impl.Seeders
{
    // ReSharper disable ClassNeverInstantiated.Global
    public class CoreDataSqlSeeder : NonContentFileSqlDbSeeder
    // ReSharper restore ClassNeverInstantiated.Global
    {

        protected override IEnumerable<string> SqlScripts
        {
            get
            {
                return new[]
                {
                    "CoreData.sql",
                };
            }
        }

        public override void Seed(UCosmicContext context)
        {
            if (!context.Languages.Any())
                base.Seed(context);
        }
    }
}
