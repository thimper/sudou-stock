namespace sudou_stock
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.智能找股 = new System.Windows.Forms.RibbonTab();
            this.董事局 = new System.Windows.Forms.RibbonPanel();
            this.大单跟踪 = new System.Windows.Forms.RibbonPanel();
            this.超级盘口 = new System.Windows.Forms.RibbonPanel();
            this.年月分析 = new System.Windows.Forms.RibbonTab();
            this.汇总统计 = new System.Windows.Forms.RibbonTab();
            this.打开 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.保存 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.设置 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.退出 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.公司新闻 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.公司大事件 = new System.Windows.Forms.RibbonButton();
            this.新闻报表 = new System.Windows.Forms.RibbonButton();
            this.懂事 = new System.Windows.Forms.RibbonButton();
            this.大单 = new System.Windows.Forms.RibbonButton();
            this.历史盘口 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.打开);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.保存);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItems.Add(this.设置);
            this.ribbon1.OrbDropDown.OptionItems.Add(this.退出);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "菜单";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.ribbonButton1);
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.ribbonButton3);
            this.ribbon1.QuickAcessToolbar.DropDownButtonItems.Add(this.ribbonButton4);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton6);
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1038, 156);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.智能找股);
            this.ribbon1.Tabs.Add(this.年月分析);
            this.ribbon1.Tabs.Add(this.汇总统计);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // 智能找股
            // 
            this.智能找股.Panels.Add(this.公司新闻);
            this.智能找股.Panels.Add(this.董事局);
            this.智能找股.Panels.Add(this.大单跟踪);
            this.智能找股.Panels.Add(this.超级盘口);
            this.智能找股.Text = "智能找股";
            // 
            // 董事局
            // 
            this.董事局.Items.Add(this.懂事);
            this.董事局.Text = "董事局";
            // 
            // 大单跟踪
            // 
            this.大单跟踪.Items.Add(this.大单);
            this.大单跟踪.Text = "大单跟踪";
            // 
            // 超级盘口
            // 
            this.超级盘口.Items.Add(this.历史盘口);
            this.超级盘口.Text = "超级盘口";
            // 
            // 年月分析
            // 
            this.年月分析.Text = "年月分析";
            // 
            // 汇总统计
            // 
            this.汇总统计.Text = "汇总统计";
            // 
            // 打开
            // 
            this.打开.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.打开.Image = global::sudou_stock.Properties.Resources.open_file_16px_1187339_easyicon_net;
            this.打开.SmallImage = global::sudou_stock.Properties.Resources.open_file_16px_1187339_easyicon_net;
            this.打开.Text = "打开";
            // 
            // 保存
            // 
            this.保存.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.保存.Image = global::sudou_stock.Properties.Resources.Save_as_16px_1186319_easyicon_net;
            this.保存.SmallImage = global::sudou_stock.Properties.Resources.Save_as_16px_1186319_easyicon_net;
            this.保存.Text = "保存";
            // 
            // 设置
            // 
            this.设置.Image = global::sudou_stock.Properties.Resources.setting_16px_1117178_easyicon_net;
            this.设置.SmallImage = global::sudou_stock.Properties.Resources.setting_16px_1117178_easyicon_net;
            this.设置.Text = "设 置";
            this.设置.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // 退出
            // 
            this.退出.Image = global::sudou_stock.Properties.Resources.exit_16px_27110_easyicon_net;
            this.退出.SmallImage = global::sudou_stock.Properties.Resources.exit_16px_27110_easyicon_net;
            this.退出.Text = "退出";
            this.退出.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton6.SmallImage = global::sudou_stock.Properties.Resources.save16;
            this.ribbonButton6.Text = "ribbonButton6";
            // 
            // 公司新闻
            // 
            this.公司新闻.Image = global::sudou_stock.Properties.Resources.find32;
            this.公司新闻.Items.Add(this.ribbonButton2);
            this.公司新闻.Items.Add(this.公司大事件);
            this.公司新闻.Items.Add(this.新闻报表);
            this.公司新闻.Text = "公司新闻";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = global::sudou_stock.Properties.Resources.news_uk_bbs_48px_1135252_easyicon_net;
            this.ribbonButton2.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "最新新闻";
            // 
            // 公司大事件
            // 
            this.公司大事件.Image = global::sudou_stock.Properties.Resources.Bbc_News_48px_1123513_easyicon_net;
            this.公司大事件.SmallImage = ((System.Drawing.Image)(resources.GetObject("公司大事件.SmallImage")));
            this.公司大事件.Text = "公司大事件";
            // 
            // 新闻报表
            // 
            this.新闻报表.Image = global::sudou_stock.Properties.Resources.News_report48;
            this.新闻报表.SmallImage = ((System.Drawing.Image)(resources.GetObject("新闻报表.SmallImage")));
            this.新闻报表.Text = "新闻报表";
            // 
            // 懂事
            // 
            this.懂事.Image = global::sudou_stock.Properties.Resources.meeting_48;
            this.懂事.SmallImage = ((System.Drawing.Image)(resources.GetObject("懂事.SmallImage")));
            this.懂事.Text = "";
            // 
            // 大单
            // 
            this.大单.Image = global::sudou_stock.Properties.Resources.big_stock48;
            this.大单.SmallImage = ((System.Drawing.Image)(resources.GetObject("大单.SmallImage")));
            this.大单.Text = "ribbonButton5";
            // 
            // 历史盘口
            // 
            this.历史盘口.Image = global::sudou_stock.Properties.Resources.History_stock48;
            this.历史盘口.SmallImage = ((System.Drawing.Image)(resources.GetObject("历史盘口.SmallImage")));
            this.历史盘口.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 606);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "选股专家";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab 智能找股;
        private System.Windows.Forms.RibbonPanel 公司新闻;
        private System.Windows.Forms.RibbonTab 年月分析;
        private System.Windows.Forms.RibbonOrbMenuItem 打开;
        private System.Windows.Forms.RibbonOrbMenuItem 保存;
        private System.Windows.Forms.RibbonOrbOptionButton 退出;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton 公司大事件;
        private System.Windows.Forms.RibbonButton 新闻报表;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonOrbOptionButton 设置;
        private System.Windows.Forms.RibbonTab 汇总统计;
        private System.Windows.Forms.RibbonPanel 董事局;
        private System.Windows.Forms.RibbonPanel 大单跟踪;
        private System.Windows.Forms.RibbonPanel 超级盘口;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton 懂事;
        private System.Windows.Forms.RibbonButton 大单;
        private System.Windows.Forms.RibbonButton 历史盘口;
    }
}