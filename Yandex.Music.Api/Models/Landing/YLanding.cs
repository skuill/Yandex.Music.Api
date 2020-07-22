﻿using System.Collections.Generic;

namespace Yandex.Music.Api.Models.Landing
{
    public class YLanding
    {
        #region Свойства

        public List<YLandingBlock> Blocks { get; set; }
        public string ContentId { get; set; }
        public bool Pumpkin { get; set; }

        #endregion
    }
}