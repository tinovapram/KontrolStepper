using System;
using System.Drawing;

using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using System.Windows.Forms;

namespace KontrolStepper
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private int _baudRate = 115200;
        private int _dataBits = 8;
        private int cba = +54, pos = 0, step, cmd = 0, sisa,i=0;
        private Handshake _handshake = Handshake.None;
        private Parity _parity = Parity.None;
        private StopBits _stopBits = StopBits.One;
        private string tString = string.Empty, aa;
        private double dtA, dtB, deg;
        private bool isCW, isCont;

        private void setSerial()
        {
            _data = new SerialPort();
            _data.BaudRate = _baudRate;
            _data.Parity = _parity;
            _data.Handshake = _handshake;
            _data.DataBits = _dataBits;
            _data.StopBits = _stopBits;
        }

        private void ldPort()
        {
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            ArrayComPortsNames = SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length != 0)
            {
                do
                {
                    index += 1;
                    cboPorts.Items.Add(ArrayComPortsNames[index]);
                }
                while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);
                if (index == ArrayComPortsNames.GetUpperBound(0))
                {
                    ComPortName = ArrayComPortsNames[0];
                }
                cboPorts.Text = ArrayComPortsNames[0];

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (_data.IsOpen) _data.Close();
                _data.PortName = cboPorts.Text;
                _data.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show("Port tidak dapat dibuka " + er.ToString(), "Buka Port Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (_data.IsOpen) { Button2.Enabled = false; Button1.Enabled = true; cboPorts.Enabled = false; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ldPort();
            setSerial();
            phsGrf.ChartAreas[0].AxisX.ScrollBar.Enabled=true;
            phsGrf.ChartAreas[0].AxisX.ScaleView.Size = 10;
        }



        private void cboPorts_DropDown(object sender, EventArgs e)
        {
            cboPorts.Items.Clear();
            ldPort();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                _data.Write("#+000*+000" + '\n');
                timer1.Enabled = false;
                _data.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Port tidak dapat ditutup " + er.ToString(), "Tutup Port Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!_data.IsOpen) { Button1.Enabled = false; Button2.Enabled = true; cboPorts.Enabled = true; }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (_data.IsOpen)
            {
                foreach (var series in phsGrf.Series)
                {
                    series.Points.Clear();
                }
                phsGrf.Series[0].ChartType = SeriesChartType.StepLine;
                phsGrf.Series[1].ChartType = SeriesChartType.StepLine;
                i = 0;
                if (rbFull.Checked)
                {
                    cmd = 1;
                    timer1.Interval = 15;
                    if (rbCont.Checked)
                    {
                        step = 10;
                    }
                    if (rbDiscont.Checked)
                    {
                        deg = Convert.ToDouble(sudutBox.Text);
                        step = Convert.ToInt16(deg / 1.8);
                    }
                }

                if (rbHalf.Checked)
                {
                    phsGrf.Series[0].ChartType = SeriesChartType.StepLine;
                    phsGrf.Series[1].ChartType = SeriesChartType.StepLine;
                    cmd = 2;
                    timer1.Interval = 2;
                    if (rbCont.Checked)
                    {
                        step = 10;
                    }
                    if (rbDiscont.Checked)
                    {
                        deg = Convert.ToDouble(sudutBox.Text);
                        step = Convert.ToInt16(deg / 0.9);
                    }
                }
                if (rbCW.Checked)
                {
                    isCW = true;
                }
                if (rbCCW.Checked)
                {
                    isCW = false;
                }
                if(rbCont.Checked)
                {
                    isCont = true;
                }
                if (rbDiscont.Checked)
                {
                    isCont = false;
                }
                if (rbMicro.Checked)
                {
                    timer1.Interval = 1;
                    phsGrf.Series[0].ChartType = SeriesChartType.Spline;
                    phsGrf.Series[1].ChartType = SeriesChartType.Spline;
                    cmd = 3;
                    if (rbCont.Checked)
                    {                        
                        step = 15;
                    }
                    if (rbDiscont.Checked)
                    {
                        deg = Convert.ToDouble(sudutBox.Text);
                        step = Convert.ToInt16((deg / 7.2) * 360);
                        //step += sisa;
                    }
                }
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Serial belum tersambung!");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (_data.IsOpen)
            {
                timer1.Enabled = false;
                _data.Write("#+000*+000" + '\n');
            }
            else
            {
                MessageBox.Show("Serial belum tersambung!");
            }
        }

        private void rbDiscont_CheckedChanged(object sender, EventArgs e)
        {
            sudutBox.Enabled = rbDiscont.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //double waktu = (Environment.TickCount) / 1000.0;
            if(cmd==1)
            {
                if (i<step)
                {
                    fStep();
                    i++;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
            else if (cmd ==2)
            {
                if (i < step)
                {
                    hStep();
                    i++;
                }
                else
                {
                    timer1.Enabled = false;
                }
            }
            else if (cmd ==3) { mStep(); i += 15; }
            else if (cmd ==4) { }

            if (isCont)
            {
                step += 15;
            }
            if (phsGrf.ChartAreas[0].AxisX.Maximum > phsGrf.ChartAreas[0].AxisX.ScaleView.Size)
            { phsGrf.ChartAreas[0].AxisX.ScaleView.Scroll(phsGrf.ChartAreas[0].AxisX.Maximum); }


        }

        private void fStep()
        {
            if (isCW)
            {
                if (pos == 0)
                {
                    _0();
                    pos = 2;
                }
                else if (pos == 2)
                {
                    _2();
                    pos = 4;
                }
                else if (pos == 4)
                {
                    _4();
                    pos = 6;
                }
                else
                {
                    _6();
                    pos = 0;
                }
            }
            else
            {
                if (pos == 0)
                {
                    _0();
                    pos = 6;
                }
                else if (pos == 2)
                {
                    _2();
                    pos = 0;
                }
                else if (pos == 4)
                {
                    _4();
                    pos = 2;
                }
                else
                {
                    _6();
                    pos = 4;
                }
            }
        }

        private void hStep()
        {
            if (isCW)
            {
                if (pos == 0)
                {
                    _0();
                    pos = 1;
                }
                else if (pos == 1)
                {
                    _1();
                    pos = 2;
                }
                else if (pos == 2) {
                    _2();
                    pos = 3;
                }
                else if (pos == 3) {
                    _3();
                    pos = 4;
                }
                else if (pos == 4) {
                    _4();
                    pos = 5;
                }
                else if (pos == 5) {
                    _5();
                    pos = 6;
                }
                else if (pos == 6) {
                    _6();
                    pos = 7;
                }
                else if (pos == 7) {
                    _7();
                    pos = 0;
                }
            }
            else
            {
                if (pos == 0)
                {
                    _0();
                    pos = 7;
                }
                else if (pos == 1)
                {
                    _1();
                    pos = 0;
                }
                else if (pos == 2)
                {
                    _2();
                    pos = 1;
                }
                else if (pos == 3)
                {
                    _3();
                    pos = 2;
                }
                else if (pos == 4)
                {
                    _4();
                    pos = 3;
                }
                else if (pos == 5)
                {
                    _5();
                    pos = 4;
                }
                else if (pos == 6)
                {
                    _6();
                    pos = 5;
                }
                else if (pos == 7)
                {
                    _7();
                    pos = 6;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_data.IsOpen)
            {
                timer1.Enabled = false;
                _data.Write("#+000*+000" + '\n');
                _data.Close();
            }
        }

        private void mStep()
        {
            if(!isCW)
            {
                if (i < step)
                {
                    deg = i * (Math.PI / 180);
                    dtA = Math.Sin(deg) * 255;
                    dtB = Math.Cos(deg) * 255;
                    phsGrf.Series["pA"].Points.AddY(dtA);
                    phsGrf.Series["pB"].Points.AddY(dtB);
                    _data.Write("#"+dtA.ToString("+000;-000")+"*"+ dtB.ToString("+000;-000") + '\n');
                }
                else if (i>=step)
                {
                    deg = step * (Math.PI / 180);
                    dtA = Math.Sin(deg)*255;
                    dtB = Math.Cos(deg)*255;
                    phsGrf.Series["pA"].Points.AddY(dtA);
                    phsGrf.Series["pB"].Points.AddY(dtB);
                    timer1.Enabled = false;
                    _data.Write("#" + dtA.ToString("+000;-000") + "*" + dtB.ToString("+000;-000") + '\n');
                }
            }
            else
            {
                if (i < step)
                {
                    deg = i * (Math.PI / 180);
                    dtA = Math.Cos(deg) * 255;
                    dtB = Math.Sin(deg) * 255;
                    phsGrf.Series["pA"].Points.AddY(dtA);
                    phsGrf.Series["pB"].Points.AddY(dtB);
                    _data.Write("#" + dtA.ToString("+000;-000") + "*" + dtB.ToString("+000;-000") + '\n');
                }
                else if (i >= step)
                {
                    deg = step * (Math.PI / 180);
                    dtB = Math.Sin(deg) * 255;
                    dtA = Math.Cos(deg) * 255;
                    phsGrf.Series["pA"].Points.AddY(dtA);
                    phsGrf.Series["pB"].Points.AddY(dtB);
                    timer1.Enabled = false;
                    _data.Write("#" + dtA.ToString("+000;-000") + "*" + dtB.ToString("+000;-000") + '\n');
                }
            }
        }
    
        private void _0()
        {
            _data.Write("#+255*+000" + '\n');
            phsGrf.Series["pA"].Points.AddY(255);
            phsGrf.Series["pB"].Points.AddY(0);
        }
        private void _1()
        {
            _data.Write("#+255*+255" + '\n');
            phsGrf.Series["pA"].Points.AddY(255);
            phsGrf.Series["pB"].Points.AddY(255);
        }
        private void _2()
        {
            _data.Write("#+000*+255" + '\n');
            phsGrf.Series["pB"].Points.AddY(255);
            phsGrf.Series["pA"].Points.AddY(0);
        }
        private void _3()
        {
            _data.Write("#-255*+255" + '\n');
            phsGrf.Series["pA"].Points.AddY(-255);
            phsGrf.Series["pB"].Points.AddY(255);
        }
        private void _4()
        {
            _data.Write("#-255*+000" + '\n');
            phsGrf.Series["pA"].Points.AddY(-255);
            phsGrf.Series["pB"].Points.AddY(0);
        }
        private void _5()
        {
            _data.Write("#-255*-255" + '\n');
            phsGrf.Series["pA"].Points.AddY(-255);
            phsGrf.Series["pB"].Points.AddY(-255);
        }
        private void _6()
        {
            _data.Write("#+000*-255" + '\n');
            phsGrf.Series["pB"].Points.AddY(-255);
            phsGrf.Series["pA"].Points.AddY(0);
        }
        private void _7()
        {
            _data.Write("#+255*-255" + '\n');
            phsGrf.Series["pA"].Points.AddY(255);
            phsGrf.Series["pB"].Points.AddY(-255);
        }

    }
}
    
    

