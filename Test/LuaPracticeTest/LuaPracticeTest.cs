using System;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLua;
using NLuaPractice;

namespace LuaPracticeTest
{
    [TestClass]
    public class LuaAPITests
    {
        [TestMethod]
        public void 루아_DoStringTest()
        {
            //루아 스크립트 엔진
            using (Lua lua = new Lua())
            {
                lua.State.Encoding = Encoding.UTF8; //입력 문자열 인코딩 방식. 지정하지 않을 경우 문자 꺠짐 발생함
                lua.DoString("res = '루아 프로젝트'");
                string res = (string)lua["res"];

                Assert.AreEqual("루아 프로젝트", res);
            }
        }

        [TestMethod]
        public void 루아_API_Setter프로퍼티_Label_Text_변경()
        {
            Label label = new Label();
            LabelAPI api = new LabelAPI(label);

            //루아 스크립트 엔진
            using (Lua lua = new Lua())
            {
                lua["LabelAPI"] = api;
                lua.State.Encoding = Encoding.UTF8; //입력 문자열 인코딩 방식. 지정하지 않을 경우 문자 꺠짐 발생함
                lua.DoString(@"
                    LabelAPI.Text = 'hello'
                ");

                Assert.AreEqual("hello", label.Text);
            }
        }

        [TestMethod]
        public void 루아_API_Getter프로퍼티_Label_Text_가져오기()
        {
            Label label = new Label();
            LabelAPI api = new LabelAPI(label);

            //루아 스크립트 엔진
            using (Lua lua = new Lua())
            {
                lua["LabelAPI"] = api;
                lua.State.Encoding = Encoding.UTF8; //입력 문자열 인코딩 방식. 지정하지 않을 경우 문자 꺠짐 발생함
                lua.DoString(@"
                    LabelAPI.Text = 'hello'
                    local labelText = LabelAPI.Text
                ");

                string res = (string)lua["labelText"];

                Assert.AreEqual("hello", label.Text);
            }
        }

        [TestMethod]
        public void 루아_API_Label_BackColor_변경()
        {
            Label label = new Label();
            LabelAPI api = new LabelAPI(label);

            //루아 스크립트 엔진
            using (Lua lua = new Lua())
            {
                lua["LabelAPI"] = api;
                lua.State.Encoding = Encoding.UTF8; //입력 문자열 인코딩 방식. 지정하지 않을 경우 문자 꺠짐 발생함
                lua.DoString(@"
                    LabelAPI:SetColor(255, 0, 0)
                ");

                Assert.AreEqual(255, label.BackColor.R);
                Assert.AreEqual(0, label.BackColor.G);
                Assert.AreEqual(0, label.BackColor.B);
            }
        }
    }
}
