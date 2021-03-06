﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MongoDB.Driver;
using Sean.DataScience.Common;

namespace Sean.DataScience.Data.MongoDB
{
    public class MongoModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MongoBootstrap>();
            builder.Register((context) =>
            {
                var options = context.Resolve<MongoOptions>();
                return new MongoClient(options.Url);
            });
            base.Load(builder);
        }
    }
}
