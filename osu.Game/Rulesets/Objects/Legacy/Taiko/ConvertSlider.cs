﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Rulesets.Objects.Types;

namespace osu.Game.Rulesets.Objects.Legacy.Taiko
{
    /// <summary>
    /// Legacy osu!taiko Slider-type, used for parsing Beatmaps.
    /// </summary>
    internal sealed class ConvertSlider : Legacy.ConvertSlider, IHasCombo
    {
        public bool NewCombo { get; set; }
    }
}
