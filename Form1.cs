using System;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiT_Toolbox
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("sc.exe", "Stop Spooler");
            Process.Start("sc.exe", "Start Spooler");
            MessageBox.Show("Gotowe");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //  I have a problem with changing the service start mode

            Process.Start("sc.exe", "Start WdiServiceHost");

            Process.Start("sc.exe", "config [XboxGipSvc] start= demand");
            Process.Start("sc.exe", "Config [XblAuthManager] state= demand");
            Process.Start("sc.exe", "Config [XblGameSave] state= demand");
            Process.Start("sc.exe", "Config [xboxgip] state= demand");
            Process.Start("sc.exe", "Config [vds] state= demand");
            Process.Start("sc.exe", "Config [WdiSystemHost] state= demand");
            Process.Start("sc.exe", "Config [wscsvc] state= auto");
            Process.Start("Sc.exe", "Start wscsvc");
            Process.Start("sc.exe", "Config [DPS] state= auto");
            Process.Start("sc.exe", "Start DPS");
            Process.Start("sc.exe", "Config [diagsvc] state= demand");
            Process.Start("sc.exe", "Config [VSS] state= demand");
            Process.Start("sc.exe", "Config [SDRSVC] state= demand");
            Process.Start("sc.exe", "Config [swprv] state= demand");
            Process.Start("sc.exe", "config start= auto BITS");
            Process.Start("sc.exe", "Start BITS");
            Process.Start("sc.exe", "Config [PcaSvc] state= demand");
            Process.Start("sc.exe", "Start PcaSvc");
            Process.Start("sc.exe", "Config [WerSvc] state= demand");
            Process.Start("sc.exe", "Config [SecurityHealthService] state= demand");
            MessageBox.Show("Services set to Safe mode");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  I have a problem with changing the service start mode
            Process.Start("sc.exe", "Stop WdiServiceHost");
            Process.Start("sc.exe", "config [WdiServiceHost] state= disabled");
            Process.Start("sc.exe", "Stop XboxGipSvc");
            Process.Start("sc.exe", "config [XboxGipSvc] state= disabled");
            Process.Start("sc.exe", "Stop XblAuthManager");
            Process.Start("sc.exe", "config [XblAuthManager] state= disabled");
            Process.Start("sc.exe", "Stop XblGameSave");
            Process.Start("sc.exe", "config [XblGameSave] state= disabled");
            Process.Start("sc.exe", "Stop xboxgip");
            Process.Start("sc.exe", "config [xboxgip] state= disabled");
            Process.Start("sc.exe", "Stop vds");
            Process.Start("sc.exe", "config vds state= disabled");
            Process.Start("sc.exe", "Stop WdiSystemHost");
            Process.Start("sc.exe", "config [WdiSystemHost] state= disabled");
            Process.Start("Sc.exe", "Stop wscsvc");
            Process.Start("sc.exe", "config [wscsvc] state= disabled");
            Process.Start("sc.exe", "Stop DPS");
            Process.Start("sc.exe", "config [DPS] state= disabled");
            Process.Start("sc.exe", "Stop diagsvc");
            Process.Start("sc.exe", "config [diagsvc] state= disabled");
            Process.Start("sc.exe", "Stop VSS");
            Process.Start("sc.exe", "config [VSS] state= disabled");
            Process.Start("sc.exe", "Stop SDRSVC");
            Process.Start("sc.exe", "Config [SDRSVC] state= disabled");
            Process.Start("sc.exe", "Stop swprv");
            Process.Start("sc.exe", "Config [swprv] state= disabled");
            Process.Start("sc.exe", "Stop BITS");
            Process.Start("sc.exe", "Config [BITS] state= disabled");
            Process.Start("sc.exe", "Stop PcaSvc");
            Process.Start("sc.exe", "Config [PcaSvc] state= disabled");
            Process.Start("sc.exe", "Stop WerSvc");
            Process.Start("sc.exe", "Config [WerSvc] state= disabled");
            Process.Start("sc.exe", "Stop SecurityHealthService");
            Process.Start("sc.exe", "Config [SecurityHealthService] state= disabled");
            MessageBox.Show("Services set to Extreme mode");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Fixing error %Windir\Temp%  Permisions 
            // My knowledge of C # is too little to write this
            MessageBox.Show("Fixed Error 2503 reboot required ");
            Process.Start("shutdown.exe", "-r -t 10");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string root = @"C:\Temp";
            if (!Directory.Exists(root))

                Directory.CreateDirectory(root);

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://adwcleaner.pl/wp-content/uploads/program/adwcleaner_8.2.exe", @"c:\Temp\adw.exe");
            Directory.SetCurrentDirectory(root);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Process p = new Process();
            p.StartInfo.FileName = "adw.exe";
            p.StartInfo.Arguments = @"c:\Temp\adw.exe /eula /clean /preinstalled /noreboot";
            p.Start();



            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://devbuilds.s.kaspersky-labs.com/devbuilds/KVRT/latest/full/KVRT.exe", @"c:\Temp\KVRT.exe");
            Directory.SetCurrentDirectory(root);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Process.Start(@"c:\Temp\KVRT.exe");

            p.WaitForExit();
            MessageBox.Show("Skanowanie zakończone");

        }
          
        private void button6_Click(object sender, EventArgs e)
        {
            string root = @"C:\Temp";
            if (!Directory.Exists(root))

                Directory.CreateDirectory(root);

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://github.com/kamiloxf/w10/releases/download/1/VisualCppRedist_AIO_x86_x64.exe", @"c:\Temp\VisualCppRedist_AIO_x86_x64.exe");
            Directory.SetCurrentDirectory(root);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Process.Start(@"c:\Temp\VisualCppRedist_AIO_x86_x64.exe");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string root = @"C:\Temp";
            if (!Directory.Exists(root))

                Directory.CreateDirectory(root);

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://github.com/kamiloxf/w10/releases/download/1/DXrtAiO.exe", @"c:\Temp\dx.exe");
            Directory.SetCurrentDirectory(root);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Process.Start(@"c:\Temp\dx.exe");
            MessageBox.Show("DirectX Zainstalowany");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Windows Activator
            // My knowledge of C # is too little to write this
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string root = @"C:\Dodatki";
            if (!Directory.Exists(root))

                Directory.CreateDirectory(root);


            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://download.cpuid.com/cpu-z/cpu-z_1.95-en.exe", @"c:\Dodatki\cpu-z.exe");
            Directory.SetCurrentDirectory(root);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Process c = new Process();
            c.StartInfo.FileName = "cpu-z.exe";
            c.StartInfo.Arguments = @"c:\Dodatki\cpu-z.exe /silent";
            c.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string root = @"C:\Dodatki";
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient webClient = new WebClient())
                webClient.DownloadFile("https://github.com/kamiloxf/w10/releases/download/1/GPU-Z.exe", @"c:\Dodatki\gpu-z.exe");
            Directory.SetCurrentDirectory(root);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Process g = new Process();
            g.StartInfo.FileName = "gpu-z.exe";
            g.StartInfo.Arguments = @"c:\Dodatki\gpu-z.exe /silent";
            g.Start();
        }
    }
}
