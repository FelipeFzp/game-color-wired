using System;
using System.Windows.Forms;

namespace GameColor.Core.Helpers
{
    public static class KeyCombination
    {
        public const string PRESS_KEY_COMBINATION_LABEL = "Press key combination";
        
        public static string Serialize(this KeyEventArgs source, string escapeMessage = PRESS_KEY_COMBINATION_LABEL)
        {
            var combination = String.Empty;

            if (source.KeyCode == Keys.Escape)
                return escapeMessage;

            if (source.Control)
                combination += Keys.Control.ToString();

            if (source.Control && source.Alt)
                combination += " + ";

            if (source.Alt)
                combination += Keys.Alt.ToString();

            if ((source.Control || source.Alt) &&
                (source.KeyCode != Keys.Control && source.KeyCode != Keys.Alt && source.KeyCode != Keys.ControlKey && source.KeyCode != Keys.Menu))
                combination += $" + {source.KeyCode}";
            else
                combination += source.KeyCode.ToString();

            return combination;
        }
    }
}
