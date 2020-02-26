﻿using System;
using Xml;

namespace Svg
{
    [Element("path")]
    public class SvgPath : SvgMarkerElement, ISvgPresentationAttributes, ISvgTestsAttributes, ISvgStylableAttributes, ISvgResourcesAttributes, ISvgTransformableAttributes
    {
        [Attribute("d")]
        public string? PathData
        {
            get => GetAttribute("d");
            set => SetAttribute("d", value);
        }

        [Attribute("pathLength")]
        public string? PathLength
        {
            get => GetAttribute("pathLength");
            set => SetAttribute("pathLength", value);
        }

        public override void Print(Action<string> write, string indent)
        {
            base.Print(write, indent);

            if (PathData != null)
            {
                write($"{indent}{nameof(PathData)}: \"{PathData}\"");
            }
            if (PathLength != null)
            {
                write($"{indent}{nameof(PathLength)}: \"{PathLength}\"");
            }
        }
    }
}
