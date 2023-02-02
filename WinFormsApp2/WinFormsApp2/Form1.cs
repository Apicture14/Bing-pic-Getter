using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;
using System.Xml.Linq;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom;

namespace WinFormsApp2
{
    public partial class Form1 : MaterialForm
    {
        public readonly MaterialSkinManager m;
        public SynchronizationContext syn;
        public string fname = "";
        public string link = "";
        public enum LogLevel
        {
            Debug=0,
            Info,
            Warning,
            Error
        }
        public Form1()
        {
            InitializeComponent();

            m = MaterialSkinManager.Instance;

            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.AddFormToManage(this);

            syn = SynchronizationContext.Current;
            Log("Form Inited");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            Log("Btn_Get Clicked!");
            try
            {

                int page = int.Parse(this.Pagein.Text);
                int index = int.Parse(this.Idxin.Text);

                Log($"Get p:{page} i:{index}");
                Thread t = new Thread(new ParameterizedThreadStart(Get));
                t.Name = "Get Thread";
                t.IsBackground = true;
                t.Start((object)new int[2] { page, index });

                Log($"Thread {t.Name} started to Get Pic");

                btn_download.Enabled = false;
                btn_clear.Enabled = true;

                Log("Btn_Get Finished!");

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log(ex.ToString(),LogLevel.Error);
            }
        }
        private void Get(object source)
        {
            try
            {
                Log("Func Get Started!");
                int page = ((int[])source)[0], index = ((int[])source)[1];
                Log($"Get p:{page} i:{index}");
                string url = $@"https://bing.ioliu.cn/?p={page}";
                Log($"Target url:{url}");
                WebClient wc = new WebClient();
                Log($"WebCilent {wc} created");
                wc.Headers.Add("user-agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36 Edg/108.0.1462.76");
                Log("Added Headers");
                Stream s = wc.OpenRead(url);
                HtmlDocument h = new HtmlDocument();
                h.LoadHtml(new StreamReader(s).ReadToEnd());

                Log($"Html obj get {h}");

                HtmlNode con = h.DocumentNode.SelectSingleNode("/html/body/div[3]");
                HtmlNode tar = con.ChildNodes[index];
                HtmlNode downloadn = tar.ChildNodes[0].ChildNodes[3].ChildNodes[2];
                HtmlNode descn = tar.ChildNodes[0].ChildNodes[2].ChildNodes[0];

                string imgl = downloadn.Attributes["href"].Value;
                Log($"Get Image Link: {imgl}");
                string desc = descn.InnerHtml;
                Log($"Get Description Text: {desc}");
                fname = downloadn.Attributes["title"].Value;
                link = imgl;

                syn.Post(update, new string[2] { imgl, desc });
                Log("Request posted");
                Log("Func Get Finished!");
            }
            catch (Exception ex)
            {
                Log(ex.ToString(),LogLevel.Error);
                MessageBox.Show(ex.Message,"错误!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            //MessageBox.Show($"{imgl},{desc}");

            
        }
        private void update(object con)
        {
            Log("Func Update Started!");
            string[] cons = (string[])con;
            this.srcout.Text = cons[0];
            this.desout.Text = cons[1];

            Log("Imgl desc, result presented");

            btn_copy.Enabled = true;
            btn_get.Enabled = true;
            cd_d.BackColor = Color.Yellow;
            l_download.Text = "检测链接有效性";

            

            Thread t = new Thread(new ParameterizedThreadStart(Verify));
            t.Name = "Verify Thread";
            Log($"Verify Thread {t.Name} created with {link}");
            t.IsBackground= true;
            t.Start((object) link);
            Log("Func Update Finished!");
        }
        private void Verify(object url)
        {
            Log("Func Verify Started!");
            bool? resb = null;
            try
            {
                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create((string)url);
                Log($"Request to {(string)url} created");
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                if (res == null)
                {
                 resb= false;
                    Log($"Invaild Link {(string)url}", LogLevel.Warning);
                }
                else
                {
                    resb= true;
                    Log($"Vaild Link {(string) url}");
                }
            }catch(Exception ex)
            {
                resb= false;
                Log(ex.ToString(),LogLevel.Error);
            }
            finally
            {
                syn.Post(Show_res,(object)resb);
                Log("Request posted");
                Log("Func Verify Finished!");
            }
        }
        private void Show_res(object res)
        {
            Log("Func Show_res Started!");
            bool r = (bool)res;
            Log($"res:{r}");
            if (r)
            {
                cd_d.BackColor = Color.Green;
                l_download.Text = "链接有效!";
                btn_download.Enabled = true;
             
                if (cb_name.Checked)
                {
                    namein.Text = fname;
                }
            }
            else
            {
                cd_d.BackColor = Color.Red;
                l_download.Text = "链接失效!";
                btn_download.Enabled = false;
            }
            Log("Func Show_res Finished!");
        }

        private void cb_name_CheckedChanged(object sender, EventArgs e)
        {
            Log("Func CheckBox_handler Started!");
            bool c = cb_name.Checked;
            Log($"Checked:{cb_name.Checked}");
            if (c)
            {
                namein.Enabled = false;
                namein.Text = fname;
            }
            else
            {
                namein.Enabled = true;
                namein.Text = "";
            }
            Log("Func CheckBox_handler Finished!");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Log("Func clear Started!");
            srcout.Clear();
            desout.Clear();
            btn_copy.Enabled = false;
            btn_download.Enabled = false;
            l_download.Text = "等待获取";
            fname = "";
            link = "";
            if (cb_name.Checked) { namein.Text = ""; }
            Log("Func clear Finished!");
        }
        private void Log(string msg, LogLevel level = LogLevel.Info)
        {
            string levelt = "";
            switch ((int)level)
            {
                case 0:
                    levelt = "Debug";
                    break;
                case 1:
                    levelt = "Info";
                    break;
                case 2:
                    levelt = "Warning";
                    break;
                case 3:
                    levelt = "Error";
                    break;
            }
            string logt = "[" + DateTime.Now.ToShortTimeString() + "]" + $" {levelt}: " + msg + "\n";
            syn.Post(log, (object)logt);
        }

        private void log(object logt)
        {
            this.output.AppendText((string)logt);
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            Log("Btn_download Clicked!");
            try
            {
                string path = pathin.Text;
                string name = namein.Text + ".jpg";
                Log($"Get path: {path},name: {name}");
                if (Directory.Exists(path))
                {
                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("文件名不能为空!","警告!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        throw new Exception();
                    }
                    
                }
                else
                {
                    MessageBox.Show("不存在的路径!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception();
                }

                Thread t = new Thread(new ParameterizedThreadStart(download));
                t.Name = "Download Thread";
                Log($"download Thread {t.Name} created with {link} -> {path} ");
                t.IsBackground = true;
                t.Start((object)new string[2] { link, path });
                Log("Thread Started");
                Log("Btn_download Finished!");

            }
            catch (Exception ex)
            {
                Log(ex.ToString(), LogLevel.Error);
            }
        }
            
        private void download(object par)
        {
            Log("Func download Started!");
            string url = ((string[])par)[0];
            string path = ((string[])par)[1];

            Log($"Get url:{url},path:{path}");

            WebClient wc = new WebClient();
            Log($"WebCilent {wc} created, start download");
                wc.DownloadFile(url, path);
                MessageBox.Show($"下载{url}到{path}完成!");
            Log($"Download Finished {url}->{path}");
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            Log("Btn_beowse Clicked!");
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.RootFolder = Environment.SpecialFolder.DesktopDirectory;
            Log($"Created new Dialog with Root: {d.RootFolder}");
            if (d.ShowDialog() == DialogResult.OK)
            {
                Log($"Selected path: {d.SelectedPath}");
                this.pathin.Text = d.SelectedPath;
            }
        
                }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            btn_clear.Enabled = true;
            namein.Enabled = true;
            cb_name.Checked = false;
            cb_name.Enabled = false;

            WebClient wc = new WebClient();
            Stream s = wc.OpenRead("https://cn.bing.com");
            string hh = new StreamReader(s).ReadToEnd();
            HtmlDocument h = new HtmlDocument();
            h.LoadHtml(hh);
            HtmlNode n = h.DocumentNode.SelectSingleNode("//*[@id=\"preloadBg\"]");
            string imgl = n.Attributes["href"].Value;
            link = imgl;
            syn.Post(update, (object)new string[2] { imgl, "快速获取无描述" });


        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.srcout.Text);
        }
    }
}