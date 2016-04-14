﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Data.Aggregation {

    abstract class Aggregator<T> {
        protected readonly Accessor<T> Accessor;

        public Aggregator(Accessor<T> accessor) {
            Accessor = accessor;
        }

        public abstract void Step(T container, string selector);
        public abstract object Finish();
    }

}
