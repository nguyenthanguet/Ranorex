﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AutomationTestProject.Recording
{
    public partial class CheckReport
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void GetColor()
        {
        	String color = repo.HọcLiệuSachMềm.Ngaygiobatdau.GetAttributeValue<String>("border");
        	String colorRed = "1px solid rgb(255, 0, 0)";
        	//Report.Info("Red-Color is: " + colorRed);tr
        	Report.Info("Ngay bat dau button bolder color is: " + color);
        	bool result = Validate.Equals(colorRed, color);
        	if(result==true){
        		Validate.IsTrue(true, "Bolder of button has red color");
        	}
        	else{
        		Validate.IsTrue(false, "Bolder of button does not have red color");
        	}
        }

    }
}
