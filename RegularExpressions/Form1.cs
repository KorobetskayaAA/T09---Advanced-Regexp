using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpressions
{
    public partial class FormRegExp : Form
    {
        public FormRegExp()
        {
            InitializeComponent();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            var regex = new Regex(textBoxRegexp.Text,
                RegexOptions.Multiline | (checkBoxCase.Checked ? RegexOptions.IgnoreCase : 0));
            var match = regex.Match(textBoxInput.Text,
                textBoxInput.SelectionStart + textBoxInput.SelectionLength);
            
            if (match.Success)
            {
                textBoxInput.Select(match.Index, match.Length);
                labelMathchResult.Text = "Найдено: " + match.Value;
            }
            else
            {
                labelMathchResult.Text = "Ничего не найдено!";
            }
            textBoxInput.Select();
        }

        private void buttonFindAll_Click(object sender, EventArgs e)
        {
            textBoxInput.Select(0, textBoxInput.Text.Length);
            textBoxInput.SelectionBackColor = Color.Transparent;

            var regex = new Regex(textBoxRegexp.Text,
                RegexOptions.Multiline | (checkBoxCase.Checked ? RegexOptions.IgnoreCase : 0));
            var matches = regex.Matches(textBoxInput.Text);

            labelMathchResult.Text = $"Найдено совпадений: {matches.Count}";
            foreach (Match match in matches)
            {
                textBoxInput.Select(match.Index, match.Length);
                textBoxInput.SelectionBackColor = Color.Yellow;
            }
            textBoxInput.Select();
        }
    }
}
