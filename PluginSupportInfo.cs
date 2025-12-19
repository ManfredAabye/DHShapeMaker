using PaintDotNet;
using System;

namespace ShapeMaker
{
    public class PluginSupportInfo : IPluginSupportInfo
    {
        public string? Author => "The Dwarf Horde";
        public string? Copyright => "©2015-2025 The Dwarf Horde";
        public string? DisplayName => "DH ShapeMaker";
        public Version? Version => new Version("2.0.0");
        public Uri? WebsiteUri => new Uri("https://github.com/dwarf-horde");
    }
}
