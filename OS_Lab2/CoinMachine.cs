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

            recognizer(Int32.Parse(form.inputText.Text));
        }

        private void run_exchange()
        {
            var form = Form.ActiveForm as appForm;

            Thread.Sleep(200);
            exchanger(mail_box, Int32.Parse(form.nominalText.Text));
            
        }

        private void recognizer(int nominal)
        {
            var form = Form.ActiveForm as appForm;

            form.logText.AppendText("Recognizing\n");
            Thread.Sleep(100);
            if (Array.BinarySearch(nominals, nominal) >= 0){
                mail_box = nominal;
                form.logText.AppendText(String.Format("{0} recognized\n", nominal.ToString()));
            }
            else
            {
                form.logText.AppendText(String.Format("Unknown nominal {0}\n", nominal.ToString()));
            }

        }

        private void exchanger(int nominal, int max_nom)
        {
            var form = Form.ActiveForm as appForm;

            form.logText.AppendText("Exchanging\n");
            Thread.Sleep(200);
            if (max_nom <= nominal)
            {
                List<int> res = new List<int>();
                int rest = nominal;

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
                form.logText.AppendText("Exchange nominal is greater then inserted coin.\n");
            }
            mail_box = 0;
        }
    }
}
