﻿using Nikse.SubtitleEdit.Core.Common.TextLengthCalculator;
using System.Collections.Generic;
using System.Linq;

namespace Nikse.SubtitleEdit.Logic
{
    public class CpsLineLength
    {
        public string Code { get; set; }
        public override string ToString()
        {
            switch (Code)
            {
                case nameof(CalcNoSpaceCpsOnly):
                    return LanguageSettings.Current.Settings.CpsLineLengthStyleCalcNoSpaceCpsOnly;
                case nameof(CalcNoSpace):
                    return LanguageSettings.Current.Settings.CpsLineLengthStyleCalcNoSpace;
                case nameof(CalcCjk):
                    return LanguageSettings.Current.Settings.CpsLineLengthStyleCalcCjk;
                case nameof(CalcCjkNoSpace):
                    return LanguageSettings.Current.Settings.CpsLineLengthStyleCalcCjkNoSpace;
                case nameof(CalcIgnoreArabicDiacriticsCpsOnly):
                    return LanguageSettings.Current.Settings.CpsLineLengthStyleCalcIgnoreArabicDiacriticsCpsOnly;
                case nameof(CalcIgnoreArabicDiacriticsNoSpaceCpsOnly):
                    return LanguageSettings.Current.Settings.CpsLineLengthStyleCalcIgnoreArabicDiacriticsNoSpaceCpsOnly;
                default:
                    return LanguageSettings.Current.Settings.CpsLineLengthStyleCalcAll;
            }
        }

        public static List<CpsLineLength> List()
        {
            return CalcFactory.Calculators.Select(p => new CpsLineLength { Code = p.GetType().Name }).ToList();
        }
    }
}