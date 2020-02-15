using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Html5;


namespace FirefoxSeleniumBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        IWebDriver driver;
        FirefoxDriverService fds = FirefoxDriverService.CreateDefaultService(Application.StartupPath, "geckodriver.exe");
        FirefoxOptions options = new FirefoxOptions();

        public async void RunDriver(String proxy, String useragent, String fakelocates)
        {

            
            
            fds.HideCommandPromptWindow = true;
            //FirefoxProfile profile = new FirefoxProfile();

           
            
            if (!String.IsNullOrEmpty(proxy.ToString()))
            {

                Proxy prox = new Proxy();
                prox.HttpProxy = proxy;
                prox.SslProxy = proxy;
                prox.FtpProxy = proxy;
                options.Proxy = prox;
                options.SetPreference("geo.enabled", true);
                options.SetPreference("geo.prompt.testing", true);
                options.SetPreference("geo.prompt.testing.allow", true);
                options.SetPreference("geo.wifi.uri", Application.StartupPath+@"\locations"+fakelocates);
                options.SetPreference("general.useragent.override", useragent);

                //profile.setPreference("permissions.default.desktop-notification", 1);
               
                driver = new FirefoxDriver(fds, options);
            }
            
            await Task.Delay(2000);

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            string[] useragents = File.ReadAllLines(Application.StartupPath + "/useragents.txt");
            string[] proxies = File.ReadAllLines(Application.StartupPath + "/proxies.txt");

            foreach(var item in useragents)
            {
                listBoxuserAgents.Items.Add(item);

            }
            foreach(var item in proxies)
            {
                richTextBoxProxies.Text +=  item + "\n";

            }

            
        }
        

        private async void btnRun_Click(object sender, EventArgs e)
        {

            await Task.Run(async () =>
            {
                try
                {
                    for (int i = 0; i < richTextBoxProxies.Lines.Length; i++)
                    {
                        Random rand = new Random();
                        int randProxy = rand.Next(2, richTextBoxProxies.Lines.Length);

                        if(await Process(randProxy))
                        {
                            listBoxLogs.Items.Add("Başarılı : " + i);
                            listBoxLogs.Items.Add("\n Kullanılan proxy -> " + richTextBoxProxies.Lines[i]);


                        }
                        else
                        {
                            listBoxLogs.Items.Add("Hatalı İşlem" + i);
                            listBoxLogs.Items.Add("\n Kullanılan proxy -> " + richTextBoxProxies.Lines[i]);
                        }


                    }


                }
                catch (Exception ex)
                {

                    listBoxLogs.Items.Add("Hata : " + ex.Message);
                    driver.Quit();
                    throw;

                }








            });

            
        }

        public async Task<bool> Process(int n)
        {

            bool basarili = false;
            try
            {
                Random randm = new Random();
                int useragentuzunluk = listBoxuserAgents.Items.Count;
                int usragentsira = randm.Next(1, useragentuzunluk);
                String useragnt = listBoxuserAgents.Items[usragentsira].ToString();
                String proxy = richTextBoxProxies.Lines[n];
                linkLabeluseragent.Text = useragnt;
                linkLabelpoxy.Text = proxy;
                
                FakeLocates loc = new FakeLocates();
                String fakelocate = loc.locats();
                
                linkLabelLocate.Text = fakelocate;
                RunDriver(proxy, useragnt, fakelocate);
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(240);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(240);
                driver.Navigate().GoToUrl(txtLink.Text);
                if (driver.Title == "Attention Required! | Cloudflare" || driver.Title == "502 Bad Gateway")
                {
                    listBoxLogs.Text += "\n" + " Cloudflare Hatası Tekrar Deneniyor..." + "\n";
                    await Task.Delay(2000);
                    driver.Quit();

                }
                else
                {
                    await Task.Delay(20000);
                    //Link.tl
                    //IWebElement skipAdBtn = driver.FindElement(By.CssSelector("#get_link_btn"));
                    //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", skipAdBtn);
                    //await Task.Delay(5000);
                    //driver.SwitchTo().Window(driver.WindowHandles.First());
                    //((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", skipAdBtn);
                    //await Task.Delay(5000);
                    //driver.SwitchTo().Window(driver.WindowHandles.First());
                    //await Task.Delay(5000);
                    //int rndTime = randm.Next(3000, 10000);
                    //await Task.Delay(rndTime);

                    //#skip_bu2tton

                    IWebElement skipAd2Btn = driver.FindElement(By.CssSelector("#skip_bu2tton"));
                    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", skipAd2Btn);
                    await Task.Delay(5000);
                    driver.SwitchTo().Window(driver.WindowHandles.Last());
                    await Task.Delay(5000);
                    options.SetPreference("permissions.default.desktop-notification", 1);
                    await Task.Delay(5000);
                    








                    basarili = true;
                    await Task.Delay(2000);
                    driver.Quit();



                }
               

               
            }
            catch (Exception ex)
            {

                basarili = false;

                listBoxLogs.Items.Add("Hata :" + ex.Message);
                driver.Quit();

                throw;
            }




            
            return basarili;
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            driver.Quit();
        }

        private void buttonsaveLogs_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
            string file_path = Application.StartupPath + @"\logs.txt";
            FileStream fs = new FileStream(file_path, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            foreach (var item in listBoxLogs.Items)
            {
                File.AppendAllText(file_path, currentTime + "\n" + item.ToString());


            }

            MessageBox.Show("LOG BAŞARI İLE KAYIT EDİLDİ!");

            listBoxLogs.Items.Clear();


        }
    }
}
