﻿// Created by Ethem Acar

using System;
using System.Threading;
using System.Windows.Forms;
using OpenYeeLightUI.Classes;
using Colore;
using Colore.Data;

namespace OpenYeeLightUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!SingleInstance.Start())
            {
                SingleInstance.ShowFirstInstance();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RazerSDK.Initialize();

            try
            {
                MainForm mainForm = new MainForm();
                Application.Run(mainForm);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            SingleInstance.Stop();

        }
    }
}