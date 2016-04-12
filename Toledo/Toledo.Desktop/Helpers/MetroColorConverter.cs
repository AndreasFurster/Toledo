using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;

namespace Toledo.Desktop.Helpers
{
    static class MetroColorConverter
    {
        private static readonly Dictionary<int, Color> _colors = new Dictionary<int, Color>();

        static MetroColorConverter()
        {
            _colors.Add((int)MetroColorStyle.Black, ColorTranslator.FromHtml("#000000"));
            _colors.Add((int)MetroColorStyle.White, ColorTranslator.FromHtml("#FFFFFF"));
            _colors.Add((int)MetroColorStyle.Silver, ColorTranslator.FromHtml("#555555"));
            _colors.Add((int)MetroColorStyle.Blue, ColorTranslator.FromHtml("#00AEDB"));
            _colors.Add((int)MetroColorStyle.Green, ColorTranslator.FromHtml("#00B159"));
            _colors.Add((int)MetroColorStyle.Lime, ColorTranslator.FromHtml("#8EBC00"));
            _colors.Add((int)MetroColorStyle.Teal, ColorTranslator.FromHtml("#00AAAD"));
            _colors.Add((int)MetroColorStyle.Orange, ColorTranslator.FromHtml("#F37735"));
            _colors.Add((int)MetroColorStyle.Brown, ColorTranslator.FromHtml("#A55100"));
            _colors.Add((int)MetroColorStyle.Pink, ColorTranslator.FromHtml("#E771BD"));
            _colors.Add((int)MetroColorStyle.Magenta, ColorTranslator.FromHtml("#FF0094"));
            _colors.Add((int)MetroColorStyle.Purple, ColorTranslator.FromHtml("#7C4199"));
            _colors.Add((int)MetroColorStyle.Red, ColorTranslator.FromHtml("#D11141"));
            _colors.Add((int)MetroColorStyle.Yellow, ColorTranslator.FromHtml("#FFC425"));
        }

        public static Color ToColor(this MetroColorStyle metroColor)
        {
            return _colors[(int)metroColor];
        }

        public static MetroColorStyle ToMetroColorStyle(this Color color)
        {
            return (MetroColorStyle)_colors.Single(c => c.Value == color).Key;
        }
    }
}
