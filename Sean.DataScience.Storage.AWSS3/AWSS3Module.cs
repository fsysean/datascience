﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace Sean.DataScience.Storage.AWSS3
{
    public class AWSS3Module: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AWSS3API>();
            base.Load(builder);
        }
    }
}
