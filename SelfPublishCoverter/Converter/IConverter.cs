﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mono.App.SelfPublishConverter.Model;

namespace Mono.App.SelfPublishConverter.Converter
{
    interface IConverter
    {
        string Convert(Book book);
    }
}