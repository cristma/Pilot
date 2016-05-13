﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilotProject.Domain
{
    internal interface IEventHandler<T>
    {
        void Handle(T @event);
    }
}