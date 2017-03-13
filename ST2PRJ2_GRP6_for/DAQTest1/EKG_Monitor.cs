using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ST2Prj2LibNI_DAQ;

namespace ST2PRJ2_GRP6_for
{
    public partial class EKG_Monitor : Form
    {
        NI_DAQVoltage dataCollector;
        List<double> dataListe;

        public EKG_Monitor()
        {
            InitializeComponent();
            dataListe = new List<double>();

            dataCollector = new NI_DAQVoltage();
            dataCollector.rangeMaximumVolt = 5;
            dataCollector.sampleRateInHz = 500;
            dataCollector.samplesPerChannel = 5000;
        }

        private void btnReadEKG_Click(object sender, EventArgs e)
        {
            btnReadEKG.Enabled = false;

            dataListe.Clear();
            chartEKG.Series["EKG"].Points.Clear();

            double x = 0;

            for (int i = 0; i < 100; i++)
            {
                dataListe.Add(0.0);
            }

            for (int i = 0; i < 100; i++)
            {
                dataListe.Add(1.0);
            }

            for (int i = 0; i < 100; i++)
            {
                dataListe.Add(0.0);
            }

            dataCollector.getVoltageSeqBlocking();

            foreach(var ele in dataCollector.currentVoltageSeq)
            {
                dataListe.Add(ele);
            }            

            foreach (var ele in dataListe)
            {
                double y = ele;
                chartEKG.Series["EKG"].Points.AddXY(x, y);
                x += 0.002;
            }

            txtBoxPulse.Text = Convert.ToString(findPuls(dataListe));

            txtBoxHRV.Text = Convert.ToString(findHRV(dataListe));

            btnReadEKG.Enabled = true;

            return;
        }

        private List<double> findToppunkt(List<double> inputListe)
        {
            List<double> toppunktsListe = new List<double>();
            double maxValue = 0;


            List<double> last10 = new List<double>();
            for(int i = 0; i < inputListe.Count; i++)
            {
                last10.Add(inputListe[i]);
                if (last10.Count > 10)
                {
                    last10.RemoveAt(0);
                }

                if (overLimit(last10, 1.0))
                {
                    if (inputListe[i] >= maxValue)
                    {
                        maxValue = inputListe[i];
                    }
                }
                else
                {
                    if (maxValue > 0)
                    {
                        toppunktsListe.Add(i);
                        maxValue = 0;
                    }
                }
            }                  

            return toppunktsListe;
        }

        private bool overLimit(List<double> values, double limit)
        {
            double sum = 0;
            if (values.Count < 10)
            {
                return false;
            }

            foreach (var item in values)
            {
                sum += item;
            }

            double avg = (sum / values.Count);

            if (avg > limit)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private int findPuls(List<double> inputListe)
        {
            int puls = 0;
            int rTakker = findToppunkt(inputListe).Count;

            puls = rTakker * (60 / (dataCollector.samplesPerChannel / (int)dataCollector.sampleRateInHz));

            return puls;
        }

        private long findHRV(List<double> inputListe)
        {
            long HRV = 0;
            List<double> toppunktsListeX = findToppunkt(inputListe);            
            double sum = 0;            

            for (int i = 0; i < (toppunktsListeX.Count - 1); i++)
            {
                sum += (toppunktsListeX[i + 1] - toppunktsListeX[i]);
            }

            if (toppunktsListeX.Count > 0)
            {
                HRV = Convert.ToInt64(((sum / toppunktsListeX.Count)/500)*1000);
            }
            else
            {
                MessageBox.Show("Fejl, ingen signal ved elektroder");
            }

            return HRV;
        }


    }
}
