﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.ViewModel
{
	public class MainWindowViewModel
	{
		public string Text { get; set; }

		public MainWindowViewModel()
		{
			this.Text = "Hello, world!";
		}
	}
}
