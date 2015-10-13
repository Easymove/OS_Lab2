using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OS_Lab2
{
    class CoinMachine
    {
        Semaphore s_rec = new Semaphore(1, 1);
        Semaphore s_xch = new Semaphore(0, 1);
        public int[] nominals = { 1, 2, 5, 10, 25, 50, 100 };
        public int[] counts = { 10, 10, 10, 5, 2, 2, 2 };
        private int mail_box = 0;

        public void run()
        {
            var form = Form.ActiveForm as appForm;

            Thread rec_thread = new Thread(run_recognizer);
            Thread xch_thread = new Thread(run_exchange);

            //form.logText.AppendText("Starting recognizer.\n");
            rec_thread.Start();
            //form.logText.AppendText("Starting exchanger.\n");
            xch_thread.Start();

        }

        private void run_recognizer()
        {
            var form = Form.ActiveForm as appForm;
            form.startButton.Enabled = false;

            recognizer(Int32.Parse(form.inputText.Text));
        }

        private void run_exchange()
        {
            var form = Form.ActiveForm as appForm;

            exchanger(Int32.Parse(form.nominalText.Text));
            
            form.startButton.Enabled = true;
        }

        private void recognizer(int nominal)
        {
            s_rec.WaitOne();
            
            var form = Form.ActiveForm as appForm;

            form.logText.AppendText("Recognizing\n");
            Thread.Sleep(3000);

            if (Array.BinarySearch(nominals, nominal) >= 0){
                mail_box = nominal;
                form.logText.AppendText(String.Format("{0} recognized\n", nominal.ToString()));
            }
            else
            {
                form.logText.AppendText(String.Format("Unknown nominal {0}\n", nominal.ToString()));
            }
            s_xch.Release();
        }

        private void exchanger(int max_nom)
        {
            s_xch.WaitOne();
            
            var form = Form.ActiveForm as appForm;

            form.logText.AppendText("Exchanging\n");
            Thread.Sleep(1000);

            if (max_nom <= mail_box)
            {
                List<int> res = new List<int>();
                int rest = mail_box;

                int ind = Array.BinarySearch(nominals, max_nom);
                int [] tmp_arr = new int[ind + 1];
                Array.Copy(nominals, tmp_arr, ind + 1);

                foreach (int i in tmp_arr.Reverse())
                {
                    if (rest != 0 && counts[Array.BinarySearch(nominals, i)] > 0)
                    {
                        int tmp = rest / i;
                        int to_add = tmp < counts[Array.BinarySearch(nominals, i)] ? tmp : counts[Array.BinarySearch(nominals, i)];   
                        
                        for (int j = 0; j < to_add; j++)
                        {
                            res.Add(i);
                        }
                        counts[Array.BinarySearch(nominals, i)] -= to_add;
                        rest = rest - i * to_add;
                    }
                }

                if (rest == 0)
                {
                    form.logText.AppendText(String.Format("Exchanging finished. Result: {0}\n", String.Join("  ", res.ToArray())));
                    form.resText.Text = String.Join("  ", res.ToArray());
                    form.restText.Text = "[1, 2, 5, 10, 25, 50, 100]  ::  " + String.Join("  ", counts);
                }
                else
                {
                    form.logText.AppendText("Not enough coins.\n");
                }
            }
            else
            {
                form.logText.AppendText(String.Format("Cannot exchange. {0} > {1}\n", max_nom, mail_box));
            }
            mail_box = 0;
            s_rec.Release();
        }
    }
}
