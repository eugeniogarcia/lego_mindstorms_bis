using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using NKH.MindSqualls;

namespace NxtRemote2
{
    public partial class Form1: Form
    {
        private NxtBrick brick;
        private NxtMotorSync motorPair;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Disconnected";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                byte comPort = byte.Parse(this.txtComPort.Text);
                brick = new NxtBrick(comPort);

                brick.MotorB = new NxtMotor();
                brick.MotorC = new NxtMotor();
                motorPair = new NxtMotorSync(brick.MotorB, brick.MotorC);

                brick.Connect();

                this.Text = "Connected: " + brick.Name;
            }
            catch
            {
                Disconnect();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btnIdle_Click(object sender, EventArgs e)
        {
            Idle();
        }

        private void Idle()
        {
            if (brick != null && brick.IsConnected)
                motorPair.Idle();

            this.vbarPower.Value = 0;
            this.hbarTurnRatio.Value = 0;
        }

        private void Disconnect()
        {
            Idle();

            if (brick != null && brick.IsConnected)
                brick.Disconnect();

            brick = null;
            motorPair = null;

            this.Text = "Disconnected";
        }

        private void hbarTurnRatio_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void vbarPower_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void ValueChanged()
        {
            if (brick != null && brick.IsConnected)
            {
                sbyte power = (sbyte) (-this.vbarPower.Value);
                sbyte turnRatio = (sbyte) this.hbarTurnRatio.Value;

                if (power < 0) turnRatio = (sbyte) (-turnRatio);

                motorPair.Run(power, 0, turnRatio);
            }
        }
    }
}