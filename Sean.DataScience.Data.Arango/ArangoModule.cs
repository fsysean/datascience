﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Sean.DataScience.Data.Arango
{
    public class ArangoModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArangoConnection>();
            base.Load(builder);
        }
    }
}
