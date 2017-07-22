namespace NEST
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
            this.btnIndexArtCollecetion = new System.Windows.Forms.Button();
            this.btnIndexForeignLanguage = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbArtCollecetion = new System.Windows.Forms.TabPage();
            this.btnCreateClientArtCollecetion = new System.Windows.Forms.Button();
            this.txtArtCollecetionResult = new System.Windows.Forms.TextBox();
            this.txtCollectionIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCollectionUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpForeignLanguage = new System.Windows.Forms.TabPage();
            this.btnCreateClientForeignLanguage = new System.Windows.Forms.Button();
            this.txtForeignLanguageResult = new System.Windows.Forms.TextBox();
            this.txtLanuageIndex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLanuageUri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.termArtCollecetion = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.termForeignLanguage = new System.Windows.Forms.TextBox();
            this.resultForeignLanguage = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tbArtCollecetion.SuspendLayout();
            this.tpForeignLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIndexArtCollecetion
            // 
            this.btnIndexArtCollecetion.Location = new System.Drawing.Point(15, 75);
            this.btnIndexArtCollecetion.Name = "btnIndexArtCollecetion";
            this.btnIndexArtCollecetion.Size = new System.Drawing.Size(80, 23);
            this.btnIndexArtCollecetion.TabIndex = 0;
            this.btnIndexArtCollecetion.Text = "인덱싱";
            this.btnIndexArtCollecetion.UseVisualStyleBackColor = true;
            this.btnIndexArtCollecetion.Click += new System.EventHandler(this.btnIndexArtCollecetion_Click);
            // 
            // btnIndexForeignLanguage
            // 
            this.btnIndexForeignLanguage.Location = new System.Drawing.Point(15, 75);
            this.btnIndexForeignLanguage.Name = "btnIndexForeignLanguage";
            this.btnIndexForeignLanguage.Size = new System.Drawing.Size(80, 23);
            this.btnIndexForeignLanguage.TabIndex = 1;
            this.btnIndexForeignLanguage.Text = "인덱싱";
            this.btnIndexForeignLanguage.UseVisualStyleBackColor = true;
            this.btnIndexForeignLanguage.Click += new System.EventHandler(this.btnIndexForeignLanguage_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbArtCollecetion);
            this.tabControl.Controls.Add(this.tpForeignLanguage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(10, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(964, 641);
            this.tabControl.TabIndex = 3;
            // 
            // tbArtCollecetion
            // 
            this.tbArtCollecetion.Controls.Add(this.textBox1);
            this.tbArtCollecetion.Controls.Add(this.termArtCollecetion);
            this.tbArtCollecetion.Controls.Add(this.btnCreateClientArtCollecetion);
            this.tbArtCollecetion.Controls.Add(this.txtArtCollecetionResult);
            this.tbArtCollecetion.Controls.Add(this.txtCollectionIndex);
            this.tbArtCollecetion.Controls.Add(this.label2);
            this.tbArtCollecetion.Controls.Add(this.txtCollectionUri);
            this.tbArtCollecetion.Controls.Add(this.label1);
            this.tbArtCollecetion.Controls.Add(this.btnIndexArtCollecetion);
            this.tbArtCollecetion.Location = new System.Drawing.Point(4, 22);
            this.tbArtCollecetion.Name = "tbArtCollecetion";
            this.tbArtCollecetion.Padding = new System.Windows.Forms.Padding(3);
            this.tbArtCollecetion.Size = new System.Drawing.Size(956, 615);
            this.tbArtCollecetion.TabIndex = 0;
            this.tbArtCollecetion.Text = "서울시립미술관 소장품 정보";
            this.tbArtCollecetion.UseVisualStyleBackColor = true;
            // 
            // btnCreateClientArtCollecetion
            // 
            this.btnCreateClientArtCollecetion.Location = new System.Drawing.Point(364, 12);
            this.btnCreateClientArtCollecetion.Name = "btnCreateClientArtCollecetion";
            this.btnCreateClientArtCollecetion.Size = new System.Drawing.Size(120, 23);
            this.btnCreateClientArtCollecetion.TabIndex = 6;
            this.btnCreateClientArtCollecetion.Text = "클라이언트 생성";
            this.btnCreateClientArtCollecetion.UseVisualStyleBackColor = true;
            this.btnCreateClientArtCollecetion.Click += new System.EventHandler(this.btnCreateClientArtCollecetion_Click);
            // 
            // txtArtCollecetionResult
            // 
            this.txtArtCollecetionResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArtCollecetionResult.Location = new System.Drawing.Point(15, 108);
            this.txtArtCollecetionResult.Multiline = true;
            this.txtArtCollecetionResult.Name = "txtArtCollecetionResult";
            this.txtArtCollecetionResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArtCollecetionResult.Size = new System.Drawing.Size(925, 207);
            this.txtArtCollecetionResult.TabIndex = 5;
            // 
            // txtCollectionIndex
            // 
            this.txtCollectionIndex.Location = new System.Drawing.Point(128, 40);
            this.txtCollectionIndex.Name = "txtCollectionIndex";
            this.txtCollectionIndex.Size = new System.Drawing.Size(200, 21);
            this.txtCollectionIndex.TabIndex = 4;
            this.txtCollectionIndex.Text = "seoul_art_collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "기본 Index:";
            // 
            // txtCollectionUri
            // 
            this.txtCollectionUri.Location = new System.Drawing.Point(128, 13);
            this.txtCollectionUri.Name = "txtCollectionUri";
            this.txtCollectionUri.Size = new System.Drawing.Size(200, 21);
            this.txtCollectionUri.TabIndex = 2;
            this.txtCollectionUri.Text = "http://localhost:9200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elasticsearch URI:";
            // 
            // tpForeignLanguage
            // 
            this.tpForeignLanguage.Controls.Add(this.resultForeignLanguage);
            this.tpForeignLanguage.Controls.Add(this.termForeignLanguage);
            this.tpForeignLanguage.Controls.Add(this.btnCreateClientForeignLanguage);
            this.tpForeignLanguage.Controls.Add(this.txtForeignLanguageResult);
            this.tpForeignLanguage.Controls.Add(this.txtLanuageIndex);
            this.tpForeignLanguage.Controls.Add(this.label3);
            this.tpForeignLanguage.Controls.Add(this.txtLanuageUri);
            this.tpForeignLanguage.Controls.Add(this.label4);
            this.tpForeignLanguage.Controls.Add(this.btnIndexForeignLanguage);
            this.tpForeignLanguage.Location = new System.Drawing.Point(4, 22);
            this.tpForeignLanguage.Name = "tpForeignLanguage";
            this.tpForeignLanguage.Padding = new System.Windows.Forms.Padding(3);
            this.tpForeignLanguage.Size = new System.Drawing.Size(956, 615);
            this.tpForeignLanguage.TabIndex = 1;
            this.tpForeignLanguage.Text = "서울시 외국어 표기 정보";
            this.tpForeignLanguage.UseVisualStyleBackColor = true;
            // 
            // btnCreateClientForeignLanguage
            // 
            this.btnCreateClientForeignLanguage.Location = new System.Drawing.Point(364, 12);
            this.btnCreateClientForeignLanguage.Name = "btnCreateClientForeignLanguage";
            this.btnCreateClientForeignLanguage.Size = new System.Drawing.Size(120, 23);
            this.btnCreateClientForeignLanguage.TabIndex = 10;
            this.btnCreateClientForeignLanguage.Text = "클라이언트 생성";
            this.btnCreateClientForeignLanguage.UseVisualStyleBackColor = true;
            this.btnCreateClientForeignLanguage.Click += new System.EventHandler(this.btnCreateClientForeignLanguage_Click);
            // 
            // txtForeignLanguageResult
            // 
            this.txtForeignLanguageResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtForeignLanguageResult.Location = new System.Drawing.Point(15, 108);
            this.txtForeignLanguageResult.Multiline = true;
            this.txtForeignLanguageResult.Name = "txtForeignLanguageResult";
            this.txtForeignLanguageResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtForeignLanguageResult.Size = new System.Drawing.Size(925, 207);
            this.txtForeignLanguageResult.TabIndex = 9;
            // 
            // txtLanuageIndex
            // 
            this.txtLanuageIndex.Location = new System.Drawing.Point(128, 40);
            this.txtLanuageIndex.Name = "txtLanuageIndex";
            this.txtLanuageIndex.Size = new System.Drawing.Size(200, 21);
            this.txtLanuageIndex.TabIndex = 8;
            this.txtLanuageIndex.Text = "seoul_foreign_language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "기본 Index:";
            // 
            // txtLanuageUri
            // 
            this.txtLanuageUri.Location = new System.Drawing.Point(128, 13);
            this.txtLanuageUri.Name = "txtLanuageUri";
            this.txtLanuageUri.Size = new System.Drawing.Size(200, 21);
            this.txtLanuageUri.TabIndex = 6;
            this.txtLanuageUri.Text = "http://localhost:9200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Elasticsearch URI:";
            // 
            // termArtCollecetion
            // 
            this.termArtCollecetion.Location = new System.Drawing.Point(15, 331);
            this.termArtCollecetion.Name = "termArtCollecetion";
            this.termArtCollecetion.Size = new System.Drawing.Size(200, 21);
            this.termArtCollecetion.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(15, 367);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(925, 234);
            this.textBox1.TabIndex = 8;
            // 
            // termForeignLanguage
            // 
            this.termForeignLanguage.Location = new System.Drawing.Point(15, 331);
            this.termForeignLanguage.Name = "termForeignLanguage";
            this.termForeignLanguage.Size = new System.Drawing.Size(200, 21);
            this.termForeignLanguage.TabIndex = 11;
            this.termForeignLanguage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.termForeignLanguage_KeyUp);
            // 
            // resultForeignLanguage
            // 
            this.resultForeignLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultForeignLanguage.Location = new System.Drawing.Point(15, 367);
            this.resultForeignLanguage.Multiline = true;
            this.resultForeignLanguage.Name = "resultForeignLanguage";
            this.resultForeignLanguage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultForeignLanguage.Size = new System.Drawing.Size(925, 234);
            this.resultForeignLanguage.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elasticsearch - NEST API";
            this.tabControl.ResumeLayout(false);
            this.tbArtCollecetion.ResumeLayout(false);
            this.tbArtCollecetion.PerformLayout();
            this.tpForeignLanguage.ResumeLayout(false);
            this.tpForeignLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIndexArtCollecetion;
        private System.Windows.Forms.Button btnIndexForeignLanguage;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tbArtCollecetion;
        private System.Windows.Forms.TabPage tpForeignLanguage;
        private System.Windows.Forms.TextBox txtCollectionIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCollectionUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLanuageIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLanuageUri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArtCollecetionResult;
        private System.Windows.Forms.TextBox txtForeignLanguageResult;
        private System.Windows.Forms.Button btnCreateClientArtCollecetion;
        private System.Windows.Forms.Button btnCreateClientForeignLanguage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox termArtCollecetion;
        private System.Windows.Forms.TextBox resultForeignLanguage;
        private System.Windows.Forms.TextBox termForeignLanguage;
    }
}

