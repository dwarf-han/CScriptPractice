using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLuaPractice
{
    public class LabelAPI
    {
        //루아 스크립트로 조작 할 Label Control
        private Label label;

        //루아 - 프로퍼티 접근 
        public string Text 
        {
            get => label.Text;
            set
            {
                label.Text = value;
            }
        }

        public LabelAPI(Label labelControl)
        {
            this.label = labelControl;
            this.label.Text = Text;
        }

        //루아 - Method 접근
        public void SetColor(byte r, byte g, byte b)
        {
            this.label.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
