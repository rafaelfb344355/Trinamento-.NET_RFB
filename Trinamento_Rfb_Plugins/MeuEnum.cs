﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinamento_Rfb_Plugins
{
        public class MeuEnum
        {
            public enum Stage
            {
                PreValidation = 10,
                PreOperation = 20,
                PostOperation = 40
            }

            public enum Mode
            {
                Asynchronous = 1,
                Synchronous = 0
            }
        }
    }

