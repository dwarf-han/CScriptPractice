namespace NLuaPractice
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.luaSrciptTextBox = new System.Windows.Forms.RichTextBox();
            this.RunLuaScript = new System.Windows.Forms.Button();
            this.luaResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lua Script";
            // 
            // luaSrciptTextBox
            // 
            this.luaSrciptTextBox.Location = new System.Drawing.Point(17, 41);
            this.luaSrciptTextBox.Name = "luaSrciptTextBox";
            this.luaSrciptTextBox.Size = new System.Drawing.Size(408, 487);
            this.luaSrciptTextBox.TabIndex = 1;
            this.luaSrciptTextBox.Text = "";
            // 
            // RunLuaScript
            // 
            this.RunLuaScript.Location = new System.Drawing.Point(326, 12);
            this.RunLuaScript.Name = "RunLuaScript";
            this.RunLuaScript.Size = new System.Drawing.Size(99, 23);
            this.RunLuaScript.TabIndex = 2;
            this.RunLuaScript.Text = "실행";
            this.RunLuaScript.UseVisualStyleBackColor = true;
            this.RunLuaScript.Click += new System.EventHandler(this.RunLuaScript_Click);
            // 
            // luaResultLabel
            // 
            this.luaResultLabel.Location = new System.Drawing.Point(501, 121);
            this.luaResultLabel.Name = "luaResultLabel";
            this.luaResultLabel.Size = new System.Drawing.Size(322, 335);
            this.luaResultLabel.TabIndex = 3;
            this.luaResultLabel.Text = "루아 실행 결과";
            this.luaResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.luaResultLabel);
            this.Controls.Add(this.RunLuaScript);
            this.Controls.Add(this.luaSrciptTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Lua Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox luaSrciptTextBox;
        private System.Windows.Forms.Button RunLuaScript;
        private System.Windows.Forms.Label luaResultLabel;
    }
}

