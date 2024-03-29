﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //定义usb事件常量  
        public const int WM_DEVICECHANGE = 0x219;
        public const int WM_CLOSE = 0x0010;
        public const int DBT_DEVICEARRIVAL = 0x8000;
        public const int DBT_CONFIGCHANGECANCELED = 0x0019;
        public const int DBT_CONFIGCHANGED = 0x0018;
        public const int DBT_CUSTOMEVENT = 0x8006;
        public const int DBT_DEVICEQUERYREMOVE = 0x8001;
        public const int DBT_DEVICEQUERYREMOVEFAILED = 0x8002;
        public const int DBT_DEVICEREMOVECOMPLETE = 0x8004;
        public const int DBT_DEVICEREMOVEPENDING = 0x8003;
        public const int DBT_DEVICETYPESPECIFIC = 0x8005;
        public const int DBT_DEVNODES_CHANGED = 0x0007;
        public const int DBT_QUERYCHANGECONFIG = 0x0017;
        public const int DBT_USERDEFINED = 0xFFFF;
        public string srcPath = null;
        public string dstPath = null;

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string a, string b);

        [DllImport("user32.dll")]
        private static extern IntPtr PostMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {

            try
            {
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case WM_DEVICECHANGE:
                            break;
                        case DBT_DEVICEARRIVAL:
                            DriveInfo[] s = DriveInfo.GetDrives();
                            foreach (DriveInfo drive in s)
                            {
                                if (drive.DriveType == DriveType.Removable)
                                {
                                    dstPath = drive.Name.ToString();
                                    richTextBox1.AppendText("U盘已插入，盘符是" + drive.Name.ToString() + "\r\n");
                                    txb_dstPath.Text = dstPath;
                                    break;
                                }
                            }
                            if (dstPath != null)
                            {
                                copy();
                            }
                            break;
                        case DBT_CONFIGCHANGECANCELED:
                            MessageBox.Show("2");
                            break;
                        case DBT_CONFIGCHANGED:
                            MessageBox.Show("3");
                            break;
                        case DBT_CUSTOMEVENT:
                            MessageBox.Show("4");
                            break;
                        case DBT_DEVICEQUERYREMOVE:
                            MessageBox.Show("5");
                            break;
                        case DBT_DEVICEQUERYREMOVEFAILED:
                            MessageBox.Show("6");
                            break;
                        case DBT_DEVICEREMOVECOMPLETE:
                            richTextBox1.AppendText("U盘已卸载");
                            IntPtr ptr1 = FindWindow(null, "usb tool");
                            if (ptr1 != IntPtr.Zero)
                            {
                                PostMessage(ptr1, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);//close message box
                            }
                            break;
                        case DBT_DEVICEREMOVEPENDING:
                            MessageBox.Show("7");
                            break;
                        case DBT_DEVICETYPESPECIFIC:
                            MessageBox.Show("8");
                            break;
                        case DBT_DEVNODES_CHANGED:
                            //MessageBox.Show("9");
                            break;
                        case DBT_QUERYCHANGECONFIG:
                            MessageBox.Show("10");
                            break;
                        case DBT_USERDEFINED:
                            MessageBox.Show("11");
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_src_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdg = new OpenFileDialog();
            fdg.Title = "请选择需要复制的文件";
            fdg.Filter = "二进制文件(*.bin)|*.bin|所有文件(*.*)|*.*";
            if(fdg.ShowDialog() == DialogResult.OK)
            {
                srcPath = fdg.FileName;
            }
            txb_srcPath.Text = srcPath;
        }

        private void Btn_dst_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();
            dstPath = folderBrowser.SelectedPath;
            txb_dstPath.Text = dstPath;
        }


        private void copy()
        {
            string fileName = srcPath.Split('\\').Last();//获取文件名
            string dstFile = Path.Combine(dstPath, fileName);

            File.Copy(srcPath, dstFile, true);
            MessageBox.Show("copy success", "usb tool");
        }

    }
}
