using System;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
namespace SystemTest
{
   

    public partial class MainWindow : Form
    {
        private static Thread t1 = new Thread(new ThreadStart(doCPU));
        private static Thread t3 = new Thread(new ThreadStart(doCPU));
        private static Thread t5 = new Thread(new ThreadStart(doCPU));

        private static Thread t2 = new Thread(new ThreadStart(doIO));
        private static Thread t4 = new Thread(new ThreadStart(doIO));
        private static Thread t6 = new Thread(new ThreadStart(doIO));
        private static string basePath = @"C:\ECSTest\";
        public MainWindow()
        {

            InitializeComponent();
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }

            autoExcute();
            //this.cpustop.Enabled = false;
            //this.yingpanstop.Enabled = false;
        }

        private  void autoExcute()
        {
           
            this.cpustart.Enabled = false;
            this.yingpanstart.Enabled = false;

            this.cpustop.Enabled = true;
            this.yingpanstop.Enabled = true;


            t1.Start();
            t2.Start();
            t3.Start();
            t5.Start();

        }
        private void cpustart_Click(object sender, EventArgs e)
        {
            this.cpustart.Enabled = false;
            this.cpustop.Enabled = true;
            try
            {
                t1.Start();
                t3.Start();
                t5.Start();

            }
            catch(ThreadStateException eve)
            {
                Console.WriteLine(eve.Message);
                t1 = new Thread(new ThreadStart(doCPU));
                t3 = new Thread(new ThreadStart(doCPU));
                t5 = new Thread(new ThreadStart(doCPU));

                t1.Start();
                t3.Start();
                t5.Start();

            }
          
        }

        private void cpustop_Click(object sender, EventArgs e)
        {
            t1.Abort();
            t3.Abort();
            t5.Abort();
            this.cpustart.Enabled = true;
            this.cpustop.Enabled = false;
            
        }

        private void yingpanstart_Click(object sender, EventArgs e)
        {
            this.yingpanstart.Enabled = false;
            this.yingpanstop.Enabled = true;

            try
            {
                t2.Start();
            }
            catch (ThreadStateException eve)
            {
                t2=new Thread(new ThreadStart(doIO));
                t2.Start();
                Console.WriteLine(eve.Message);
            }

        }

        private void yingpanstop_Click(object sender, EventArgs e)
        {
            t2.Abort();
            this.yingpanstart.Enabled = true;
            this.yingpanstop.Enabled = false;
           
        }

        private static void doCPU()
        {
            bool l = true;
            while(l)
            {
                l = !l;
                while (!l) l = !l;
            }
        }
        private static void doIO()
        {
            int i = 1;
            int j = 1;
            while(j<500)
            {
                string path=basePath+"new"+j+"\\";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                while(i<500)
                {
                    readAndWriteFile(path);
                    i++;
                }
                j--;
            }


        }
        private static void readAndWriteFile(string path)
        {
            FileStream fs; //声明文件流的对象  
            StreamReader sr; //声明读取器的对象  
           
            string read_path = @"file\test1.doc";
            try  
            {   
                fs = new FileStream(read_path,  //文件路径                                       
                        FileMode.Open, //打开文件的方式  
                         FileAccess.ReadWrite, //控制对文件的读写  
                        FileShare.None);  //控制其它进程对此文件的访问  
                   sr = new StreamReader(fs, Encoding.Default);  
                   string str = sr.ReadToEnd();
                   
                   string wpath = path + "new" + DateTime.Now.ToFileTimeUtc() + ".doc";
                   //Console.WriteLine(wpath);

                   StreamWriter sw = new StreamWriter(wpath);

                   sw.WriteLine(str);
                   sw.Flush();
                   sw.Close();
                   sr.Close();
                   fs.Close();
             }  
             catch (Exception ex)  
             {  
                    MessageBox.Show("读文件操作异常：" + ex.Message+path);  
             }  
             finally  
             {  
             }  

        }
        private static void doMemory()
        {

        }
        private static void doNetwork()
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
