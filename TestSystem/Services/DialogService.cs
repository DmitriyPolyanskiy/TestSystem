﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TestSystem.Services.Interfaces;

namespace TestSystem.Services
{
    public class DialogService : IDialogService
    {
        public bool OpenFileDialog(out string filename)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            filename = "";

            if (openFileDialog.ShowDialog() is true)
            {
                filename = openFileDialog.FileName;
                return true;
            }

            return false;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
