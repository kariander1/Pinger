using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Pinger.Properties;

namespace Pinger
{
    public partial class Form_main : Form
    {
        List<Machine> pingers;
        XmlDocument doc;
        public Form_main()
        {
            InitializeComponent();
            LoadXml();
            
            CreatePingers();
            try
            {
                timer_Ping.Interval = Settings.Default.poll_period;
            }
            catch (Exception)
            {

                timer_Ping.Interval = 30000;
            }
        }
        private void PingMachine(Machine machine)
        {
            int count =0;
            dataGridView_Display[4, machine.id].Value = "Pinging...";
            dataGridView_Display[0, machine.id].Value = Resources.VSDocs;
            State lastState = machine.state;
            machine.state = State.Unknown;
            Application.DoEvents();
            do
            {
                Ping pinger = new Ping();
                PingReply reply = pinger.Send(machine.address);
                if (reply.Status == IPStatus.Success)
                {
                    dataGridView_Display[0, machine.id].Value = Resources.SysReqMet;
                    if (count > 0)
                    
                        dataGridView_Display[4, machine.id].Value = "Retrys: " + count;
                    
                    else
                    
                        dataGridView_Display[4, machine.id].Value = "";
                    if (lastState == State.Error)
                        notifyIcon_LOP.ShowBalloonTip(24 * 60 * 60 * 1000, "Machine Up", machine.machineName + " started responding", ToolTipIcon.Info);
                    machine.state = State.OK;
                    break;
                }
                else
                {
                    dataGridView_Display[0, machine.id].Value = Resources.stop;
                    dataGridView_Display[4, machine.id].Value = reply.Status;

                }

                Application.DoEvents();
                count++;
            } while (count < Settings.Default.ping_retrys);
            if (count == Settings.Default.ping_retrys)
            {
                if (lastState == State.OK)
                    notifyIcon_LOP.ShowBalloonTip(24 * 60 * 60 * 1000, "Machine Down", machine.machineName + " isn't responding", ToolTipIcon.Error);
                machine.state = State.Error;
            }
        }
     
        private void PingMachines(List<Machine> machines)
        {
       
                
                    toolStripStatusLabel_pingLabel.Text = "Pinging...";
                    for (int i = 0; i < machines.Count; i++)
                    {
                        Machine machine = machines[i];
                        PingMachine(machine);
                        if (statusStrip_status.InvokeRequired)
                        {
                            statusStrip_status.Invoke(new MethodInvoker(delegate { toolStripProgressBar_pingProgress.Value = ((i + 1) * 100) / (machines.Count); }));
                        }
                        else
                            toolStripProgressBar_pingProgress.Value = ((i + 1) * 100) / (machines.Count);
                        Application.DoEvents();
                    }
                    toolStripStatusLabel_pingLabel.Text = "Last Ping on: " + DateTime.UtcNow + " UTC";
                
            
        }
        private void CreatePingers()
        {
          
            pingers = new List<Machine>();
           XmlNodeList clusters = doc.SelectNodes("Machines/Cluster");
           foreach (XmlNode cluster in clusters)
           {
               GroupBox temp = new GroupBox();
               temp.Text = cluster.Attributes["Text"].Value.ToString();
               temp.AutoSize = true;
               
               foreach (XmlNode machine in cluster.SelectNodes("Machine"))
               {
                   int index = dataGridView_Display.Rows.Add();
                   Machine tempMachine = new Machine( cluster.Attributes["Text"].Value.ToString(), machine.Attributes["IP"].Value.ToString(), machine.Attributes["Text"].Value.ToString(), index);
                   pingers.Add(tempMachine);            
                  
                   
                   dataGridView_Display.Rows[index].Cells[0].Value = (Image)Resources.VSDocs;
                   dataGridView_Display.Rows[index].Cells[1].Value = tempMachine.cluster;
                   dataGridView_Display.Rows[index].Cells[2].Value = tempMachine.machineName;
                   dataGridView_Display.Rows[index].Cells[3].Value = tempMachine.address;
                   
               }
           }
        }

        private void LoadXml()
        {
            string path= Settings.Default.config_path;
            doc = new XmlDocument();
            if (File.Exists(path))
            {
                try
                {
                    doc.Load(path);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed reading Config file:\n" + e.Message);

                }
            }
            else
            {
                MessageBox.Show("Configuration File not found: " + path);
            }
        }

        private void timer_Ping_Tick(object sender, EventArgs e)
        {

            if (!backgroundWorker_worker.IsBusy)
            {
                backgroundWorker_worker.CancelAsync();
                backgroundWorker_worker.RunWorkerAsync();
            }
       
        }

        private void notifyIcon_LOP_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }
        private void Form_main_Shown(object sender, EventArgs e)
        {
            backgroundWorker_worker.RunWorkerAsync();
            
        }

        private void backgroundWorker_worker_DoWork(object sender, DoWorkEventArgs e)
        {
           
            Application.DoEvents();
            PingMachines(pingers);
      
           
        }

        private void dataGridView_Display_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
               
                        PingMachine(pingers[e.RowIndex]);
                      
                    
                
            }
        }

    
    }
}
