﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlsDemo
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList1.SelectedValue;
            switch (s)
            {
                case "Personal":
                    MultiView1.SetActiveView(PersonalView);
                    break;
                case "Educational":
                    MultiView1.SetActiveView(EducationalDetails);
                    break;
                case "Other":
                    MultiView1.SetActiveView(Other);
                    break;
                default:
                    break;
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string s=FileUpload1.FileName;

                FileUpload1.SaveAs(@"D:\Sulakshana\198-Mphasis\WebAppsDemos\ControlsDemo\ControlsDemo\UploadedDocs\" + s);
                Response.Write("file Upload succeeded");
            }
        }
    }
}