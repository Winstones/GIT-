using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HookINCS
{
    public partial class Form1 : Form
    {
        private Hook hook;

        #region 初始化组件
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            hook = Hook.GetInstance();
            hook.OnKeyPress += new KeyEventHandler(OnKeyDown);
            hook.InstallKeyBoardHook();
        }

        private void OnKeyDown(object sender, KeyEventArgs e) 
        {
            MessageBox.Show(e.KeyCode.ToString() + " KeyPress");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hook.UninstallKeyBoardHook();
        }

        #region 窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
