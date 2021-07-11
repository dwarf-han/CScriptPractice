using NLua;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLuaPractice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 실행 버튼 클릭 이벤트 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RunLuaScript_Click(object sender, EventArgs e)
        {
            try
            {
                //루아 스크립트 엔진 선언
                using (Lua lua = new Lua())
                {
                    //Label API 객체 등록
                    lua["LabelAPI"] = new LabelAPI(luaResultLabel);

                    //인코딩 문자열 방식 지정
                    lua.State.Encoding = Encoding.UTF8;

                    //Lua Script Text -> 스크립트 실행
                    lua.DoString(luaSrciptTextBox.Text);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"{err}");
            }
        }
    }
}
