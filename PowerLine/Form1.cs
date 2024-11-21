using System.IO.Ports;
using Settings = PowerLine.Properties.Settings;
using Line.Messaging;

namespace PowerLine
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        private Settings _settings = Settings.Default;
        public Form1()
        {
            InitializeComponent();
        }
        public class PowerLine
        {
            public float L { get; set; }
            public float voltage { get; set; }
            public float current { get; set; }
            public float power { get; set; }
            public float energy { get; set; }
            public float frequency { get; set; }
            public float pf { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {

                comboBox1.Items.Add(port);
            }
            comboBox1.SelectedIndex = 0;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Line", 50);
            listView1.Columns.Add("Voltage", 100);
            listView1.Columns.Add("Current", 100);
            listView1.Columns.Add("Power", 100);
            listView1.Columns.Add("Energy", 100);
            listView1.Columns.Add("Frequency", 100);
            listView1.Columns.Add("Pf", 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }
                else
                {
                    var jsonString = _serialPort.ReadLine();
                    var powerLine = System.Text.Json.JsonSerializer.Deserialize<PowerLine>(jsonString);

                    if (powerLine?.L == 1)
                    {
                        txtvoltage1.Text = powerLine.voltage.ToString();
                        txtcurrent1.Text = powerLine.current.ToString();
                        txtpower1.Text = powerLine.power.ToString();
                        txtenergy1.Text = powerLine.energy.ToString();
                        txtfrequency1.Text = powerLine.frequency.ToString();
                        txtpf1.Text = powerLine.pf.ToString();
                    }
                    else if (powerLine?.L == 2)
                    {
                        txtvoltage2.Text = powerLine.voltage.ToString();
                        txtcurrent2.Text = powerLine.current.ToString();
                        txtpower2.Text = powerLine.power.ToString();
                        txtenergy2.Text = powerLine.energy.ToString();
                        txtfrequency2.Text = powerLine.frequency.ToString();
                        txtpf2.Text = powerLine.pf.ToString();
                    }
                    else if (powerLine?.L == 3)
                    {
                        txtvoltage3.Text = powerLine.voltage.ToString();
                        txtcurrent3.Text = powerLine.current.ToString();
                        txtpower3.Text = powerLine.power.ToString();
                        txtenergy3.Text = powerLine.energy.ToString();
                        txtfrequency3.Text = powerLine.frequency.ToString();
                        txtpf3.Text = powerLine.pf.ToString();
                    }
                    string[] arr = new string[7];
                    ListViewItem item;

                    arr[0] = powerLine == null ? "" : powerLine.L.ToString();
                    arr[1] = powerLine == null ? "" : powerLine.voltage.ToString();
                    arr[2] = powerLine == null ? "" : powerLine.current.ToString();
                    arr[3] = powerLine == null ? "" : powerLine.power.ToString();
                    arr[4] = powerLine == null ? "" : powerLine.energy.ToString();
                    arr[5] = powerLine == null ? "" : powerLine.frequency.ToString();
                    arr[6] = powerLine == null ? "" : powerLine.pf.ToString();

                    item = new ListViewItem(arr);
                    listView1.Items.Add(item);

                    var vol1 = txtvoltage1.Text;
                    if (string.IsNullOrWhiteSpace(vol1))
                    {
                        AlertNotifyAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Block of code to handle errors
                //Notify error alert if enable
                if (_settings.EnableErrorNotify) 
                {
                    if (_settings.LastErrorDateTime == default(System.DateTime))
                    {
                        _settings.LastErrorDateTime = DateTime.Now;
                    }

                    var currentDateTime = DateTime.Now;
                    var lastError = _settings.LastErrorDateTime;
                    var difference = currentDateTime - lastError;


                    if (difference.TotalMinutes > _settings.NotifyErrorPeriodInMinutes)
                    {
                        var message = string.Format("{0} {1}", _settings.ErrorMessage, _settings.Location);
                        BroadcastLineMessage(message);
                    }
                }
            }
        }

        private void AlertNotifyAsync()
        {
            if (_settings.LastNotifyDateTime == default(System.DateTime))
            {
                _settings.LastNotifyDateTime = DateTime.Now;
            }

            var currentDateTime = DateTime.Now;
            var lastNotify = _settings.LastNotifyDateTime;
            var difference = currentDateTime - lastNotify;

            if (difference.TotalMinutes > _settings.NotifyPeriodInMinutes)
            {
                //do notify
                var message = string.Format("{0} {1}", _settings.NotifyMessage, _settings.Location);
                BroadcastLineMessage(message);
            }
        }

        private void BroadcastLineMessage(string message)
        {
            var boardcastMessage = new TextMessage(message);
            var messagingClient = new LineMessagingClient(_settings.LineChannelAccessToken, _settings.LineEndponintApi);
            var task = messagingClient.BroadcastMessageAsync(new List<ISendMessage> { boardcastMessage });
            task.Wait();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Enabled = true;
            _serialPort = new SerialPort(comboBox1.Text);

            _serialPort.BaudRate = 115200;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;
            _serialPort.ReadTimeout = 2000;
            _serialPort.WriteTimeout = 500;

            try
            {
                if (!_serialPort.IsOpen)
                {
                    _serialPort.Open();
                }

                timer1.Stop();
                timer1.Interval = Convert.ToInt32(_settings.IntervalCheckTimeInMillisecond);
                timer1.Start();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Error");              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            _serialPort.Close();
            timer1.Enabled = false;
        }
    }
}
