namespace AnsFinder
{
  partial class Form1
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.search_B = new System.Windows.Forms.Button();
      this.colours_L = new System.Windows.Forms.Label();
      this.genre_L = new System.Windows.Forms.Label();
      this.colours_CB = new System.Windows.Forms.ComboBox();
      this.genre_CB = new System.Windows.Forms.ComboBox();
      this.search_L = new System.Windows.Forms.Label();
      this.search_TB = new System.Windows.Forms.TextBox();
      this.result_L = new System.Windows.Forms.Label();
      this.result_RTB = new System.Windows.Forms.RichTextBox();
      this.clearB = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // search_B
      // 
      this.search_B.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.search_B.Location = new System.Drawing.Point(251, 355);
      this.search_B.Name = "search_B";
      this.search_B.Size = new System.Drawing.Size(84, 23);
      this.search_B.TabIndex = 0;
      this.search_B.Text = "検索";
      this.search_B.UseVisualStyleBackColor = true;
      this.search_B.Click += new System.EventHandler(this.search_B_Click);
      // 
      // colours_L
      // 
      this.colours_L.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.colours_L.AutoSize = true;
      this.colours_L.Location = new System.Drawing.Point(15, 26);
      this.colours_L.Name = "colours_L";
      this.colours_L.Size = new System.Drawing.Size(35, 12);
      this.colours_L.TabIndex = 1;
      this.colours_L.Text = "色数：";
      // 
      // genre_L
      // 
      this.genre_L.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.genre_L.AutoSize = true;
      this.genre_L.Location = new System.Drawing.Point(123, 26);
      this.genre_L.Name = "genre_L";
      this.genre_L.Size = new System.Drawing.Size(48, 12);
      this.genre_L.TabIndex = 1;
      this.genre_L.Text = "ジャンル：";
      // 
      // colours_CB
      // 
      this.colours_CB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.colours_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.colours_CB.FormatString = "N0";
      this.colours_CB.FormattingEnabled = true;
      this.colours_CB.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
      this.colours_CB.Location = new System.Drawing.Point(53, 23);
      this.colours_CB.Name = "colours_CB";
      this.colours_CB.Size = new System.Drawing.Size(47, 20);
      this.colours_CB.TabIndex = 2;
      // 
      // genre_CB
      // 
      this.genre_CB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.genre_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.genre_CB.FormattingEnabled = true;
      this.genre_CB.Items.AddRange(new object[] {
            "",
            "文系",
            "理系",
            "生活＆雑学",
            "スポーツ",
            "芸能",
            "アニメ＆ゲーム"});
      this.genre_CB.Location = new System.Drawing.Point(174, 23);
      this.genre_CB.Name = "genre_CB";
      this.genre_CB.Size = new System.Drawing.Size(160, 20);
      this.genre_CB.TabIndex = 3;
      // 
      // search_L
      // 
      this.search_L.AutoSize = true;
      this.search_L.Location = new System.Drawing.Point(15, 65);
      this.search_L.Name = "search_L";
      this.search_L.Size = new System.Drawing.Size(35, 12);
      this.search_L.TabIndex = 4;
      this.search_L.Text = "検索：";
      // 
      // search_TB
      // 
      this.search_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.search_TB.Location = new System.Drawing.Point(53, 62);
      this.search_TB.Name = "search_TB";
      this.search_TB.Size = new System.Drawing.Size(280, 19);
      this.search_TB.TabIndex = 5;
      this.search_TB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_TB_KeyUp);
      // 
      // result_L
      // 
      this.result_L.AutoSize = true;
      this.result_L.Location = new System.Drawing.Point(17, 109);
      this.result_L.Name = "result_L";
      this.result_L.Size = new System.Drawing.Size(59, 12);
      this.result_L.TabIndex = 7;
      this.result_L.Text = "検索結果：";
      // 
      // result_RTB
      // 
      this.result_RTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.result_RTB.Location = new System.Drawing.Point(19, 124);
      this.result_RTB.Name = "result_RTB";
      this.result_RTB.ReadOnly = true;
      this.result_RTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
      this.result_RTB.Size = new System.Drawing.Size(314, 225);
      this.result_RTB.TabIndex = 8;
      this.result_RTB.Text = "";
      // 
      // clearB
      // 
      this.clearB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.clearB.Location = new System.Drawing.Point(174, 354);
      this.clearB.Name = "clearB";
      this.clearB.Size = new System.Drawing.Size(60, 24);
      this.clearB.TabIndex = 9;
      this.clearB.Text = "クリア";
      this.clearB.UseVisualStyleBackColor = true;
      this.clearB.Click += new System.EventHandler(this.clearB_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(347, 390);
      this.Controls.Add(this.clearB);
      this.Controls.Add(this.result_RTB);
      this.Controls.Add(this.result_L);
      this.Controls.Add(this.search_TB);
      this.Controls.Add(this.search_L);
      this.Controls.Add(this.genre_CB);
      this.Controls.Add(this.colours_CB);
      this.Controls.Add(this.genre_L);
      this.Controls.Add(this.colours_L);
      this.Controls.Add(this.search_B);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "神の閃き Ver.1.3 by YS";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button search_B;
    private System.Windows.Forms.Label colours_L;
    private System.Windows.Forms.Label genre_L;
    private System.Windows.Forms.ComboBox colours_CB;
    private System.Windows.Forms.ComboBox genre_CB;
    private System.Windows.Forms.Label search_L;
    private System.Windows.Forms.TextBox search_TB;
    private System.Windows.Forms.Label result_L;
    private System.Windows.Forms.RichTextBox result_RTB;
    private System.Windows.Forms.Button clearB;

  }
}

