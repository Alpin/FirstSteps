﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm {
    public partial class AlarmSettings : Form {

        private Alarm mainWindow;
        private static bool isOpen=false;

        //Var CellCnt
        private int _CellCnt;
        public int CellCnt {
            get { return _CellCnt; }
            set {
                _CellCnt = value;
            }
        }

        private int _LastRowIndex;
        public int LastRowIndex {
            get { return _LastRowIndex; }
            set {
                _LastRowIndex = value;
            }
        }
        //AlarmSettingsGui.Date;
        //AlarmSettingsGui.Hour", typeof(int));
        //AlarmSettingsGui.Minute", typeof(int));
        //AlarmSettingsGui.AlarmActiv", typeof(bool));
        //AlarmSettingsGui.Note = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        //AlarmSettingsGui.ProgPathActiv", typeof(bool));
        //AlarmSettingsGui.ProgPath; //Path to start Programm
        //AlarmSettingsGui.SoundActive", typeof(bool));
        //AlarmSettingsGui.SoundSource; //Radiobtn "ringtone", "soundfile", "youtube"
        //AlarmSettingsGui.ID;

        //Var Notification (Cell 1)
        private string _Date;
        public string Date {
            get { return _Date; }
            set {
                _Date = value;
                if(value != null && value != "") {
                    dtASDate.Value = Convert.ToDateTime(value);
                }
            }
        }
        //Var Notification (Cell 2)
        private int _Hour;
        public int Hour {
            get { return _Hour; }
            set {
                _Hour = value;
                numASHour.Value = value;
            }
        }
        //Var Notification (Cell 3)
        private int _Minute;
        public int Minute {
            get { return _Minute; }
            set {
                _Minute = value;
                numASMin.Value = value;
            }
        }
        //Var Notification (Cell 4)
        private bool _AlarmActiv;
        public bool AlarmActiv {
            get { return _AlarmActiv; }
            set {
                _AlarmActiv = value;
                cbASActive.Checked = value;
            }
        }
        //Var Notification (Cell 5)
        private string _note;
        public string Note {
            get {return _note;}
            set {
                _note = value;
                tbASNote.Text = value;
            }
        }
    
        //Var ProgPathActiv (Cell 6)
        private bool _ProgPathActiv;
        public bool ProgPathActiv {
            get { return _ProgPathActiv; }
            set {
                _ProgPathActiv = value;
                cbStartProg.Checked = value;
            }
        }

        //Var ProgPath (Cell 7)
        private string _ProgPath;
        public string ProgPath {
            get { return _ProgPath; }
            set {
                _ProgPath = value;
                tbASProgPath.Text = value;
            }
        }

        //Var SoundActive (Cell 8)
        private bool _SoundActive;
        public bool SoundActive {
            get { return _SoundActive; }
            set {
                _SoundActive = value;
                rbASSoundFilePath.Checked = value;
            }
        }

        //Var SoundSource (Cell 9)
        private string _SoundSource;
        public string SoundSource {
            get { return _SoundSource; }
            set {
                _SoundSource = value;
                tbASFilePath.Text = value;
            }
        }

        //Var ID (Cell 10)
        private string _ID;
        public string ID {
            get { return _ID; }
            set {
                _ID = value;
                
            }
        }

        public AlarmSettings(Alarm alarmWindow) {
            if (isOpen) {
                return;
            }
            InitializeComponent();

            isOpen = true;
            mainWindow = alarmWindow;

            ////Create Amount of X Variables
            //int i = 0;
            //while (CellCnt >= i) {
            //    i++;
            //    string currentName = "Var" + i.ToString();
            //}

            //Tooltips
            System.Windows.Forms.ToolTip ToolTipdtASDate = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipnumASHour = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipnumASMin = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTiptbASYoutubePath = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTiptbASFilePath = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTipcbASAlarmSound = new System.Windows.Forms.ToolTip();
            System.Windows.Forms.ToolTip ToolTiptbASNote = new System.Windows.Forms.ToolTip();
            ToolTipdtASDate.SetToolTip(dtASDate, "Please insert your Note that should be attatched to the Alarm.");
            ToolTipnumASHour.SetToolTip(numASHour, "Here you can Set the Alarm hour.");
            ToolTipnumASMin.SetToolTip(numASMin, "Here you can Set the Alarm minute.");
            ToolTiptbASYoutubePath.SetToolTip(tbASYoutubePath, "Please insert your Note that should be attatched to the Alarm.");
            ToolTiptbASFilePath.SetToolTip(tbASFilePath, "Please insert your Note that should be attatched to the Alarm.");
            ToolTipcbASAlarmSound.SetToolTip(cbASAlarmSound, "Please insert your Note that should be attatched to the Alarm.");
            ToolTiptbASNote.SetToolTip(tbASNote, "Please insert your Note that should be attatched to the Alarm.");
        }

        //Var VarList
        //private List<string> _VarList;
        //private ListBox _VarList;
        //public ListBox VarList {
        //    get { return _VarList; }
        //    set {
        //        _VarList = value;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e) {
            Date = dtASDate.Value.ToString();
            Hour = Convert.ToInt32(numASHour.Value);
            Minute = Convert.ToInt32(numASMin.Value);
            AlarmActiv = cbASActive.Checked;
            Note = tbASNote.Text;
            ProgPathActiv = cbStartProg.Checked;
            ProgPath = tbASProgPath.Text;
            SoundActive = rbASSoundFilePath.Checked;
            SoundSource = tbASFilePath.Text;

            mainWindow.UpdateRowDetails(this);
            isOpen = false;
            Dispose();
        }

        private void AlarmSettings_FormClosing(object sender, FormClosingEventArgs e) {
            isOpen = false;
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {

        }

        private void btbASFileDialog_Click(object sender, EventArgs e) {

        }
    }
}
