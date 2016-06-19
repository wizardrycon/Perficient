using FizzBuzzLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzWinUI
{
    public partial class FBWinUI : Form
    {
        
        public FBWinUI()
        {
            InitializeComponent();
        }

        private void addparmBtn_Click(object sender, EventArgs e)
        {
            long numval = Convert.ToInt64(numericNTxt.Value);

            string repstr = replacestrTxt.Text;

            if(!string.IsNullOrEmpty(repstr))
                paramListBox.Items.Add(numval.ToString() + "," + repstr.Replace(',',' ').Trim());
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            paramListBox.Items.Remove(paramListBox.SelectedItem);
        }

        private void processBtn_Click(object sender, EventArgs e)
        {         
            outputTxt.Text = string.Empty;

            List<FizzBuzzArgs> _fba = new List<FizzBuzzArgs>();
            long _start = Convert.ToInt64(startnumNTxt.Value);
            long _end = Convert.ToInt64(endnumNTxt.Value);

            foreach (var Item in paramListBox.Items)
            {
                string[] _rowitem = Item.ToString().Split(',');
                long _num = Convert.ToInt64(_rowitem[0]);
                string _repstr = _rowitem[1];

                _fba.Add(new FizzBuzzArgs(_repstr, _num));
            }

            if (bulkChk.Checked)
            {
                FizzBuzz fb = new FizzBuzz();
                foreach (string _retstr in fb.ProcessBulk(_start, _end, _fba))
                    outputTxt.AppendText(_retstr + Environment.NewLine);                                                    
            }
            else
            {
                FizzBuzz fb = new FizzBuzz(_start, _end, _fba);
                string _retstr = string.Empty;
                while(_retstr != null)
                {
                    _retstr = fb.Next();
                    if (_retstr != null)
                        outputTxt.AppendText(_retstr + Environment.NewLine);
                }
            }
        }

        private void startnumNTxt_ValueChanged(object sender, EventArgs e)
        {
            if (endnumNTxt.Value <= startnumNTxt.Value)
                endnumNTxt.Value = startnumNTxt.Value + 1;

            endnumNTxt.Minimum = startnumNTxt.Value + 1;
        }
    }
}
