using CsvHelper;
using Nest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEST
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ElasticClient collectionClient;
        private ElasticClient languageClient;

        private void btnCreateClientArtCollecetion_Click(object sender, EventArgs e)
        {
            try
            {
                var collectionSettings = new ConnectionSettings(new Uri(txtCollectionUri.Text)).DefaultIndex(txtCollectionIndex.Text);
                this.collectionClient = new ElasticClient(collectionSettings);

                btnCreateClientArtCollecetion.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnIndexArtCollecetion_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"..\..\서울시립미술관 소장품 정보.csv"))
            {
                var csv = new CsvReader(reader);
                csv.Configuration.RegisterClassMap<ArtCollecetionMap>();

                var records = csv.GetRecords<ArtCollecetion>();
                foreach (ArtCollecetion artCollecetion in records)
                {
                    var asyncIndexResponse = await this.collectionClient.IndexAsync(artCollecetion);

                    txtArtCollecetionResult.AppendText("Id:" + asyncIndexResponse.Id + ", Version: " + asyncIndexResponse.Version + ", Result: " + asyncIndexResponse.Result + ", Title: " + artCollecetion.TitleKorean + " (" + artCollecetion.TitleEnglish + ")" + Environment.NewLine);
                    txtArtCollecetionResult.ScrollToCaret();
                }
            }
        }

        private void btnCreateClientForeignLanguage_Click(object sender, EventArgs e)
        {
            try
            {
                var languageSettings = new ConnectionSettings(new Uri(txtLanuageUri.Text)).DefaultIndex(txtLanuageIndex.Text);
                this.languageClient = new ElasticClient(languageSettings);

                btnCreateClientForeignLanguage.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnIndexForeignLanguage_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(@"..\..\서울시 외국어 표기 정보.csv"))
            {
                var csv = new CsvReader(reader);
                csv.Configuration.RegisterClassMap<ForeignLanguageMap>();

                var records = csv.GetRecords<ForeignLanguage>();
                foreach (ForeignLanguage lanuage in records)
                {
                    var asyncIndexResponse = await this.languageClient.IndexAsync(lanuage);
                    txtForeignLanguageResult.AppendText("Id:" + asyncIndexResponse.Id + ", Version: " + asyncIndexResponse.Version + ", Result: " + asyncIndexResponse.Result + ", Title: " + lanuage.Korean + " (" + lanuage.English + ")" + Environment.NewLine);

                    txtForeignLanguageResult.ScrollToCaret();
                }
            }
        }

        private async void termForeignLanguage_KeyUp(object sender, KeyEventArgs e)
        {
            resultForeignLanguage.Clear();

            if (termForeignLanguage.Text.Trim().Length == 0)
            {
                return;
            }

            var searchResults = await this.languageClient.SearchAsync<ForeignLanguage>(s => s
               .Query(q => q
                   .Bool(b => b
                       .Must(m => m
                            .Wildcard(w => w.Field(p => p.Korean).Value(termForeignLanguage.Text + "*") 
                            )
                        )
                   )
               ).Size(20)  
            );
            
            resultForeignLanguage.SuspendLayout();
            foreach (var document in searchResults.Documents)
            {
                resultForeignLanguage.AppendText(document.Korean + " / " + document.English + " / " + document.SimplifiedChinese + " / " + document.TraditionalChinese + " / " + document.Japanese + Environment.NewLine);
            }
            resultForeignLanguage.ResumeLayout();
        }
    }

}
