﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoringService.Core.Domain
{
    public class SocialStatusTranslate
    {
        public int Id { get; set; }
        public SocialStatus SocialStatus { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
    }
}