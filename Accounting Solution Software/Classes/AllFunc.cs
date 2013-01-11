using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting_Solution_Software
{
    class AllFunc
    {
        String prefix = null;
        MainForm mf = null;

        public AllFunc()
        {
        }

        public AllFunc(String prefix,MainForm mf)
        {
            Prefix = prefix;
            Mf = mf;
        }

        public String Prefix { get; set; }

        public MainForm Mf { get; set; }

        public string digit_separated(string str)
        {
            if ((str.CompareTo("")!=0)&&(str!=null))
            {
                string val = String.Format("{0:#,0}", Convert.ToDouble(str));
                return val;
            }
            else if (str.CompareTo("0") == 0)
            {
                return "0";
            }
            else
            {
                return "0";
            }
        }

        public string remove_separated(string str)
        {
            if ((str.CompareTo("") != 0) && (str != null))
            {
                return str.Replace(",", "");
            }
            else
            {
                return "0";
            }
        }

        public void digit_filter(object sender, KeyEventArgs e, String str)
        {
            //Allow navigation keyboard arrows
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                case Keys.PageUp:
                case Keys.PageDown:
                    e.SuppressKeyPress = false;
                    return;
                default:
                    break;
            }

            //Block non-number characters
            char currentKey = (char)e.KeyCode;
            bool modifier = e.Control || e.Alt || e.Shift;
            bool nonNumber = char.IsLetter(currentKey) ||
                             char.IsSymbol(currentKey) ||
                             char.IsWhiteSpace(currentKey) ||
                             char.IsPunctuation(currentKey);
            bool numpad = e.KeyCode.ToString().Contains("NumPad0") || e.KeyCode.ToString().Contains("NumPad1") || e.KeyCode.ToString().Contains("NumPad2") || e.KeyCode.ToString().Contains("NumPad3") || e.KeyCode.ToString().Contains("NumPad4") || e.KeyCode.ToString().Contains("NumPad5") || e.KeyCode.ToString().Contains("NumPad6") || e.KeyCode.ToString().Contains("NumPad7") || e.KeyCode.ToString().Contains("NumPad8") || e.KeyCode.ToString().Contains("NumPad9");
            if (!modifier && nonNumber && !numpad || ((e.KeyValue == 188) || (e.KeyValue == 190)))
            {
                e.SuppressKeyPress = true;
            }

            //Handle pasted Text
            if (e.Control && e.KeyCode == Keys.V)
            {
                //Preview paste data (removing non-number characters)
                string pasteText = Clipboard.GetText();
                string strippedText = "";
                for (int i = 0; i < pasteText.Length; i++)
                {
                    if (char.IsDigit(pasteText[i]))
                        strippedText += pasteText[i].ToString();
                }

                if (strippedText != pasteText)
                {
                    //There were non-numbers in the pasted text
                    e.SuppressKeyPress = true;

                    //OPTIONAL: Manually insert text stripped of non-numbers
                    TextBox me = (TextBox)sender;
                    int start = me.SelectionStart;
                    string newTxt = me.Text;
                    newTxt = newTxt.Remove(me.SelectionStart, me.SelectionLength); //remove highlighted text
                    newTxt = newTxt.Insert(me.SelectionStart, strippedText); //paste
                    me.Text = newTxt;
                    me.SelectionStart = start + strippedText.Length;
                }
                else
                    e.SuppressKeyPress = false;
            }
        }

        public void digit_filter_allow_dot(object sender, KeyEventArgs e, String str,TextBox txtObj)
        {
            //Allow navigation keyboard arrows
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                case Keys.PageUp:
                case Keys.PageDown:
                    e.SuppressKeyPress = false;
                    return;
                default:
                    break;
            }

            //Block non-number characters
            char currentKey = (char)e.KeyCode;
            bool modifier = e.Control || e.Alt || e.Shift;
            bool nonNumber = char.IsLetter(currentKey) ||
                             char.IsSymbol(currentKey) ||
                             char.IsWhiteSpace(currentKey) ||
                             char.IsPunctuation(currentKey);

            int dotCount = 0;
            char[] arrChar = txtObj.Text.ToCharArray();
            	for (int i = 0; i < arrChar.Length; i++)
	            {
	                // Get character from array.
	                char letter = arrChar[i];
                    if (arrChar[i].CompareTo('.') == 0)
                    {
                        dotCount++;
                    }
	            }
            if ((dotCount>0)&&(e.KeyValue == 190))
            {
                e.SuppressKeyPress = true;
            }

            bool numpad = e.KeyCode.ToString().Contains("NumPad0") || e.KeyCode.ToString().Contains("NumPad1") || e.KeyCode.ToString().Contains("NumPad2") || e.KeyCode.ToString().Contains("NumPad3") || e.KeyCode.ToString().Contains("NumPad4") || e.KeyCode.ToString().Contains("NumPad5") || e.KeyCode.ToString().Contains("NumPad6") || e.KeyCode.ToString().Contains("NumPad7") || e.KeyCode.ToString().Contains("NumPad8") || e.KeyCode.ToString().Contains("NumPad9");
            
            if (!modifier && nonNumber && !numpad || ((e.KeyValue == 188)))
            {
                e.SuppressKeyPress = true;
            }

            //Handle pasted Text
            if (e.Control && e.KeyCode == Keys.V)
            {
                //Preview paste data (removing non-number characters)
                string pasteText = Clipboard.GetText();
                string strippedText = "";
                for (int i = 0; i < pasteText.Length; i++)
                {
                    if (char.IsDigit(pasteText[i]))
                        strippedText += pasteText[i].ToString();
                }

                if (strippedText != pasteText)
                {
                    //There were non-numbers in the pasted text
                    e.SuppressKeyPress = true;

                    //OPTIONAL: Manually insert text stripped of non-numbers
                    TextBox me = (TextBox)sender;
                    int start = me.SelectionStart;
                    string newTxt = me.Text;
                    newTxt = newTxt.Remove(me.SelectionStart, me.SelectionLength); //remove highlighted text
                    newTxt = newTxt.Insert(me.SelectionStart, strippedText); //paste
                    me.Text = newTxt;
                    me.SelectionStart = start + strippedText.Length;
                }
                else
                    e.SuppressKeyPress = false;
            }
        }
    }
}
